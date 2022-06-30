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
            Debug.Assert(explicitAssemblies[0] is AssemblyDataForAssemblyBeingBuilt);
            Debug.Assert(explicitReferences.Length == explicitReferenceMap.Length);

            var referenceBindings = ArrayBuilder<AssemblyReferenceBinding[]>.GetInstance();
            try
            {
                // Based on assembly identity, for each assembly, 
                // bind its references against the other assemblies we have.
                for (int i = 0; i < explicitAssemblies.Length; i++)
                {
                    referenceBindings.Add(explicitAssemblies[i].BindAssemblyReferences(explicitAssemblies, IdentityComparer));
                }

                if (resolverOpt?.ResolveMissingAssemblies == true)
                {
                    ResolveAndBindMissingAssemblies(
                        compilation,
                        explicitAssemblies,
                        explicitModules,
                        explicitReferences,
                        explicitReferenceMap,
                        resolverOpt,
                        importOptions,
                        supersedeLowerVersions,
                        referenceBindings,
                        assemblyReferencesBySimpleName,
                        out allAssemblies,
                        out implicitlyResolvedReferences,
                        out implicitlyResolvedReferenceMap,
                        ref implicitReferenceResolutions,
                        resolutionDiagnostics);
                }
                else
                {
                    allAssemblies = explicitAssemblies;
                    implicitlyResolvedReferences = ImmutableArray<MetadataReference>.Empty;
                    implicitlyResolvedReferenceMap = ImmutableArray<ResolvedReference>.Empty;
                }

                // implicitly resolved missing assemblies were added to both referenceBindings and assemblies:
                Debug.Assert(referenceBindings.Count == allAssemblies.Length);

                hasCircularReference = CheckCircularReference(referenceBindings);
                corLibraryIndex = IndexOfCorLibrary(explicitAssemblies, assemblyReferencesBySimpleName, supersedeLowerVersions);

                // For each assembly, locate AssemblySymbol with similar reference resolution
                // What does similar mean?
                // Similar means: 
                // 1) The same references are resolved against the assemblies that we are given 
                //   (or were found during implicit assembly resolution).
                // 2) The same assembly is used as the COR library.

                var boundInputs = new BoundInputAssembly[referenceBindings.Count];
                for (int i = 0; i < referenceBindings.Count; i++)
                {
                    boundInputs[i].ReferenceBinding = referenceBindings[i];
                }

                var candidateInputAssemblySymbols = new TAssemblySymbol[allAssemblies.Length];

                // If any assembly from assemblies array refers back to assemblyBeingBuilt,
                // we know that we cannot reuse symbols for any assemblies containing NoPia
                // local types. Because we cannot reuse symbols for assembly referring back
                // to assemblyBeingBuilt.
                if (!hasCircularReference)
                {
                    // Deal with assemblies containing NoPia local types.
                    if (ReuseAssemblySymbolsWithNoPiaLocalTypes(boundInputs, candidateInputAssemblySymbols, allAssemblies, corLibraryIndex))
                    {
                        return boundInputs;
                    }
                }

                // NoPia shortcut either didn't apply or failed, go through general process 
                // of matching candidates.

                ReuseAssemblySymbols(boundInputs, candidateInputAssemblySymbols, allAssemblies, corLibraryIndex);

                return boundInputs;
            }
            finally
            {
                referenceBindings.Free();
            }
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
            Debug.Assert(explicitAssemblies[0] is AssemblyDataForAssemblyBeingBuilt);
            Debug.Assert(referenceBindings.Count == explicitAssemblies.Length);
            Debug.Assert(explicitReferences.Length == explicitReferenceMap.Length);

            // -1 for assembly being built:
            int totalReferencedAssemblyCount = explicitAssemblies.Length - 1;

            var implicitAssemblies = ArrayBuilder<AssemblyData>.GetInstance();

            // assembly identities whose resolution failed for all attempted requesting references:
            var resolutionFailures = PooledHashSet<AssemblyIdentity>.GetInstance();

            var metadataReferencesBuilder = ArrayBuilder<MetadataReference>.GetInstance();

            Dictionary<MetadataReference, MergedAliases>? lazyAliasMap = null;

            // metadata references and corresponding bindings of their references, used to calculate a fixed point:
            var referenceBindingsToProcess = ArrayBuilder<(MetadataReference, ArraySegment<AssemblyReferenceBinding>)>.GetInstance();

            // collect all missing identities, resolve the assemblies and bind their references against explicit definitions:
            GetInitialReferenceBindingsToProcess(explicitModules, explicitReferences, explicitReferenceMap, referenceBindings, totalReferencedAssemblyCount, referenceBindingsToProcess);

            // NB: includes the assembly being built:
            int explicitAssemblyCount = explicitAssemblies.Length;

            try
            {
                while (referenceBindingsToProcess.Count > 0)
                {
                    var (requestingReference, bindings) = referenceBindingsToProcess.Pop();

                    foreach (var binding in bindings)
                    {
                        // only attempt to resolve unbound references (regardless of version difference of the bound ones)
                        if (binding.IsBound)
                        {
                            continue;
                        }

                        Debug.Assert(binding.ReferenceIdentity is object);
                        if (!TryResolveMissingReference(
                            requestingReference,
                            binding.ReferenceIdentity,
                            ref implicitReferenceResolutions,
                            resolver,
                            resolutionDiagnostics,
                            out AssemblyIdentity? resolvedAssemblyIdentity,
                            out AssemblyMetadata? resolvedAssemblyMetadata,
                            out PortableExecutableReference? resolvedReference))
                        {
                            // Note the failure, but do not commit it to implicitReferenceResolutions until we are done with resolving all missing references.
                            resolutionFailures.Add(binding.ReferenceIdentity);
                            continue;
                        }

                        // One attempt for resolution succeeded. The attempt is cached in implicitReferenceResolutions, so further attempts won't fail and add it back.
                        // Since the failures tracked in resolutionFailures do not affect binding there is no need to revert any decisions made so far.
                        resolutionFailures.Remove(binding.ReferenceIdentity);

                        // The resolver may return different version than we asked for, so it may happen that 
                        // it returns the same identity for two different input identities (e.g. if a higher version 
                        // of an assembly is available than what the assemblies reference: "A, v1" -> "A, v3" and "A, v2" -> "A, v3").
                        // If such case occurs merge the properties (aliases) of the resulting references in the same way we do
                        // during initial explicit references resolution.

                        // -1 for assembly being built:
                        int index = explicitAssemblyCount - 1 + metadataReferencesBuilder.Count;

                        var existingReference = TryAddAssembly(resolvedAssemblyIdentity, resolvedReference, index, resolutionDiagnostics, Location.None, assemblyReferencesBySimpleName, supersedeLowerVersions);
                        if (existingReference != null)
                        {
                            MergeReferenceProperties(existingReference, resolvedReference, resolutionDiagnostics, ref lazyAliasMap);
                            continue;
                        }

                        metadataReferencesBuilder.Add(resolvedReference);

                        var data = CreateAssemblyDataForResolvedMissingAssembly(resolvedAssemblyMetadata, resolvedReference, importOptions);
                        implicitAssemblies.Add(data);

                        var referenceBinding = data.BindAssemblyReferences(explicitAssemblies, IdentityComparer);
                        referenceBindings.Add(referenceBinding);
                        referenceBindingsToProcess.Push((resolvedReference, new ArraySegment<AssemblyReferenceBinding>(referenceBinding)));
                    }
                }

                // record failures for resolution in subsequent submissions: 
                foreach (var assemblyIdentity in resolutionFailures)
                {
                    implicitReferenceResolutions = implicitReferenceResolutions.Add(assemblyIdentity, null);
                }

                if (implicitAssemblies.Count == 0)
                {
                    Debug.Assert(lazyAliasMap == null);

                    resolvedReferences = ImmutableArray<ResolvedReference>.Empty;
                    metadataReferences = ImmutableArray<MetadataReference>.Empty;
                    allAssemblies = explicitAssemblies;
                    return;
                }

                // Rebind assembly references that were initially missing. All bindings established above
                // are against explicitly specified references.

                allAssemblies = explicitAssemblies.AddRange(implicitAssemblies);

                for (int bindingsIndex = 0; bindingsIndex < referenceBindings.Count; bindingsIndex++)
                {
                    var referenceBinding = referenceBindings[bindingsIndex];

                    for (int i = 0; i < referenceBinding.Length; i++)
                    {
                        var binding = referenceBinding[i];

                        // We don't rebind references bound to a non-matching version of a reference that was explicitly
                        // specified, even if we have a better version now.
                        if (binding.IsBound)
                        {
                            continue;
                        }

                        // We only need to resolve against implicitly resolved assemblies,
                        // since we already resolved against explicitly specified ones.
                        Debug.Assert(binding.ReferenceIdentity is object);
                        referenceBinding[i] = ResolveReferencedAssembly(
                            binding.ReferenceIdentity,
                            allAssemblies,
                            explicitAssemblyCount,
                            IdentityComparer);
                    }
                }

                UpdateBindingsOfAssemblyBeingBuilt(referenceBindings, explicitAssemblyCount, implicitAssemblies);

                metadataReferences = metadataReferencesBuilder.ToImmutable();
                resolvedReferences = ToResolvedAssemblyReferences(metadataReferences, lazyAliasMap, explicitAssemblyCount);
            }
            finally
            {
                implicitAssemblies.Free();
                referenceBindingsToProcess.Free();
                metadataReferencesBuilder.Free();
                resolutionFailures.Free();
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
DynAbs.Tracing.TraceSender.TraceEnterMethod(529,19750,22303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20237,20269);

f_529_20237_20268(f_529_20250_20262(result)== 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20347,20451);

var 
explicitModuleToReferenceMap = f_529_20382_20450(explicitModules, explicitReferenceMap)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20528,20584);

