// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol>
    {        /// <summary>
             /// For the given set of AssemblyData objects, do the following:
             ///    1) Resolve references from each assembly against other assemblies in the set.
             ///    2) Choose suitable AssemblySymbol instance for each AssemblyData object.
             ///
             /// The first element (index==0) of the assemblies array represents the assembly being built.
             /// One can think about the rest of the items in assemblies array as assembly references given to the compiler to
             /// build executable for the assembly being built. 
             /// </summary>
             /// <param name="compilation">Compilation.</param>
             /// <param name="explicitAssemblies">
             /// An array of <see cref="AssemblyData"/> objects describing assemblies, for which this method should
             /// resolve references and find suitable AssemblySymbols. The first slot contains the assembly being built.
             /// </param>
             /// <param name="explicitModules">
             /// An array of <see cref="PEModule"/> objects describing standalone modules referenced by the compilation.
             /// </param>
             /// <param name="explicitReferences">
             /// An array of references passed to the compilation and resolved from #r directives.
             /// May contain references that were skipped during resolution (they don't have a corresponding explicit assembly).
             /// </param>
             /// <param name="explicitReferenceMap">
             /// Maps index to <paramref name="explicitReferences"/> to an index of a resolved assembly or module in <paramref name="explicitAssemblies"/> or modules.
             /// </param>
             /// <param name="resolverOpt">
             /// Reference resolver used to look up missing assemblies.
             /// </param>
             /// <param name="supersedeLowerVersions">
             /// Hide lower versions of dependencies that have multiple versions behind an alias.
             /// </param>
             /// <param name="assemblyReferencesBySimpleName">
             /// Used to filter out assemblies that have the same strong or weak identity.
             /// Maps simple name to a list of identities. The highest version of each name is the first.
             /// </param>
             /// <param name="importOptions">
             /// Import options applied to implicitly resolved references.
             /// </param>
             /// <param name="allAssemblies">
             /// Updated array <paramref name="explicitAssemblies"/> with resolved implicitly referenced assemblies appended.
             /// </param>
             /// <param name="implicitlyResolvedReferences">
             /// Implicitly resolved references.
             /// </param>
             /// <param name="implicitlyResolvedReferenceMap">
             /// Maps indices of implicitly resolved references to the corresponding indices of resolved assemblies in <paramref name="allAssemblies"/> (explicit + implicit).
             /// </param>
             /// <param name="implicitReferenceResolutions">
             /// Map of implicit reference resolutions performed in the preceding script compilation. 
             /// Output contains additional implicit resolutions performed during binding of this script compilation references.
             /// </param>
             /// <param name="resolutionDiagnostics">
             /// Any diagnostics reported while resolving missing assemblies.
             /// </param>
             /// <param name="hasCircularReference">
             /// True if the assembly being compiled is indirectly referenced through some of its own references.
             /// </param>
             /// <param name="corLibraryIndex">
             /// The definition index of the COR library.
             /// </param>
             /// <return>
             /// An array of <see cref="BoundInputAssembly"/> structures describing the result. It has the same amount of items as
             /// the input assemblies array, <see cref="BoundInputAssembly"/> for each input AssemblyData object resides
             /// at the same position.
             /// 
             /// Each <see cref="BoundInputAssembly"/> contains the following data:
             /// 
             /// -    Suitable AssemblySymbol instance for the corresponding assembly, 
             ///     null reference if none is available/found. Always null for the first element, which corresponds to the assembly being built.
             ///
             /// -    Result of resolving assembly references of the corresponding assembly 
             ///     against provided set of assembly definitions. Essentially, this is an array returned by
             ///     <see cref="AssemblyData.BindAssemblyReferences(ImmutableArray{AssemblyData}, AssemblyIdentityComparer)"/> method.
             /// </return>
        protected BoundInputAssembly[] Bind(
                    TCompilation compilation,
                    ImmutableArray<AssemblyData> explicitAssemblies,
                    ImmutableArray<PEModule> explicitModules,
                    ImmutableArray<MetadataReference> explicitReferences,
                    ImmutableArray<ResolvedReference> explicitReferenceMap,
                    MetadataReferenceResolver? resolverOpt,
                    MetadataImportOptions importOptions,
                    bool supersedeLowerVersions,
                    [In, Out] Dictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName,
                    out ImmutableArray<AssemblyData> allAssemblies,
                    out ImmutableArray<MetadataReference> implicitlyResolvedReferences,
                    out ImmutableArray<ResolvedReference> implicitlyResolvedReferenceMap,
                    ref ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> implicitReferenceResolutions,
                    [In, Out] DiagnosticBag resolutionDiagnostics,
                    out bool hasCircularReference,
                    out int corLibraryIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 5285, 10547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6373, 6446);

                f_529_6373_6445(explicitAssemblies[0] is AssemblyDataForAssemblyBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6460, 6531);

                f_529_6460_6530(explicitReferences.Length == explicitReferenceMap.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6547, 6626);

                var
                referenceBindings = f_529_6571_6625()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6831, 6836);
                        // Based on assembly identity, for each assembly, 
                        // bind its references against the other assemblies we have.
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6822, 7039) || true) && (i < explicitAssemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6869, 6872)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 6822, 7039))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 6822, 7039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 6914, 7020);

                            f_529_6914_7019(referenceBindings, f_529_6936_7018(explicitAssemblies[i], explicitAssemblies, IdentityComparer));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 218);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 218);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 7059, 8223) || true) && (f_529_7063_7100_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(resolverOpt, 529, 7063, 7100)?.ResolveMissingAssemblies) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 7059, 8223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 7150, 7899);

                        f_529_7150_7898(this, compilation, explicitAssemblies, explicitModules, explicitReferences, explicitReferenceMap, resolverOpt, importOptions, supersedeLowerVersions, referenceBindings, assemblyReferencesBySimpleName, out allAssemblies, out implicitlyResolvedReferences, out implicitlyResolvedReferenceMap, ref implicitReferenceResolutions, resolutionDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 7059, 8223);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 7059, 8223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 7981, 8016);

                        allAssemblies = explicitAssemblies;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 8038, 8109);

                        implicitlyResolvedReferences = ImmutableArray<MetadataReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 8131, 8204);

                        implicitlyResolvedReferenceMap = ImmutableArray<ResolvedReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 7059, 8223);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 8355, 8417);

                    f_529_8355_8416(f_529_8368_8391(referenceBindings) == allAssemblies.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 8437, 8502);

                    hasCircularReference = f_529_8460_8501(referenceBindings);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 8520, 8632);

                    corLibraryIndex = f_529_8538_8631(explicitAssemblies, assemblyReferencesBySimpleName, supersedeLowerVersions);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9071, 9137);

                    var
                    boundInputs = new BoundInputAssembly[f_529_9112_9135(referenceBindings)]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9164, 9169);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9155, 9319) || true) && (i < f_529_9175_9198(referenceBindings))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9200, 9203)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 9155, 9319))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 9155, 9319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9245, 9300);

                            boundInputs[i].ReferenceBinding = f_529_9279_9299(referenceBindings, i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 165);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9339, 9417);

                    var
                    candidateInputAssemblySymbols = new TAssemblySymbol[allAssemblies.Length]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9759, 10131) || true) && (!hasCircularReference)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 9759, 10131);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 9901, 10112) || true) && (f_529_9905_10020(this, boundInputs, candidateInputAssemblySymbols, allAssemblies, corLibraryIndex))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 9901, 10112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 10070, 10089);

                            return boundInputs;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 9901, 10112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 9759, 10131);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 10291, 10388);

                    f_529_10291_10387(this, boundInputs, candidateInputAssemblySymbols, allAssemblies, corLibraryIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 10408, 10427);

                    return boundInputs;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(529, 10456, 10536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 10496, 10521);

                    f_529_10496_10520(referenceBindings);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(529, 10456, 10536);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 5285, 10547);

                int
                f_529_6373_6445(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 6373, 6445);
                    return 0;
                }


                int
                f_529_6460_6530(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 6460, 6530);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                f_529_6571_6625()
                {
                    var return_v = ArrayBuilder<AssemblyReferenceBinding[]>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 6571, 6625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_6936_7018(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                assemblyIdentityComparer)
                {
                    var return_v = this_param.BindAssemblyReferences(assemblies, assemblyIdentityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 6936, 7018);
                    return return_v;
                }


                int
                f_529_6914_7019(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 6914, 7019);
                    return 0;
                }


                bool?
                f_529_7063_7100_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 7063, 7100);
                    return return_v;
                }


                int
                f_529_7150_7898(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                explicitAssemblies, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                explicitModules, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                explicitReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                explicitReferenceMap, Microsoft.CodeAnalysis.MetadataReferenceResolver
                resolver, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions, bool
                supersedeLowerVersions, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                referenceBindings, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                assemblyReferencesBySimpleName, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                allAssemblies, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                metadataReferences, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                resolvedReferences, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                implicitReferenceResolutions, Microsoft.CodeAnalysis.DiagnosticBag
                resolutionDiagnostics)
                {
                    this_param.ResolveAndBindMissingAssemblies(compilation, explicitAssemblies, explicitModules, explicitReferences, explicitReferenceMap, resolver, importOptions, supersedeLowerVersions, referenceBindings, assemblyReferencesBySimpleName, out allAssemblies, out metadataReferences, out resolvedReferences, ref implicitReferenceResolutions, resolutionDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 7150, 7898);
                    return 0;
                }


                int
                f_529_8368_8391(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 8368, 8391);
                    return return_v;
                }


                int
                f_529_8355_8416(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 8355, 8416);
                    return 0;
                }


                bool
                f_529_8460_8501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                referenceBindings)
                {
                    var return_v = CheckCircularReference((System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>)referenceBindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 8460, 8501);
                    return return_v;
                }


                int
                f_529_8538_8631(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                assemblyReferencesBySimpleName, bool
                supersedeLowerVersions)
                {
                    var return_v = IndexOfCorLibrary(assemblies, (System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>)assemblyReferencesBySimpleName, supersedeLowerVersions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 8538, 8631);
                    return return_v;
                }


                int
                f_529_9112_9135(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 9112, 9135);
                    return return_v;
                }


                int
                f_529_9175_9198(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 9175, 9198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_9279_9299(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 9279, 9299);
                    return return_v;
                }


                bool
                f_529_9905_10020(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.BoundInputAssembly[]
                boundInputs, TAssemblySymbol[]
                candidateInputAssemblySymbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies, int
                corLibraryIndex)
                {
                    var return_v = this_param.ReuseAssemblySymbolsWithNoPiaLocalTypes(boundInputs, candidateInputAssemblySymbols, assemblies, corLibraryIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 9905, 10020);
                    return return_v;
                }


                int
                f_529_10291_10387(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.BoundInputAssembly[]
                boundInputs, TAssemblySymbol[]
                candidateInputAssemblySymbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies, int
                corLibraryIndex)
                {
                    this_param.ReuseAssemblySymbols(boundInputs, candidateInputAssemblySymbols, assemblies, corLibraryIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 10291, 10387);
                    return 0;
                }


                int
                f_529_10496_10520(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 10496, 10520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 5285, 10547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 5285, 10547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ResolveAndBindMissingAssemblies(
                    TCompilation compilation,
                    ImmutableArray<AssemblyData> explicitAssemblies,
                    ImmutableArray<PEModule> explicitModules,
                    ImmutableArray<MetadataReference> explicitReferences,
                    ImmutableArray<ResolvedReference> explicitReferenceMap,
                    MetadataReferenceResolver resolver,
                    MetadataImportOptions importOptions,
                    bool supersedeLowerVersions,
                    [In, Out] ArrayBuilder<AssemblyReferenceBinding[]> referenceBindings,
                    [In, Out] Dictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName,
                    out ImmutableArray<AssemblyData> allAssemblies,
                    out ImmutableArray<MetadataReference> metadataReferences,
                    out ImmutableArray<ResolvedReference> resolvedReferences,
                    ref ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> implicitReferenceResolutions,
                    DiagnosticBag resolutionDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 10559, 19738);
                Microsoft.CodeAnalysis.AssemblyIdentity? resolvedAssemblyIdentity = default(Microsoft.CodeAnalysis.AssemblyIdentity?);
                Microsoft.CodeAnalysis.AssemblyMetadata? resolvedAssemblyMetadata = default(Microsoft.CodeAnalysis.AssemblyMetadata?);
                Microsoft.CodeAnalysis.PortableExecutableReference? resolvedReference = default(Microsoft.CodeAnalysis.PortableExecutableReference?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 11621, 11694);

                f_529_11621_11693(explicitAssemblies[0] is AssemblyDataForAssemblyBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 11708, 11775);

                f_529_11708_11774(f_529_11721_11744(referenceBindings) == explicitAssemblies.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 11789, 11860);

                f_529_11789_11859(explicitReferences.Length == explicitReferenceMap.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 11921, 11986);

                int
                totalReferencedAssemblyCount = explicitAssemblies.Length - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12002, 12068);

                var
                implicitAssemblies = f_529_12027_12067()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12185, 12256);

                var
                resolutionFailures = f_529_12210_12255()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12272, 12350);

                var
                metadataReferencesBuilder = f_529_12304_12349()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12366, 12432);

                Dictionary<MetadataReference, MergedAliases>?
                lazyAliasMap = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12565, 12686);

                var
                referenceBindingsToProcess = f_529_12598_12685()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 12829, 13002);

                f_529_12829_13001(this, explicitModules, explicitReferences, explicitReferenceMap, referenceBindings, totalReferencedAssemblyCount, referenceBindingsToProcess);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13073, 13127);

                int
                explicitAssemblyCount = explicitAssemblies.Length
                ;

                try
                {
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13179, 16914) || true) && (f_529_13186_13218(referenceBindingsToProcess) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 13179, 16914);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13264, 13335);

                            var (requestingReference, bindings) = f_529_13302_13334(referenceBindingsToProcess);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13359, 16895);
                                foreach (var binding in f_529_13383_13391_I(bindings))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 13359, 16895);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13565, 13678) || true) && (binding.IsBound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 13565, 13678);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13642, 13651);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 13565, 13678);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13706, 13756);

                                    f_529_13706_13755(binding.ReferenceIdentity is object);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 13782, 14643) || true) && (!f_529_13787_14309(this, requestingReference, binding.ReferenceIdentity, ref implicitReferenceResolutions, resolver, resolutionDiagnostics, out resolvedAssemblyIdentity, out resolvedAssemblyMetadata, out resolvedReference))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 13782, 14643);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 14527, 14577);

                                        f_529_14527_14576(                            // Note the failure, but do not commit it to implicitReferenceResolutions until we are done with resolving all missing references.
                                                                    resolutionFailures, binding.ReferenceIdentity);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 14607, 14616);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 13782, 14643);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 14993, 15046);

                                    f_529_14993_15045(
                                                            // One attempt for resolution succeeded. The attempt is cached in implicitReferenceResolutions, so further attempts won't fail and add it back.
                                                            // Since the failures tracked in resolutionFailures do not affect binding there is no need to revert any decisions made so far.
                                                            resolutionFailures, binding.ReferenceIdentity);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 15704, 15776);

                                    int
                                    index = explicitAssemblyCount - 1 + f_529_15744_15775(metadataReferencesBuilder)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 15804, 15989);

                                    var
                                    existingReference = f_529_15828_15988(this, resolvedAssemblyIdentity, resolvedReference, index, resolutionDiagnostics, f_529_15918_15931(), assemblyReferencesBySimpleName, supersedeLowerVersions)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16015, 16272) || true) && (existingReference != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 16015, 16272);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16102, 16206);

                                        f_529_16102_16205(this, existingReference, resolvedReference, resolutionDiagnostics, ref lazyAliasMap);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16236, 16245);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 16015, 16272);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16300, 16349);

                                    f_529_16300_16348(
                                                            metadataReferencesBuilder, resolvedReference);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16377, 16493);

                                    var
                                    data = f_529_16388_16492(this, resolvedAssemblyMetadata, resolvedReference, importOptions)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16519, 16548);

                                    f_529_16519_16547(implicitAssemblies, data);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16576, 16665);

                                    var
                                    referenceBinding = f_529_16599_16664(data, explicitAssemblies, IdentityComparer)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16691, 16731);

                                    f_529_16691_16730(referenceBindings, referenceBinding);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 16757, 16872);

                                    referenceBindingsToProcess.Push((resolvedReference, f_529_16809_16869(referenceBinding)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 13359, 16895);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 3537);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 3537);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 13179, 16914);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 13179, 16914);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 13179, 16914);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17013, 17213);
                        foreach (var assemblyIdentity in f_529_17046_17064_I(resolutionFailures))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 17013, 17213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17106, 17194);

                            implicitReferenceResolutions = f_529_17137_17193(implicitReferenceResolutions, assemblyIdentity, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 17013, 17213);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 201);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 201);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17233, 17616) || true) && (f_529_17237_17261(implicitAssemblies) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 17233, 17616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17308, 17343);

                        f_529_17308_17342(lazyAliasMap == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17367, 17428);

                        resolvedReferences = ImmutableArray<ResolvedReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17450, 17511);

                        metadataReferences = ImmutableArray<MetadataReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17533, 17568);

                        allAssemblies = explicitAssemblies;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17590, 17597);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 17233, 17616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17810, 17874);

                    allAssemblies = explicitAssemblies.AddRange(implicitAssemblies);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17903, 17920);

                        for (int
        bindingsIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17894, 19147) || true) && (bindingsIndex < f_529_17938_17961(referenceBindings))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 17963, 17978)
        , bindingsIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 17894, 19147))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 17894, 19147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18020, 18076);

                            var
                            referenceBinding = f_529_18043_18075(referenceBindings, bindingsIndex)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18109, 18114);

                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18100, 19128) || true) && (i < f_529_18120_18143(referenceBinding))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18145, 18148)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 18100, 19128))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 18100, 19128);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18198, 18232);

                                    var
                                    binding = referenceBinding[i]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18459, 18572) || true) && (binding.IsBound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 18459, 18572);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18536, 18545);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 18459, 18572);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18781, 18831);

                                    f_529_18781_18830(binding.ReferenceIdentity is object);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 18857, 19105);

                                    referenceBinding[i] = f_529_18879_19104(binding.ReferenceIdentity, allAssemblies, explicitAssemblyCount, IdentityComparer);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 1029);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 1029);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 1254);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 1254);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19167, 19264);

                    f_529_19167_19263(referenceBindings, explicitAssemblyCount, implicitAssemblies);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19284, 19345);

                    metadataReferences = f_529_19305_19344(metadataReferencesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19363, 19470);

                    resolvedReferences = f_529_19384_19469(metadataReferences, lazyAliasMap, explicitAssemblyCount);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(529, 19499, 19727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19539, 19565);

                    f_529_19539_19564(implicitAssemblies);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19583, 19617);

                    f_529_19583_19616(referenceBindingsToProcess);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19635, 19668);

                    f_529_19635_19667(metadataReferencesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 19686, 19712);

                    f_529_19686_19711(resolutionFailures);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(529, 19499, 19727);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 10559, 19738);

                int
                f_529_11621_11693(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 11621, 11693);
                    return 0;
                }


                int
                f_529_11721_11744(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 11721, 11744);
                    return return_v;
                }


                int
                f_529_11708_11774(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 11708, 11774);
                    return 0;
                }


                int
                f_529_11789_11859(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 11789, 11859);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                f_529_12027_12067()
                {
                    var return_v = ArrayBuilder<AssemblyData>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 12027, 12067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_529_12210_12255()
                {
                    var return_v = PooledHashSet<AssemblyIdentity>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 12210, 12255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                f_529_12304_12349()
                {
                    var return_v = ArrayBuilder<MetadataReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 12304, 12349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                f_529_12598_12685()
                {
                    var return_v = ArrayBuilder<(MetadataReference, ArraySegment<AssemblyReferenceBinding>)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 12598, 12685);
                    return return_v;
                }


                int
                f_529_12829_13001(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                explicitModules, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                explicitReferences, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                explicitReferenceMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                referenceBindings, int
                totalReferencedAssemblyCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                result)
                {
                    this_param.GetInitialReferenceBindingsToProcess(explicitModules, explicitReferences, explicitReferenceMap, referenceBindings, totalReferencedAssemblyCount, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 12829, 13001);
                    return 0;
                }


                int
                f_529_13186_13218(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 13186, 13218);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)
                f_529_13302_13334(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                builder)
                {
                    var return_v = builder.Pop<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 13302, 13334);
                    return return_v;
                }


                int
                f_529_13706_13755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 13706, 13755);
                    return 0;
                }


                bool
                f_529_13787_14309(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                requestingReference, Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                implicitReferenceResolutions, Microsoft.CodeAnalysis.MetadataReferenceResolver
                resolver, Microsoft.CodeAnalysis.DiagnosticBag
                resolutionDiagnostics, out Microsoft.CodeAnalysis.AssemblyIdentity?
                resolvedAssemblyIdentity, out Microsoft.CodeAnalysis.AssemblyMetadata?
                resolvedAssemblyMetadata, out Microsoft.CodeAnalysis.PortableExecutableReference?
                resolvedReference)
                {
                    var return_v = this_param.TryResolveMissingReference(requestingReference, referenceIdentity, ref implicitReferenceResolutions, resolver, resolutionDiagnostics, out resolvedAssemblyIdentity, out resolvedAssemblyMetadata, out resolvedReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 13787, 14309);
                    return return_v;
                }


                bool
                f_529_14527_14576(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 14527, 14576);
                    return return_v;
                }


                bool
                f_529_14993_15045(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 14993, 15045);
                    return return_v;
                }


                int
                f_529_15744_15775(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 15744, 15775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_529_15918_15931()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 15918, 15931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference?
                f_529_15828_15988(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.PortableExecutableReference
                reference, int
                assemblyIndex, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                referencesBySimpleName, bool
                supersedeLowerVersions)
                {
                    var return_v = this_param.TryAddAssembly(identity, (Microsoft.CodeAnalysis.MetadataReference)reference, assemblyIndex, diagnostics, location, referencesBySimpleName, supersedeLowerVersions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 15828, 15988);
                    return return_v;
                }


                int
                f_529_16102_16205(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                primaryReference, Microsoft.CodeAnalysis.PortableExecutableReference
                newReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                lazyAliasMap)
                {
                    this_param.MergeReferenceProperties(primaryReference, (Microsoft.CodeAnalysis.MetadataReference)newReference, diagnostics, ref lazyAliasMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16102, 16205);
                    return 0;
                }


                int
                f_529_16300_16348(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.MetadataReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16300, 16348);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                f_529_16388_16492(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyMetadata
                assemblyMetadata, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions)
                {
                    var return_v = this_param.CreateAssemblyDataForResolvedMissingAssembly(assemblyMetadata, peReference, importOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16388, 16492);
                    return return_v;
                }


                int
                f_529_16519_16547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16519, 16547);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_16599_16664(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                assemblyIdentityComparer)
                {
                    var return_v = this_param.BindAssemblyReferences(assemblies, assemblyIdentityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16599, 16664);
                    return return_v;
                }


                int
                f_529_16691_16730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16691, 16730);
                    return 0;
                }


                System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                f_529_16809_16869(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                array)
                {
                    var return_v = new System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 16809, 16869);
                    return return_v;
                }


                System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                f_529_13383_13391_I(System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 13383, 13391);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                f_529_17137_17193(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, Microsoft.CodeAnalysis.PortableExecutableReference?
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 17137, 17193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                f_529_17046_17064_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 17046, 17064);
                    return return_v;
                }


                int
                f_529_17237_17261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 17237, 17261);
                    return return_v;
                }


                int
                f_529_17308_17342(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 17308, 17342);
                    return 0;
                }


                int
                f_529_17938_17961(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 17938, 17961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_18043_18075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 18043, 18075);
                    return return_v;
                }


                int
                f_529_18120_18143(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 18120, 18143);
                    return return_v;
                }


                int
                f_529_18781_18830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 18781, 18830);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_529_18879_19104(Microsoft.CodeAnalysis.AssemblyIdentity
                reference, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                definitions, int
                definitionStartIndex, Microsoft.CodeAnalysis.AssemblyIdentityComparer
                assemblyIdentityComparer)
                {
                    var return_v = ResolveReferencedAssembly(reference, definitions, definitionStartIndex, assemblyIdentityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 18879, 19104);
                    return return_v;
                }


                int
                f_529_19167_19263(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                referenceBindings, int
                explicitAssemblyCount, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                implicitAssemblies)
                {
                    UpdateBindingsOfAssemblyBeingBuilt(referenceBindings, explicitAssemblyCount, implicitAssemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19167, 19263);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_529_19305_19344(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19305, 19344);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                f_529_19384_19469(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                references, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                propertyMapOpt, int
                explicitAssemblyCount)
                {
                    var return_v = ToResolvedAssemblyReferences(references, propertyMapOpt, explicitAssemblyCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19384, 19469);
                    return return_v;
                }


                int
                f_529_19539_19564(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19539, 19564);
                    return 0;
                }


                int
                f_529_19583_19616(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19583, 19616);
                    return 0;
                }


                int
                f_529_19635_19667(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19635, 19667);
                    return 0;
                }


                int
                f_529_19686_19711(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.AssemblyIdentity>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 19686, 19711);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 10559, 19738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 10559, 19738);
            }
        }

        private void GetInitialReferenceBindingsToProcess(
                    ImmutableArray<PEModule> explicitModules,
                    ImmutableArray<MetadataReference> explicitReferences,
                    ImmutableArray<ResolvedReference> explicitReferenceMap,
                    ArrayBuilder<AssemblyReferenceBinding[]> referenceBindings,
                    int totalReferencedAssemblyCount,
                    [Out] ArrayBuilder<(MetadataReference, ArraySegment<AssemblyReferenceBinding>)> result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 19750, 22303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20237, 20269);

                f_529_20237_20268(f_529_20250_20262(result) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20347, 20451);

                var
                explicitModuleToReferenceMap = f_529_20382_20450(explicitModules, explicitReferenceMap)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20528, 20584);

                var
                bindingsOfAssemblyBeingBuilt = f_529_20563_20583(referenceBindings, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20598, 20646);

                int
                bindingIndex = totalReferencedAssemblyCount
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20669, 20684);
                    for (int
        moduleIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20660, 21230) || true) && (moduleIndex < explicitModules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20724, 20737)
        , moduleIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 20660, 21230))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 20660, 21230);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20771, 20855);

                        var
                        moduleReference = explicitReferences[explicitModuleToReferenceMap[moduleIndex]]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20873, 20956);

                        var
                        moduleBindingsCount = explicitModules[moduleIndex].ReferencedAssemblies.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 20976, 21159);

                        f_529_20976_21158(
                                        result, (moduleReference,
                        f_529_21049_21156(bindingsOfAssemblyBeingBuilt, bindingIndex, moduleBindingsCount)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21179, 21215);

                        bindingIndex += moduleBindingsCount;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21246, 21312);

                f_529_21246_21311(bindingIndex == f_529_21275_21310(bindingsOfAssemblyBeingBuilt));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21448, 21466);

                    // the first binding is for the assembly being built, all its references are bound or added above
                    for (int
        referenceIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21439, 22098) || true) && (referenceIndex < explicitReferenceMap.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21514, 21530)
        , referenceIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 21439, 22098))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 21439, 22098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21564, 21632);

                        var
                        explicitReferenceMapping = explicitReferenceMap[referenceIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21650, 21819) || true) && (explicitReferenceMapping.IsSkipped || (DynAbs.Tracing.TraceSender.Expression_False(529, 21654, 21749) || explicitReferenceMapping.Kind == MetadataImageKind.Module))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 21650, 21819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21791, 21800);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 21650, 21819);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 21891, 22083);

                        f_529_21891_22082(
                                        // +1 for the assembly being built
                                        result, (explicitReferences[referenceIndex],
                        f_529_21983_22080(f_529_22026_22079(referenceBindings, explicitReferenceMapping.Index + 1))));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22208, 22292);

                f_529_22208_22291(f_529_22221_22233(result) == explicitModules.Length + totalReferencedAssemblyCount);
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 19750, 22303);

                int
                f_529_20250_20262(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 20250, 20262);
                    return return_v;
                }


                int
                f_529_20237_20268(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 20237, 20268);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_529_20382_20450(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                modules, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                resolvedReferences)
                {
                    var return_v = CalculateModuleToReferenceMap(modules, resolvedReferences);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 20382, 20450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_20563_20583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 20563, 20583);
                    return return_v;
                }


                System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                f_529_21049_21156(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                array, int
                offset, int
                count)
                {
                    var return_v = new System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21049, 21156);
                    return return_v;
                }


                int
                f_529_20976_21158(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param, (Microsoft.CodeAnalysis.MetadataReference moduleReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 20976, 21158);
                    return 0;
                }


                int
                f_529_21275_21310(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 21275, 21310);
                    return return_v;
                }


                int
                f_529_21246_21311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21246, 21311);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_22026_22079(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 22026, 22079);
                    return return_v;
                }


                System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                f_529_21983_22080(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                array)
                {
                    var return_v = new System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21983, 22080);
                    return return_v;
                }


                int
                f_529_21891_22082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param, (Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21891, 22082);
                    return 0;
                }


                int
                f_529_22221_22233(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 22221, 22233);
                    return return_v;
                }


                int
                f_529_22208_22291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 22208, 22291);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 19750, 22303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 19750, 22303);
            }
        }

        private static ImmutableArray<int> CalculateModuleToReferenceMap(ImmutableArray<PEModule> modules, ImmutableArray<ResolvedReference> resolvedReferences)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 22315, 23142);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22492, 22597) || true) && (modules.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 22492, 22597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22549, 22582);

                    return ImmutableArray<int>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 22492, 22597);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22613, 22672);

                var
                result = f_529_22626_22671(modules.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22686, 22718);

                f_529_22686_22717(result, modules.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22743, 22748);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22734, 23080) || true) && (i < resolvedReferences.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22781, 22784)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 22734, 23080))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 22734, 23080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22818, 22864);

                        var
                        resolvedReference = resolvedReferences[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 22882, 23065) || true) && (f_529_22886_22914_M(!resolvedReference.IsSkipped) && (DynAbs.Tracing.TraceSender.Expression_True(529, 22886, 22968) && resolvedReference.Kind == MetadataImageKind.Module))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 22882, 23065);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23010, 23046);

                            result[resolvedReference.Index] = i;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 22882, 23065);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23096, 23131);

                return f_529_23103_23130(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 22315, 23142);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_529_22626_22671(int
                capacity)
                {
                    var return_v = ArrayBuilder<int>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 22626, 22671);
                    return return_v;
                }


                int
                f_529_22686_22717(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                count)
                {
                    this_param.ZeroInit(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 22686, 22717);
                    return 0;
                }


                bool
                f_529_22886_22914_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 22886, 22914);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_529_23103_23130(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23103, 23130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 22315, 23142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 22315, 23142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<ResolvedReference> ToResolvedAssemblyReferences(
                    ImmutableArray<MetadataReference> references,
                    Dictionary<MetadataReference, MergedAliases>? propertyMapOpt,
                    int explicitAssemblyCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 23154, 23868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23431, 23507);

                var
                result = f_529_23444_23506(references.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23530, 23535);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23521, 23806) || true) && (i < references.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23560, 23563)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 23521, 23806))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 23521, 23806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23645, 23791);

                        f_529_23645_23790(                // -1 for assembly being built
                                        result, f_529_23656_23789(references[i], explicitAssemblyCount - 1 + i, MetadataImageKind.Assembly, propertyMapOpt));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 23822, 23857);

                return f_529_23829_23856(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 23154, 23868);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                f_529_23444_23506(int
                capacity)
                {
                    var return_v = ArrayBuilder<ResolvedReference>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23444, 23506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                f_529_23656_23789(Microsoft.CodeAnalysis.MetadataReference
                reference, int
                index, Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                propertyMapOpt)
                {
                    var return_v = GetResolvedReferenceAndFreePropertyMapEntry(reference, index, kind, propertyMapOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23656, 23789);
                    return return_v;
                }


                int
                f_529_23645_23790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23645, 23790);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                f_529_23829_23856(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23829, 23856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 23154, 23868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 23154, 23868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void UpdateBindingsOfAssemblyBeingBuilt(ArrayBuilder<AssemblyReferenceBinding[]> referenceBindings, int explicitAssemblyCount, ArrayBuilder<AssemblyData> implicitAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 23880, 25332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24093, 24158);

                var
                referenceBindingsOfAssemblyBeingBuilt = f_529_24137_24157(referenceBindings, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24270, 24429);

                var
                bindingsOfAssemblyBeingBuilt = f_529_24305_24428(f_529_24356_24400(referenceBindingsOfAssemblyBeingBuilt) + f_529_24403_24427(implicitAssemblies))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24545, 24649);

                f_529_24545_24648(
                            // add bindings for explicitly specified assemblies (-1 for the assembly being built):
                            bindingsOfAssemblyBeingBuilt, referenceBindingsOfAssemblyBeingBuilt, explicitAssemblyCount - 1);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24739, 24744);

                    // add bindings for implicitly resolved assemblies:
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24730, 24950) || true) && (i < f_529_24750_24774(implicitAssemblies))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24776, 24779)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 24730, 24950))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 24730, 24950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 24813, 24935);

                        f_529_24813_24934(bindingsOfAssemblyBeingBuilt, f_529_24846_24933(f_529_24875_24905(f_529_24875_24896(implicitAssemblies, i)), explicitAssemblyCount + i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 221);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 25058, 25236);

                f_529_25058_25235(
                            // add bindings for assemblies referenced by modules added to the compilation:
                            bindingsOfAssemblyBeingBuilt, referenceBindingsOfAssemblyBeingBuilt, explicitAssemblyCount - 1, f_529_25162_25206(referenceBindingsOfAssemblyBeingBuilt) - explicitAssemblyCount + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 25252, 25321);

                referenceBindings[0] = f_529_25275_25320(bindingsOfAssemblyBeingBuilt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 23880, 25332);

                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_24137_24157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24137, 24157);
                    return return_v;
                }


                int
                f_529_24356_24400(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24356, 24400);
                    return return_v;
                }


                int
                f_529_24403_24427(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24403, 24427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                f_529_24305_24428(int
                capacity)
                {
                    var return_v = ArrayBuilder<AssemblyReferenceBinding>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24305, 24428);
                    return return_v;
                }


                int
                f_529_24545_24648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                items, int
                length)
                {
                    this_param.AddRange(items, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24545, 24648);
                    return 0;
                }


                int
                f_529_24750_24774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24750, 24774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                f_529_24875_24896(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24875, 24896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_529_24875_24905(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24875, 24905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                f_529_24846_24933(Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity, int
                definitionIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding(referenceIdentity, definitionIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24846, 24933);
                    return return_v;
                }


                int
                f_529_24813_24934(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24813, 24934);
                    return 0;
                }


                int
                f_529_25162_25206(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 25162, 25206);
                    return return_v;
                }


                int
                f_529_25058_25235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                items, int
                start, int
                length)
                {
                    this_param.AddRange(items, start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 25058, 25235);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_25275_25320(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 25275, 25320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 23880, 25332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 23880, 25332);
            }
        }

        /// <summary>
        /// Resolve <paramref name="referenceIdentity"/> using a given <paramref name="resolver"/>.
        /// 
        /// We make sure not to query the resolver for the same identity multiple times (across submissions).
        /// Doing so ensures that we don't create multiple assembly symbols within the same chain of script compilations 
        /// for the same implicitly resolved identity. Failure to do so results in cast errors like "can't convert T to T".
        /// 
        /// The method only records successful resolution results by updating <paramref name="implicitReferenceResolutions"/>.
        /// Failures are only recorded after all resolution attempts have been completed.
        /// 
        /// This approach addresses the following scenario. Consider a script:
        /// <code>
        ///   #r "dir1\a.dll"
        ///   #r "dir2\b.dll"
        /// </code>
        /// where both a.dll and b.dll reference x.dll, which is present only in dir2. Let's assume the resolver first 
        /// attempts to resolve "x" referenced from "dir1\a.dll". The resolver may fail to find the dependency if it only
        /// looks up the directory containing the referencing assembly (dir1). If we recorded and this failure immediately
        /// we would not call the resolver to resolve "x" within the context of "dir2\b.dll" (or any other referencing assembly). 
        /// 
        /// This behavior would ensure consistency and if the types from x.dll do leak thru to the script compilation, but it 
        /// would result in a missing assembly error. By recording the failure after all resolution attempts are complete
        /// we also achieve a consistent behavior but are able to bind the reference to "x.dll". Besides, this approach
        /// also avoids dependency on the order in which we evaluate the assembly references in the scenario above.
        /// In general, the result of the resolution may still depend on the order of #r - if there are different assemblies 
        /// of the same identity in different directories.
        /// </summary>
        private bool TryResolveMissingReference(
                    MetadataReference requestingReference,
                    AssemblyIdentity referenceIdentity,
                    ref ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> implicitReferenceResolutions,
                    MetadataReferenceResolver resolver,
                    DiagnosticBag resolutionDiagnostics,
                    [NotNullWhen(true)] out AssemblyIdentity? resolvedAssemblyIdentity,
                    [NotNullWhen(true)] out AssemblyMetadata? resolvedAssemblyMetadata,
                    [NotNullWhen(true)] out PortableExecutableReference? resolvedReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 27485, 29972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28112, 28144);

                resolvedAssemblyIdentity = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28158, 28190);

                resolvedAssemblyMetadata = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28204, 28242);

                bool
                isNewlyResolvedReference = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28564, 28842) || true) && (!f_529_28569_28651(implicitReferenceResolutions, referenceIdentity, out resolvedReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 28564, 28842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28685, 28777);

                    resolvedReference = f_529_28705_28776(resolver, requestingReference, referenceIdentity);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28795, 28827);

                    isNewlyResolvedReference = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 28564, 28842);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28858, 28949) || true) && (resolvedReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 28858, 28949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28921, 28934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 28858, 28949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 28965, 29054);

                resolvedAssemblyMetadata = f_529_28992_29053(this, resolvedReference, resolutionDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29068, 29166) || true) && (resolvedAssemblyMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 29068, 29166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29138, 29151);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 29068, 29166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29182, 29244);

                var
                resolvedAssembly = f_529_29205_29243(resolvedAssemblyMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29258, 29299);

                f_529_29258_29298(resolvedAssembly is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29510, 29750) || true) && (isNewlyResolvedReference && (DynAbs.Tracing.TraceSender.Expression_True(529, 29514, 29688) && f_529_29559_29629(IdentityComparer, referenceIdentity, f_529_29603_29628(resolvedAssembly)) == AssemblyIdentityComparer.ComparisonResult.NotEquivalent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 29510, 29750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29722, 29735);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 29510, 29750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29766, 29819);

                resolvedAssemblyIdentity = f_529_29793_29818(resolvedAssembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29833, 29935);

                implicitReferenceResolutions = f_529_29864_29934(implicitReferenceResolutions, referenceIdentity, resolvedReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 29949, 29961);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 27485, 29972);

                bool
                f_529_28569_28651(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, out Microsoft.CodeAnalysis.PortableExecutableReference?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 28569, 28651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference?
                f_529_28705_28776(Microsoft.CodeAnalysis.MetadataReferenceResolver
                this_param, Microsoft.CodeAnalysis.MetadataReference
                definition, Microsoft.CodeAnalysis.AssemblyIdentity
                referenceIdentity)
                {
                    var return_v = this_param.ResolveMissingAssembly(definition, referenceIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 28705, 28776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata?
                f_529_28992_29053(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAssemblyMetadata(peReference, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 28992, 29053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly?
                f_529_29205_29243(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 29205, 29243);
                    return return_v;
                }


                int
                f_529_29258_29298(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 29258, 29298);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_529_29603_29628(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 29603, 29628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_529_29559_29629(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.Compare(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 29559, 29629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_529_29793_29818(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 29793, 29818);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                f_529_29864_29934(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.PortableExecutableReference?>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, Microsoft.CodeAnalysis.PortableExecutableReference
                value)
                {
                    var return_v = this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 29864, 29934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 27485, 29972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 27485, 29972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AssemblyData CreateAssemblyDataForResolvedMissingAssembly(
                    AssemblyMetadata assemblyMetadata,
                    PortableExecutableReference peReference,
                    MetadataImportOptions importOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 29984, 30635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30227, 30273);

                var
                assembly = f_529_30242_30272(assemblyMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30287, 30320);

                f_529_30287_30319(assembly is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30334, 30624);

                return f_529_30341_30623(this, assembly, assemblyMetadata.CachedSymbols, f_529_30461_30494(peReference), SimpleAssemblyName, importOptions, peReference.Properties.EmbedInteropTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 29984, 30635);

                Microsoft.CodeAnalysis.PEAssembly?
                f_529_30242_30272(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 30242, 30272);
                    return return_v;
                }


                int
                f_529_30287_30319(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 30287, 30319);
                    return 0;
                }


                Microsoft.CodeAnalysis.DocumentationProvider
                f_529_30461_30494(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.DocumentationProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 30461, 30494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                f_529_30341_30623(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PEAssembly
                assembly, Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                cachedSymbols, Microsoft.CodeAnalysis.DocumentationProvider
                documentationProvider, string
                sourceAssemblySimpleName, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions, bool
                embedInteropTypes)
                {
                    var return_v = this_param.CreateAssemblyDataForFile(assembly, cachedSymbols, documentationProvider, sourceAssemblySimpleName, importOptions, embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 30341, 30623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 29984, 30635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 29984, 30635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReuseAssemblySymbolsWithNoPiaLocalTypes(BoundInputAssembly[] boundInputs, TAssemblySymbol[] candidateInputAssemblySymbols, ImmutableArray<AssemblyData> assemblies, int corLibraryIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 30647, 37095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30869, 30909);

                int
                totalAssemblies = assemblies.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30932, 30937);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30923, 37055) || true) && (i < totalAssemblies)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30960, 30963)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 30923, 37055))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 30923, 37055);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 30997, 31109) || true) && (f_529_31001_31039_M(!assemblies[i].ContainsNoPiaLocalTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 30997, 31109);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31081, 31090);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 30997, 31109);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31129, 36536);
                            foreach (TAssemblySymbol candidateAssembly in f_529_31175_31205_I(f_529_31175_31205(assemblies[i])))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 31129, 36536);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31589, 31728) || true) && (f_529_31593_31620(this, candidateAssembly) != f_529_31624_31646(assemblies[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 31589, 31728);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31696, 31705);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 31589, 31728);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31752, 31855);

                                ImmutableArray<TAssemblySymbol>
                                resolutionAssemblies = f_529_31807_31854(this, candidateAssembly)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31879, 31995) || true) && (resolutionAssemblies.IsDefault)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 31879, 31995);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 31963, 31972);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 31879, 31995);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32019, 32103);

                                f_529_32019_32102(candidateInputAssemblySymbols, 0, f_529_32065_32101(candidateInputAssemblySymbols));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32539, 32557);

                                bool
                                match = true
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32581, 33618);
                                    foreach (TAssemblySymbol assembly in f_529_32618_32638_I(resolutionAssemblies))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 32581, 33618);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32688, 32702);

                                        match = false;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32739, 32744);

                                            for (int
                    j = 1
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32730, 33407) || true) && (j < totalAssemblies)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32767, 32770)
                    , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 32730, 33407))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 32730, 33407);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 32828, 33380) || true) && (f_529_32832_32874(assemblies[j], assembly) && (DynAbs.Tracing.TraceSender.Expression_True(529, 32832, 32955) && f_529_32911_32929(this, assembly) == f_529_32933_32955(assemblies[j])))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 32828, 33380);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33021, 33065);

                                                    candidateInputAssemblySymbols[j] = assembly;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33099, 33112);

                                                    match = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 32828, 33380);
                                                }
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 678);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 678);
                                        }
                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33435, 33595) || true) && (!match)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 33435, 33595);
                                            DynAbs.Tracing.TraceSender.TraceBreak(529, 33562, 33568);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 33435, 33595);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 32581, 33618);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 1038);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 1038);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33642, 33734) || true) && (!match)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 33642, 33734);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33702, 33711);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 33642, 33734);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33767, 33772);

                                    for (int
                j = 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33758, 36042) || true) && (j < totalAssemblies)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33795, 33798)
                , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 33758, 36042))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 33758, 36042);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 33848, 36019) || true) && (candidateInputAssemblySymbols[j] == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 33848, 36019);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 34009, 34023);

                                            match = false;
                                            DynAbs.Tracing.TraceSender.TraceBreak(529, 34053, 34059);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 33848, 36019);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 33848, 36019);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 34371, 35992) || true) && (corLibraryIndex < 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 34371, 35992);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 34523, 35037) || true) && (f_529_34527_34574(this, candidateInputAssemblySymbols[j]) != null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 34523, 35037);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 34836, 34906);

                                                    f_529_34836_34905(f_529_34849_34896(this, candidateInputAssemblySymbols[j]) == null);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 34944, 34958);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 34996, 35002);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 34523, 35037);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 34371, 35992);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 34371, 35992);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 35278, 35313);

                                                f_529_35278_35312(corLibraryIndex != 0);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 35452, 35961) || true) && (!f_529_35457_35569(candidateInputAssemblySymbols[corLibraryIndex], f_529_35521_35568(this, candidateInputAssemblySymbols[j])))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 35452, 35961);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 35761, 35830);

                                                    f_529_35761_35829(candidateInputAssemblySymbols[corLibraryIndex] == null);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 35868, 35882);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 35920, 35926);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 35452, 35961);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 34371, 35992);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 33848, 36019);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 2285);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 2285);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36066, 36517) || true) && (match)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 36066, 36517);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36188, 36193);
                                        // We found a match, use it.
                                        for (int
                j = 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36179, 36454) || true) && (j < totalAssemblies)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36216, 36219)
                , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 36179, 36454))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 36179, 36454);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36277, 36332);

                                            f_529_36277_36331(candidateInputAssemblySymbols[j] != null);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36362, 36427);

                                            boundInputs[j].AssemblySymbol = candidateInputAssemblySymbols[j];
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 276);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 276);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36482, 36494);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 36066, 36517);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 31129, 36536);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 5408);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 5408);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 36630, 36714);

                        f_529_36630_36713(candidateInputAssemblySymbols, 0, f_529_36676_36712(candidateInputAssemblySymbols));
                        DynAbs.Tracing.TraceSender.TraceBreak(529, 37034, 37040);

                        break;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 6133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 6133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37071, 37084);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 30647, 37095);

                bool
                f_529_31001_31039_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 31001, 31039);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TAssemblySymbol>
                f_529_31175_31205(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.AvailableSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 31175, 31205);
                    return return_v;
                }


                bool
                f_529_31593_31620(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.IsLinked(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 31593, 31620);
                    return return_v;
                }


                bool
                f_529_31624_31646(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 31624, 31646);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TAssemblySymbol>
                f_529_31807_31854(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetNoPiaResolutionAssemblies(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 31807, 31854);
                    return return_v;
                }


                int
                f_529_32065_32101(TAssemblySymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 32065, 32101);
                    return return_v;
                }


                int
                f_529_32019_32102(TAssemblySymbol[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 32019, 32102);
                    return 0;
                }


                bool
                f_529_32832_32874(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param, TAssemblySymbol
                assembly)
                {
                    var return_v = this_param.IsMatchingAssembly(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 32832, 32874);
                    return return_v;
                }


                bool
                f_529_32911_32929(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.IsLinked(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 32911, 32929);
                    return return_v;
                }


                bool
                f_529_32933_32955(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 32933, 32955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TAssemblySymbol>
                f_529_32618_32638_I(System.Collections.Immutable.ImmutableArray<TAssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 32618, 32638);
                    return return_v;
                }


                TAssemblySymbol?
                f_529_34527_34574(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetCorLibrary(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 34527, 34574);
                    return return_v;
                }


                TAssemblySymbol?
                f_529_34849_34896(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetCorLibrary(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 34849, 34896);
                    return return_v;
                }


                int
                f_529_34836_34905(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 34836, 34905);
                    return 0;
                }


                int
                f_529_35278_35312(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 35278, 35312);
                    return 0;
                }


                TAssemblySymbol?
                f_529_35521_35568(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetCorLibrary(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 35521, 35568);
                    return return_v;
                }


                bool
                f_529_35457_35569(TAssemblySymbol
                objA, TAssemblySymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 35457, 35569);
                    return return_v;
                }


                int
                f_529_35761_35829(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 35761, 35829);
                    return 0;
                }


                int
                f_529_36277_36331(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 36277, 36331);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<TAssemblySymbol>
                f_529_31175_31205_I(System.Collections.Generic.IEnumerable<TAssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 31175, 31205);
                    return return_v;
                }


                int
                f_529_36676_36712(TAssemblySymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 36676, 36712);
                    return return_v;
                }


                int
                f_529_36630_36713(TAssemblySymbol[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 36630, 36713);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 30647, 37095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 30647, 37095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReuseAssemblySymbols(BoundInputAssembly[] boundInputs, TAssemblySymbol[] candidateInputAssemblySymbols, ImmutableArray<AssemblyData> assemblies, int corLibraryIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(529, 37107, 50284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37381, 37477);

                Queue<AssemblyReferenceCandidate>
                candidatesToExamine = f_529_37437_37476()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37491, 37531);

                int
                totalAssemblies = assemblies.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37711, 37796);

                List<TAssemblySymbol?>
                candidateReferencedSymbols = f_529_37763_37795<TAssemblySymbol?>(1024)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37821, 37826);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37812, 50273) || true) && (i < totalAssemblies)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37849, 37852)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 37812, 50273))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 37812, 50273);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 37936, 38088) || true) && (boundInputs[i].AssemblySymbol != null || (DynAbs.Tracing.TraceSender.Expression_False(529, 37940, 38018) || f_529_37981_38018(assemblies[i])))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 37936, 38088);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 38060, 38069);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 37936, 38088);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 38108, 50258);
                            foreach (TAssemblySymbol candidateAssembly in f_529_38154_38184_I(f_529_38154_38184(assemblies[i])))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 38108, 50258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 38226, 38244);

                                bool
                                match = true
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 38862, 38946);

                                f_529_38862_38945(candidateInputAssemblySymbols, 0, f_529_38908_38944(candidateInputAssemblySymbols));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39164, 39192);

                                f_529_39164_39191(
                                                    // Symbols and index of the corresponding assembly to match against are accumulated in the
                                                    // candidatesToExamine queue. They are examined one by one. 
                                                    candidatesToExamine);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39366, 39448);

                                f_529_39366_39447(
                                                    // This is a queue of symbols that we are picking up as a result of using
                                                    // symbols from candidateAssembly
                                                    candidatesToExamine, f_529_39394_39446(i, candidateAssembly));
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39472, 49486) || true) && (match && (DynAbs.Tracing.TraceSender.Expression_True(529, 39479, 39517) && f_529_39488_39513(candidatesToExamine) > 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 39472, 49486);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39567, 39636);

                                        AssemblyReferenceCandidate
                                        candidate = f_529_39606_39635(candidatesToExamine)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39664, 39709);

                                        f_529_39664_39708(candidate.DefinitionIndex >= 0);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39735, 39784);

                                        f_529_39735_39783(candidate.AssemblySymbol is object);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39812, 39859);

                                        int
                                        candidateIndex = candidate.DefinitionIndex
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 39978, 40147);

                                        f_529_39978_40146(boundInputs[candidateIndex].AssemblySymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(529, 39991, 40145) || candidateInputAssemblySymbols[candidateIndex] == null));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40175, 40251);

                                        TAssemblySymbol?
                                        inputAssembly = boundInputs[candidateIndex].AssemblySymbol
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40277, 40449) || true) && (inputAssembly == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 40277, 40449);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40360, 40422);

                                            inputAssembly = candidateInputAssemblySymbols[candidateIndex];
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 40277, 40449);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40477, 41155) || true) && (inputAssembly != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 40477, 41155);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40560, 40901) || true) && (f_529_40564_40627(inputAssembly, candidate.AssemblySymbol))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 40560, 40901);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 40797, 40806);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 40560, 40901);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 41021, 41035);

                                            match = false;
                                            DynAbs.Tracing.TraceSender.TraceBreak(529, 41065, 41071);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 40477, 41155);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 41541, 41810) || true) && (f_529_41545_41579(this, candidate.AssemblySymbol) != f_529_41583_41618(assemblies[candidateIndex]))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 41541, 41810);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 41676, 41690);

                                            match = false;
                                            DynAbs.Tracing.TraceSender.TraceBreak(529, 41720, 41726);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 41541, 41810);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 41912, 41980);

                                        f_529_41912_41979(candidateInputAssemblySymbols[candidateIndex] == null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42006, 42079);

                                        candidateInputAssemblySymbols[candidateIndex] = candidate.AssemblySymbol;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42266, 42343);

                                        var
                                        candidateReferenceBinding = boundInputs[candidateIndex].ReferenceBinding
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42486, 42521);

                                        f_529_42486_42520(
                                                                // get the AssemblySymbols the candidate symbol refers to into candidateReferencedSymbols
                                                                candidateReferencedSymbols);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42547, 42632);

                                        f_529_42547_42631(candidate.AssemblySymbol, candidateReferencedSymbols);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42660, 42710);

                                        f_529_42660_42709(candidateReferenceBinding is object);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42736, 42819);

                                        f_529_42736_42818(f_529_42749_42781(candidateReferenceBinding) == f_529_42785_42817<TAssemblySymbol?>(candidateReferencedSymbols));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42845, 42900);

                                        int
                                        referencesCount = f_529_42867_42899<TAssemblySymbol?>(candidateReferencedSymbols)
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42937, 42942);

                                            for (int
                    k = 0
                    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42928, 46870) || true) && (k < referencesCount)
                    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 42965, 42968)
                    , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 42928, 46870))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 42928, 46870);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 43706, 44430) || true) && (f_529_43710_43747_M(!candidateReferenceBinding[k].IsBound))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 43706, 44430);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 43813, 44318) || true) && (f_529_43817_43846<TAssemblySymbol?>(candidateReferencedSymbols, k) != null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 43813, 44318);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44194, 44208);

                                                        match = false;
                                                        DynAbs.Tracing.TraceSender.TraceBreak(529, 44246, 44252);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 43813, 44318);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44354, 44363);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 43706, 44430);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44570, 44639);

                                                var
                                                currentCandidateReferencedSymbol = f_529_44609_44638<TAssemblySymbol?>(candidateReferencedSymbols, k)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44669, 44950) || true) && (currentCandidateReferencedSymbol == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 44669, 44950);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44834, 44848);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 44882, 44888);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 44669, 44950);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 44982, 45049);

                                                int
                                                definitionIndex = candidateReferenceBinding[k].DefinitionIndex
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 45079, 45359) || true) && (definitionIndex == 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 45079, 45359);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 45274, 45288);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 45322, 45328);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 45079, 45359);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 45476, 45806) || true) && (!f_529_45481_45561(assemblies[definitionIndex], currentCandidateReferencedSymbol))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 45476, 45806);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 45690, 45704);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 45738, 45744);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 45476, 45806);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 45838, 46224) || true) && (f_529_45842_45893(assemblies[definitionIndex]))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 45838, 46224);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 46108, 46122);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 46156, 46162);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 45838, 46224);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 46256, 46593) || true) && (f_529_46260_46302(this, currentCandidateReferencedSymbol) != f_529_46306_46342(assemblies[definitionIndex]))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 46256, 46593);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 46477, 46491);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 46525, 46531);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 46256, 46593);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 46732, 46843);

                                                f_529_46732_46842(
                                                                            // Add this reference to the queue so that we consider it as a candidate too 
                                                                            candidatesToExamine, f_529_46760_46841(definitionIndex, currentCandidateReferencedSymbol));
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 3943);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 3943);
                                        }
                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47039, 49463) || true) && (match)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 47039, 49463);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47106, 47185);

                                            TAssemblySymbol?
                                            candidateCorLibrary = f_529_47145_47184(this, candidate.AssemblySymbol)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47217, 49436) || true) && (candidateCorLibrary == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 47217, 49436);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47444, 47666) || true) && (corLibraryIndex >= 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 47444, 47666);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47542, 47556);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 47594, 47600);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 47444, 47666);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 47217, 49436);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 47217, 49436);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47907, 47942);

                                                f_529_47907_47941(corLibraryIndex != 0);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 47978, 48065);

                                                f_529_47978_48064(f_529_47991_48063(candidateCorLibrary, f_529_48028_48062(this, candidateCorLibrary)));

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 48188, 48409) || true) && (corLibraryIndex < 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 48188, 48409);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 48285, 48299);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 48337, 48343);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 48188, 48409);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 48548, 48885) || true) && (!f_529_48553_48620(assemblies[corLibraryIndex], candidateCorLibrary))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 48548, 48885);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 48761, 48775);

                                                    match = false;
                                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 48813, 48819);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 48548, 48885);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 48921, 48988);

                                                f_529_48921_48987(f_529_48934_48986_M(!assemblies[corLibraryIndex].ContainsNoPiaLocalTypes));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49022, 49074);

                                                f_529_49022_49073(f_529_49035_49072_M(!assemblies[corLibraryIndex].IsLinked));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49108, 49153);

                                                f_529_49108_49152(!f_529_49122_49151(this, candidateCorLibrary));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49307, 49405);

                                                f_529_49307_49404(
                                                                                // Add the candidate COR library to the queue so that we consider it as a candidate.
                                                                                candidatesToExamine, f_529_49335_49403(corLibraryIndex, candidateCorLibrary));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 47217, 49436);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 47039, 49463);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 39472, 49486);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 39472, 49486);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 39472, 49486);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49510, 50239) || true) && (match)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 49510, 50239);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49643, 49648);
                                        // Merge the set of symbols into result
                                        for (int
                k = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49634, 50051) || true) && (k < totalAssemblies)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49671, 49674)
                , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 49634, 50051))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 49634, 50051);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49732, 50024) || true) && (candidateInputAssemblySymbols[k] != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 49732, 50024);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49842, 49894);

                                                f_529_49842_49893(boundInputs[k].AssemblySymbol == null);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 49928, 49993);

                                                boundInputs[k].AssemblySymbol = candidateInputAssemblySymbols[k];
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 49732, 50024);
                                            }
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 418);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 418);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(529, 50160, 50166);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 49510, 50239);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 38108, 50258);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 12151);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 12151);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 12462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 12462);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(529, 37107, 50284);

                System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                f_529_37437_37476()
                {
                    var return_v = new System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 37437, 37476);
                    return return_v;
                }


                System.Collections.Generic.List<TAssemblySymbol?>
                f_529_37763_37795<TAssemblySymbol>(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<TAssemblySymbol?>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 37763, 37795);
                    return return_v;
                }


                bool
                f_529_37981_38018(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 37981, 38018);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<TAssemblySymbol>
                f_529_38154_38184(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.AvailableSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 38154, 38184);
                    return return_v;
                }


                int
                f_529_38908_38944(TAssemblySymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 38908, 38944);
                    return return_v;
                }


                int
                f_529_38862_38945(TAssemblySymbol[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 38862, 38945);
                    return 0;
                }


                int
                f_529_39164_39191(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39164, 39191);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                f_529_39394_39446(int
                definitionIndex, TAssemblySymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate(definitionIndex, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39394, 39446);
                    return return_v;
                }


                int
                f_529_39366_39447(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39366, 39447);
                    return 0;
                }


                int
                f_529_39488_39513(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 39488, 39513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                f_529_39606_39635(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param)
                {
                    var return_v = this_param.Dequeue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39606, 39635);
                    return return_v;
                }


                int
                f_529_39664_39708(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39664, 39708);
                    return 0;
                }


                int
                f_529_39735_39783(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39735, 39783);
                    return 0;
                }


                int
                f_529_39978_40146(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 39978, 40146);
                    return 0;
                }


                bool
                f_529_40564_40627(TAssemblySymbol
                objA, TAssemblySymbol
                objB)
                {
                    var return_v = Object.ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 40564, 40627);
                    return return_v;
                }


                bool
                f_529_41545_41579(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.IsLinked(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 41545, 41579);
                    return return_v;
                }


                bool
                f_529_41583_41618(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 41583, 41618);
                    return return_v;
                }


                int
                f_529_41912_41979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 41912, 41979);
                    return 0;
                }


                int
                f_529_42486_42520<TAssemblySymbol>(System.Collections.Generic.List<TAssemblySymbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 42486, 42520);
                    return 0;
                }


                int
                f_529_42547_42631(TAssemblySymbol
                assemblySymbol, System.Collections.Generic.List<TAssemblySymbol>
                referencedAssemblySymbols)
                {
                    GetActualBoundReferencesUsedBy(assemblySymbol, referencedAssemblySymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 42547, 42631);
                    return 0;
                }


                int
                f_529_42660_42709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 42660, 42709);
                    return 0;
                }


                int
                f_529_42749_42781(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 42749, 42781);
                    return return_v;
                }


                int
                f_529_42785_42817<TAssemblySymbol>(System.Collections.Generic.List<TAssemblySymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 42785, 42817);
                    return return_v;
                }


                int
                f_529_42736_42818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 42736, 42818);
                    return 0;
                }


                int
                f_529_42867_42899<TAssemblySymbol>(System.Collections.Generic.List<TAssemblySymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 42867, 42899);
                    return return_v;
                }


                bool
                f_529_43710_43747_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 43710, 43747);
                    return return_v;
                }


                TAssemblySymbol?
                f_529_43817_43846<TAssemblySymbol>(System.Collections.Generic.List<TAssemblySymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 43817, 43846);
                    return return_v;
                }


                TAssemblySymbol?
                f_529_44609_44638<TAssemblySymbol>(System.Collections.Generic.List<TAssemblySymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 44609, 44638);
                    return return_v;
                }


                bool
                f_529_45481_45561(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param, TAssemblySymbol
                assembly)
                {
                    var return_v = this_param.IsMatchingAssembly(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 45481, 45561);
                    return return_v;
                }


                bool
                f_529_45842_45893(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 45842, 45893);
                    return return_v;
                }


                bool
                f_529_46260_46302(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.IsLinked(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 46260, 46302);
                    return return_v;
                }


                bool
                f_529_46306_46342(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 46306, 46342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                f_529_46760_46841(int
                definitionIndex, TAssemblySymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate(definitionIndex, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 46760, 46841);
                    return return_v;
                }


                int
                f_529_46732_46842(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 46732, 46842);
                    return 0;
                }


                TAssemblySymbol?
                f_529_47145_47184(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetCorLibrary(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 47145, 47184);
                    return return_v;
                }


                int
                f_529_47907_47941(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 47907, 47941);
                    return 0;
                }


                TAssemblySymbol?
                f_529_48028_48062(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.GetCorLibrary(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 48028, 48062);
                    return return_v;
                }


                bool
                f_529_47991_48063(TAssemblySymbol
                objA, TAssemblySymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 47991, 48063);
                    return return_v;
                }


                int
                f_529_47978_48064(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 47978, 48064);
                    return 0;
                }


                bool
                f_529_48553_48620(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param, TAssemblySymbol
                assembly)
                {
                    var return_v = this_param.IsMatchingAssembly(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 48553, 48620);
                    return return_v;
                }


                bool
                f_529_48934_48986_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 48934, 48986);
                    return return_v;
                }


                int
                f_529_48921_48987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 48921, 48987);
                    return 0;
                }


                bool
                f_529_49035_49072_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 49035, 49072);
                    return return_v;
                }


                int
                f_529_49022_49073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49022, 49073);
                    return 0;
                }


                bool
                f_529_49122_49151(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TAssemblySymbol
                candidateAssembly)
                {
                    var return_v = this_param.IsLinked(candidateAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49122, 49151);
                    return return_v;
                }


                int
                f_529_49108_49152(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49108, 49152);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                f_529_49335_49403(int
                definitionIndex, TAssemblySymbol
                symbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate(definitionIndex, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49335, 49403);
                    return return_v;
                }


                int
                f_529_49307_49404(System.Collections.Generic.Queue<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceCandidate
                item)
                {
                    this_param.Enqueue(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49307, 49404);
                    return 0;
                }


                int
                f_529_49842_49893(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 49842, 49893);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<TAssemblySymbol>
                f_529_38154_38184_I(System.Collections.Generic.IEnumerable<TAssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 38154, 38184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 37107, 50284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 37107, 50284);
            }
        }

        private static bool CheckCircularReference(IReadOnlyList<AssemblyReferenceBinding[]> referenceBindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 50296, 50805);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50433, 50438);
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50424, 50765) || true) && (i < f_529_50444_50467(referenceBindings))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50469, 50472)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 50424, 50765))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 50424, 50765);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50506, 50750);
                            foreach (AssemblyReferenceBinding index in f_529_50549_50569_I(f_529_50549_50569(referenceBindings, i)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 50506, 50750);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50611, 50731) || true) && (index.BoundToAssemblyBeingBuilt)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 50611, 50731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50696, 50708);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 50611, 50731);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 50506, 50750);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 245);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 245);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50781, 50794);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 50296, 50805);

                int
                f_529_50444_50467(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 50444, 50467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_50549_50569(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 50549, 50569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_529_50549_50569_I(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 50549, 50569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 50296, 50805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 50296, 50805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSuperseded(AssemblyIdentity identity, IReadOnlyDictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 50817, 51184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 50995, 51056);

                var
                value = f_529_51007_51055(f_529_51007_51052(assemblyReferencesBySimpleName, f_529_51038_51051(identity)), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51070, 51109);

                f_529_51070_51108(value.Identity is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51123, 51173);

                return f_529_51130_51152(value.Identity) != f_529_51156_51172(identity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 50817, 51184);

                string
                f_529_51038_51051(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51038, 51051);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                f_529_51007_51052(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51007, 51052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                f_529_51007_51055(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51007, 51055);
                    return return_v;
                }


                int
                f_529_51070_51108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 51070, 51108);
                    return 0;
                }


                System.Version
                f_529_51130_51152(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51130, 51152);
                    return return_v;
                }


                System.Version
                f_529_51156_51172(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51156, 51172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 50817, 51184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 50817, 51184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int IndexOfCorLibrary(ImmutableArray<AssemblyData> assemblies, IReadOnlyDictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName, bool supersedeLowerVersions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 51196, 54204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51482, 51529);

                ArrayBuilder<int>?
                corLibraryCandidates = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51554, 51559);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51545, 52998) || true) && (i < assemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51584, 51587)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(529, 51545, 52998))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 51545, 52998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 51621, 51650);

                        var
                        assembly = assemblies[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 52103, 52983) || true) && (f_529_52107_52125_M(!assembly.IsLinked) && (DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52189) && assembly.AssemblyReferences.Length == 0) && (DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52247) && f_529_52214_52247_M(!assembly.ContainsNoPiaLocalTypes)) && (DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52365) && (!supersedeLowerVersions || (DynAbs.Tracing.TraceSender.Expression_False(529, 52273, 52364) || !f_529_52301_52364(f_529_52314_52331(assembly), assemblyReferencesBySimpleName)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 52103, 52983);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 52569, 52964) || true) && (f_529_52573_52604(assembly))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 52569, 52964);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 52654, 52826) || true) && (corLibraryCandidates == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 52654, 52826);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 52744, 52799);

                                    corLibraryCandidates = f_529_52767_52798();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 52654, 52826);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 52913, 52941);

                                f_529_52913_52940(
                                                        // This could be the COR library.
                                                        corLibraryCandidates, i);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(529, 52569, 52964);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(529, 52103, 52983);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(529, 1, 1454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(529, 1, 1454);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53178, 53879) || true) && (corLibraryCandidates != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 53178, 53879);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53244, 53864) || true) && (f_529_53248_53274(corLibraryCandidates) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 53244, 53864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53426, 53463);

                        int
                        result = f_529_53439_53462(corLibraryCandidates, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53485, 53513);

                        f_529_53485_53512(corLibraryCandidates);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53535, 53549);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 53244, 53864);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 53244, 53864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 53817, 53845);

                        f_529_53817_53844(                    // TODO: C# seems to pick the first one (but produces warnings when looking up predefined types).
                                                              // See PredefinedTypes::Init(ErrorHandling*).
                                            corLibraryCandidates);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(529, 53244, 53864);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 53178, 53879);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 54035, 54167) || true) && (assemblies.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(529, 54039, 54109) && assemblies[0].AssemblyReferences.Length == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(529, 54035, 54167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 54143, 54152);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(529, 54035, 54167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 54183, 54193);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 51196, 54204);

                bool
                f_529_52107_52125_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 52107, 52125);
                    return return_v;
                }


                bool
                f_529_52214_52247_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 52214, 52247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_529_52314_52331(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 52314, 52331);
                    return return_v;
                }


                bool
                f_529_52301_52364(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                assemblyReferencesBySimpleName)
                {
                    var return_v = IsSuperseded(identity, assemblyReferencesBySimpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 52301, 52364);
                    return return_v;
                }


                bool
                f_529_52573_52604(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                this_param)
                {
                    var return_v = this_param.DeclaresTheObjectClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 52573, 52604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_529_52767_52798()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 52767, 52798);
                    return return_v;
                }


                int
                f_529_52913_52940(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 52913, 52940);
                    return 0;
                }


                int
                f_529_53248_53274(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 53248, 53274);
                    return return_v;
                }


                int
                f_529_53439_53462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 53439, 53462);
                    return return_v;
                }


                int
                f_529_53485_53512(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 53485, 53512);
                    return 0;
                }


                int
                f_529_53817_53844(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 53817, 53844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 51196, 54204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 51196, 54204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool InternalsMayBeVisibleToAssemblyBeingCompiled(string compilationName, PEAssembly assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529, 54552, 54774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(529, 54687, 54763);

                return !f_529_54695_54762(f_529_54695_54752(assembly, compilationName));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529, 54552, 54774);

                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_529_54695_54752(Microsoft.CodeAnalysis.PEAssembly
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 54695, 54752);
                    return return_v;
                }


                bool
                f_529_54695_54762(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                source)
                {
                    var return_v = source.IsEmpty<System.Collections.Immutable.ImmutableArray<byte>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 54695, 54762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529, 54552, 54774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529, 54552, 54774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract void GetActualBoundReferencesUsedBy(TAssemblySymbol assemblySymbol, List<TAssemblySymbol?> referencedAssemblySymbols);

        protected abstract ImmutableArray<TAssemblySymbol> GetNoPiaResolutionAssemblies(TAssemblySymbol candidateAssembly);

        protected abstract bool IsLinked(TAssemblySymbol candidateAssembly);

        protected abstract TAssemblySymbol? GetCorLibrary(TAssemblySymbol candidateAssembly);
    }
}
