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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 9367, 21226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10088, 10141);

                ImmutableArray<Location>
                referenceDirectiveLocations
                = default(ImmutableArray<Location>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10155, 10287);

                f_530_10155_10286(this, compilation, diagnostics, out references, out boundReferenceDirectiveMap, out referenceDirectiveLocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10422, 10461);

                int
                referenceCount = references.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10475, 10584);

                int
                referenceDirectiveCount = ((DynAbs.Tracing.TraceSender.Conditional_F1(530, 10506, 10541) || ((referenceDirectiveLocations != null && DynAbs.Tracing.TraceSender.Conditional_F2(530, 10544, 10578)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 10581, 10582))) ? referenceDirectiveLocations.Length : 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10600, 10657);

                var
                referenceMap = new ResolvedReference[referenceCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 10920, 10986);

                Dictionary<MetadataReference, MergedAliases>?
                lazyAliasMap = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11131, 11250);

                var
                boundReferences = f_530_11153_11249(MetadataReferenceEqualityComparer.Instance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11266, 11420);

                ArrayBuilder<MetadataReference>?
                uniqueDirectiveReferences = (DynAbs.Tracing.TraceSender.Conditional_F1(530, 11327, 11364) || (((referenceDirectiveLocations != null) && DynAbs.Tracing.TraceSender.Conditional_F2(530, 11367, 11412)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 11415, 11419))) ? f_530_11367_11412() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11434, 11499);

                var
                assembliesBuilder = f_530_11458_11498()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11513, 11563);

                ArrayBuilder<PEModule>?
                lazyModulesBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11579, 11662);

                bool
                supersedeLowerVersions = f_530_11609_11661(f_530_11609_11628(compilation))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11957, 11992);

                    // When duplicate references with conflicting EmbedInteropTypes flag are encountered,
                    // VB uses the flag from the last one, C# reports an error. We need to enumerate in reverse order
                    // so that we find the one that matters first.
                    for (int
        referenceIndex = referenceCount - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 11948, 19454) || true) && (referenceIndex >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12015, 12031)
        , referenceIndex--, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 11948, 19454))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 11948, 19454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12065, 12113);

                        var
                        boundReference = references[referenceIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12131, 12227) || true) && (boundReference == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 12131, 12227);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12199, 12208);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 12131, 12227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12329, 12366);

                        MetadataReference?
                        existingReference
                        = default(MetadataReference?);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12384, 12876) || true) && (f_530_12388_12454(boundReferences, boundReference, out existingReference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 12384, 12876);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12613, 12824) || true) && ((object)boundReference != existingReference)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 12613, 12824);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12710, 12801);

                                f_530_12710_12800(this, existingReference, boundReference, diagnostics, ref lazyAliasMap);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 12613, 12824);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12848, 12857);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 12384, 12876);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12896, 12948);

                        f_530_12896_12947(
                                        boundReferences, boundReference, boundReference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 12968, 12986);

                        Location
                        location
                        = default(Location);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13004, 13340) || true) && (referenceIndex < referenceDirectiveCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 13004, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13090, 13145);

                            location = referenceDirectiveLocations[referenceIndex];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13167, 13214);

                            f_530_13167_13213(uniqueDirectiveReferences!, boundReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 13004, 13340);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 13004, 13340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13296, 13321);

                            location = f_530_13307_13320();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 13004, 13340);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13404, 13470);

                        var
                        compilationReference = boundReference as CompilationReference
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13488, 15249) || true) && (compilationReference != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 13488, 15249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13562, 15197);

                            switch (compilationReference.Properties.Kind)
                            {

                                case MetadataImageKind.Assembly:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 13562, 15197);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 13718, 14162);

                                    existingReference = f_530_13738_14161(this, f_530_13787_13837(f_530_13787_13828(f_530_13787_13819(compilationReference))), boundReference, f_530_13921_13945_M(-assembliesBuilder.Count) - 1, diagnostics, location, assemblyReferencesBySimpleName, supersedeLowerVersions);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 14194, 14454) || true) && (existingReference != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 14194, 14454);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 14289, 14380);

                                        f_530_14289_14379(this, existingReference, boundReference, diagnostics, ref lazyAliasMap);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 14414, 14423);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 14194, 14454);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 14824, 14893);

                                    var
                                    asmData = f_530_14838_14892(this, compilationReference)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 14923, 14993);

                                    f_530_14923_14992(asmData, referenceIndex, referenceMap, assembliesBuilder);
                                    DynAbs.Tracing.TraceSender.TraceBreak(530, 15023, 15029);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 13562, 15197);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 13562, 15197);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15095, 15174);

                                    throw f_530_15101_15173(compilationReference.Properties.Kind);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 13562, 15197);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15221, 15230);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 13488, 15249);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15304, 15366);

                        var
                        peReference = (PortableExecutableReference)boundReference
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15384, 15470);

                        Metadata?
                        metadata = f_530_15405_15469(this, peReference, f_530_15430_15445(), location, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15488, 15549);

                        f_530_15488_15548(metadata != null || (DynAbs.Tracing.TraceSender.Expression_False(530, 15501, 15547) || f_530_15521_15547(diagnostics)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15569, 19439) || true) && (metadata != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15569, 19439);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15631, 19420);

                            switch (peReference.Properties.Kind)
                            {

                                case MetadataImageKind.Assembly:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15631, 19420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15778, 15828);

                                    var
                                    assemblyMetadata = (AssemblyMetadata)metadata
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15858, 15939);

                                    WeakList<IAssemblySymbolInternal>
                                    cachedSymbols = assemblyMetadata.CachedSymbols
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 15971, 17841) || true) && (f_530_15975_16009(assemblyMetadata))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15971, 17841);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16075, 16129);

                                        PEAssembly?
                                        assembly = f_530_16098_16128(assemblyMetadata)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16163, 16196);

                                        f_530_16163_16195(assembly is object);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16230, 16666);

                                        existingReference = f_530_16250_16665(this, f_530_16303_16320(assembly), peReference, f_530_16409_16433_M(-assembliesBuilder.Count) - 1, diagnostics, location, assemblyReferencesBySimpleName, supersedeLowerVersions);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16702, 16978) || true) && (existingReference != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 16702, 16978);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16805, 16896);

                                            f_530_16805_16895(this, existingReference, boundReference, diagnostics, ref lazyAliasMap);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 16934, 16943);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 16702, 16978);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 17014, 17442);

                                        var
                                        asmData = f_530_17028_17441(this, assembly, cachedSymbols, f_530_17191_17224(peReference), SimpleAssemblyName, f_530_17320_17361(f_530_17320_17339(compilation)), peReference.Properties.EmbedInteropTypes)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 17478, 17548);

                                        f_530_17478_17547(asmData, referenceIndex, referenceMap, assembliesBuilder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15971, 17841);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15971, 17841);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 17678, 17810);

                                        f_530_17678_17809(diagnostics, f_530_17694_17808(f_530_17694_17709(), f_530_17727_17770(f_530_17727_17742()), location, f_530_17782_17801(peReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(530, 17782, 17807) ?? "")));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15971, 17841);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 17947, 17978);

                                    f_530_17947_17977(assemblyMetadata);
                                    DynAbs.Tracing.TraceSender.TraceBreak(530, 18008, 18014);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15631, 19420);

                                case MetadataImageKind.Module:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15631, 19420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 18102, 18148);

                                    var
                                    moduleMetadata = (ModuleMetadata)metadata
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 18178, 19225) || true) && (f_530_18182_18218(f_530_18182_18203(moduleMetadata)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 18178, 19225);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 18499, 18811) || true) && (f_530_18503_18548_M(!f_530_18504_18525(moduleMetadata).IsEntireImageAvailable))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 18499, 18811);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 18622, 18776);

                                            f_530_18622_18775(diagnostics, f_530_18638_18774(f_530_18638_18653(), f_530_18671_18736(f_530_18671_18686()), location, f_530_18748_18767(peReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(530, 18748, 18773) ?? "")));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 18499, 18811);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 18847, 18934);

                                        f_530_18847_18933(f_530_18857_18878(moduleMetadata), referenceIndex, referenceMap, ref lazyModulesBuilder);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 18178, 19225);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 18178, 19225);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19064, 19194);

                                        f_530_19064_19193(diagnostics, f_530_19080_19192(f_530_19080_19095(), f_530_19113_19154(f_530_19113_19128()), location, f_530_19166_19185(peReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(530, 19166, 19191) ?? "")));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 18178, 19225);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(530, 19255, 19261);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15631, 19420);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 15631, 19420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19327, 19397);

                                    throw f_530_19333_19396(peReference.Properties.Kind);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15631, 19420);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 15569, 19439);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 7507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 7507);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19470, 19825) || true) && (uniqueDirectiveReferences != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 19470, 19825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19541, 19585);

                    f_530_19541_19584(uniqueDirectiveReferences);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19603, 19677);

                    boundReferenceDirectives = f_530_19630_19676(uniqueDirectiveReferences);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 19470, 19825);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 19470, 19825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 19743, 19810);

                    boundReferenceDirectives = ImmutableArray<MetadataReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 19470, 19825);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20199, 20204);

                    // We enumerated references in reverse order in the above code
                    // and thus assemblies and modules in the builders are reversed.
                    // Fix up all the indices and reverse the builder content now to get 
                    // the ordering matching the references.
                    // 
                    // Also fills in aliases.

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20190, 20726) || true) && (i < f_530_20210_20229(referenceMap))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20231, 20234)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(530, 20190, 20726))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 20190, 20726);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20268, 20711) || true) && (f_530_20272_20298_M(!referenceMap[i].IsSkipped))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 20268, 20711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20340, 20464);

                            int
                            count = (DynAbs.Tracing.TraceSender.Conditional_F1(530, 20352, 20404) || (((referenceMap[i].Kind == MetadataImageKind.Assembly) && DynAbs.Tracing.TraceSender.Conditional_F2(530, 20407, 20430)) || DynAbs.Tracing.TraceSender.Conditional_F3(530, 20433, 20463))) ? f_530_20407_20430(assembliesBuilder) : f_530_20433_20458_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lazyModulesBuilder, 530, 20433, 20458)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(530, 20433, 20463) ?? 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20488, 20542);

                            int
                            reversedIndex = count - 1 - referenceMap[i].Index
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20564, 20692);

                            referenceMap[i] = f_530_20582_20691(references[i], reversedIndex, referenceMap[i].Kind, lazyAliasMap);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 20268, 20711);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20742, 20778);

                f_530_20742_20777(
                            assembliesBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20792, 20844);

                assemblies = f_530_20805_20843(assembliesBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20860, 21151) || true) && (lazyModulesBuilder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 20860, 21151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 20924, 20965);

                    modules = ImmutableArray<PEModule>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 20860, 21151);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 20860, 21151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21031, 21068);

                    f_530_21031_21067(lazyModulesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21086, 21136);

                    modules = f_530_21096_21135(lazyModulesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 20860, 21151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 21167, 21215);

                return f_530_21174_21214(referenceMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 9367, 21226);

                int
                f_530_10155_10286(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, TCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                references, out System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                boundReferenceDirectives, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                referenceDirectiveLocations)
                {
                    this_param.GetCompilationReferences(compilation, diagnostics, out references, out boundReferenceDirectives, out referenceDirectiveLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 10155, 10286);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MetadataReference>
                f_530_11153_11249(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.MetadataReferenceEqualityComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MetadataReference>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.MetadataReference>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 11153, 11249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                f_530_11367_11412()
                {
                    var return_v = ArrayBuilder<MetadataReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 11367, 11412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                f_530_11458_11498()
                {
                    var return_v = ArrayBuilder<AssemblyData>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 11458, 11498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_11609_11628(TCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 11609, 11628);
                    return return_v;
                }


                bool
                f_530_11609_11661(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.ReferencesSupersedeLowerVersions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 11609, 11661);
                    return return_v;
                }


                bool
                f_530_12388_12454(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, out Microsoft.CodeAnalysis.MetadataReference?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 12388, 12454);
                    return return_v;
                }


                int
                f_530_12710_12800(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                primaryReference, Microsoft.CodeAnalysis.MetadataReference
                newReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                lazyAliasMap)
                {
                    this_param.MergeReferenceProperties(primaryReference, newReference, diagnostics, ref lazyAliasMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 12710, 12800);
                    return 0;
                }


                int
                f_530_12896_12947(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, Microsoft.CodeAnalysis.MetadataReference
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 12896, 12947);
                    return 0;
                }


                int
                f_530_13167_13213(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 13167, 13213);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_530_13307_13320()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 13307, 13320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_530_13787_13819(Microsoft.CodeAnalysis.CompilationReference
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 13787, 13819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_530_13787_13828(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 13787, 13828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_13787_13837(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 13787, 13837);
                    return return_v;
                }


                int
                f_530_13921_13945_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 13921, 13945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference?
                f_530_13738_14161(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.MetadataReference
                reference, int
                assemblyIndex, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                referencesBySimpleName, bool
                supersedeLowerVersions)
                {
                    var return_v = this_param.TryAddAssembly(identity, reference, assemblyIndex, diagnostics, location, referencesBySimpleName, supersedeLowerVersions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 13738, 14161);
                    return return_v;
                }


                int
                f_530_14289_14379(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                primaryReference, Microsoft.CodeAnalysis.MetadataReference
                newReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                lazyAliasMap)
                {
                    this_param.MergeReferenceProperties(primaryReference, newReference, diagnostics, ref lazyAliasMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 14289, 14379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                f_530_14838_14892(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.CompilationReference
                compilationReference)
                {
                    var return_v = this_param.CreateAssemblyDataForCompilation(compilationReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 14838, 14892);
                    return return_v;
                }


                int
                f_530_14923_14992(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                data, int
                referenceIndex, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference[]
                referenceMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies)
                {
                    AddAssembly(data, referenceIndex, referenceMap, assemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 14923, 14992);
                    return 0;
                }


                System.Exception
                f_530_15101_15173(Microsoft.CodeAnalysis.MetadataImageKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 15101, 15173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_15430_15445()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 15430, 15445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata?
                f_530_15405_15469(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetMetadata(peReference, messageProvider, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 15405, 15469);
                    return return_v;
                }


                bool
                f_530_15521_15547(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 15521, 15547);
                    return return_v;
                }


                int
                f_530_15488_15548(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 15488, 15548);
                    return 0;
                }


                bool
                f_530_15975_16009(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.IsValidAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 15975, 16009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly?
                f_530_16098_16128(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 16098, 16128);
                    return return_v;
                }


                int
                f_530_16163_16195(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 16163, 16195);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_530_16303_16320(Microsoft.CodeAnalysis.PEAssembly
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 16303, 16320);
                    return return_v;
                }


                int
                f_530_16409_16433_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 16409, 16433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference?
                f_530_16250_16665(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 16250, 16665);
                    return return_v;
                }


                int
                f_530_16805_16895(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                primaryReference, Microsoft.CodeAnalysis.MetadataReference
                newReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                lazyAliasMap)
                {
                    this_param.MergeReferenceProperties(primaryReference, newReference, diagnostics, ref lazyAliasMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 16805, 16895);
                    return 0;
                }


                Microsoft.CodeAnalysis.DocumentationProvider
                f_530_17191_17224(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.DocumentationProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17191, 17224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_17320_17339(TCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17320, 17339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImportOptions
                f_530_17320_17361(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataImportOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17320, 17361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                f_530_17028_17441(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PEAssembly
                assembly, Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
                cachedSymbols, Microsoft.CodeAnalysis.DocumentationProvider
                documentationProvider, string
                sourceAssemblySimpleName, Microsoft.CodeAnalysis.MetadataImportOptions
                importOptions, bool
                embedInteropTypes)
                {
                    var return_v = this_param.CreateAssemblyDataForFile(assembly, cachedSymbols, documentationProvider, sourceAssemblySimpleName, importOptions, embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 17028, 17441);
                    return return_v;
                }


                int
                f_530_17478_17547(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData
                data, int
                referenceIndex, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference[]
                referenceMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                assemblies)
                {
                    AddAssembly(data, referenceIndex, referenceMap, assemblies);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 17478, 17547);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_17694_17709()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17694, 17709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_17727_17742()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17727, 17742);
                    return return_v;
                }


                int
                f_530_17727_17770(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17727, 17770);
                    return return_v;
                }


                string?
                f_530_17782_17801(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 17782, 17801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_17694_17808(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 17694, 17808);
                    return return_v;
                }


                int
                f_530_17678_17809(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 17678, 17809);
                    return 0;
                }


                int
                f_530_17947_17977(Microsoft.CodeAnalysis.AssemblyMetadata
                obj)
                {
                    GC.KeepAlive((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 17947, 17977);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_530_18182_18203(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18182, 18203);
                    return return_v;
                }


                bool
                f_530_18182_18218(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.IsLinkedModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18182, 18218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_530_18504_18525(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18504, 18525);
                    return return_v;
                }


                bool
                f_530_18503_18548_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18503, 18548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_18638_18653()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18638, 18653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_18671_18686()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18671, 18686);
                    return return_v;
                }


                int
                f_530_18671_18736(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_LinkedNetmoduleMetadataMustProvideFullPEImage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18671, 18736);
                    return return_v;
                }


                string?
                f_530_18748_18767(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18748, 18767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_18638_18774(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 18638, 18774);
                    return return_v;
                }


                int
                f_530_18622_18775(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 18622, 18775);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_530_18857_18878(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 18857, 18878);
                    return return_v;
                }


                int
                f_530_18847_18933(Microsoft.CodeAnalysis.PEModule
                module, int
                referenceIndex, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference[]
                referenceMap, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>?
                modules)
                {
                    AddModule(module, referenceIndex, referenceMap, ref modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 18847, 18933);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_19080_19095()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 19080, 19095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_19113_19128()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 19113, 19128);
                    return return_v;
                }


                int
                f_530_19113_19154(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 19113, 19154);
                    return return_v;
                }


                string?
                f_530_19166_19185(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 19166, 19185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_19080_19192(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 19080, 19192);
                    return return_v;
                }


                int
                f_530_19064_19193(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 19064, 19193);
                    return 0;
                }


                System.Exception
                f_530_19333_19396(Microsoft.CodeAnalysis.MetadataImageKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 19333, 19396);
                    return return_v;
                }


                int
                f_530_19541_19584(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 19541, 19584);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_530_19630_19676(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 19630, 19676);
                    return return_v;
                }


                int
                f_530_20210_20229(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 20210, 20229);
                    return return_v;
                }


                bool
                f_530_20272_20298_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 20272, 20298);
                    return return_v;
                }


                int
                f_530_20407_20430(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 20407, 20430);
                    return return_v;
                }


                int?
                f_530_20433_20458_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 20433, 20458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference
                f_530_20582_20691(Microsoft.CodeAnalysis.MetadataReference
                reference, int
                index, Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>?
                propertyMapOpt)
                {
                    var return_v = GetResolvedReferenceAndFreePropertyMapEntry(reference, index, kind, propertyMapOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 20582, 20691);
                    return return_v;
                }


                int
                f_530_20742_20777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 20742, 20777);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                f_530_20805_20843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 20805, 20843);
                    return return_v;
                }


                int
                f_530_21031_21067(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21031, 21067);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                f_530_21096_21135(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PEModule>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21096, 21135);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                f_530_21174_21214(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference[]
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 21174, 21214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 9367, 21226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 9367, 21226);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 22896, 24792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23076, 23103);

                Metadata?
                existingMetadata
                = default(Metadata?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23125, 23141);

                lock (ObservedMetadata)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23175, 23334) || true) && (f_530_23179_23249(this, peReference, diagnostics, out existingMetadata))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 23175, 23334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23291, 23315);

                        return existingMetadata;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 23175, 23334);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23365, 23387);

                Metadata?
                newMetadata
                = default(Metadata?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23401, 23434);

                Diagnostic?
                newDiagnostic = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23484, 23530);

                    newMetadata = f_530_23498_23529(peReference);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23622, 23912) || true) && (newMetadata is AssemblyMetadata assemblyMetadata)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 23622, 23912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23716, 23755);

                        _ = f_530_23720_23754(assemblyMetadata);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 23622, 23912);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 23622, 23912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 23837, 23893);

                        _ = f_530_23841_23892(f_530_23841_23877(((ModuleMetadata)newMetadata)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 23622, 23912);
                    }
                }
                catch (Exception e) when (e is BadImageFormatException || (DynAbs.Tracing.TraceSender.Expression_False(530, 23967, 24015) || e is IOException))
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(530, 23941, 24253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24049, 24201);

                    newDiagnostic = f_530_24065_24200(e, messageProvider, location, f_530_24145_24164(peReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(530, 24145, 24170) ?? ""), peReference.Properties.Kind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24219, 24238);

                    newMetadata = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(530, 23941, 24253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24275, 24291);

                lock (ObservedMetadata)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24325, 24484) || true) && (f_530_24329_24399(this, peReference, diagnostics, out existingMetadata))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 24325, 24484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24441, 24465);

                        return existingMetadata;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 24325, 24484);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24504, 24621) || true) && (newDiagnostic != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 24504, 24621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24571, 24602);

                        f_530_24571_24601(diagnostics, newDiagnostic);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 24504, 24621);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24641, 24729);

                    f_530_24641_24728(
                                    ObservedMetadata, peReference, (MetadataOrDiagnostic?)newMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(530, 24675, 24727) ?? newDiagnostic!));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 24747, 24766);

                    return newMetadata;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 22896, 24792);

                bool
                f_530_23179_23249(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.Metadata?
                metadata)
                {
                    var return_v = this_param.TryGetObservedMetadata(peReference, diagnostics, out metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 23179, 23249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata
                f_530_23498_23529(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.GetMetadataNoCopy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 23498, 23529);
                    return return_v;
                }


                bool
                f_530_23720_23754(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.IsValidAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 23720, 23754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_530_23841_23877(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 23841, 23877);
                    return return_v;
                }


                bool
                f_530_23841_23892(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.IsLinkedModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 23841, 23892);
                    return return_v;
                }


                string?
                f_530_24145_24164(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 24145, 24164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_24065_24200(System.Exception
                e, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.Location
                location, string
                display, Microsoft.CodeAnalysis.MetadataImageKind
                kind)
                {
                    var return_v = PortableExecutableReference.ExceptionToDiagnostic(e, messageProvider, location, display, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 24065, 24200);
                    return return_v;
                }


                bool
                f_530_24329_24399(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.Metadata?
                metadata)
                {
                    var return_v = this_param.TryGetObservedMetadata(peReference, diagnostics, out metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 24329, 24399);
                    return return_v;
                }


                int
                f_530_24571_24601(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 24571, 24601);
                    return 0;
                }


                int
                f_530_24641_24728(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                key, object
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.MetadataReference)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 24641, 24728);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 22896, 24792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 22896, 24792);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 25450, 26312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25589, 25674);

                var
                metadata = f_530_25604_25673(this, peReference, f_530_25629_25644(), f_530_25646_25659(), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25688, 25749);

                f_530_25688_25748(metadata != null || (DynAbs.Tracing.TraceSender.Expression_False(530, 25701, 25747) || f_530_25721_25747(diagnostics)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25765, 25846) || true) && (metadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 25765, 25846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25819, 25831);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 25765, 25846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25932, 25984);

                var
                assemblyMetadata = metadata as AssemblyMetadata
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 25998, 26261) || true) && (f_530_26002_26037_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(assemblyMetadata, 530, 26002, 26037)?.IsValidAssembly()) != true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 25998, 26261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26079, 26216);

                    f_530_26079_26215(diagnostics, f_530_26095_26214(f_530_26095_26110(), f_530_26128_26171(f_530_26128_26143()), f_530_26173_26186(), f_530_26188_26207(peReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(530, 26188, 26213) ?? "")));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26234, 26246);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 25998, 26261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 26277, 26301);

                return assemblyMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 25450, 26312);

                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_25629_25644()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 25629, 25644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_530_25646_25659()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 25646, 25659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Metadata?
                f_530_25604_25673(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.PortableExecutableReference
                peReference, Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetMetadata(peReference, messageProvider, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 25604, 25673);
                    return return_v;
                }


                bool
                f_530_25721_25747(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 25721, 25747);
                    return return_v;
                }


                int
                f_530_25688_25748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 25688, 25748);
                    return 0;
                }


                bool?
                f_530_26002_26037_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 26002, 26037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_26095_26110()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 26095, 26110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_26128_26143()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 26128, 26143);
                    return return_v;
                }


                int
                f_530_26128_26171(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 26128, 26171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_530_26173_26186()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 26173, 26186);
                    return return_v;
                }


                string?
                f_530_26188_26207(Microsoft.CodeAnalysis.PortableExecutableReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 26188, 26207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_26095_26214(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 26095, 26214);
                    return return_v;
                }


                int
                f_530_26079_26215(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 26079, 26215);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 25450, 26312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 25450, 26312);
            }
            throw new System.Exception("Slicer error: unreachable code");
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 28237, 29140);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28458, 28590) || true) && (!f_530_28463_28534(this, newReference, primaryReference, diagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 28458, 28590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28568, 28575);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 28458, 28590);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28606, 28745) || true) && (lazyAliasMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 28606, 28745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28664, 28730);

                    lazyAliasMap = f_530_28679_28729();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 28606, 28745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28761, 28790);

                MergedAliases?
                mergedAliases
                = default(MergedAliases?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28804, 29079) || true) && (!f_530_28809_28870(lazyAliasMap, primaryReference, out mergedAliases))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 28804, 29079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28904, 28940);

                    mergedAliases = f_530_28920_28939();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 28958, 29008);

                    f_530_28958_29007(lazyAliasMap, primaryReference, mergedAliases);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29026, 29064);

                    f_530_29026_29063(mergedAliases, primaryReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 28804, 29079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 29095, 29129);

                f_530_29095_29128(
                            mergedAliases, newReference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 28237, 29140);

                bool
                f_530_28463_28534(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                primaryReference, Microsoft.CodeAnalysis.MetadataReference
                duplicateReference, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckPropertiesConsistency(primaryReference, duplicateReference, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 28463, 28534);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>
                f_530_28679_28729()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 28679, 28729);
                    return return_v;
                }


                bool
                f_530_28809_28870(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, out Microsoft.CodeAnalysis.MergedAliases?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 28809, 28870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MergedAliases
                f_530_28920_28939()
                {
                    var return_v = new Microsoft.CodeAnalysis.MergedAliases();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 28920, 28939);
                    return return_v;
                }


                int
                f_530_28958_29007(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.MergedAliases>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, Microsoft.CodeAnalysis.MergedAliases
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 28958, 29007);
                    return 0;
                }


                int
                f_530_29026_29063(Microsoft.CodeAnalysis.MergedAliases
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    this_param.Merge(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 29026, 29063);
                    return 0;
                }


                int
                f_530_29095_29128(Microsoft.CodeAnalysis.MergedAliases
                this_param, Microsoft.CodeAnalysis.MetadataReference
                reference)
                {
                    this_param.Merge(reference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 29095, 29128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 28237, 29140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 28237, 29140);
            }
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
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 30654, 36854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31039, 31131);

                var
                referencedAssembly = f_530_31064_31130(identity, reference, assemblyIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31147, 31206);

                List<ReferencedAssemblyIdentity>?
                sameSimpleNameIdentities
                = default(List<ReferencedAssemblyIdentity>?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31220, 31486) || true) && (!f_530_31225_31304(referencesBySimpleName, f_530_31260_31273(identity), out sameSimpleNameIdentities))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 31220, 31486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31338, 31441);

                    f_530_31338_31440(referencesBySimpleName, f_530_31365_31378(identity), new List<ReferencedAssemblyIdentity> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => referencedAssembly, 530, 31380, 31439) });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31459, 31471);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 31220, 31486);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31502, 32451) || true) && (supersedeLowerVersions)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 31502, 32451);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31562, 31872);
                        foreach (var other in f_530_31584_31608_I(sameSimpleNameIdentities))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 31562, 31872);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31650, 31689);

                            f_530_31650_31688(other.Identity is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31711, 31853) || true) && (f_530_31715_31731(identity) == f_530_31735_31757(other.Identity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 31711, 31853);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 31807, 31830);

                                return other.Reference;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 31711, 31853);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 31562, 31872);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 311);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 311);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32015, 32404) || true) && (f_530_32019_32064(sameSimpleNameIdentities[0].Identity!) > f_530_32067_32083(identity))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 32015, 32404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32125, 32174);

                        f_530_32125_32173(sameSimpleNameIdentities, referencedAssembly);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 32015, 32404);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 32015, 32404);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32256, 32314);

                        f_530_32256_32313(sameSimpleNameIdentities, f_530_32285_32312(sameSimpleNameIdentities, 0));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32336, 32385);

                        sameSimpleNameIdentities[0] = referencedAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 32015, 32404);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32424, 32436);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 31502, 32451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32467, 32543);

                ReferencedAssemblyIdentity
                equivalent = default(ReferencedAssemblyIdentity)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32557, 34123) || true) && (f_530_32561_32582(identity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 32557, 34123);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 32616, 33604);
                        foreach (var other in f_530_32638_32662_I(sameSimpleNameIdentities))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 32616, 33604);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33173, 33212);

                            f_530_33173_33211(other.Identity is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33234, 33585) || true) && (f_530_33238_33265(other.Identity) && (DynAbs.Tracing.TraceSender.Expression_True(530, 33238, 33363) && f_530_33294_33363(IdentityComparer, identity, other.Identity)) && (DynAbs.Tracing.TraceSender.Expression_True(530, 33238, 33461) && f_530_33392_33461(IdentityComparer, other.Identity, identity)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 33234, 33585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33511, 33530);

                                equivalent = other;
                                DynAbs.Tracing.TraceSender.TraceBreak(530, 33556, 33562);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 33234, 33585);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 32616, 33604);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 989);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 32557, 34123);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 32557, 34123);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33670, 34108);
                        foreach (var other in f_530_33692_33716_I(sameSimpleNameIdentities))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 33670, 34108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33810, 33849);

                            f_530_33810_33848(other.Identity is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 33871, 34089) || true) && (f_530_33875_33903_M(!other.Identity.IsStrongName) && (DynAbs.Tracing.TraceSender.Expression_True(530, 33875, 33965) && f_530_33907_33965(this, identity, other.Identity)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 33871, 34089);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34015, 34034);

                                equivalent = other;
                                DynAbs.Tracing.TraceSender.TraceBreak(530, 34060, 34066);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 33871, 34089);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 33670, 34108);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 439);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 439);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 32557, 34123);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34139, 34298) || true) && (equivalent.Identity == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 34139, 34298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34204, 34253);

                    f_530_34204_34252(sameSimpleNameIdentities, referencedAssembly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34271, 34283);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 34139, 34298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34382, 36742) || true) && (f_530_34386_34407(identity))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 34382, 36742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34441, 34488);

                    f_530_34441_34487(f_530_34454_34486(equivalent.Identity));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 34587, 35237) || true) && (identity != equivalent.Identity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 34587, 35237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 35075, 35218);

                        f_530_35075_35217(f_530_35075_35090(), diagnostics, location, reference, identity, equivalent.Reference!, equivalent.Identity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 34587, 35237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 34382, 36742);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 34382, 36742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 35851, 35899);

                    f_530_35851_35898(f_530_35864_35897_M(!equivalent.Identity.IsStrongName));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 36490, 36727) || true) && (identity != equivalent.Identity)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 36490, 36727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 36567, 36708);

                        f_530_36567_36707(f_530_36567_36582(), diagnostics, location, reference, identity, equivalent.Reference!, equivalent.Identity);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 36490, 36727);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(530, 34382, 36742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 36758, 36801);

                f_530_36758_36800(equivalent.Reference != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 36815, 36843);

                return equivalent.Reference;
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 30654, 36854);

                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                f_530_31064_31130(Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.MetadataReference
                reference, int
                relativeAssemblyIndex)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity(identity, reference, relativeAssemblyIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 31064, 31130);
                    return return_v;
                }


                string
                f_530_31260_31273(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 31260, 31273);
                    return return_v;
                }


                bool
                f_530_31225_31304(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                this_param, string
                key, out System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 31225, 31304);
                    return return_v;
                }


                string
                f_530_31365_31378(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 31365, 31378);
                    return return_v;
                }


                int
                f_530_31338_31440(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                this_param, string
                key, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 31338, 31440);
                    return 0;
                }


                int
                f_530_31650_31688(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 31650, 31688);
                    return 0;
                }


                System.Version
                f_530_31715_31731(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 31715, 31731);
                    return return_v;
                }


                System.Version
                f_530_31735_31757(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 31735, 31757);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                f_530_31584_31608_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 31584, 31608);
                    return return_v;
                }


                System.Version
                f_530_32019_32064(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 32019, 32064);
                    return return_v;
                }


                System.Version
                f_530_32067_32083(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 32067, 32083);
                    return return_v;
                }


                int
                f_530_32125_32173(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 32125, 32173);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                f_530_32285_32312(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 32285, 32312);
                    return return_v;
                }


                int
                f_530_32256_32313(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 32256, 32313);
                    return 0;
                }


                bool
                f_530_32561_32582(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 32561, 32582);
                    return return_v;
                }


                int
                f_530_33173_33211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33173, 33211);
                    return 0;
                }


                bool
                f_530_33238_33265(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 33238, 33265);
                    return return_v;
                }


                bool
                f_530_33294_33363(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.ReferenceMatchesDefinition(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33294, 33363);
                    return return_v;
                }


                bool
                f_530_33392_33461(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.ReferenceMatchesDefinition(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33392, 33461);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                f_530_32638_32662_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 32638, 32662);
                    return return_v;
                }


                int
                f_530_33810_33848(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33810, 33848);
                    return 0;
                }


                bool
                f_530_33875_33903_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 33875, 33903);
                    return return_v;
                }


                bool
                f_530_33907_33965(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                identity1, Microsoft.CodeAnalysis.AssemblyIdentity
                identity2)
                {
                    var return_v = this_param.WeakIdentityPropertiesEquivalent(identity1, identity2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33907, 33965);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                f_530_33692_33716_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 33692, 33716);
                    return return_v;
                }


                int
                f_530_34204_34252(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param, Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 34204, 34252);
                    return 0;
                }


                bool
                f_530_34386_34407(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 34386, 34407);
                    return return_v;
                }


                bool
                f_530_34454_34486(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 34454, 34486);
                    return return_v;
                }


                int
                f_530_34441_34487(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 34441, 34487);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_35075_35090()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 35075, 35090);
                    return return_v;
                }


                int
                f_530_35075_35217(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.MetadataReference
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.MetadataReference
                equivalentReference, Microsoft.CodeAnalysis.AssemblyIdentity
                equivalentIdentity)
                {
                    this_param.ReportDuplicateMetadataReferenceStrong(diagnostics, location, reference, identity, equivalentReference, equivalentIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 35075, 35217);
                    return 0;
                }


                bool
                f_530_35864_35897_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 35864, 35897);
                    return return_v;
                }


                int
                f_530_35851_35898(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 35851, 35898);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_36567_36582()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 36567, 36582);
                    return return_v;
                }


                int
                f_530_36567_36707(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.MetadataReference
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                identity, Microsoft.CodeAnalysis.MetadataReference
                equivalentReference, Microsoft.CodeAnalysis.AssemblyIdentity
                equivalentIdentity)
                {
                    this_param.ReportDuplicateMetadataReferenceWeak(diagnostics, location, reference, identity, equivalentReference, equivalentIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 36567, 36707);
                    return 0;
                }


                int
                f_530_36758_36800(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 36758, 36800);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 30654, 36854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 30654, 36854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void GetCompilationReferences(
                    TCompilation compilation,
                    DiagnosticBag diagnostics,
                    out ImmutableArray<MetadataReference> references,
                    out IDictionary<(string, string), MetadataReference> boundReferenceDirectives,
                    out ImmutableArray<Location> referenceDirectiveLocations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(530, 36866, 41138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37236, 37334);

                ArrayBuilder<MetadataReference>
                referencesBuilder = f_530_37288_37333()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37348, 37414);

                ArrayBuilder<Location>?
                referenceDirectiveLocationsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37428, 37515);

                IDictionary<(string, string), MetadataReference>?
                localBoundReferenceDirectives = null
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37567, 39644);
                        foreach (var referenceDirective in f_530_37602_37633_I(f_530_37602_37633(compilation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 37567, 39644);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37675, 37727);

                            f_530_37675_37726(referenceDirective.Location is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37751, 38044) || true) && (f_530_37755_37800(f_530_37755_37774(compilation)) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 37751, 38044);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 37858, 37989);

                                f_530_37858_37988(diagnostics, f_530_37874_37987(f_530_37874_37889(), f_530_37907_37957(f_530_37907_37922()), referenceDirective.Location));
                                DynAbs.Tracing.TraceSender.TraceBreak(530, 38015, 38021);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 37751, 38044);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38146, 38194);

                            f_530_38146_38193(referenceDirective.File is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38216, 38279);

                            f_530_38216_38278(f_530_38229_38267(referenceDirective.Location) is object);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38301, 38545) || true) && (localBoundReferenceDirectives != null && (DynAbs.Tracing.TraceSender.Expression_True(530, 38305, 38463) && f_530_38346_38463(localBoundReferenceDirectives, (f_530_38389_38436(f_530_38389_38427(referenceDirective.Location)), referenceDirective.File))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 38301, 38545);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38513, 38522);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 38301, 38545);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38569, 38698);

                            MetadataReference?
                            boundReference = f_530_38605_38697(referenceDirective.File, referenceDirective.Location, compilation)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38720, 39000) || true) && (boundReference == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 38720, 39000);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38796, 38942);

                                f_530_38796_38941(diagnostics, f_530_38812_38940(f_530_38812_38827(), f_530_38845_38885(f_530_38845_38860()), referenceDirective.Location, referenceDirective.File));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 38968, 38977);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 38720, 39000);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39024, 39324) || true) && (localBoundReferenceDirectives == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 39024, 39324);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39115, 39201);

                                localBoundReferenceDirectives = f_530_39147_39200();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39227, 39301);

                                referenceDirectiveLocationsBuilder = f_530_39264_39300();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(530, 39024, 39324);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39348, 39386);

                            f_530_39348_39385(
                                                referencesBuilder, boundReference);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39408, 39477);

                            f_530_39408_39476(referenceDirectiveLocationsBuilder!, referenceDirective.Location);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39499, 39625);

                            f_530_39499_39624(localBoundReferenceDirectives, (f_530_39534_39581(f_530_39534_39572(referenceDirective.Location)), referenceDirective.File), boundReference);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(530, 37567, 39644);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(530, 1, 2078);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(530, 1, 2078);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39753, 39812);

                    f_530_39753_39811(
                                    // add external reference at the end, so that they are processed first:
                                    referencesBuilder, f_530_39780_39810(compilation));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 39916, 40009);

                    var
                    previousScriptCompilation = f_530_39948_40008_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_530_39948_39981(compilation), 530, 39948, 40008)?.PreviousScriptCompilation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40027, 40225) || true) && (previousScriptCompilation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 40027, 40225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40106, 40206);

                        f_530_40106_40205(referencesBuilder, f_530_40133_40204(f_530_40133_40185(previousScriptCompilation)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 40027, 40225);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40245, 40528) || true) && (localBoundReferenceDirectives == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(530, 40245, 40528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40399, 40509);

                        localBoundReferenceDirectives = f_530_40431_40508();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(530, 40245, 40528);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40548, 40605);

                    boundReferenceDirectives = localBoundReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40623, 40668);

                    references = f_530_40636_40667(referencesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 40686, 40807);

                    referenceDirectiveLocations = f_530_40716_40772_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(referenceDirectiveLocationsBuilder, 530, 40716, 40772)?.ToImmutableAndFree()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>?>(530, 40716, 40806) ?? ImmutableArray<Location>.Empty);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(530, 40836, 41127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41087, 41112);

                    f_530_41087_41111(                // Put this in a finally because we have tests that (intentionally) cause ResolveReferenceDirective to throw and 
                                                      // we don't want to clutter the test output with leak reports.
                                    referencesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(530, 40836, 41127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(530, 36866, 41138);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                f_530_37288_37333()
                {
                    var return_v = ArrayBuilder<MetadataReference>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 37288, 37333);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ReferenceDirective>
                f_530_37602_37633(TCompilation
                this_param)
                {
                    var return_v = this_param.ReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37602, 37633);
                    return return_v;
                }


                int
                f_530_37675_37726(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 37675, 37726);
                    return 0;
                }


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_37755_37774(TCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37755, 37774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReferenceResolver?
                f_530_37755_37800(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.MetadataReferenceResolver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37755, 37800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_37874_37889()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37874, 37889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_37907_37922()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37907, 37922);
                    return return_v;
                }


                int
                f_530_37907_37957(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataReferencesNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 37907, 37957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_37874_37987(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = this_param.CreateDiagnostic(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 37874, 37987);
                    return return_v;
                }


                int
                f_530_37858_37988(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 37858, 37988);
                    return 0;
                }


                int
                f_530_38146_38193(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38146, 38193);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_530_38229_38267(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38229, 38267);
                    return return_v;
                }


                int
                f_530_38216_38278(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38216, 38278);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_530_38389_38427(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38389, 38427);
                    return return_v;
                }


                string
                f_530_38389_38436(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38389, 38436);
                    return return_v;
                }


                bool
                f_530_38346_38463(System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                this_param, (string FilePath, string File)
                key)
                {
                    var return_v = this_param.ContainsKey(((string, string))key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38346, 38463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference?
                f_530_38605_38697(string
                reference, Microsoft.CodeAnalysis.Location
                location, TCompilation
                compilation)
                {
                    var return_v = ResolveReferenceDirective(reference, location, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38605, 38697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_38812_38827()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38812, 38827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_530_38845_38860()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38845, 38860);
                    return return_v;
                }


                int
                f_530_38845_38885(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_MetadataFileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 38845, 38885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_530_38812_38940(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = this_param.CreateDiagnostic(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38812, 38940);
                    return return_v;
                }


                int
                f_530_38796_38941(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 38796, 38941);
                    return 0;
                }


                System.Collections.Generic.Dictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                f_530_39147_39200()
                {
                    var return_v = new System.Collections.Generic.Dictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39147, 39200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                f_530_39264_39300()
                {
                    var return_v = ArrayBuilder<Location>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39264, 39300);
                    return return_v;
                }


                int
                f_530_39348_39385(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39348, 39385);
                    return 0;
                }


                int
                f_530_39408_39476(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39408, 39476);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_530_39534_39572(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 39534, 39572);
                    return return_v;
                }


                string
                f_530_39534_39581(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 39534, 39581);
                    return return_v;
                }


                int
                f_530_39499_39624(System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                this_param, (string FilePath, string File)
                key, Microsoft.CodeAnalysis.MetadataReference
                value)
                {
                    this_param.Add(((string, string))key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39499, 39624);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ReferenceDirective>
                f_530_37602_37633_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ReferenceDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 37602, 37633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_530_39780_39810(TCompilation
                this_param)
                {
                    var return_v = this_param.ExternalReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 39780, 39810);
                    return return_v;
                }


                int
                f_530_39753_39811(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 39753, 39811);
                    return 0;
                }


                Microsoft.CodeAnalysis.ScriptCompilationInfo?
                f_530_39948_39981(TCompilation
                this_param)
                {
                    var return_v = this_param.ScriptCompilationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 39948, 39981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation?
                f_530_39948_40008_M(Microsoft.CodeAnalysis.Compilation?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 39948, 40008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager
                f_530_40133_40185(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GetBoundReferenceManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 40133, 40185);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_530_40133_40204(Microsoft.CodeAnalysis.CommonReferenceManager
                this_param)
                {
                    var return_v = this_param.ExplicitReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 40133, 40204);
                    return return_v;
                }


                int
                f_530_40106_40205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 40106, 40205);
                    return 0;
                }


                System.Collections.Generic.IDictionary<(string, string), Microsoft.CodeAnalysis.MetadataReference>
                f_530_40431_40508()
                {
                    var return_v = SpecializedCollections.EmptyDictionary<(string, string), MetadataReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 40431, 40508);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.MetadataReference>
                f_530_40636_40667(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 40636, 40667);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>?
                f_530_40716_40772_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 40716, 40772);
                    return return_v;
                }


                int
                f_530_41087_41111(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.MetadataReference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(530, 41087, 41111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(530, 36866, 41138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(530, 36866, 41138);
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

                f_530_41630_41697(f_530_41643_41688(f_530_41643_41662(compilation)) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(530, 41714, 41880);

                var
                references = f_530_41731_41879(f_530_41731_41776(f_530_41731_41750(compilation)), reference, basePath, MetadataReferenceProperties.Assembly.WithRecursiveAliases(true))
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


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_41643_41662(TCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41643, 41662);
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


                Microsoft.CodeAnalysis.CompilationOptions
                f_530_41731_41750(TCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(530, 41731, 41750);
                    return return_v;
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