var 
bindingsOfAssemblyBeingBuilt = f_529_20563_20583(referenceBindings, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20598,20646);

int 
bindingIndex = totalReferencedAssemblyCount
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20669,20684);
            for (int 
moduleIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20660,21230) || true) && (moduleIndex < explicitModules.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20724,20737)
,moduleIndex++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,20660,21230))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,20660,21230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20771,20855);

var 
moduleReference = explicitReferences[explicitModuleToReferenceMap[moduleIndex]]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20873,20956);

var 
moduleBindingsCount = explicitModules[moduleIndex].ReferencedAssemblies.Length
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,20976,21159);

f_529_20976_21158(
                result, (moduleReference,
f_529_21049_21156(bindingsOfAssemblyBeingBuilt, bindingIndex, moduleBindingsCount)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21179,21215);

bindingIndex += moduleBindingsCount;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,571);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,571);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21246,21312);

f_529_21246_21311(bindingIndex == f_529_21275_21310(bindingsOfAssemblyBeingBuilt));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21448,21466);

            // the first binding is for the assembly being built, all its references are bound or added above
            for (int 
referenceIndex = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21439,22098) || true) && (referenceIndex < explicitReferenceMap.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21514,21530)
,referenceIndex++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,21439,22098))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,21439,22098);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21564,21632);

