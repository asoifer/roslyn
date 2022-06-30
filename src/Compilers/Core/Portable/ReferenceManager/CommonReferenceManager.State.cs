// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    using MetadataOrDiagnostic = System.Object;
    internal abstract class CommonReferenceManager
    {
        internal static object SymbolCacheAndReferenceManagerStateGuard;

        internal abstract IEnumerable<KeyValuePair<MetadataReference, IAssemblySymbolInternal>> GetReferencedAssemblies();

        internal abstract IEnumerable<(IAssemblySymbolInternal, ImmutableArray<string>)> GetReferencedAssemblyAliases();

        internal abstract MetadataReference? GetMetadataReference(IAssemblySymbolInternal? assemblySymbol);

        internal abstract ImmutableArray<MetadataReference> ExplicitReferences { get; }

        internal abstract ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> ImplicitReferenceResolutions { get; }

        public CommonReferenceManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(531, 610, 2182);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(531, 610, 2182);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 610, 2182);
        }


        static CommonReferenceManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(531, 610, 2182);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 1322, 1377);
            SymbolCacheAndReferenceManagerStateGuard = f_531_1365_1377(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(531, 610, 2182);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 610, 2182);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(531, 610, 2182);

        static object
        f_531_1365_1377()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 1365, 1377);
            return return_v;
        }

    }
    internal partial class CommonReferenceManager<TCompilation, TAssemblySymbol> : CommonReferenceManager
    {
        internal readonly string SimpleAssemblyName;

        internal readonly AssemblyIdentityComparer IdentityComparer;

        internal readonly Dictionary<MetadataReference, MetadataOrDiagnostic> ObservedMetadata;

        private int _isBound;

        private ThreeState _lazyHasCircularReference;

        private Dictionary<MetadataReference, int>? _lazyReferencedAssembliesMap;

        private Dictionary<MetadataReference, int>? _lazyReferencedModuleIndexMap;

        private IDictionary<(string, string), MetadataReference>? _lazyReferenceDirectiveMap;

        private ImmutableArray<MetadataReference> _lazyDirectiveReferences;

        private ImmutableArray<MetadataReference> _lazyExplicitReferences;

        private ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?>? _lazyImplicitReferenceResolutions;

        private ImmutableArray<Diagnostic> _lazyDiagnostics;

        private TAssemblySymbol? _lazyCorLibraryOpt;

        private ImmutableArray<PEModule> _lazyReferencedModules;

        private ImmutableArray<ModuleReferences<TAssemblySymbol>> _lazyReferencedModulesReferences;

        private ImmutableArray<TAssemblySymbol> _lazyReferencedAssemblies;

        private ImmutableArray<ImmutableArray<string>> _lazyAliasesOfReferencedAssemblies;

        private ImmutableArray<UnifiedAssembly<TAssemblySymbol>> _lazyUnifiedAssemblies;

        public CommonReferenceManager(string simpleAssemblyName, AssemblyIdentityComparer identityComparer, Dictionary<MetadataReference, MetadataOrDiagnostic>? observedMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(531, 9721, 10253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 2713, 2731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 2983, 2999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 3309, 3325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 3493, 3501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 3836, 3861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 4174, 4202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 4736, 4765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 5138, 5164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 6950, 6983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 7988, 8006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 9916, 9957);

                f_531_9916_9956(simpleAssemblyName != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 9971, 10010);

                f_531_9971_10009(identityComparer != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10026, 10071);

                this.SimpleAssemblyName = simpleAssemblyName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10085, 10126);

                this.IdentityComparer = identityComparer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10140, 10242);

                this.ObservedMetadata = observedMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>?>(531, 10164, 10241) ?? f_531_10184_10241());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(531, 9721, 10253);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 9721, 10253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 9721, 10253);
            }
        }

        internal ImmutableArray<Diagnostic> Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 10337, 10444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10373, 10387);

                    f_531_10373_10386(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10405, 10429);

                    return _lazyDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 10337, 10444);

                    int
                    f_531_10373_10386(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 10373, 10386);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 10265, 10455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 10265, 10455);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasCircularReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 10526, 10661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10562, 10576);

                    f_531_10562_10575(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10594, 10646);

                    return _lazyHasCircularReference == ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 10526, 10661);

                    int
                    f_531_10562_10575(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 10562, 10575);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 10467, 10672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 10467, 10672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Dictionary<MetadataReference, int> ReferencedAssembliesMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 10776, 10895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10812, 10826);

                    f_531_10812_10825(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 10844, 10880);

                    return _lazyReferencedAssembliesMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 10776, 10895);

                    int
                    f_531_10812_10825(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 10812, 10825);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 10684, 10906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 10684, 10906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Dictionary<MetadataReference, int> ReferencedModuleIndexMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 11011, 11131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11047, 11061);

                    f_531_11047_11060(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11079, 11116);

                    return _lazyReferencedModuleIndexMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 11011, 11131);

                    int
                    f_531_11047_11060(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 11047, 11060);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 10918, 11142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 10918, 11142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IDictionary<(string, string), MetadataReference> ReferenceDirectiveMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 11258, 11375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11294, 11308);

                    f_531_11294_11307(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11326, 11360);

                    return _lazyReferenceDirectiveMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 11258, 11375);

                    int
                    f_531_11294_11307(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 11294, 11307);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 11154, 11386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 11154, 11386);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<MetadataReference> DirectiveReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 11485, 11600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11521, 11535);

                    f_531_11521_11534(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11553, 11585);

                    return _lazyDirectiveReferences;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 11485, 11600);

                    int
                    f_531_11521_11534(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 11521, 11534);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 11398, 11611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 11398, 11611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> ImplicitReferenceResolutions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 11762, 11886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11798, 11812);

                    f_531_11798_11811(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 11830, 11871);

                    return _lazyImplicitReferenceResolutions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 11762, 11886);

                    int
                    f_531_11798_11811(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 11798, 11811);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 11623, 11897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 11623, 11897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<MetadataReference> ExplicitReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 12004, 12118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12040, 12054);

                    f_531_12040_12053(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12072, 12103);

                    return _lazyExplicitReferences;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 12004, 12118);

                    int
                    f_531_12040_12053(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 12040, 12053);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 11909, 12129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 11909, 12129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TAssemblySymbol? CorLibraryOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 12279, 12388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12315, 12329);

                    f_531_12315_12328(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12347, 12373);

                    return _lazyCorLibraryOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 12279, 12388);

                    int
                    f_531_12315_12328(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 12315, 12328);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 12215, 12399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 12215, 12399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<PEModule> ReferencedModules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 12487, 12600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12523, 12537);

                    f_531_12523_12536(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12555, 12585);

                    return _lazyReferencedModules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 12487, 12600);

                    int
                    f_531_12523_12536(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 12523, 12536);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 12411, 12611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 12411, 12611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<ModuleReferences<TAssemblySymbol>> ReferencedModulesReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 12734, 12857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12770, 12784);

                    f_531_12770_12783(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 12802, 12842);

                    return _lazyReferencedModulesReferences;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 12734, 12857);

                    int
                    f_531_12770_12783(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 12770, 12783);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 12623, 12868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 12623, 12868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<TAssemblySymbol> ReferencedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 12966, 13082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13002, 13016);

                    f_531_13002_13015(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13034, 13067);

                    return _lazyReferencedAssemblies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 12966, 13082);

                    int
                    f_531_13002_13015(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13002, 13015);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 12880, 13093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 12880, 13093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<ImmutableArray<string>> AliasesOfReferencedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 13207, 13332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13243, 13257);

                    f_531_13243_13256(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13275, 13317);

                    return _lazyAliasesOfReferencedAssemblies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 13207, 13332);

                    int
                    f_531_13243_13256(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13243, 13256);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 13105, 13343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 13105, 13343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<UnifiedAssembly<TAssemblySymbol>> UnifiedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 13455, 13568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13491, 13505);

                    f_531_13491_13504(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13523, 13553);

                    return _lazyUnifiedAssemblies;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 13455, 13568);

                    int
                    f_531_13491_13504(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>
                    this_param)
                    {
                        this_param.AssertBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13491, 13504);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 13355, 13579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 13355, 13579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG")]
        internal void AssertUnbound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 13776, 14751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13862, 13890);

                f_531_13862_13889(_isBound == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13904, 13966);

                f_531_13904_13965(_lazyHasCircularReference == ThreeState.Unknown);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 13980, 14031);

                f_531_13980_14030(_lazyReferencedAssembliesMap == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14045, 14097);

                f_531_14045_14096(_lazyReferencedModuleIndexMap == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14111, 14160);

                f_531_14111_14159(_lazyReferenceDirectiveMap == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14174, 14223);

                f_531_14174_14222(_lazyDirectiveReferences.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14237, 14293);

                f_531_14237_14292(_lazyImplicitReferenceResolutions == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14307, 14355);

                f_531_14307_14354(_lazyExplicitReferences.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14369, 14416);

                f_531_14369_14415(_lazyReferencedModules.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14430, 14487);

                f_531_14430_14486(_lazyReferencedModulesReferences.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14501, 14551);

                f_531_14501_14550(_lazyReferencedAssemblies.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14565, 14624);

                f_531_14565_14623(_lazyAliasesOfReferencedAssemblies.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14638, 14685);

                f_531_14638_14684(_lazyUnifiedAssemblies.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 14699, 14740);

                f_531_14699_14739(_lazyCorLibraryOpt == null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 13776, 14751);

                int
                f_531_13862_13889(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13862, 13889);
                    return 0;
                }


                int
                f_531_13904_13965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13904, 13965);
                    return 0;
                }


                int
                f_531_13980_14030(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 13980, 14030);
                    return 0;
                }


                int
                f_531_14045_14096(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14045, 14096);
                    return 0;
                }


                int
                f_531_14111_14159(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14111, 14159);
                    return 0;
                }


                int
                f_531_14174_14222(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14174, 14222);
                    return 0;
                }


                int
                f_531_14237_14292(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14237, 14292);
                    return 0;
                }


                int
                f_531_14307_14354(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14307, 14354);
                    return 0;
                }


                int
                f_531_14369_14415(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14369, 14415);
                    return 0;
                }


                int
                f_531_14430_14486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14430, 14486);
                    return 0;
                }


                int
                f_531_14501_14550(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14501, 14550);
                    return 0;
                }


                int
                f_531_14565_14623(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14565, 14623);
                    return 0;
                }


                int
                f_531_14638_14684(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14638, 14684);
                    return 0;
                }


                int
                f_531_14699_14739(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 14699, 14739);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 13776, 14751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 13776, 14751);
            }
        }

        [Conditional("DEBUG")]
        [MemberNotNull(nameof(_lazyReferencedAssembliesMap), nameof(_lazyReferencedModuleIndexMap), nameof(_lazyReferenceDirectiveMap), nameof(_lazyImplicitReferenceResolutions))]
        internal void AssertBound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 14763, 16035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15028, 15056);

                f_531_15028_15055(_isBound != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15070, 15132);

                f_531_15070_15131(_lazyHasCircularReference != ThreeState.Unknown);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15146, 15197);

                f_531_15146_15196(_lazyReferencedAssembliesMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15211, 15263);

                f_531_15211_15262(_lazyReferencedModuleIndexMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15277, 15326);

                f_531_15277_15325(_lazyReferenceDirectiveMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15340, 15390);

                f_531_15340_15389(f_531_15353_15388_M(!_lazyDirectiveReferences.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15404, 15460);

                f_531_15404_15459(_lazyImplicitReferenceResolutions != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15474, 15523);

                f_531_15474_15522(f_531_15487_15521_M(!_lazyExplicitReferences.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15537, 15585);

                f_531_15537_15584(f_531_15550_15583_M(!_lazyReferencedModules.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15599, 15657);

                f_531_15599_15656(f_531_15612_15655_M(!_lazyReferencedModulesReferences.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15671, 15722);

                f_531_15671_15721(f_531_15684_15720_M(!_lazyReferencedAssemblies.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15736, 15796);

                f_531_15736_15795(f_531_15749_15794_M(!_lazyAliasesOfReferencedAssemblies.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15810, 15858);

                f_531_15810_15857(f_531_15823_15856_M(!_lazyUnifiedAssemblies.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 15942, 16024);

                f_531_15942_16023(_lazyReferencedAssemblies.Length == 0 || (DynAbs.Tracing.TraceSender.Expression_False(531, 15955, 16022) || _lazyCorLibraryOpt != null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 14763, 16035);

                int
                f_531_15028_15055(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15028, 15055);
                    return 0;
                }


                int
                f_531_15070_15131(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15070, 15131);
                    return 0;
                }


                int
                f_531_15146_15196(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15146, 15196);
                    return 0;
                }


                int
                f_531_15211_15262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15211, 15262);
                    return 0;
                }


                int
                f_531_15277_15325(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15277, 15325);
                    return 0;
                }


                bool
                f_531_15353_15388_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15353, 15388);
                    return return_v;
                }


                int
                f_531_15340_15389(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15340, 15389);
                    return 0;
                }


                int
                f_531_15404_15459(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15404, 15459);
                    return 0;
                }


                bool
                f_531_15487_15521_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15487, 15521);
                    return return_v;
                }


                int
                f_531_15474_15522(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15474, 15522);
                    return 0;
                }


                bool
                f_531_15550_15583_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15550, 15583);
                    return return_v;
                }


                int
                f_531_15537_15584(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15537, 15584);
                    return 0;
                }


                bool
                f_531_15612_15655_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15612, 15655);
                    return return_v;
                }


                int
                f_531_15599_15656(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15599, 15656);
                    return 0;
                }


                bool
                f_531_15684_15720_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15684, 15720);
                    return return_v;
                }


                int
                f_531_15671_15721(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15671, 15721);
                    return 0;
                }


                bool
                f_531_15749_15794_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15749, 15794);
                    return return_v;
                }


                int
                f_531_15736_15795(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15736, 15795);
                    return 0;
                }


                bool
                f_531_15823_15856_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 15823, 15856);
                    return return_v;
                }


                int
                f_531_15810_15857(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15810, 15857);
                    return 0;
                }


                int
                f_531_15942_16023(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 15942, 16023);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 14763, 16035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 14763, 16035);
            }
        }

        [Conditional("DEBUG")]
        internal void AssertCanReuseForCompilation(TCompilation compilation)
        {
            Debug.Assert(compilation.MakeSourceAssemblySimpleName() == this.SimpleAssemblyName);
        }

        internal bool IsBound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 16325, 16397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 16361, 16382);

                    return _isBound != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 16325, 16397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 16279, 16408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 16279, 16408);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Call only while holding <see cref="CommonReferenceManager.SymbolCacheAndReferenceManagerStateGuard"/>.
        /// </summary>
        internal void InitializeNoLock(
            Dictionary<MetadataReference, int> referencedAssembliesMap,
            Dictionary<MetadataReference, int> referencedModulesMap,
            IDictionary<(string, string), MetadataReference> boundReferenceDirectiveMap,
            ImmutableArray<MetadataReference> directiveReferences,
            ImmutableArray<MetadataReference> explicitReferences,
            ImmutableDictionary<AssemblyIdentity, PortableExecutableReference?> implicitReferenceResolutions,
            bool containsCircularReferences,
            ImmutableArray<Diagnostic> diagnostics,
            TAssemblySymbol? corLibraryOpt,
            ImmutableArray<PEModule> referencedModules,
            ImmutableArray<ModuleReferences<TAssemblySymbol>> referencedModulesReferences,
            ImmutableArray<TAssemblySymbol> referencedAssemblies,
            ImmutableArray<ImmutableArray<string>> aliasesOfReferencedAssemblies,
            ImmutableArray<UnifiedAssembly<TAssemblySymbol>> unifiedAssemblies)
        {
            AssertUnbound();

            Debug.Assert(referencedModules.Length == referencedModulesReferences.Length);
            Debug.Assert(referencedModules.Length == referencedModulesMap.Count);
            Debug.Assert(referencedAssemblies.Length == aliasesOfReferencedAssemblies.Length);

            _lazyReferencedAssembliesMap = referencedAssembliesMap;
            _lazyReferencedModuleIndexMap = referencedModulesMap;
            _lazyDiagnostics = diagnostics;
            _lazyReferenceDirectiveMap = boundReferenceDirectiveMap;
            _lazyDirectiveReferences = directiveReferences;
            _lazyExplicitReferences = explicitReferences;
            _lazyImplicitReferenceResolutions = implicitReferenceResolutions;

            _lazyCorLibraryOpt = corLibraryOpt;
            _lazyReferencedModules = referencedModules;
            _lazyReferencedModulesReferences = referencedModulesReferences;
            _lazyReferencedAssemblies = referencedAssemblies;
            _lazyAliasesOfReferencedAssemblies = aliasesOfReferencedAssemblies;
            _lazyUnifiedAssemblies = unifiedAssemblies;
            _lazyHasCircularReference = containsCircularReferences.ToThreeState();

            // once we flip this bit the state of the manager is immutable and available to any readers:
            Interlocked.Exchange(ref _isBound, 1);
        }

        private static readonly ImmutableArray<string> s_supersededAlias;

        protected static void BuildReferencedAssembliesAndModulesMaps(
                    BoundInputAssembly[] bindingResult,
                    ImmutableArray<MetadataReference> references,
                    ImmutableArray<ResolvedReference> referenceMap,
                    int referencedModuleCount,
                    int explicitlyReferencedAssemblyCount,
                    IReadOnlyDictionary<string, List<ReferencedAssemblyIdentity>> assemblyReferencesBySimpleName,
                    bool supersedeLowerVersions,
                    out Dictionary<MetadataReference, int> referencedAssembliesMap,
                    out Dictionary<MetadataReference, int> referencedModulesMap,
                    out ImmutableArray<ImmutableArray<string>> aliasesOfReferencedAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(531, 19519, 22707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20254, 20340);

                referencedAssembliesMap = f_531_20280_20339(referenceMap.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20354, 20439);

                referencedModulesMap = f_531_20377_20438(referencedModuleCount);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20453, 20590);

                var
                aliasesOfReferencedAssembliesBuilder = f_531_20496_20589(referenceMap.Length - referencedModuleCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20604, 20637);

                bool
                hasRecursiveAliases = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20662, 20667);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20653, 21694) || true) && (i < referenceMap.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20694, 20697)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(531, 20653, 21694))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 20653, 21694);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20731, 20830) || true) && (referenceMap[i].IsSkipped)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 20731, 20830);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20802, 20811);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 20731, 20830);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20850, 21679) || true) && (referenceMap[i].Kind == MetadataImageKind.Module)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 20850, 21679);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 20999, 21043);

                            int
                            moduleIndex = 1 + referenceMap[i].Index
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21065, 21118);

                            f_531_21065_21117(referencedModulesMap, references[i], moduleIndex);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 20850, 21679);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 20850, 21679);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21255, 21297);

                            int
                            assemblyIndex = referenceMap[i].Index
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21319, 21393);

                            f_531_21319_21392(f_531_21332_21374(aliasesOfReferencedAssembliesBuilder) == assemblyIndex);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21417, 21475);

                            f_531_21417_21474(
                                                referencedAssembliesMap, references[i], assemblyIndex);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21497, 21566);

                            f_531_21497_21565(aliasesOfReferencedAssembliesBuilder, referenceMap[i].AliasesOpt);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21590, 21660);

                            hasRecursiveAliases |= f_531_21613_21659_M(!referenceMap[i].RecursiveAliasesOpt.IsDefault);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 20850, 21679);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 1042);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21710, 21875) || true) && (hasRecursiveAliases)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 21710, 21875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21767, 21860);

                    f_531_21767_21859(bindingResult, referenceMap, aliasesOfReferencedAssembliesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 21710, 21875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21891, 21965);

                f_531_21891_21964(!f_531_21905_21963(aliasesOfReferencedAssembliesBuilder, a => a.IsDefault));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 21981, 22590) || true) && (supersedeLowerVersions)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 21981, 22590);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22041, 22575);
                        foreach (var assemblyReference in f_531_22075_22105_I(assemblyReferencesBySimpleName))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 22041, 22575);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22241, 22246);
                                // the item in the list is the highest version, by construction
                                for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22232, 22556) || true) && (i < f_531_22252_22281(assemblyReference.Value))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22283, 22286)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(531, 22232, 22556))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 22232, 22556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22336, 22435);

                                    int
                                    assemblyIndex = assemblyReference.Value[i].GetAssemblyIndex(explicitlyReferencedAssemblyCount)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22461, 22533);

                                    aliasesOfReferencedAssembliesBuilder[assemblyIndex] = s_supersededAlias;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 325);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 325);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 22041, 22575);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 535);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 21981, 22590);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 22606, 22696);

                aliasesOfReferencedAssemblies = f_531_22638_22695(aliasesOfReferencedAssembliesBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(531, 19519, 22707);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                f_531_20280_20339(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 20280, 20339);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                f_531_20377_20438(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 20377, 20438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                f_531_20496_20589(int
                capacity)
                {
                    var return_v = ArrayBuilder<ImmutableArray<string>>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 20496, 20589);
                    return return_v;
                }


                int
                f_531_21065_21117(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21065, 21117);
                    return 0;
                }


                int
                f_531_21332_21374(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 21332, 21374);
                    return return_v;
                }


                int
                f_531_21319_21392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21319, 21392);
                    return 0;
                }


                int
                f_531_21417_21474(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21417, 21474);
                    return 0;
                }


                int
                f_531_21497_21565(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param, System.Collections.Immutable.ImmutableArray<string>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21497, 21565);
                    return 0;
                }


                bool
                f_531_21613_21659_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 21613, 21659);
                    return return_v;
                }


                int
                f_531_21767_21859(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.BoundInputAssembly[]
                bindingResult, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                referenceMap, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                aliasesOfReferencedAssembliesBuilder)
                {
                    PropagateRecursiveAliases(bindingResult, referenceMap, aliasesOfReferencedAssembliesBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21767, 21859);
                    return 0;
                }


                bool
                f_531_21905_21963(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                builder, System.Func<System.Collections.Immutable.ImmutableArray<string>, bool>
                predicate)
                {
                    var return_v = builder.Any<System.Collections.Immutable.ImmutableArray<string>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21905, 21963);
                    return return_v;
                }


                int
                f_531_21891_21964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 21891, 21964);
                    return 0;
                }


                int
                f_531_22252_22281(System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 22252, 22281);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                f_531_22075_22105_I(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.List<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ReferencedAssemblyIdentity>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 22075, 22105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<string>>
                f_531_22638_22695(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 22638, 22695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 19519, 22707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 19519, 22707);
            }
        }

        internal static ImmutableDictionary<AssemblyIdentity, AssemblyIdentity> GetAssemblyReferenceIdentityBaselineMap(ImmutableArray<TAssemblySymbol> symbols, ImmutableArray<AssemblyIdentity> originalIdentities)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(531, 23610, 25510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 23840, 23898);

                f_531_23840_23897(originalIdentities.Length == symbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 23914, 23998);

                ImmutableDictionary<AssemblyIdentity, AssemblyIdentity>.Builder?
                lazyBuilder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24021, 24026);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24012, 25384) || true) && (i < originalIdentities.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24059, 24062)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(531, 24012, 25384))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 24012, 25384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24096, 24137);

                        var
                        symbolIdentity = symbols[i].Identity
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24155, 24210);

                        var
                        versionPattern = symbols[i].AssemblyVersionPattern
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24228, 24273);

                        var
                        originalIdentity = originalIdentities[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24293, 25369) || true) && (versionPattern is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 24293, 25369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24363, 24463);

                            f_531_24363_24462(f_531_24376_24396(versionPattern) == ushort.MaxValue || (DynAbs.Tracing.TraceSender.Expression_False(531, 24376, 24461) || f_531_24419_24442(versionPattern) == ushort.MaxValue));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24487, 24588);

                            lazyBuilder = lazyBuilder ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>.Builder?>(531, 24501, 24587) ?? f_531_24516_24587());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24612, 24676);

                            var
                            sourceIdentity = f_531_24633_24675(symbolIdentity, versionPattern)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24700, 25087) || true) && (f_531_24704_24743(lazyBuilder, sourceIdentity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 24700, 25087);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 24944, 25064);

                                throw f_531_24950_25063(f_531_24976_25062());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(531, 24700, 25087);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 25111, 25161);

                            f_531_25111_25160(
                                                lazyBuilder, sourceIdentity, originalIdentity);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 24293, 25369);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 24293, 25369);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 25301, 25350);

                            f_531_25301_25349(originalIdentity == symbolIdentity);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 24293, 25369);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 1373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 1373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 25400, 25499);

                return f_531_25407_25433_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(lazyBuilder, 531, 25407, 25433)?.ToImmutable()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>?>(531, 25407, 25498) ?? ImmutableDictionary<AssemblyIdentity, AssemblyIdentity>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(531, 23610, 25510);

                int
                f_531_23840_23897(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 23840, 23897);
                    return 0;
                }


                int
                f_531_24376_24396(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 24376, 24396);
                    return return_v;
                }


                int
                f_531_24419_24442(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 24419, 24442);
                    return return_v;
                }


                int
                f_531_24363_24462(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 24363, 24462);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>.Builder
                f_531_24516_24587()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<AssemblyIdentity, AssemblyIdentity>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 24516, 24587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_531_24633_24675(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param, System.Version
                version)
                {
                    var return_v = this_param.WithVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 24633, 24675);
                    return return_v;
                }


                bool
                f_531_24704_24743(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>.Builder
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 24704, 24743);
                    return return_v;
                }


                string
                f_531_24976_25062()
                {
                    var return_v = CodeAnalysisResources.CompilationReferencesAssembliesWithDifferentAutoGeneratedVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 24976, 25062);
                    return return_v;
                }


                System.NotSupportedException
                f_531_24950_25063(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 24950, 25063);
                    return return_v;
                }


                int
                f_531_25111_25160(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>.Builder
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                key, Microsoft.CodeAnalysis.AssemblyIdentity
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 25111, 25160);
                    return 0;
                }


                int
                f_531_25301_25349(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 25301, 25349);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>?
                f_531_25407_25433_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.AssemblyIdentity, Microsoft.CodeAnalysis.AssemblyIdentity>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 25407, 25433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 23610, 25510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 23610, 25510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CompareVersionPartsSpecifiedInSource(Version version, Version candidateVersion, TAssemblySymbol candidateSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(531, 25522, 26601);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 25739, 25887) || true) && (f_531_25743_25756(version) != f_531_25760_25782(candidateVersion) || (DynAbs.Tracing.TraceSender.Expression_False(531, 25743, 25825) || f_531_25786_25799(version) != f_531_25803_25825(candidateVersion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 25739, 25887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 25859, 25872);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 25739, 25887);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26018, 26078);

                var
                versionPattern = candidateSymbol.AssemblyVersionPattern
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26092, 26218);

                f_531_26092_26217(versionPattern is null || (DynAbs.Tracing.TraceSender.Expression_False(531, 26105, 26170) || f_531_26131_26151(versionPattern) == ushort.MaxValue) || (DynAbs.Tracing.TraceSender.Expression_False(531, 26105, 26216) || f_531_26174_26197(versionPattern) == ushort.MaxValue));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26234, 26409) || true) && ((versionPattern is null || (DynAbs.Tracing.TraceSender.Expression_False(531, 26239, 26303) || f_531_26265_26285(versionPattern) < ushort.MaxValue)) && (DynAbs.Tracing.TraceSender.Expression_True(531, 26238, 26347) && f_531_26308_26321(version) != f_531_26325_26347(candidateVersion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 26234, 26409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26381, 26394);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 26234, 26409);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26425, 26562) || true) && (versionPattern is null && (DynAbs.Tracing.TraceSender.Expression_True(531, 26429, 26500) && f_531_26455_26471(version) != f_531_26475_26500(candidateVersion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 26425, 26562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26534, 26547);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 26425, 26562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 26578, 26590);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(531, 25522, 26601);

                int
                f_531_25743_25756(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 25743, 25756);
                    return return_v;
                }


                int
                f_531_25760_25782(System.Version
                this_param)
                {
                    var return_v = this_param.Major;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 25760, 25782);
                    return return_v;
                }


                int
                f_531_25786_25799(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 25786, 25799);
                    return return_v;
                }


                int
                f_531_25803_25825(System.Version
                this_param)
                {
                    var return_v = this_param.Minor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 25803, 25825);
                    return return_v;
                }


                int
                f_531_26131_26151(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26131, 26151);
                    return return_v;
                }


                int
                f_531_26174_26197(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26174, 26197);
                    return return_v;
                }


                int
                f_531_26092_26217(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 26092, 26217);
                    return 0;
                }


                int
                f_531_26265_26285(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26265, 26285);
                    return return_v;
                }


                int
                f_531_26308_26321(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26308, 26321);
                    return return_v;
                }


                int
                f_531_26325_26347(System.Version
                this_param)
                {
                    var return_v = this_param.Build;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26325, 26347);
                    return return_v;
                }


                int
                f_531_26455_26471(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26455, 26471);
                    return return_v;
                }


                int
                f_531_26475_26500(System.Version
                this_param)
                {
                    var return_v = this_param.Revision;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 26475, 26500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 25522, 26601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 25522, 26601);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void PropagateRecursiveAliases(
                    BoundInputAssembly[] bindingResult,
                    ImmutableArray<ResolvedReference> referenceMap,
                    ArrayBuilder<ImmutableArray<string>> aliasesOfReferencedAssembliesBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(531, 27237, 30136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 27506, 27569);

                var
                assemblyIndicesToProcess = f_531_27537_27568()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 27583, 27646);

                var
                visitedAssemblies = BitVector.Create(f_531_27624_27644(bindingResult))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 27706, 27791);

                f_531_27706_27790(f_531_27719_27739(bindingResult) == f_531_27743_27785(aliasesOfReferencedAssembliesBuilder) + 1);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 27807, 29760);
                    foreach (ResolvedReference reference in f_531_27847_27859_I(referenceMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 27807, 29760);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 27893, 29745) || true) && (f_531_27897_27917_M(!reference.IsSkipped) && (DynAbs.Tracing.TraceSender.Expression_True(531, 27897, 27961) && f_531_27921_27961_M(!reference.RecursiveAliasesOpt.IsDefault)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 27893, 29745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28003, 28056);

                            var
                            recursiveAliases = reference.RecursiveAliasesOpt
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28080, 28139);

                            f_531_28080_28138(reference.Kind == MetadataImageKind.Assembly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28161, 28187);

                            visitedAssemblies.Clear();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28211, 28261);

                            f_531_28211_28260(f_531_28224_28254(assemblyIndicesToProcess) == 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28283, 28329);

                            f_531_28283_28328(assemblyIndicesToProcess, reference.Index);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28353, 29726) || true) && (f_531_28360_28390(assemblyIndicesToProcess) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 28353, 29726);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28444, 28495);

                                    int
                                    assemblyIndex = f_531_28464_28494(assemblyIndicesToProcess)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28521, 28561);

                                    visitedAssemblies[assemblyIndex] = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28632, 28777);

                                    aliasesOfReferencedAssembliesBuilder[assemblyIndex] = f_531_28686_28776(f_531_28706_28757(aliasesOfReferencedAssembliesBuilder, assemblyIndex), recursiveAliases);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 28928, 29001);

                                    var
                                    referenceBinding = bindingResult[assemblyIndex + 1].ReferenceBinding
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29027, 29068);

                                    f_531_29027_29067(referenceBinding is object);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29094, 29703);
                                        foreach (var binding in f_531_29118_29134_I(referenceBinding))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 29094, 29703);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29192, 29676) || true) && (binding.IsBound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 29192, 29676);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29346, 29403);

                                                int
                                                dependentAssemblyIndex = binding.DefinitionIndex - 1
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29437, 29645) || true) && (f_531_29441_29483_M(!visitedAssemblies[dependentAssemblyIndex]))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 29437, 29645);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29557, 29610);

                                                    f_531_29557_29609(assemblyIndicesToProcess, dependentAssemblyIndex);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 29437, 29645);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(531, 29192, 29676);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 29094, 29703);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 610);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 610);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(531, 28353, 29726);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 28353, 29726);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(531, 28353, 29726);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 27893, 29745);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(531, 27807, 29760);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 1954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 1954);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29785, 29790);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29776, 30077) || true) && (i < f_531_29796_29838(aliasesOfReferencedAssembliesBuilder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29840, 29843)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(531, 29776, 30077))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 29776, 30077);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29877, 30062) || true) && (aliasesOfReferencedAssembliesBuilder[i].IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 29877, 30062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 29972, 30043);

                            aliasesOfReferencedAssembliesBuilder[i] = ImmutableArray<string>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 29877, 30062);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 30093, 30125);

                f_531_30093_30124(
                            assemblyIndicesToProcess);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(531, 27237, 30136);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_531_27537_27568()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 27537, 27568);
                    return return_v;
                }


                int
                f_531_27624_27644(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.BoundInputAssembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 27624, 27644);
                    return return_v;
                }


                int
                f_531_27719_27739(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.BoundInputAssembly[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 27719, 27739);
                    return return_v;
                }


                int
                f_531_27743_27785(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 27743, 27785);
                    return return_v;
                }


                int
                f_531_27706_27790(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 27706, 27790);
                    return 0;
                }


                bool
                f_531_27897_27917_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 27897, 27917);
                    return return_v;
                }


                bool
                f_531_27921_27961_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 27921, 27961);
                    return return_v;
                }


                int
                f_531_28080_28138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 28080, 28138);
                    return 0;
                }


                int
                f_531_28224_28254(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 28224, 28254);
                    return return_v;
                }


                int
                f_531_28211_28260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 28211, 28260);
                    return 0;
                }


                int
                f_531_28283_28328(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 28283, 28328);
                    return 0;
                }


                int
                f_531_28360_28390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 28360, 28390);
                    return return_v;
                }


                int
                f_531_28464_28494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                builder)
                {
                    var return_v = builder.Pop<int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 28464, 28494);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_531_28706_28757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 28706, 28757);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_531_28686_28776(System.Collections.Immutable.ImmutableArray<string>
                aliasesOpt, System.Collections.Immutable.ImmutableArray<string>
                newAliases)
                {
                    var return_v = MergedAliases.Merge(aliasesOpt, newAliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 28686, 28776);
                    return return_v;
                }


                int
                f_531_29027_29067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 29027, 29067);
                    return 0;
                }


                bool
                f_531_29441_29483_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 29441, 29483);
                    return return_v;
                }


                int
                f_531_29557_29609(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 29557, 29609);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                f_531_29118_29134_I(Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.AssemblyReferenceBinding[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 29118, 29134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                f_531_27847_27859_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CommonReferenceManager<TCompilation, TAssemblySymbol>.ResolvedReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 27847, 27859);
                    return return_v;
                }


                int
                f_531_29796_29838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<string>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 29796, 29838);
                    return return_v;
                }


                int
                f_531_30093_30124(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 30093, 30124);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 27237, 30136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 27237, 30136);
            }
        }

        internal IEnumerable<string> ExternAliases
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 30275, 30338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 30278, 30338);
                    var temp = f_531_30278_30307();
                    return f_531_30278_30338(ref temp, aliases => aliases); 
                    DynAbs.Tracing.TraceSender.TraceExitMethod(531, 30275, 30338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 30275, 30338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 30275, 30338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override IEnumerable<KeyValuePair<MetadataReference, IAssemblySymbolInternal>> GetReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 30351, 30641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 30496, 30630);

                return f_531_30503_30629(ReferencedAssembliesMap, ra => KeyValuePairUtil.Create(ra.Key, (IAssemblySymbolInternal)ReferencedAssemblies[ra.Value]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 30351, 30641);

                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>>
                f_531_30503_30629(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.MetadataReference, int>, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.MetadataReference, int>, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.MetadataReference, Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 30503, 30629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 30351, 30641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 30351, 30641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TAssemblySymbol? GetReferencedAssemblySymbol(MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 30653, 30897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 30760, 30770);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 30784, 30886);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(531, 30791, 30848) || ((f_531_30791_30848(ReferencedAssembliesMap, reference, out index) && DynAbs.Tracing.TraceSender.Conditional_F2(531, 30851, 30878)) || DynAbs.Tracing.TraceSender.Conditional_F3(531, 30881, 30885))) ? ReferencedAssemblies[index] : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 30653, 30897);

                bool
                f_531_30791_30848(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 30791, 30848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 30653, 30897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 30653, 30897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetReferencedModuleIndex(MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 30909, 31114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31000, 31010);

                int
                index
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31024, 31103);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(531, 31031, 31089) || ((f_531_31031_31089(ReferencedModuleIndexMap, reference, out index) && DynAbs.Tracing.TraceSender.Conditional_F2(531, 31092, 31097)) || DynAbs.Tracing.TraceSender.Conditional_F3(531, 31100, 31102))) ? index : -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 30909, 31114);

                bool
                f_531_31031_31089(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                this_param, Microsoft.CodeAnalysis.MetadataReference
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 31031, 31089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 30909, 31114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 30909, 31114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MetadataReference? GetMetadataReference(IAssemblySymbolInternal? assemblySymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 31269, 31666);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31392, 31627);
                    foreach (var entry in f_531_31414_31437_I(ReferencedAssembliesMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 31392, 31627);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31471, 31612) || true) && ((object)ReferencedAssemblies[entry.Value] == assemblySymbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 31471, 31612);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31576, 31593);

                            return entry.Key;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(531, 31471, 31612);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(531, 31392, 31627);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31643, 31655);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 31269, 31666);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                f_531_31414_31437_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 31414, 31437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 31269, 31666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 31269, 31666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<(IAssemblySymbolInternal, ImmutableArray<string>)> GetReferencedAssemblyAliases()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 31678, 31999);

                var listYield = new List<(IAssemblySymbolInternal, ImmutableArray<string>)>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31823, 31828);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31814, 31988) || true) && (i < ReferencedAssemblies.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31863, 31866)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(531, 31814, 31988))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(531, 31814, 31988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 31900, 31973);

                        listYield.Add((ReferencedAssemblies[i], AliasesOfReferencedAssemblies[i]));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(531, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(531, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 31678, 31999);

                return listYield;
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 31678, 31999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 31678, 31999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool DeclarationsAccessibleWithoutAlias(int referencedAssemblyIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(531, 32011, 32321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 32111, 32180);

                var
                aliases = AliasesOfReferencedAssemblies[referencedAssemblyIndex]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(531, 32194, 32310);

                return aliases.Length == 0 || (DynAbs.Tracing.TraceSender.Expression_False(531, 32201, 32309) || aliases.IndexOf(MetadataReferenceProperties.GlobalAlias, f_531_32281_32303()) >= 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(531, 32011, 32321);

                System.StringComparer
                f_531_32281_32303()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 32281, 32303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(531, 32011, 32321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(531, 32011, 32321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static int
        f_531_9916_9956(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 9916, 9956);
            return 0;
        }


        static int
        f_531_9971_10009(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 9971, 10009);
            return 0;
        }


        static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>
        f_531_10184_10241()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.MetadataReference, object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 10184, 10241);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<string>>
        f_531_30278_30307()
        {
            var return_v = AliasesOfReferencedAssemblies;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(531, 30278, 30307);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_531_30278_30338(ref System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<string>>
        source, System.Func<System.Collections.Immutable.ImmutableArray<string>, System.Collections.Generic.IEnumerable<string>>
        selector)
        {
            var return_v = source.SelectMany<System.Collections.Immutable.ImmutableArray<string>, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(531, 30278, 30338);
            return return_v;
        }

    }
}
