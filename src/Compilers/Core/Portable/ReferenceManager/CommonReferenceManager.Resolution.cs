// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    using MetadataOrDiagnostic = System.Object;
    internal abstract partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
            where TCompilation : Compilation
            where TAssemblySymbol : class, IAssemblySymbolInternal
    {
        protected abstract CommonMessageProvider MessageProvider { get; }

        protected abstract AssemblyData CreateAssemblyDataForFile(
                    PEAssembly assembly,
                    WeakList<IAssemblySymbolInternal> cachedSymbols,
                    DocumentationProvider documentationProvider,
                    string sourceAssemblySimpleName,
                    MetadataImportOptions importOptions,
                    bool embedInteropTypes);

        protected abstract AssemblyData CreateAssemblyDataForCompilation(
                    CompilationReference compilationReference);

        protected abstract bool CheckPropertiesConsistency(MetadataReference primaryReference, MetadataReference duplicateReference, DiagnosticBag diagnostics);

        protected abstract bool WeakIdentityPropertiesEquivalent(AssemblyIdentity identity1, AssemblyIdentity identity2);

        [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
        protected struct ResolvedReference
        {

            private readonly MetadataImageKind _kind;

            private readonly int _index;

            private readonly ImmutableArray<string> _aliasesOpt;

            private readonly ImmutableArray<string> _recursiveAliasesOpt;

            public ResolvedReference(int index, MetadataImageKind kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(530, 3034, 3371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3126, 3151);

                    f_530_3126_3150(index >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3169, 3188);

                    _index = index + 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3206, 3219);

                    _kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3237, 3283);

                    _aliasesOpt = default(ImmutableArray<string>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3301, 3356);

                    _recursiveAliasesOpt = default(ImmutableArray<string>);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(530, 3034, 3371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 3034, 3371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 3034, 3371);
                }
            }

            public ResolvedReference(int index, MetadataImageKind kind, ImmutableArray<string> aliasesOpt, ImmutableArray<string> recursiveAliasesOpt)
            : this(f_530_3586_3591_C(index), kind)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(530, 3423, 3978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3787, 3857);

                    f_530_3787_3856(f_530_3800_3821_M(!aliasesOpt.IsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(530, 3800, 3855) || f_530_3825_3855_M(!recursiveAliasesOpt.IsDefault)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3877, 3902);

                    _aliasesOpt = aliasesOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 3920, 3963);

                    _recursiveAliasesOpt = recursiveAliasesOpt;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(530, 3423, 3978);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 3423, 3978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 3423, 3978);
                }
            }

            private bool IsUninitialized
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 4023, 4081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 4026, 4081);
                        return _aliasesOpt.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(530, 4026, 4081) && _recursiveAliasesOpt.IsDefault); DynAbs.Tracing.TraceSender.TraceExitMethod(530, 4023, 4081);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 4023, 4081);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 4023, 4081);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<string> AliasesOpt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 4538, 4673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 4582, 4613);

                        f_530_4582_4612(f_530_4595_4611_M(!IsUninitialized));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 4635, 4654);

                        return _aliasesOpt;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(530, 4538, 4673);

                        bool
                        f_530_4595_4611_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 4595, 4611);
                            return return_v;
                        }


                        int
                        f_530_4582_4612(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 4582, 4612);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 4465, 4688);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 4465, 4688);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<string> RecursiveAliasesOpt
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 5163, 5307);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 5207, 5238);

                        f_530_5207_5237(f_530_5220_5236_M(!IsUninitialized));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 5260, 5288);

                        return _recursiveAliasesOpt;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(530, 5163, 5307);

                        bool
                        f_530_5220_5236_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 5220, 5236);
                            return return_v;
                        }


                        int
                        f_530_5207_5237(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 5207, 5237);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 5081, 5322);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 5081, 5322);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsSkipped
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 5528, 5610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 5572, 5591);

                        return _index == 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(530, 5528, 5610);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 5474, 5625);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 5474, 5625);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public MetadataImageKind Kind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 5703, 5826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 5747, 5772);

                        f_530_5747_5771(f_530_5760_5770_M(!IsSkipped));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 5794, 5807);

                        return _kind;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(530, 5703, 5826);

                        bool
                        f_530_5760_5770_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 5760, 5770);
                            return return_v;
                        }


                        int
                        f_530_5747_5771(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 5747, 5771);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 5641, 5841);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 5641, 5841);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public int Index
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 6110, 6238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 6154, 6179);

                        f_530_6154_6178(f_530_6167_6177_M(!IsSkipped));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 6201, 6219);

                        return _index - 1;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(530, 6110, 6238);

                        bool
                        f_530_6167_6177_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 6167, 6177);
                            return return_v;
                        }


                        int
                        f_530_6154_6178(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 6154, 6178);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 6061, 6253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 6061, 6253);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 6269, 6549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 6337, 6534);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(530, 6344, 6353) || ((IsSkipped && DynAbs.Tracing.TraceSender.Conditional_F2(530, 6356, 6367)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 6370, 6533))) ? "<skipped>" : $"{((DynAbs.Tracing.TraceSender.Conditional_F1(530, 6374, 6409) || ((_kind == MetadataImageKind.Assembly && DynAbs.Tracing.TraceSender.Conditional_F2(530, 6412, 6415)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 6418, 6421))) ? "A" : "M")}[{Index}]:{DisplayAliases(_aliasesOpt, "aliases")}{DisplayAliases(_recursiveAliasesOpt, "recursive-aliases")}";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(530, 6269, 6549);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 6269, 6549);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 6269, 6549);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string DisplayAliases(ImmutableArray<string> aliasesOpt, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 6565, 6780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 6682, 6765);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(530, 6689, 6709) || ((aliasesOpt.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(530, 6712, 6714)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 6717, 6764))) ? "" : $" {name} = '{f_530_6731_6761("','", aliasesOpt)}'";
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 6565, 6780);

                    string
                    f_530_6731_6761(string
                    separator, System.Collections.Immutable.ImmutableArray<string>
                    values)
                    {
                        var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 6731, 6761);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 6565, 6780);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 6565, 6780);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static ResolvedReference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(530, 2640, 6791);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(530, 2640, 6791);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 2640, 6791);
            }

            static int
            f_530_3126_3150(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 3126, 3150);
                return 0;
            }


            bool
            f_530_3800_3821_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 3800, 3821);
                return return_v;
            }


            bool
            f_530_3825_3855_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 3825, 3855);
                return return_v;
            }


            static int
            f_530_3787_3856(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 3787, 3856);
                return 0;
            }


            static int
            f_530_3586_3591_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(530, 3423, 3978);
                return return_v;
            }

        }

        protected readonly struct ReferencedAssemblyIdentity
        {

            public readonly AssemblyIdentity? Identity;

            public readonly MetadataReference? Reference;

            public readonly int RelativeAssemblyIndex;

            public int GetAssemblyIndex(int explicitlyReferencedAssemblyCount)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 7418, 7548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 7438, 7548);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(530, 7438, 7464) || ((RelativeAssemblyIndex >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(530, 7467, 7488)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 7491, 7548))) ? RelativeAssemblyIndex : explicitlyReferencedAssemblyCount + RelativeAssemblyIndex; DynAbs.Tracing.TraceSender.TraceExitMethod(530, 7418, 7548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 7418, 7548);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 7418, 7548);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ReferencedAssemblyIdentity(AssemblyIdentity identity, MetadataReference reference, int relativeAssemblyIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(530, 7565, 7853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 7714, 7734);

                    Identity = identity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 7752, 7774);

                    Reference = reference;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 7792, 7838);

                    RelativeAssemblyIndex = relativeAssemblyIndex;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(530, 7565, 7853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 7565, 7853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 7565, 7853);
                }
            }
            static ReferencedAssemblyIdentity()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(530, 6803, 7864);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(530, 6803, 7864);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 6803, 7864);
            }
        }

        /// <summary>
        /// Resolves given metadata references to assemblies and modules.
        /// </summary>
        /// <param name="compilation">The compilation whose references are being resolved.</param>
        /// <param name="assemblyReferencesBySimpleName">
        /// Used to filter out assemblies that have the same strong or weak identity.
        /// Maps simple name to a list of identities. The highest version of each name is the first.
        /// </param>
        /// <param name="references">List where to store resolved references. References from #r directives will follow references passed to the compilation constructor.</param>
        /// <param name="boundReferenceDirectiveMap">Maps #r values to successfully resolved metadata references. Does not contain values that failed to resolve.</param>
        /// <param name="boundReferenceDirectives">Unique metadata references resolved from #r directives.</param>
        /// <param name="assemblies">List where to store information about resolved assemblies to.</param>
        /// <param name="modules">List where to store information about resolved modules to.</param>
        /// <param name="diagnostics">Diagnostic bag where to report resolution errors.</param>
        /// <returns>
        /// Maps index to <paramref name="references"/> to an index of a resolved assembly or module in <paramref name="assemblies"/> or <paramref name="modules"/>, respectively.
        ///</returns>
        protected ImmutableArray<ResolvedReference> ResolveMetadataReferences(
            TCompilation compilation,
            [Out] Dictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName,
            out ImmutableArray<MetadataReference> references,
            out IDictionary<(string, string), MetadataReference> boundReferenceDirectiveMap,
            out ImmutableArray<MetadataReference> boundReferenceDirectives,
            out ImmutableArray<AssemblyData> assemblies,
            out ImmutableArray<PEModule> modules,
            DiagnosticBag diagnostics)
        {
            // Locations of all #r directives in the order they are listed in the references list.
            ImmutableArray<Location> referenceDirectiveLocations;
            GetCompilationReferences(compilation, diagnostics, out references, out boundReferenceDirectiveMap, out referenceDirectiveLocations);

            // References originating from #r directives precede references supplied as arguments of the compilation.
            int referenceCount = references.Length;
            int referenceDirectiveCount = (referenceDirectiveLocations != null ? referenceDirectiveLocations.Length : 0);

            var referenceMap = new ResolvedReference[referenceCount];

            // Maps references that were added to the reference set (i.e. not filtered out as duplicates) to a set of names that 
            // can be used to alias these references. Duplicate assemblies contribute their aliases into this set.
            Dictionary<MetadataReference, MergedAliases>? lazyAliasMap = null;

            // Used to filter out duplicate references that reference the same file (resolve to the same full normalized path).
            var boundReferences = new Dictionary<MetadataReference, MetadataReference>(MetadataReferenceEqualityComparer.Instance);

            ArrayBuilder<MetadataReference>? uniqueDirectiveReferences = (referenceDirectiveLocations != null) ? ArrayBuilder<MetadataReference>.GetInstance() : null;
            var assembliesBuilder = ArrayBuilder<AssemblyData>.GetInstance();
            ArrayBuilder<PEModule>? lazyModulesBuilder = null;

            bool supersedeLowerVersions = compilation.Options.ReferencesSupersedeLowerVersions;

            // When duplicate references with conflicting EmbedInteropTypes flag are encountered,
            // VB uses the flag from the last one, C# reports an error. We need to enumerate in reverse order
            // so that we find the one that matters first.
            for (int referenceIndex = referenceCount - 1; referenceIndex >= 0; referenceIndex--)
            {
                var boundReference = references[referenceIndex];
                if (boundReference == null)
                {
                    continue;
                }

                // add bound reference if it doesn't exist yet, merging aliases:
                MetadataReference? existingReference;
                if (boundReferences.TryGetValue(boundReference, out existingReference))
                {
                    // merge properties of compilation-based references if the underlying compilations are the same
                    if ((object)boundReference != existingReference)
                    {
                        MergeReferenceProperties(existingReference, boundReference, diagnostics, ref lazyAliasMap);
                    }

                    continue;
                }

                boundReferences.Add(boundReference, boundReference);

                Location location;
                if (referenceIndex < referenceDirectiveCount)
                {
                    location = referenceDirectiveLocations[referenceIndex];
                    uniqueDirectiveReferences!.Add(boundReference);
                }
                else
                {
                    location = Location.None;
                }

                // compilation reference

                var compilationReference = boundReference as CompilationReference;
                if (compilationReference != null)
                {
                    switch (compilationReference.Properties.Kind)
                    {
                        case MetadataImageKind.Assembly:
                            existingReference = TryAddAssembly(
                                compilationReference.Compilation.Assembly.Identity,
                                boundReference,
                                -assembliesBuilder.Count - 1,
                                diagnostics,
                                location,
                                assemblyReferencesBySimpleName,
                                supersedeLowerVersions);

                            if (existingReference != null)
                            {
                                MergeReferenceProperties(existingReference, boundReference, diagnostics, ref lazyAliasMap);
                                continue;
                            }

                            // Note, if SourceAssemblySymbol hasn't been created for 
                            // compilationAssembly.Compilation yet, we want this to happen 
                            // right now. Conveniently, this constructor will trigger creation of the 
                            // SourceAssemblySymbol.
                            var asmData = CreateAssemblyDataForCompilation(compilationReference);
                            AddAssembly(asmData, referenceIndex, referenceMap, assembliesBuilder);
                            break;

                        default:
                            throw ExceptionUtilities.UnexpectedValue(compilationReference.Properties.Kind);
                    }

                    continue;
                }

                // PE reference

                var peReference = (PortableExecutableReference)boundReference;
                Metadata? metadata = GetMetadata(peReference, MessageProvider, location, diagnostics);
                Debug.Assert(metadata != null || diagnostics.HasAnyErrors());

                if (metadata != null)
                {
                    switch (peReference.Properties.Kind)
                    {
                        case MetadataImageKind.Assembly:
                            var assemblyMetadata = (AssemblyMetadata)metadata;
                            WeakList<IAssemblySymbolInternal> cachedSymbols = assemblyMetadata.CachedSymbols;

                            if (assemblyMetadata.IsValidAssembly())
                            {
                                PEAssembly? assembly = assemblyMetadata.GetAssembly();
                                Debug.Assert(assembly is object);
                                existingReference = TryAddAssembly(
                                    assembly.Identity,
                                    peReference,
                                    -assembliesBuilder.Count - 1,
                                    diagnostics,
                                    location,
                                    assemblyReferencesBySimpleName,
                                    supersedeLowerVersions);

                                if (existingReference != null)
                                {
                                    MergeReferenceProperties(existingReference, boundReference, diagnostics, ref lazyAliasMap);
                                    continue;
                                }

                                var asmData = CreateAssemblyDataForFile(
                                    assembly,
                                    cachedSymbols,
                                    peReference.DocumentationProvider,
                                    SimpleAssemblyName,
                                    compilation.Options.MetadataImportOptions,
                                    peReference.Properties.EmbedInteropTypes);

                                AddAssembly(asmData, referenceIndex, referenceMap, assembliesBuilder);
                            }
                            else
                            {
                                diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_MetadataFileNotAssembly, location, peReference.Display ?? ""));
                            }

                            // asmData keeps strong ref after this point
                            GC.KeepAlive(assemblyMetadata);
                            break;

                        case MetadataImageKind.Module:
                            var moduleMetadata = (ModuleMetadata)metadata;
                            if (moduleMetadata.Module.IsLinkedModule)
                            {
                                // We don't support netmodules since some checks in the compiler need information from the full PE image
                                // (Machine, Bit32Required, PE image hash).
                                if (!moduleMetadata.Module.IsEntireImageAvailable)
                                {
                                    diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_LinkedNetmoduleMetadataMustProvideFullPEImage, location, peReference.Display ?? ""));
                                }

                                AddModule(moduleMetadata.Module, referenceIndex, referenceMap, ref lazyModulesBuilder);
                            }
                            else
                            {
                                diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_MetadataFileNotModule, location, peReference.Display ?? ""));
                            }
                            break;

                        default:
                            throw ExceptionUtilities.UnexpectedValue(peReference.Properties.Kind);
                    }
                }
            }

            if (uniqueDirectiveReferences != null)
            {
                uniqueDirectiveReferences.ReverseContents();
                boundReferenceDirectives = uniqueDirectiveReferences.ToImmutableAndFree();
            }
            else
            {
                boundReferenceDirectives = ImmutableArray<MetadataReference>.Empty;
            }

            // We enumerated references in reverse order in the above code
            // and thus assemblies and modules in the builders are reversed.
            // Fix up all the indices and reverse the builder content now to get 
            // the ordering matching the references.
            // 
            // Also fills in aliases.

            for (int i = 0; i < referenceMap.Length; i++)
            {
                if (!referenceMap[i].IsSkipped)
                {
                    int count = (referenceMap[i].Kind == MetadataImageKind.Assembly) ? assembliesBuilder.Count : lazyModulesBuilder?.Count ?? 0;

                    int reversedIndex = count - 1 - referenceMap[i].Index;
                    referenceMap[i] = GetResolvedReferenceAndFreePropertyMapEntry(references[i], reversedIndex, referenceMap[i].Kind, lazyAliasMap);
                }
            }

            assembliesBuilder.ReverseContents();
            assemblies = assembliesBuilder.ToImmutableAndFree();

            if (lazyModulesBuilder == null)
            {
                modules = ImmutableArray<PEModule>.Empty;
            }
            else
            {
                lazyModulesBuilder.ReverseContents();
                modules = lazyModulesBuilder.ToImmutableAndFree();
            }

            return ImmutableArray.CreateRange(referenceMap);
        }

        private static ResolvedReference GetResolvedReferenceAndFreePropertyMapEntry(MetadataReference reference, int index, MetadataImageKind kind, Dictionary<MetadataReference, MergedAliases>? propertyMapOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 21238, 22429);
                Microsoft.CodeAnalysis.MergedAliases mergedProperties = default(Microsoft.CodeAnalysis.MergedAliases);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21465, 21520);

                ImmutableArray<string>
                aliasesOpt
                = default(ImmutableArray<string>),
                recursiveAliasesOpt
                = default(ImmutableArray<string>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21536, 22327) || true) && (propertyMapOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(530, 21540, 21640) && f_530_21566_21640(propertyMapOpt, reference, out mergedProperties)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 21536, 22327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21674, 21772);

                    aliasesOpt = f_530_21687_21736_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(mergedProperties.AliasesOpt, 530, 21687, 21736).ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(530, 21687, 21771) ?? default(ImmutableArray<string>));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21790, 21906);

                    recursiveAliasesOpt = f_530_21812_21870_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(mergedProperties.RecursiveAliasesOpt, 530, 21812, 21870).ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<string>?>(530, 21812, 21905) ?? default(ImmutableArray<string>));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 21536, 22327);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 21536, 22327);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21940, 22327) || true) && (reference.Properties.HasRecursiveAliases)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 21940, 22327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 22018, 22063);

                        aliasesOpt = default(ImmutableArray<string>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 22081, 22132);

                        recursiveAliasesOpt = reference.Properties.Aliases;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 21940, 22327);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 21940, 22327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 22198, 22240);

                        aliasesOpt = reference.Properties.Aliases;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 22258, 22312);

                        recursiveAliasesOpt = default(ImmutableArray<string>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 21940, 22327);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 21536, 22327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 22343, 22418);

                return f_530_22350_22417(index, kind, aliasesOpt, recursiveAliasesOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 21238, 22429);

                bool
                f_530_21566_21640(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, out Microsoft.CodeAnalysis.MergedAliases?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21566, 21640);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>?
                f_530_21687_21736_I(System.Collections.Immutable.ImmutableArray<string>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21687, 21736);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>?
                f_530_21812_21870_I(System.Collections.Immutable.ImmutableArray<string>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21812, 21870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                f_530_22350_22417(int
                index, Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliasesOpt, System.Collections.Immutable.ImmutableArray<string>
                recursiveAliasesOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference(index, kind, aliasesOpt, recursiveAliasesOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 22350, 22417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 21238, 22429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 21238, 22429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Creates or gets metadata for PE reference.
        /// </summary>
        /// <remarks>
        /// If any of the following exceptions: <see cref="BadImageFormatException"/>, <see cref="FileNotFoundException"/>, <see cref="IOException"/>,
        /// are thrown while reading the metadata file, the exception is caught and an appropriate diagnostic stored in <paramref name="diagnostics"/>.
        /// </remarks>
        private Metadata? GetMetadata(PortableExecutableReference peReference, CommonMessageProvider messageProvider, Location location, DiagnosticBag diagnostics)
        {
            Metadata? existingMetadata;

            lock (ObservedMetadata)
            {
                if (TryGetObservedMetadata(peReference, diagnostics, out existingMetadata))
                {
                    return existingMetadata;
                }
            }

            Metadata? newMetadata;
            Diagnostic? newDiagnostic = null;
            try
            {
                newMetadata = peReference.GetMetadataNoCopy();

                // make sure basic structure of the PE image is valid:
                if (newMetadata is AssemblyMetadata assemblyMetadata)
                {
                    _ = assemblyMetadata.IsValidAssembly();
                }
                else
                {
                    _ = ((ModuleMetadata)newMetadata).Module.IsLinkedModule;
                }
            }
            catch (Exception e) when (e is BadImageFormatException || e is IOException)
            {
                newDiagnostic = PortableExecutableReference.ExceptionToDiagnostic(e, messageProvider, location, peReference.Display ?? "", peReference.Properties.Kind);
                newMetadata = null;
            }

            lock (ObservedMetadata)
            {
                if (TryGetObservedMetadata(peReference, diagnostics, out existingMetadata))
                {
                    return existingMetadata;
                }

                if (newDiagnostic != null)
                {
                    diagnostics.Add(newDiagnostic);
                }

                ObservedMetadata.Add(peReference, (MetadataOrDiagnostic?)newMetadata ?? newDiagnostic!);
                return newMetadata;
            }
        }

        private bool TryGetObservedMetadata(PortableExecutableReference peReference, DiagnosticBag diagnostics, out Metadata? metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 24804, 25438);
                object existing = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24956, 25368) || true) && (f_530_24960_25037(ObservedMetadata, peReference, out existing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 24956, 25368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25071, 25132);

                    f_530_25071_25131(existing is Metadata || (DynAbs.Tracing.TraceSender.Expression_False(530, 25084, 25130) || existing is Diagnostic));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25152, 25184);

                    metadata = existing as Metadata;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25202, 25321) || true) && (metadata == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 25202, 25321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25264, 25302);

                        f_530_25264_25301(diagnostics, existing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 25202, 25321);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25341, 25353);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 24956, 25368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25384, 25400);

                metadata = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25414, 25427);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 24804, 25438);

                bool
                f_530_24960_25037(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                key, out object?
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.MetadataReference)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 24960, 25037);
                    return return_v;
                }


                int
                f_530_25071_25131(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 25071, 25131);
                    return 0;
                }


                int
                f_530_25264_25301(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, object
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 25264, 25301);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 24804, 25438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 24804, 25438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AssemblyMetadata? GetAssemblyMetadata(PortableExecutableReference peReference, DiagnosticBag diagnostics)
        {
            var metadata = GetMetadata(peReference, MessageProvider, Location.None, diagnostics);
            Debug.Assert(metadata != null || diagnostics.HasAnyErrors());

            if (metadata == null)
            {
                return null;
            }

            // require the metadata to be a valid assembly metadata:
            var assemblyMetadata = metadata as AssemblyMetadata;
            if (assemblyMetadata?.IsValidAssembly() != true)
            {
                diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_MetadataFileNotAssembly, Location.None, peReference.Display ?? ""));
                return null;
            }

            return assemblyMetadata;
        }
        internal sealed class MetadataReferenceEqualityComparer : IEqualityComparer<MetadataReference>
        {
            internal static readonly MetadataReferenceEqualityComparer Instance;

            public bool Equals(MetadataReference? x, MetadataReference? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 26827, 27408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26922, 27020) || true) && (f_530_26926_26947(x, y))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 26922, 27020);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26989, 27001);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 26922, 27020);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27040, 27075);

                    var
                    cx = x as CompilationReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27093, 27360) || true) && (cx != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 27093, 27360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27149, 27184);

                        var
                        cy = y as CompilationReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27206, 27341) || true) && (cy != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 27206, 27341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27270, 27318);

                            return (object)f_530_27285_27299(cx) == f_530_27303_27317(cy);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 27206, 27341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 27093, 27360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27380, 27393);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(530, 26827, 27408);

                    bool
                    f_530_26926_26947(Microsoft.CodeAnalysis.MetadataReference?
                    objA, Microsoft.CodeAnalysis.MetadataReference?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 26926, 26947);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Compilation
                    f_530_27285_27299(Microsoft.CodeAnalysis.CompilationReference
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 27285, 27299);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Compilation
                    f_530_27303_27317(Microsoft.CodeAnalysis.CompilationReference
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 27303, 27317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 26827, 27408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 26827, 27408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(MetadataReference reference)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 27424, 27828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27508, 27569);

                    var
                    compilationReference = reference as CompilationReference
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27587, 27748) || true) && (compilationReference != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 27587, 27748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27661, 27729);

                        return f_530_27668_27728(f_530_27695_27727(compilationReference));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 27587, 27748);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 27768, 27813);

                    return f_530_27775_27812(reference);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(530, 27424, 27828);

                    Microsoft.CodeAnalysis.Compilation
                    f_530_27695_27727(Microsoft.CodeAnalysis.CompilationReference
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 27695, 27727);
                        return return_v;
                    }


                    int
                    f_530_27668_27728(Microsoft.CodeAnalysis.Compilation
                    o)
                    {
                        var return_v = RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 27668, 27728);
                        return return_v;
                    }


                    int
                    f_530_27775_27812(Microsoft.CodeAnalysis.MetadataReference
                    o)
                    {
                        var return_v = RuntimeHelpers.GetHashCode((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 27775, 27812);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 27424, 27828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 27424, 27828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public MetadataReferenceEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(530, 26582, 27839);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(530, 26582, 27839);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 26582, 27839);
            }


            static MetadataReferenceEqualityComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(530, 26582, 27839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26760, 26810);
                Instance = f_530_26771_26810(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(530, 26582, 27839);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 26582, 27839);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(530, 26582, 27839);

            static Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.MetadataReferenceEqualityComparer
            f_530_26771_26810()
            {
                var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.MetadataReferenceEqualityComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 26771, 26810);
                return return_v;
            }

        }

        /// <summary>
        /// Merges aliases of the first observed reference (<paramref name="primaryReference"/>) with aliases specified for an equivalent reference (<paramref name="newReference"/>).
        /// Empty alias list is considered to be the same as a list containing "global", since in both cases C# allows unqualified access to the symbols.
        /// </summary>
        private void MergeReferenceProperties(MetadataReference primaryReference, MetadataReference newReference, DiagnosticBag diagnostics, ref Dictionary<MetadataReference, MergedAliases>? lazyAliasMap)
        {
            if (!CheckPropertiesConsistency(newReference, primaryReference, diagnostics))
            {
                return;
            }

            if (lazyAliasMap == null)
            {
                lazyAliasMap = new Dictionary<MetadataReference, MergedAliases>();
            }

            MergedAliases? mergedAliases;
            if (!lazyAliasMap.TryGetValue(primaryReference, out mergedAliases))
            {
                mergedAliases = new MergedAliases();
                lazyAliasMap.Add(primaryReference, mergedAliases);
                mergedAliases.Merge(primaryReference);
            }

            mergedAliases.Merge(newReference);
        }

        private static void AddAssembly(AssemblyData data, int referenceIndex, ResolvedReference[] referenceMap, ArrayBuilder<AssemblyData> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 29275, 29637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29492, 29591);

                referenceMap[referenceIndex] = f_530_29523_29590(f_530_29545_29561(assemblies), MetadataImageKind.Assembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29605, 29626);

                f_530_29605_29625(assemblies, data);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 29275, 29637);

                int
                f_530_29545_29561(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 29545, 29561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                f_530_29523_29590(int
                index, Microsoft.CodeAnalysis.MetadataImageKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference(index, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 29523, 29590);
                    return return_v;
                }


                int
                f_530_29605_29625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 29605, 29625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 29275, 29637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 29275, 29637);
            }
        }

        private static void AddModule(PEModule module, int referenceIndex, ResolvedReference[] referenceMap, [NotNull] ref ArrayBuilder<PEModule>? modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 29772, 30214);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29944, 30059) || true) && (modules == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 29944, 30059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29997, 30044);

                    modules = f_530_30007_30043();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 29944, 30059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 30075, 30169);

                referenceMap[referenceIndex] = f_530_30106_30168(f_530_30128_30141(modules), MetadataImageKind.Module);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 30183, 30203);

                f_530_30183_30202(modules, module);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 29772, 30214);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>
                f_530_30007_30043()
                {
                    var return_v = ArrayBuilder<PEModule>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 30007, 30043);
                    return return_v;
                }


                int
                f_530_30128_30141(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 30128, 30141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                f_530_30106_30168(int
                index, Microsoft.CodeAnalysis.MetadataImageKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference(index, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 30106, 30168);
                    return return_v;
                }


                int
                f_530_30183_30202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>
                this_param, Microsoft.CodeAnalysis.PEModule
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 30183, 30202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 29772, 30214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 29772, 30214);
            }
        }

        /// <summary>
        /// Returns null if an assembly of an equivalent identity has not been added previously, otherwise returns the reference that added it.
        /// Two identities are considered equivalent if
        /// - both assembly names are strong (have keys) and are either equal or FX unified 
        /// - both assembly names are weak (no keys) and have the same simple name.
        /// </summary>
        private MetadataReference? TryAddAssembly(
            AssemblyIdentity identity,
            MetadataReference reference,
            int assemblyIndex,
            DiagnosticBag diagnostics,
            Location location,
            Dictionary<string, List<ReferencedAssemblyIdentity>> referencesBySimpleName,
            bool supersedeLowerVersions)
        {
            var referencedAssembly = new ReferencedAssemblyIdentity(identity, reference, assemblyIndex);

            List<ReferencedAssemblyIdentity>? sameSimpleNameIdentities;
            if (!referencesBySimpleName.TryGetValue(identity.Name, out sameSimpleNameIdentities))
            {
                referencesBySimpleName.Add(identity.Name, new List<ReferencedAssemblyIdentity> { referencedAssembly });
                return null;
            }

            if (supersedeLowerVersions)
            {
                foreach (var other in sameSimpleNameIdentities)
                {
                    Debug.Assert(other.Identity is object);
                    if (identity.Version == other.Identity.Version)
                    {
                        return other.Reference;
                    }
                }

                // Keep all versions of the assembly and the first identity in the list the one with the highest version:
                if (sameSimpleNameIdentities[0].Identity!.Version > identity.Version)
                {
                    sameSimpleNameIdentities.Add(referencedAssembly);
                }
                else
                {
                    sameSimpleNameIdentities.Add(sameSimpleNameIdentities[0]);
                    sameSimpleNameIdentities[0] = referencedAssembly;
                }

                return null;
            }

            ReferencedAssemblyIdentity equivalent = default(ReferencedAssemblyIdentity);
            if (identity.IsStrongName)
            {
                foreach (var other in sameSimpleNameIdentities)
                {
                    // Only compare strong with strong (weak is never equivalent to strong and vice versa).
                    // In order to eliminate duplicate references we need to try to match their identities in both directions since 
                    // ReferenceMatchesDefinition is not necessarily symmetric.
                    // (e.g. System.Numerics.Vectors, Version=4.1+ matches System.Numerics.Vectors, Version=4.0, but not the other way around.)
                    Debug.Assert(other.Identity is object);
                    if (other.Identity.IsStrongName &&
                        IdentityComparer.ReferenceMatchesDefinition(identity, other.Identity) &&
                        IdentityComparer.ReferenceMatchesDefinition(other.Identity, identity))
                    {
                        equivalent = other;
                        break;
                    }
                }
            }
            else
            {
                foreach (var other in sameSimpleNameIdentities)
                {
                    // only compare weak with weak
                    Debug.Assert(other.Identity is object);
                    if (!other.Identity.IsStrongName && WeakIdentityPropertiesEquivalent(identity, other.Identity))
                    {
                        equivalent = other;
                        break;
                    }
                }
            }

            if (equivalent.Identity == null)
            {
                sameSimpleNameIdentities.Add(referencedAssembly);
                return null;
            }

            // equivalent found - ignore and/or report an error:

            if (identity.IsStrongName)
            {
                Debug.Assert(equivalent.Identity.IsStrongName);

                // versions might have been unified for a Framework assembly:
                if (identity != equivalent.Identity)
                {
                    // Dev12 C# reports an error
                    // Dev12 VB keeps both references in the compilation and reports an ambiguity error when a symbol is used.
                    // BREAKING CHANGE in VB: we report an error for both languages

                    // Multiple assemblies with equivalent identity have been imported: '{0}' and '{1}'. Remove one of the duplicate references.
                    MessageProvider.ReportDuplicateMetadataReferenceStrong(diagnostics, location, reference, identity, equivalent.Reference!, equivalent.Identity);
                }
                // If the versions match exactly we ignore duplicates w/o reporting errors while 
                // Dev12 C# reports:
                //   error CS1703: An assembly with the same identity '{0}' has already been imported. Try removing one of the duplicate references.
                // Dev12 VB reports:
                //   Fatal error BC2000 : compiler initialization failed unexpectedly: Project already has a reference to assembly System. 
                //   A second reference to 'D:\Temp\System.dll' cannot be added.
            }
            else
            {
                Debug.Assert(!equivalent.Identity.IsStrongName);

                // Dev12 reports an error for all weak-named assemblies, even if the versions are the same.
                // We treat assemblies with the same name and version equal even if they don't have a strong name.
                // This change allows us to de-duplicate #r references based on identities rather than full paths,
                // and is closer to platforms that don't support strong names and consider name and version enough
                // to identify an assembly. An identity without version is considered to have version 0.0.0.0.

                if (identity != equivalent.Identity)
                {
                    MessageProvider.ReportDuplicateMetadataReferenceWeak(diagnostics, location, reference, identity, equivalent.Reference!, equivalent.Identity);
                }
            }

            Debug.Assert(equivalent.Reference != null);
            return equivalent.Reference;
        }

        protected void GetCompilationReferences(
            TCompilation compilation,
            DiagnosticBag diagnostics,
            out ImmutableArray<MetadataReference> references,
            out IDictionary<(string, string), MetadataReference> boundReferenceDirectives,
            out ImmutableArray<Location> referenceDirectiveLocations)
        {
            ArrayBuilder<MetadataReference> referencesBuilder = ArrayBuilder<MetadataReference>.GetInstance();
            ArrayBuilder<Location>? referenceDirectiveLocationsBuilder = null;
            IDictionary<(string, string), MetadataReference>? localBoundReferenceDirectives = null;

            try
            {
                foreach (var referenceDirective in compilation.ReferenceDirectives)
                {
                    Debug.Assert(referenceDirective.Location is object);

                    if (compilation.Options.MetadataReferenceResolver == null)
                    {
                        diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_MetadataReferencesNotSupported, referenceDirective.Location));
                        break;
                    }

                    // we already successfully bound #r with the same value:
                    Debug.Assert(referenceDirective.File is object);
                    Debug.Assert(referenceDirective.Location.SourceTree is object);
                    if (localBoundReferenceDirectives != null && localBoundReferenceDirectives.ContainsKey((referenceDirective.Location.SourceTree.FilePath, referenceDirective.File)))
                    {
                        continue;
                    }

                    MetadataReference? boundReference = ResolveReferenceDirective(referenceDirective.File, referenceDirective.Location, compilation);
                    if (boundReference == null)
                    {
                        diagnostics.Add(MessageProvider.CreateDiagnostic(MessageProvider.ERR_MetadataFileNotFound, referenceDirective.Location, referenceDirective.File));
                        continue;
                    }

                    if (localBoundReferenceDirectives == null)
                    {
                        localBoundReferenceDirectives = new Dictionary<(string, string), MetadataReference>();
                        referenceDirectiveLocationsBuilder = ArrayBuilder<Location>.GetInstance();
                    }

                    referencesBuilder.Add(boundReference);
                    referenceDirectiveLocationsBuilder!.Add(referenceDirective.Location);
                    localBoundReferenceDirectives.Add((referenceDirective.Location.SourceTree.FilePath, referenceDirective.File), boundReference);
                }

                // add external reference at the end, so that they are processed first:
                referencesBuilder.AddRange(compilation.ExternalReferences);

                // Add all explicit references of the previous script compilation.
                var previousScriptCompilation = compilation.ScriptCompilationInfo?.PreviousScriptCompilation;
                if (previousScriptCompilation != null)
                {
                    referencesBuilder.AddRange(previousScriptCompilation.GetBoundReferenceManager().ExplicitReferences);
                }

                if (localBoundReferenceDirectives == null)
                {
                    // no directive references resolved successfully:
                    localBoundReferenceDirectives = SpecializedCollections.EmptyDictionary<(string, string), MetadataReference>();
                }

                boundReferenceDirectives = localBoundReferenceDirectives;
                references = referencesBuilder.ToImmutable();
                referenceDirectiveLocations = referenceDirectiveLocationsBuilder?.ToImmutableAndFree() ?? ImmutableArray<Location>.Empty;
            }
            finally
            {
                // Put this in a finally because we have tests that (intentionally) cause ResolveReferenceDirective to throw and 
                // we don't want to clutter the test output with leak reports.
                referencesBuilder.Free();
            }
        }

        private static PortableExecutableReference? ResolveReferenceDirective(string reference, Location location, TCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 41294, 42194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41451, 41482);

                var
                tree = f_530_41462_41481(location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41496, 41581);

                string?
                basePath = (DynAbs.Tracing.TraceSender.Conditional_F1(530, 41515, 41557) || (((tree != null && (DynAbs.Tracing.TraceSender.Expression_True(530, 41516, 41556) && f_530_41532_41552(f_530_41532_41545(tree)) > 0)) && DynAbs.Tracing.TraceSender.Conditional_F2(530, 41560, 41573)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 41576, 41580))) ? f_530_41560_41573(tree) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41630, 41698);

                f_530_41630_41697(f_530_41643_41688(compilation.Options) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41714, 41880);

                var
                references = f_530_41731_41879(f_530_41731_41776(compilation.Options), reference, basePath, MetadataReferenceProperties.Assembly.WithRecursiveAliases(true))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41894, 41986) || true) && (references.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 41894, 41986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41959, 41971);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 41894, 41986);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42002, 42146) || true) && (references.Length > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 42002, 42146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42097, 42131);

                    throw f_530_42103_42130();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 42002, 42146);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42162, 42183);

                return references[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 41294, 42194);

                Microsoft.CodeAnalysis.SyntaxTree?
                f_530_41462_41481(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41462, 41481);
                    return return_v;
                }


                string
                f_530_41532_41545(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41532, 41545);
                    return return_v;
                }


                int
                f_530_41532_41552(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41532, 41552);
                    return return_v;
                }


                string
                f_530_41560_41573(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41560, 41573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_530_41643_41688(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41643, 41688);
                    return return_v;
                }


                int
                f_530_41630_41697(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 41630, 41697);
                    return 0;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver
                f_530_41731_41776(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41731, 41776);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PortableExecutableReference>
                f_530_41731_41879(Microsoft.CodeAnalysis.MetadataReferenceResolver
                this_param, string
                reference, string?
                baseFilePath, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties)
                {
                    var return_v = this_param.ResolveReference(reference, baseFilePath, properties);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 41731, 41879);
                    return return_v;
                }


                System.NotSupportedException
                f_530_42103_42130()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 42103, 42130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 41294, 42194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 41294, 42194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyReferenceBinding[] ResolveReferencedAssemblies(
                    ImmutableArray<AssemblyIdentity> references,
                    ImmutableArray<AssemblyData> definitions,
                    int definitionStartIndex,
                    AssemblyIdentityComparer assemblyIdentityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 42206, 42866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42518, 42588);

                var
                boundReferences = new AssemblyReferenceBinding[references.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42611, 42616);
                    for (int
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42602, 42816) || true) && (j < references.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42641, 42644)
        , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 42602, 42816))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 42602, 42816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42678, 42801);

                        boundReferences[j] = f_530_42699_42800(references[j], definitions, definitionStartIndex, assemblyIdentityComparer);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 42832, 42855);

                return boundReferences;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 42206, 42866);

                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_42699_42800(Microsoft.CodeAnalysis.AssemblyIdentity
                reference, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                definitions, int
                definitionStartIndex, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                assemblyIdentityComparer)
                {
                    var return_v = ResolveReferencedAssembly(reference, definitions, definitionStartIndex, assemblyIdentityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 42699, 42800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 42206, 42866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 42206, 42866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyReferenceBinding ResolveReferencedAssembly(
                    AssemblyIdentity reference,
                    ImmutableArray<AssemblyData> definitions,
                    int definitionStartIndex,
                    AssemblyIdentityComparer assemblyIdentityComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(530, 43510, 50154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44275, 44311);

                int
                minHigherVersionDefinition = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44325, 44360);

                int
                maxLowerVersionDefinition = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44466, 44532);

                bool
                resolveAgainstAssemblyBeingBuilt = definitionStartIndex == 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44546, 44603);

                definitionStartIndex = f_530_44569_44602(definitionStartIndex, 1);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44628, 44652);

                    for (int
        i = definitionStartIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44619, 46395) || true) && (i < definitions.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44678, 44681)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 44619, 46395))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 44619, 46395);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44715, 44769);

                        AssemblyIdentity
                        definition = f_530_44745_44768(definitions[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44789, 46380);

                        switch (f_530_44797_44852(assemblyIdentityComparer, reference, definition))
                        {

                            case AssemblyIdentityComparer.ComparisonResult.NotEquivalent:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 44789, 46380);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 44981, 44990);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 44789, 46380);

                            case AssemblyIdentityComparer.ComparisonResult.Equivalent:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 44789, 46380);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45098, 45148);

                                return f_530_45105_45147(reference, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 44789, 46380);

                            case AssemblyIdentityComparer.ComparisonResult.EquivalentIgnoringVersion:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 44789, 46380);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45271, 46229) || true) && (f_530_45275_45292(reference) < f_530_45295_45313(definition))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 45271, 46229);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45444, 45689) || true) && (minHigherVersionDefinition == -1 || (DynAbs.Tracing.TraceSender.Expression_False(530, 45448, 45561) || f_530_45484_45502(definition) < f_530_45505_45561(f_530_45505_45553(definitions[minHigherVersionDefinition]))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 45444, 45689);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45627, 45658);

                                        minHigherVersionDefinition = i;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 45444, 45689);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 45271, 46229);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 45271, 46229);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45803, 45856);

                                    f_530_45803_45855(f_530_45816_45833(reference) > f_530_45836_45854(definition));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 45960, 46202) || true) && (maxLowerVersionDefinition == -1 || (DynAbs.Tracing.TraceSender.Expression_False(530, 45964, 46075) || f_530_45999_46017(definition) > f_530_46020_46075(f_530_46020_46067(definitions[maxLowerVersionDefinition]))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 45960, 46202);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46141, 46171);

                                        maxLowerVersionDefinition = i;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 45960, 46202);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 45271, 46229);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46257, 46266);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 44789, 46380);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 44789, 46380);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46324, 46361);

                                throw f_530_46330_46360();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 44789, 46380);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 1777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 1777);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46484, 46667) || true) && (minHigherVersionDefinition != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 46484, 46667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46554, 46652);

                    return f_530_46561_46651(reference, minHigherVersionDefinition, versionDifference: +1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 46484, 46667);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46683, 46864) || true) && (maxLowerVersionDefinition != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 46683, 46864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 46752, 46849);

                    return f_530_46759_46848(reference, maxLowerVersionDefinition, versionDifference: -1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 46683, 46864);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47288, 47663) || true) && (f_530_47292_47322(reference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 47288, 47663);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47365, 47389);
                        for (int
        i = definitionStartIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47356, 47648) || true) && (i < definitions.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47415, 47418)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 47356, 47648))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 47356, 47648);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47460, 47629) || true) && (f_530_47464_47506(f_530_47464_47487(definitions[i])))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 47460, 47629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 47556, 47606);

                                return f_530_47563_47605(reference, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 47460, 47629);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 293);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 47288, 47663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48232, 49444) || true) && (f_530_48236_48257(reference) == AssemblyContentType.WindowsRuntime)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 48232, 49444);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48338, 48362);
                        for (int
        i = definitionStartIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48329, 49429) || true) && (i < definitions.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48388, 48391)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 48329, 49429))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 48329, 49429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48433, 48474);

                            var
                            definition = f_530_48450_48473(definitions[i])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48496, 48553);

                            var
                            sourceCompilation = f_530_48520_48552(definitions[i])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 48606, 49410) || true) && (f_530_48610_48632(definition) == AssemblyContentType.Default && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 48717) && sourceCompilation != null) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 48819) && f_530_48746_48782(f_530_48746_48771(sourceCompilation)) == OutputKind.WindowsRuntimeMetadata) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 48931) && f_530_48848_48931(f_530_48848_48891(), f_530_48899_48913(reference), f_530_48915_48930(definition))) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 49004) && f_530_48960_49004(f_530_48960_48977(reference), f_530_48985_49003(definition))) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 49086) && f_530_49033_49057(reference) == f_530_49061_49086(definition)) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 49209) && f_530_49115_49209(f_530_49115_49155(), f_530_49163_49184(reference), f_530_49186_49208(definition))) && (DynAbs.Tracing.TraceSender.Expression_True(530, 48610, 49287) && f_530_49238_49287(reference, definition)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 48606, 49410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 49337, 49387);

                                return f_530_49344_49386(reference, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 48606, 49410);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 1101);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 1101);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 48232, 49444);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 49749, 50080) || true) && (resolveAgainstAssemblyBeingBuilt && (DynAbs.Tracing.TraceSender.Expression_True(530, 49753, 49902) && f_530_49806_49902(f_530_49806_49849(), f_530_49857_49871(reference), f_530_49873_49901(f_530_49873_49896(definitions[0])))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 49749, 50080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 49936, 49997);

                    f_530_49936_49996(f_530_49949_49972(definitions[0]).PublicKeyToken.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 50015, 50065);

                    return f_530_50022_50064(reference, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 49749, 50080);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 50096, 50143);

                return f_530_50103_50142(reference);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(530, 43510, 50154);

                int
                f_530_44569_44602(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 44569, 44602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_44745_44768(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 44745, 44768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_530_44797_44852(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.Compare(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 44797, 44852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_45105_45147(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 45105, 45147);
                    return return_v;
                }


                System.Version
                f_530_45275_45292(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45275, 45292);
                    return return_v;
                }


                System.Version
                f_530_45295_45313(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45295, 45313);
                    return return_v;
                }


                System.Version
                f_530_45484_45502(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45484, 45502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_45505_45553(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45505, 45553);
                    return return_v;
                }


                System.Version
                f_530_45505_45561(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45505, 45561);
                    return return_v;
                }


                System.Version
                f_530_45816_45833(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45816, 45833);
                    return return_v;
                }


                System.Version
                f_530_45836_45854(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45836, 45854);
                    return return_v;
                }


                int
                f_530_45803_45855(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 45803, 45855);
                    return 0;
                }


                System.Version
                f_530_45999_46017(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 45999, 46017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_46020_46067(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 46020, 46067);
                    return return_v;
                }


                System.Version
                f_530_46020_46075(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 46020, 46075);
                    return return_v;
                }


                System.Exception
                f_530_46330_46360()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 46330, 46360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_46561_46651(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex, int
                versionDifference)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex, versionDifference: versionDifference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 46561, 46651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_46759_46848(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex, int
                versionDifference)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex, versionDifference: versionDifference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 46759, 46848);
                    return return_v;
                }


                bool
                f_530_47292_47322(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = identity.IsWindowsComponent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 47292, 47322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_47464_47487(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 47464, 47487);
                    return return_v;
                }


                bool
                f_530_47464_47506(Microsoft.CodeAnalysis.AssemblyIdentity
                identity)
                {
                    var return_v = identity.IsWindowsRuntime();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 47464, 47506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_47563_47605(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 47563, 47605);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_530_48236_48257(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48236, 48257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_48450_48473(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48450, 48473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_530_48520_48552(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.SourceCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48520, 48552);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_530_48610_48632(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48610, 48632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_48746_48771(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48746, 48771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_530_48746_48782(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48746, 48782);
                    return return_v;
                }


                System.StringComparer
                f_530_48848_48891()
                {
                    var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48848, 48891);
                    return return_v;
                }


                string
                f_530_48899_48913(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48899, 48913);
                    return return_v;
                }


                string
                f_530_48915_48930(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48915, 48930);
                    return return_v;
                }


                bool
                f_530_48848_48931(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 48848, 48931);
                    return return_v;
                }


                System.Version
                f_530_48960_48977(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48960, 48977);
                    return return_v;
                }


                System.Version
                f_530_48985_49003(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 48985, 49003);
                    return return_v;
                }


                bool
                f_530_48960_49004(System.Version
                this_param, System.Version
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 48960, 49004);
                    return return_v;
                }


                bool
                f_530_49033_49057(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49033, 49057);
                    return return_v;
                }


                bool
                f_530_49061_49086(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsRetargetable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49061, 49086);
                    return return_v;
                }


                System.StringComparer
                f_530_49115_49155()
                {
                    var return_v = AssemblyIdentityComparer.CultureComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49115, 49155);
                    return return_v;
                }


                string
                f_530_49163_49184(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49163, 49184);
                    return return_v;
                }


                string
                f_530_49186_49208(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49186, 49208);
                    return return_v;
                }


                bool
                f_530_49115_49209(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 49115, 49209);
                    return return_v;
                }


                bool
                f_530_49238_49287(Microsoft.CodeAnalysis.AssemblyIdentity
                x, Microsoft.CodeAnalysis.AssemblyIdentity
                y)
                {
                    var return_v = AssemblyIdentity.KeysEqual(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 49238, 49287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_49344_49386(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 49344, 49386);
                    return return_v;
                }


                System.StringComparer
                f_530_49806_49849()
                {
                    var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49806, 49849);
                    return return_v;
                }


                string
                f_530_49857_49871(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49857, 49871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_49873_49896(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49873, 49896);
                    return return_v;
                }


                string
                f_530_49873_49901(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49873, 49901);
                    return return_v;
                }


                bool
                f_530_49806_49902(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 49806, 49902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_49949_49972(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 49949, 49972);
                    return return_v;
                }


                int
                f_530_49936_49996(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 49936, 49996);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_50022_50064(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 50022, 50064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_530_50103_50142(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 50103, 50142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 43510, 50154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 43510, 50154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