var 
explicitReferenceMapping = explicitReferenceMap[referenceIndex]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21650,21819) || true) && (explicitReferenceMapping.IsSkipped ||(DynAbs.Tracing.TraceSender.Expression_False(529, 21654, 21749)||explicitReferenceMapping.Kind == MetadataImageKind.Module))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,21650,21819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21791,21800);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,21650,21819);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,21891,22083);

f_529_21891_22082(
                // +1 for the assembly being built
                result, (explicitReferences[referenceIndex],
f_529_21983_22080(f_529_22026_22079(referenceBindings, explicitReferenceMapping.Index + 1))));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,660);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,660);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22208,22292);

f_529_22208_22291(f_529_22221_22233(result)== explicitModules.Length + totalReferencedAssemblyCount);
DynAbs.Tracing.TraceSender.TraceExitMethod(529,19750,22303);

int
f_529_20250_20262(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 20250, 20262);
return return_v;
}


int
f_529_20237_20268(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 20237, 20268);
return 0;
}


System.Collections.Immutable.ImmutableArray<int>
f_529_20382_20450(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
modules,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
resolvedReferences)
{
var return_v = CalculateModuleToReferenceMap( modules, resolvedReferences);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 20382, 20450);
return return_v;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
f_529_20563_20583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 20563, 20583);
return return_v;
}


System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
f_529_21049_21156(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
array,int
offset,int
count)
{
var return_v = new System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>( array, offset, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21049, 21156);
return return_v;
}


int
f_529_20976_21158(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
this_param,(Microsoft.CodeAnalysis.MetadataReference moduleReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)
item)
{
this_param.Add( ((Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>))item);
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
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21246, 21311);
return 0;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
f_529_22026_22079(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 22026, 22079);
return return_v;
}


System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
f_529_21983_22080(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
array)
{
var return_v = new System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>( array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21983, 22080);
return return_v;
}


int
f_529_21891_22082(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
this_param,(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 21891, 22082);
return 0;
}


int
f_529_22221_22233(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.MetadataReference, System.ArraySegment<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>)>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 22221, 22233);
return return_v;
}


int
f_529_22208_22291(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 22208, 22291);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,19750,22303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,19750,22303);
}
		}

private static ImmutableArray<int> CalculateModuleToReferenceMap(ImmutableArray<PEModule> modules, ImmutableArray<ResolvedReference> resolvedReferences)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,22315,23142);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22492,22597) || true) && (modules.Length == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,22492,22597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22549,22582);

return ImmutableArray<int>.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,22492,22597);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22613,22672);

var 
result = f_529_22626_22671(modules.Length)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22686,22718);

f_529_22686_22717(            result, modules.Length);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22743,22748);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22734,23080) || true) && (i < resolvedReferences.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22781,22784)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,22734,23080))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,22734,23080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22818,22864);

var 
resolvedReference = resolvedReferences[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,22882,23065) || true) && (f_529_22886_22914_M(!resolvedReference.IsSkipped)&&(DynAbs.Tracing.TraceSender.Expression_True(529, 22886, 22968)&&resolvedReference.Kind == MetadataImageKind.Module))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,22882,23065);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23010,23046);

result[resolvedReference.Index] = i;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,22882,23065);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,347);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,347);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23096,23131);

return f_529_23103_23130(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,22315,23142);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
f_529_22626_22671(int
capacity)
{
var return_v = ArrayBuilder<int>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 22626, 22671);
return return_v;
}


int
f_529_22686_22717(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
this_param,int
count)
{
this_param.ZeroInit( count);
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,22315,23142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,22315,23142);
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
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,23154,23868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23431,23507);

var 
result = f_529_23444_23506(references.Length)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23530,23535);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23521,23806) || true) && (i < references.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23560,23563)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,23521,23806))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,23521,23806);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23645,23791);

f_529_23645_23790(                // -1 for assembly being built
                result, f_529_23656_23789(references[i], explicitAssemblyCount - 1 + i, MetadataImageKind.Assembly, propertyMapOpt));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,286);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,286);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,23822,23857);

return f_529_23829_23856(result);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,23154,23868);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
f_529_23444_23506(int
capacity)
{
var return_v = ArrayBuilder<ResolvedReference>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23444, 23506);
return return_v;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
f_529_23656_23789(Microsoft.CodeAnalysis.MetadataReference
reference,int
index,Microsoft.CodeAnalysis.MetadataImageKind
kind,System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
propertyMapOpt)
{
var return_v = GetResolvedReferenceAndFreePropertyMapEntry( reference, index, kind, propertyMapOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 23656, 23789);
return return_v;
}


int
f_529_23645_23790(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
this_param,Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
item)
{
this_param.Add( item);
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,23154,23868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,23154,23868);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void UpdateBindingsOfAssemblyBeingBuilt(ArrayBuilder<AssemblyReferenceBinding[]> referenceBindings, int explicitAssemblyCount, ArrayBuilder<AssemblyData> implicitAssemblies)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,23880,25332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24093,24158);

var 
referenceBindingsOfAssemblyBeingBuilt = f_529_24137_24157(referenceBindings, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24270,24429);

var 
bindingsOfAssemblyBeingBuilt = f_529_24305_24428(f_529_24356_24400(referenceBindingsOfAssemblyBeingBuilt)+ f_529_24403_24427(implicitAssemblies))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24545,24649);

f_529_24545_24648(
            // add bindings for explicitly specified assemblies (-1 for the assembly being built):
            bindingsOfAssemblyBeingBuilt, referenceBindingsOfAssemblyBeingBuilt, explicitAssemblyCount - 1);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24739,24744);

            // add bindings for implicitly resolved assemblies:
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24730,24950) || true) && (i < f_529_24750_24774(implicitAssemblies))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24776,24779)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,24730,24950))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,24730,24950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,24813,24935);

f_529_24813_24934(                bindingsOfAssemblyBeingBuilt, f_529_24846_24933(f_529_24875_24905(f_529_24875_24896(implicitAssemblies, i)), explicitAssemblyCount + i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,221);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,221);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,25058,25236);

f_529_25058_25235(
            // add bindings for assemblies referenced by modules added to the compilation:
            bindingsOfAssemblyBeingBuilt, referenceBindingsOfAssemblyBeingBuilt, explicitAssemblyCount - 1, f_529_25162_25206(referenceBindingsOfAssemblyBeingBuilt)- explicitAssemblyCount + 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,25252,25321);

referenceBindings[0] = f_529_25275_25320(bindingsOfAssemblyBeingBuilt);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,23880,25332);

Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
f_529_24137_24157(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 24137, 24157);
return return_v;
}


int
f_529_24356_24400(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
this_param)
{
var return_v = this_param.Length ;
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
var return_v = ArrayBuilder<AssemblyReferenceBinding>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24305, 24428);
return return_v;
}


int
f_529_24545_24648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
this_param,Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
items,int
length)
{
this_param.AddRange( items, length);
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
this_param,int
i0)
{
var return_v = this_param[ i0];
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
referenceIdentity,int
definitionIndex)
{
var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding( referenceIdentity, definitionIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24846, 24933);
return return_v;
}


int
f_529_24813_24934(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
this_param,Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 24813, 24934);
return 0;
}


int
f_529_25162_25206(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 25162, 25206);
return return_v;
}


int
f_529_25058_25235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding>
this_param,Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
items,int
start,int
length)
{
this_param.AddRange( items, start, length);
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,23880,25332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,23880,25332);
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
            resolvedAssemblyIdentity = null;
            resolvedAssemblyMetadata = null;
            bool isNewlyResolvedReference = false;

            // Check if we have previously resolved an identity and reuse the previously resolved reference if so. 
            // Use the resolver to find the missing reference.
            // Note that the resolver may return an assembly of a different identity than requested, e.g. a higher version.
            if (!implicitReferenceResolutions.TryGetValue(referenceIdentity, out resolvedReference))
            {
                resolvedReference = resolver.ResolveMissingAssembly(requestingReference, referenceIdentity);
                isNewlyResolvedReference = true;
            }

            if (resolvedReference == null)
            {
                return false;
            }

            resolvedAssemblyMetadata = GetAssemblyMetadata(resolvedReference, resolutionDiagnostics);
            if (resolvedAssemblyMetadata == null)
            {
                return false;
            }

            var resolvedAssembly = resolvedAssemblyMetadata.GetAssembly();
            Debug.Assert(resolvedAssembly is object);

            // Allow reference and definition identities to differ in version, but not other properties.
            // Don't need to compare if we are reusing a previously resolved reference.
            if (isNewlyResolvedReference &&
                IdentityComparer.Compare(referenceIdentity, resolvedAssembly.Identity) == AssemblyIdentityComparer.ComparisonResult.NotEquivalent)
            {
                return false;
            }

            resolvedAssemblyIdentity = resolvedAssembly.Identity;
            implicitReferenceResolutions = implicitReferenceResolutions.Add(referenceIdentity, resolvedReference);
            return true;
        }

        private AssemblyData CreateAssemblyDataForResolvedMissingAssembly(
            AssemblyMetadata assemblyMetadata,
            PortableExecutableReference peReference,
            MetadataImportOptions importOptions)
        {
            var assembly = assemblyMetadata.GetAssembly();
            Debug.Assert(assembly is object);
            return CreateAssemblyDataForFile(
                assembly,
                assemblyMetadata.CachedSymbols,
                peReference.DocumentationProvider,
                SimpleAssemblyName,
                importOptions,
                peReference.Properties.EmbedInteropTypes);
        }

        private bool ReuseAssemblySymbolsWithNoPiaLocalTypes(BoundInputAssembly[] boundInputs, TAssemblySymbol[] candidateInputAssemblySymbols, ImmutableArray<AssemblyData> assemblies, int corLibraryIndex)
        {
            int totalAssemblies = assemblies.Length;
            for (int i = 1; i < totalAssemblies; i++)
            {
                if (!assemblies[i].ContainsNoPiaLocalTypes)
                {
                    continue;
                }

                foreach (TAssemblySymbol candidateAssembly in assemblies[i].AvailableSymbols)
                {
                    // Candidate should be referenced the same way (/r or /l) by the compilation, 
                    // which originated the symbols. We need this restriction in order to prevent 
                    // non-interface generic types closed over NoPia local types from crossing 
                    // assembly boundaries.
                    if (IsLinked(candidateAssembly) != assemblies[i].IsLinked)
                    {
                        continue;
                    }

                    ImmutableArray<TAssemblySymbol> resolutionAssemblies = GetNoPiaResolutionAssemblies(candidateAssembly);

                    if (resolutionAssemblies.IsDefault)
                    {
                        continue;
                    }

                    Array.Clear(candidateInputAssemblySymbols, 0, candidateInputAssemblySymbols.Length);

                    // In order to reuse candidateAssembly, we need to make sure that 
                    // 1) all assemblies in resolutionAssemblies are among assemblies represented
                    //    by assemblies array.
                    // 2) From assemblies represented by assemblies array all assemblies, except 
                    //    assemblyBeingBuilt are among resolutionAssemblies.
                    bool match = true;

                    foreach (TAssemblySymbol assembly in resolutionAssemblies)
                    {
                        match = false;

                        for (int j = 1; j < totalAssemblies; j++)
                        {
                            if (assemblies[j].IsMatchingAssembly(assembly) &&
                                IsLinked(assembly) == assemblies[j].IsLinked)
                            {
                                candidateInputAssemblySymbols[j] = assembly;
                                match = true;
                                // We could break out of the loop unless assemblies array
                                // can contain duplicate values. Let's play safe and loop
                                // through all items.
                            }
                        }

                        if (!match)
                        {
                            // Requirement #1 is not met.
                            break;
                        }
                    }

                    if (!match)
                    {
                        continue;
                    }

                    for (int j = 1; j < totalAssemblies; j++)
                    {
                        if (candidateInputAssemblySymbols[j] == null)
                        {
                            // Requirement #2 is not met.
                            match = false;
                            break;
                        }
                        else
                        {
                            // Let's check if different assembly is used as the COR library.
                            // It shouldn't be possible to get in this situation, but let's play safe.
                            if (corLibraryIndex < 0)
                            {
                                // we don't have COR library.
                                if (GetCorLibrary(candidateInputAssemblySymbols[j]) != null)
                                {
                                    // but this assembly has
                                    // I am leaving the Assert here because it will likely indicate a bug somewhere.
                                    Debug.Assert(GetCorLibrary(candidateInputAssemblySymbols[j]) == null);
                                    match = false;
                                    break;
                                }
                            }
                            else
                            {
                                // We can't be compiling corlib and have a corlib reference at the same time:
                                Debug.Assert(corLibraryIndex != 0);

                                // We have COR library, it should match COR library of the candidate.
                                if (!ReferenceEquals(candidateInputAssemblySymbols[corLibraryIndex], GetCorLibrary(candidateInputAssemblySymbols[j])))
                                {
                                    // I am leaving the Assert here because it will likely indicate a bug somewhere.
                                    Debug.Assert(candidateInputAssemblySymbols[corLibraryIndex] == null);
                                    match = false;
                                    break;
                                }
                            }
                        }
                    }

                    if (match)
                    {
                        // We found a match, use it.
                        for (int j = 1; j < totalAssemblies; j++)
                        {
                            Debug.Assert(candidateInputAssemblySymbols[j] != null);
                            boundInputs[j].AssemblySymbol = candidateInputAssemblySymbols[j];
                        }

                        return true;
                    }
                }

                // Prepare candidateMatchingSymbols for next operations.
                Array.Clear(candidateInputAssemblySymbols, 0, candidateInputAssemblySymbols.Length);

                // Why it doesn't make sense to examine other assemblies with local types?
                // Since we couldn't find a suitable match for this assembly,
                // we know that requirement #2 cannot be met for any other assembly
                // containing local types.
                break;
            }

            return false;
        }

        private void ReuseAssemblySymbols(BoundInputAssembly[] boundInputs, TAssemblySymbol[] candidateInputAssemblySymbols, ImmutableArray<AssemblyData> assemblies, int corLibraryIndex)
        {
            // Queue of references we need to examine for consistency
            Queue<AssemblyReferenceCandidate> candidatesToExamine = new Queue<AssemblyReferenceCandidate>();
            int totalAssemblies = assemblies.Length;

            // A reusable buffer to contain the AssemblySymbols a candidate symbol refers to
            // ⚠ PERF: https://github.com/dotnet/roslyn/issues/47471
            List<TAssemblySymbol?> candidateReferencedSymbols = new List<TAssemblySymbol?>(1024);

            for (int i = 1; i < totalAssemblies; i++)
            {
                // We could have a match already
                if (boundInputs[i].AssemblySymbol != null || assemblies[i].ContainsNoPiaLocalTypes)
                {
                    continue;
                }

                foreach (TAssemblySymbol candidateAssembly in assemblies[i].AvailableSymbols)
                {
                    bool match = true;

                    // We should examine this candidate, all its references that are supposed to 
                    // match one of the given assemblies and do the same for their references, etc. 
                    // The whole set of symbols we get at the end should be consistent with the set 
                    // of assemblies we are given. The whole set of symbols should be accepted or rejected.

                    // The set of symbols is accumulated in candidateInputAssemblySymbols. It is merged into 
                    // boundInputs after consistency is confirmed. 
                    Array.Clear(candidateInputAssemblySymbols, 0, candidateInputAssemblySymbols.Length);

                    // Symbols and index of the corresponding assembly to match against are accumulated in the
                    // candidatesToExamine queue. They are examined one by one. 
                    candidatesToExamine.Clear();

                    // This is a queue of symbols that we are picking up as a result of using
                    // symbols from candidateAssembly
                    candidatesToExamine.Enqueue(new AssemblyReferenceCandidate(i, candidateAssembly));

                    while (match && candidatesToExamine.Count > 0)
                    {
                        AssemblyReferenceCandidate candidate = candidatesToExamine.Dequeue();

                        Debug.Assert(candidate.DefinitionIndex >= 0);
                        Debug.Assert(candidate.AssemblySymbol is object);

                        int candidateIndex = candidate.DefinitionIndex;

                        // Have we already chosen symbols for the corresponding assembly?
                        Debug.Assert(boundInputs[candidateIndex].AssemblySymbol == null ||
                                              candidateInputAssemblySymbols[candidateIndex] == null);

                        TAssemblySymbol? inputAssembly = boundInputs[candidateIndex].AssemblySymbol;
                        if (inputAssembly == null)
                        {
                            inputAssembly = candidateInputAssemblySymbols[candidateIndex];
                        }

                        if (inputAssembly != null)
                        {
                            if (Object.ReferenceEquals(inputAssembly, candidate.AssemblySymbol))
                            {
                                // We already checked this AssemblySymbol, no reason to check it again
                                continue; // Proceed with the next assembly in candidatesToExamine queue.
                            }

                            // We are using different AssemblySymbol for this assembly
                            match = false;
                            break; // Stop processing items from candidatesToExamine queue.
                        }

                        // Candidate should be referenced the same way (/r or /l) by the compilation, 
                        // which originated the symbols. We need this restriction in order to prevent 
                        // non-interface generic types closed over NoPia local types from crossing 
                        // assembly boundaries.
                        if (IsLinked(candidate.AssemblySymbol) != assemblies[candidateIndex].IsLinked)
                        {
                            match = false;
                            break; // Stop processing items from candidatesToExamine queue.
                        }

                        // Add symbols to the set at corresponding index
                        Debug.Assert(candidateInputAssemblySymbols[candidateIndex] == null);
                        candidateInputAssemblySymbols[candidateIndex] = candidate.AssemblySymbol;

                        // Now process references of the candidate.

                        // how we bound the candidate references for this compilation:
                        var candidateReferenceBinding = boundInputs[candidateIndex].ReferenceBinding;

                        // get the AssemblySymbols the candidate symbol refers to into candidateReferencedSymbols
                        candidateReferencedSymbols.Clear();
                        GetActualBoundReferencesUsedBy(candidate.AssemblySymbol, candidateReferencedSymbols);

                        Debug.Assert(candidateReferenceBinding is object);
                        Debug.Assert(candidateReferenceBinding.Length == candidateReferencedSymbols.Count);
                        int referencesCount = candidateReferencedSymbols.Count;

                        for (int k = 0; k < referencesCount; k++)
                        {
                            // All candidate's references that were /l-ed by the compilation, 
                            // which originated the symbols, must be /l-ed by this compilation and 
                            // other references must be either /r-ed or not referenced. 
                            // We need this restriction in order to prevent non-interface generic types 
                            // closed over NoPia local types from crossing assembly boundaries.

                            // if target reference isn't resolved against given assemblies, 
                            // we cannot accept a candidate that has the reference resolved.
                            if (!candidateReferenceBinding[k].IsBound)
                            {
                                if (candidateReferencedSymbols[k] != null)
                                {
                                    // can't use symbols 

                                    // If we decide do go back to accepting references like this,
                                    // we should still not do this if the reference is a /l-ed assembly.
                                    match = false;
                                    break; // Stop processing references.
                                }

                                continue; // Proceed with the next reference.
                            }

                            // We resolved the reference, candidate must have that reference resolved too.
                            var currentCandidateReferencedSymbol = candidateReferencedSymbols[k];
                            if (currentCandidateReferencedSymbol == null)
                            {
                                // can't use symbols 
                                match = false;
                                break; // Stop processing references.
                            }

                            int definitionIndex = candidateReferenceBinding[k].DefinitionIndex;
                            if (definitionIndex == 0)
                            {
                                // We can't reuse any assembly that refers to the assembly being built.
                                match = false;
                                break;
                            }

                            // Make sure symbols represent the same assembly/binary
                            if (!assemblies[definitionIndex].IsMatchingAssembly(currentCandidateReferencedSymbol))
                            {
                                // Mismatch between versions?
                                match = false;
                                break; // Stop processing references.
                            }

                            if (assemblies[definitionIndex].ContainsNoPiaLocalTypes)
                            {
                                // We already know that we cannot reuse any existing symbols for 
                                // this assembly
                                match = false;
                                break; // Stop processing references.
                            }

                            if (IsLinked(currentCandidateReferencedSymbol) != assemblies[definitionIndex].IsLinked)
                            {
                                // Mismatch between reference kind.
                                match = false;
                                break; // Stop processing references.
                            }

                            // Add this reference to the queue so that we consider it as a candidate too 
                            candidatesToExamine.Enqueue(new AssemblyReferenceCandidate(definitionIndex, currentCandidateReferencedSymbol));
                        }

                        // Check that the COR library used by the candidate assembly symbol is the same as the one use by this compilation.
                        if (match)
                        {
                            TAssemblySymbol? candidateCorLibrary = GetCorLibrary(candidate.AssemblySymbol);

                            if (candidateCorLibrary == null)
                            {
                                // If the candidate didn't have a COR library, that is fine as long as we don't have one either.
                                if (corLibraryIndex >= 0)
                                {
                                    match = false;
                                    break; // Stop processing references.
                                }
                            }
                            else
                            {
                                // We can't be compiling corlib and have a corlib reference at the same time:
                                Debug.Assert(corLibraryIndex != 0);

                                Debug.Assert(ReferenceEquals(candidateCorLibrary, GetCorLibrary(candidateCorLibrary)));

                                // Candidate has COR library, we should have one too.
                                if (corLibraryIndex < 0)
                                {
                                    match = false;
                                    break; // Stop processing references.
                                }

                                // Make sure candidate COR library represent the same assembly/binary
                                if (!assemblies[corLibraryIndex].IsMatchingAssembly(candidateCorLibrary))
                                {
                                    // Mismatch between versions?
                                    match = false;
                                    break; // Stop processing references.
                                }

                                Debug.Assert(!assemblies[corLibraryIndex].ContainsNoPiaLocalTypes);
                                Debug.Assert(!assemblies[corLibraryIndex].IsLinked);
                                Debug.Assert(!IsLinked(candidateCorLibrary));

                                // Add the candidate COR library to the queue so that we consider it as a candidate.
                                candidatesToExamine.Enqueue(new AssemblyReferenceCandidate(corLibraryIndex, candidateCorLibrary));
                            }
                        }
                    }

                    if (match)
                    {
                        // Merge the set of symbols into result
                        for (int k = 0; k < totalAssemblies; k++)
                        {
                            if (candidateInputAssemblySymbols[k] != null)
                            {
                                Debug.Assert(boundInputs[k].AssemblySymbol == null);
                                boundInputs[k].AssemblySymbol = candidateInputAssemblySymbols[k];
                            }
                        }

                        // No reason to examine other symbols for this assembly
                        break; // Stop processing assemblies[i].AvailableSymbols
                    }
                }
            }
        }

private static bool CheckCircularReference(IReadOnlyList<AssemblyReferenceBinding[]> referenceBindings)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,50296,50805);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50433,50438);
            for (int 
i = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50424,50765) || true) && (i < f_529_50444_50467(referenceBindings))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50469,50472)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,50424,50765))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,50424,50765);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50506,50750);
foreach(AssemblyReferenceBinding index in f_529_50549_50569_I(f_529_50549_50569(referenceBindings, i)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,50506,50750);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50611,50731) || true) && (index.BoundToAssemblyBeingBuilt)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,50611,50731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50696,50708);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,50611,50731);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(529,50506,50750);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,245);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,245);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,342);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,342);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50781,50794);

return false;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,50296,50805);

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
this_param,int
i0)
{
var return_v = this_param[ i0];
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,50296,50805);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,50296,50805);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsSuperseded(AssemblyIdentity identity, IReadOnlyDictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,50817,51184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,50995,51056);

var 
value = f_529_51007_51055(f_529_51007_51052(assemblyReferencesBySimpleName, f_529_51038_51051(identity)), 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51070,51109);

f_529_51070_51108(value.Identity is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51123,51173);

return f_529_51130_51152(value.Identity)!= f_529_51156_51172(identity);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,50817,51184);

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
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51007, 51052);
return return_v;
}


Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
f_529_51007_51055(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 51007, 51055);
return return_v;
}


int
f_529_51070_51108(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 51070, 51108);
return 0;
}


System.Version
f_529_51130_51152(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.Version ;
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,50817,51184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,50817,51184);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int IndexOfCorLibrary(ImmutableArray<AssemblyData> assemblies, IReadOnlyDictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName, bool supersedeLowerVersions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,51196,54204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51482,51529);

ArrayBuilder<int>? 
corLibraryCandidates = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51554,51559);

            for (int 
i = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51545,52998) || true) && (i < assemblies.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51584,51587)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(529,51545,52998))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,51545,52998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,51621,51650);

var 
assembly = assemblies[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,52103,52983) || true) && (f_529_52107_52125_M(!assembly.IsLinked)&&(DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52189)&&                    assembly.AssemblyReferences.Length == 0 )&&(DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52247)&&f_529_52214_52247_M(!assembly.ContainsNoPiaLocalTypes))&&(DynAbs.Tracing.TraceSender.Expression_True(529, 52107, 52365)&&                    (!supersedeLowerVersions ||(DynAbs.Tracing.TraceSender.Expression_False(529, 52273, 52364)||!f_529_52301_52364(f_529_52314_52331(assembly), assemblyReferencesBySimpleName)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,52103,52983);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,52569,52964) || true) && (f_529_52573_52604(assembly))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,52569,52964);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,52654,52826) || true) && (corLibraryCandidates == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,52654,52826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,52744,52799);

corLibraryCandidates = f_529_52767_52798();
DynAbs.Tracing.TraceSender.TraceExitCondition(529,52654,52826);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,52913,52941);

f_529_52913_52940(
                        // This could be the COR library.
                        corLibraryCandidates, i);
DynAbs.Tracing.TraceSender.TraceExitCondition(529,52569,52964);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(529,52103,52983);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(529,1,1454);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(529,1,1454);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53178,53879) || true) && (corLibraryCandidates != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,53178,53879);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53244,53864) || true) && (f_529_53248_53274(corLibraryCandidates)== 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,53244,53864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53426,53463);

int 
result = f_529_53439_53462(corLibraryCandidates, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53485,53513);

f_529_53485_53512(                    corLibraryCandidates);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53535,53549);

return result;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,53244,53864);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,53244,53864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,53817,53845);

f_529_53817_53844(                    // TODO: C# seems to pick the first one (but produces warnings when looking up predefined types).
                    // See PredefinedTypes::Init(ErrorHandling*).
                    corLibraryCandidates);
DynAbs.Tracing.TraceSender.TraceExitCondition(529,53244,53864);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(529,53178,53879);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,54035,54167) || true) && (assemblies.Length == 1 &&(DynAbs.Tracing.TraceSender.Expression_True(529, 54039, 54109)&&assemblies[0].AssemblyReferences.Length == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(529,54035,54167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,54143,54152);

return 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(529,54035,54167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,54183,54193);

return -1;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,51196,54204);

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
identity,System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
assemblyReferencesBySimpleName)
{
var return_v = IsSuperseded( identity, assemblyReferencesBySimpleName);
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
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(529, 52913, 52940);
return 0;
}


int
f_529_53248_53274(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(529, 53248, 53274);
return return_v;
}


int
f_529_53439_53462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
this_param,int
i0)
{
var return_v = this_param[ i0];
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,51196,54204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,51196,54204);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool InternalsMayBeVisibleToAssemblyBeingCompiled(string compilationName, PEAssembly assembly)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(529,54552,54774);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(529,54687,54763);

return !f_529_54695_54762(f_529_54695_54752(assembly, compilationName));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(529,54552,54774);

System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
f_529_54695_54752(Microsoft.CodeAnalysis.PEAssembly
this_param,string
simpleName)
{
var return_v = this_param.GetInternalsVisibleToPublicKeys( simpleName);
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
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(529,54552,54774);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(529,54552,54774);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract void GetActualBoundReferencesUsedBy(TAssemblySymbol assemblySymbol, List<TAssemblySymbol?> referencedAssemblySymbols);

protected abstract ImmutableArray<TAssemblySymbol> GetNoPiaResolutionAssemblies(TAssemblySymbol candidateAssembly);

protected abstract bool IsLinked(TAssemblySymbol candidateAssembly);

protected abstract TAssemblySymbol? GetCorLibrary(TAssemblySymbol candidateAssembly);
}
}
