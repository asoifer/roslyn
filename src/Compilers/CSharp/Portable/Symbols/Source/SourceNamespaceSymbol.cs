// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SourceNamespaceSymbol : NamespaceSymbol
    {
        private readonly SourceModuleSymbol _module;

        private readonly Symbol _container;

        private readonly MergedNamespaceDeclaration _mergedDeclaration;

        private SymbolCompletionState _state;

        private ImmutableArray<Location> _locations;

        private Dictionary<string, ImmutableArray<NamespaceOrTypeSymbol>> _nameToMembersMap;

        private Dictionary<string, ImmutableArray<NamedTypeSymbol>> _nameToTypeMembersMap;

        private ImmutableArray<Symbol> _lazyAllMembers;

        private ImmutableArray<NamedTypeSymbol> _lazyTypeMembersUnordered;

        private const int
        LazyAllMembersIsSorted = 0x1
        ;

        private int _flags;

        private LexicalSortKey _lazyLexicalSortKey;

        internal SourceNamespaceSymbol(
                    SourceModuleSymbol module, Symbol container,
                    MergedNamespaceDeclaration mergedDeclaration,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10071, 1429, 1995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 654, 661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 696, 706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 761, 779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 959, 976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1047, 1068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1323, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1365, 1416);
                this._lazyLexicalSortKey = LexicalSortKey.NotInitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1642, 1682);

                f_10071_1642_1681(mergedDeclaration != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1696, 1713);

                _module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1727, 1750);

                _container = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1764, 1803);

                _mergedDeclaration = mergedDeclaration;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1819, 1984);
                    foreach (var singleDeclaration in f_10071_1853_1883_I(f_10071_1853_1883(mergedDeclaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 1819, 1984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1917, 1969);

                        f_10071_1917_1968(diagnostics, singleDeclaration.Diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 1819, 1984);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 166);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10071, 1429, 1995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 1429, 1995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 1429, 1995);
            }
        }

        internal MergedNamespaceDeclaration MergedDeclaration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2074, 2095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2077, 2095);
                    return _mergedDeclaration; DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2074, 2095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2074, 2095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2074, 2095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2161, 2174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2164, 2174);
                    return _container; DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2161, 2174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2161, 2174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2161, 2174);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2250, 2279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2253, 2279);
                    return f_10071_2253_2279(_module); DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2250, 2279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2250, 2279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2250, 2279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal IEnumerable<Imports> GetBoundImportsMerged()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2292, 2714);

                var listYield = new List<Imports>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2370, 2414);

                var
                compilation = f_10071_2388_2413(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2428, 2703);
                    foreach (var declaration in f_10071_2456_2487_I(f_10071_2456_2487(_mergedDeclaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 2428, 2703);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2521, 2688) || true) && (f_10071_2525_2546(declaration) || (DynAbs.Tracing.TraceSender.Expression_False(10071, 2525, 2578) || f_10071_2550_2578(declaration)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 2521, 2688);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2620, 2669);

                            listYield.Add(f_10071_2633_2668(compilation, declaration));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 2521, 2688);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 2428, 2703);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 276);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2292, 2714);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10071_2388_2413(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2388, 2413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10071_2456_2487(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2456, 2487);
                    return return_v;
                }


                bool
                f_10071_2525_2546(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.HasUsings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2525, 2546);
                    return return_v;
                }


                bool
                f_10071_2550_2578(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.HasExternAliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2550, 2578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10071_2633_2668(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                declaration)
                {
                    var return_v = this_param.GetImports(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 2633, 2668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10071_2456_2487_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 2456, 2487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2292, 2714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2292, 2714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2767, 2793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2770, 2793);
                    return f_10071_2770_2793(_mergedDeclaration); DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2767, 2793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2767, 2793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2767, 2793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LexicalSortKey GetLexicalSortKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 2806, 3115);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2883, 3063) || true) && (f_10071_2887_2921_M(!_lazyLexicalSortKey.IsInitialized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 2883, 3063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 2955, 3048);

                    _lazyLexicalSortKey.SetFrom(f_10071_2983_3046(_mergedDeclaration, f_10071_3020_3045(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 2883, 3063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3077, 3104);

                return _lazyLexicalSortKey;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 2806, 3115);

                bool
                f_10071_2887_2921_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2887, 2921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10071_3020_3045(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 3020, 3045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LexicalSortKey
                f_10071_2983_3046(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.GetLexicalSortKey(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 2983, 3046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 2806, 3115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 2806, 3115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 3202, 3533);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3238, 3480) || true) && (_locations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 3238, 3480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3304, 3461);

                        f_10071_3304_3460(ref _locations, f_10071_3393_3425(_mergedDeclaration), default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 3238, 3480);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3500, 3518);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 3202, 3533);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10071_3393_3425(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.NameLocations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 3393, 3425);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10071_3304_3460(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 3304, 3460);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 3127, 3544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 3127, 3544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly Func<SingleNamespaceDeclaration, SyntaxReference> s_declaringSyntaxReferencesSelector;

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 3844, 3879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3847, 3879);
                    return f_10071_3847_3879(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 3844, 3879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 3844, 3879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 3844, 3879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<SyntaxReference> ComputeDeclaringReferencesCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 3892, 4423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4322, 4412);

                return _mergedDeclaration.Declarations.SelectAsArray(s_declaringSyntaxReferencesSelector);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 3892, 4423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 3892, 4423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 3892, 4423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 4435, 4930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4522, 4551);

                var
                result = _lazyAllMembers
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4567, 4866) || true) && (result.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 4567, 4866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4621, 4701);

                    var
                    members = f_10071_4635_4700(f_10071_4659_4699(f_10071_4659_4685(this), null))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4735, 4808);

                    f_10071_4735_4807(ref _lazyAllMembers, members);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4826, 4851);

                    result = _lazyAllMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 4567, 4866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 4882, 4919);

                return result.ConditionallyDeOrder();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 4435, 4930);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                f_10071_4659_4685(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 4659, 4685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10071_4659_4699(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                dictionary, System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>?
                comparer)
                {
                    var return_v = dictionary.Flatten<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>(comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 4659, 4699);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10071_4635_4700(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 4635, 4700);
                    return return_v;
                }


                bool
                f_10071_4735_4807(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 4735, 4807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 4435, 4930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 4435, 4930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 4942, 5731);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5018, 5720) || true) && ((_flags & LazyAllMembersIsSorted) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 5018, 5720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5094, 5117);

                    return _lazyAllMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 5018, 5720);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 5018, 5720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5183, 5227);

                    var
                    allMembers = f_10071_5200_5226(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5247, 5584) || true) && (allMembers.Length >= 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 5247, 5584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5403, 5469);

                        allMembers = allMembers.Sort(LexicalOrderSymbolComparer.Instance);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5491, 5565);

                        f_10071_5491_5564(ref _lazyAllMembers, allMembers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 5247, 5584);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5604, 5669);

                    f_10071_5604_5668(ref _flags, LazyAllMembersIsSorted);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5687, 5705);

                    return allMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 5018, 5720);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 4942, 5731);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10071_5200_5226(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 5200, 5226);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10071_5491_5564(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedExchange(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 5491, 5564);
                    return return_v;
                }


                bool
                f_10071_5604_5668(ref int
                flags, int
                toSet)
                {
                    var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 5604, 5668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 4942, 5731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 4942, 5731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 5743, 6079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5830, 5876);

                ImmutableArray<NamespaceOrTypeSymbol>
                members
                = default(ImmutableArray<NamespaceOrTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 5890, 6068);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10071, 5897, 5954) || ((f_10071_5897_5954(f_10071_5897_5923(this), name, out members) && DynAbs.Tracing.TraceSender.Conditional_F2(10071, 5974, 6019)) || DynAbs.Tracing.TraceSender.Conditional_F3(10071, 6039, 6067))) ? members.Cast<NamespaceOrTypeSymbol, Symbol>() : ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 5743, 6079);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                f_10071_5897_5923(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 5897, 5923);
                    return return_v;
                }


                bool
                f_10071_5897_5954(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 5897, 5954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 5743, 6079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 5743, 6079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetTypeMembersUnordered()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 6091, 6495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6191, 6435) || true) && (_lazyTypeMembersUnordered.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 6191, 6435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6264, 6319);

                    var
                    members = f_10071_6278_6318(f_10071_6278_6308(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6337, 6420);

                    f_10071_6337_6419(ref _lazyTypeMembersUnordered, members);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 6191, 6435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6451, 6484);

                return _lazyTypeMembersUnordered;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 6091, 6495);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10071_6278_6308(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToTypeMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6278, 6308);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10071_6278_6318(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                dictionary)
                {
                    var return_v = dictionary.Flatten<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6278, 6318);
                    return return_v;
                }


                bool
                f_10071_6337_6419(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6337, 6419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 6091, 6495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 6091, 6495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 6507, 6690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6596, 6679);

                return f_10071_6603_6678(f_10071_6603_6633(this), LexicalOrderSymbolComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 6507, 6690);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10071_6603_6633(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToTypeMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6603, 6633);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10071_6603_6678(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                dictionary, Microsoft.CodeAnalysis.CSharp.LexicalOrderSymbolComparer
                comparer)
                {
                    var return_v = dictionary.Flatten<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6603, 6678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 6507, 6690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 6507, 6690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 6702, 7020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6802, 6842);

                ImmutableArray<NamedTypeSymbol>
                members
                = default(ImmutableArray<NamedTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 6856, 7009);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10071, 6863, 6924) || ((f_10071_6863_6924(f_10071_6863_6893(this), name, out members) && DynAbs.Tracing.TraceSender.Conditional_F2(10071, 6944, 6951)) || DynAbs.Tracing.TraceSender.Conditional_F3(10071, 6971, 7008))) ? members
                : ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 6702, 7020);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10071_6863_6893(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToTypeMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6863, 6893);
                    return return_v;
                }


                bool
                f_10071_6863_6924(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 6863, 6924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 6702, 7020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 6702, 7020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 7032, 7234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7143, 7223);

                return f_10071_7150_7170(this, name).WhereAsArray((s, arity) => s.Arity == arity, arity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 7032, 7234);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10071_7150_7170(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 7150, 7170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 7032, 7234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 7032, 7234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 7318, 7384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7354, 7369);

                    return _module;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 7318, 7384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 7246, 7395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 7246, 7395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamespaceExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 7472, 7559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7508, 7544);

                    return f_10071_7515_7543(_module);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 7472, 7559);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10071_7515_7543(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    module)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 7515, 7543);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 7407, 7570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 7407, 7570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Dictionary<string, ImmutableArray<NamespaceOrTypeSymbol>> GetNameToMembersMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 7582, 8752);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7694, 8700) || true) && (_nameToMembersMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 7694, 8700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7757, 7803);

                    var
                    diagnostics = f_10071_7775_7802()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 7821, 8646) || true) && (f_10071_7825_7916(ref _nameToMembersMap, f_10071_7876_7909(this, diagnostics), null) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 7821, 8646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8152, 8223);

                        f_10071_8152_8222(f_10071_8152_8200(f_10071_8152_8177(this)), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8245, 8272);

                        f_10071_8245_8271(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8425, 8472);

                        f_10071_8425_8471(f_10071_8425_8445(), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8494, 8574);

                        var
                        wasSetThisThread = _state.NotePartComplete(CompletionPart.NameToMembersMap)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8596, 8627);

                        f_10071_8596_8626(wasSetThisThread);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 7821, 8646);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8666, 8685);

                    f_10071_8666_8684(
                                    diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 7694, 8700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8716, 8741);

                return _nameToMembersMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 7582, 8752);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10071_7775_7802()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 7775, 7802);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                f_10071_7876_7909(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.MakeNameToMembersMap(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 7876, 7909);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>?
                f_10071_7825_7916(ref System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 7825, 7916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10071_8152_8177(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 8152, 8177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10071_8152_8200(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 8152, 8200);
                    return return_v;
                }


                int
                f_10071_8152_8222(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 8152, 8222);
                    return 0;
                }


                int
                f_10071_8245_8271(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    this_param.RegisterDeclaredCorTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 8245, 8271);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10071_8425_8445()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 8425, 8445);
                    return return_v;
                }


                int
                f_10071_8425_8471(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                symbol)
                {
                    this_param.SymbolDeclaredEvent((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 8425, 8471);
                    return 0;
                }


                int
                f_10071_8596_8626(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 8596, 8626);
                    return 0;
                }


                int
                f_10071_8666_8684(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 8666, 8684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 7582, 8752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 7582, 8752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, ImmutableArray<NamedTypeSymbol>> GetNameToTypeMembersMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 8764, 9309);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 8874, 9253) || true) && (_nameToTypeMembersMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 8874, 9253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9131, 9238);

                    f_10071_9131_9237(ref _nameToTypeMembersMap, f_10071_9186_9230(f_10071_9208_9229(this)), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 8874, 9253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9269, 9298);

                return _nameToTypeMembersMap;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 8764, 9309);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                f_10071_9208_9229(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNameToMembersMap();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9208, 9229);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10071_9186_9230(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                map)
                {
                    var return_v = GetTypesFromMemberMap(map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9186, 9230);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                f_10071_9131_9237(ref System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9131, 9237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 8764, 9309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 8764, 9309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Dictionary<string, ImmutableArray<NamedTypeSymbol>> GetTypesFromMemberMap(Dictionary<string, ImmutableArray<NamespaceOrTypeSymbol>> map)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10071, 9321, 10978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9497, 9602);

                var
                dictionary = f_10071_9514_9601(StringOrdinalComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9618, 10933);
                    foreach (var kvp in f_10071_9638_9641_I(map))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 9618, 10933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9675, 9733);

                        ImmutableArray<NamespaceOrTypeSymbol>
                        members = kvp.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9753, 9774);

                        bool
                        hasType = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9792, 9818);

                        bool
                        hasNamespace = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9838, 10511);
                            foreach (var symbol in f_10071_9861_9868_I(members))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 9838, 10511);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9910, 10492) || true) && (f_10071_9914_9925(symbol) == SymbolKind.NamedType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 9910, 10492);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 9999, 10014);

                                    hasType = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10040, 10147) || true) && (hasNamespace)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 10040, 10147);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10071, 10114, 10120);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 10040, 10147);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 9910, 10492);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 9910, 10492);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10245, 10295);

                                    f_10071_10245_10294(f_10071_10258_10269(symbol) == SymbolKind.Namespace);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10321, 10341);

                                    hasNamespace = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10367, 10469) || true) && (hasType)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 10367, 10469);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10071, 10436, 10442);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 10367, 10469);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 9910, 10492);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 9838, 10511);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 674);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 674);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10531, 10918) || true) && (hasType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 10531, 10918);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10584, 10899) || true) && (hasNamespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 10584, 10899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10650, 10723);

                                f_10071_10650_10722(dictionary, kvp.Key, f_10071_10674_10721(members.OfType<NamedTypeSymbol>()));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 10584, 10899);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 10584, 10899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10821, 10876);

                                f_10071_10821_10875(dictionary, kvp.Key, members.As<NamedTypeSymbol>());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 10584, 10899);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 10531, 10918);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 9618, 10933);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 1316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 1316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 10949, 10967);

                return dictionary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10071, 9321, 10978);

                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                f_10071_9514_9601(Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9514, 9601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10071_9914_9925(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 9914, 9925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10071_10258_10269(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 10258, 10269);
                    return return_v;
                }


                int
                f_10071_10245_10294(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 10245, 10294);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10071_9861_9868_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9861, 9868);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10071_10674_10721(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 10674, 10721);
                    return return_v;
                }


                int
                f_10071_10650_10722(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 10650, 10722);
                    return 0;
                }


                int
                f_10071_10821_10875(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
                this_param, string
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 10821, 10875);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                f_10071_9638_9641_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 9638, 9641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 9321, 10978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 9321, 10978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, ImmutableArray<NamespaceOrTypeSymbol>> MakeNameToMembersMap(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 10990, 12229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 11837, 11914);

                var
                builder = f_10071_11851_11913(_mergedDeclaration.Children.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 11928, 12083);
                    foreach (var declaration in f_10071_11956_11983_I(f_10071_11956_11983(_mergedDeclaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 11928, 12083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12017, 12068);

                        builder.Add(f_10071_12029_12066(this, declaration, diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 11928, 12083);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 156);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12099, 12132);

                var
                result = builder.CreateMap()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12148, 12188);

                f_10071_12148_12187(this, result, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12204, 12218);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 10990, 12229);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol.NameToSymbolMapBuilder
                f_10071_11851_11913(int
                capacity)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol.NameToSymbolMapBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 11851, 11913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10071_11956_11983(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 11956, 11983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10071_12029_12066(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                declaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BuildSymbol(declaration, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12029, 12066);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10071_11956_11983_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 11956, 11983);
                    return return_v;
                }


                int
                f_10071_12148_12187(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                @namespace, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                result, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)@namespace, result, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12148, 12187);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 10990, 12229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 10990, 12229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckMembers(NamespaceSymbol @namespace, Dictionary<string, ImmutableArray<NamespaceOrTypeSymbol>> result, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10071, 12241, 16234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12419, 12454);

                var
                memberOfArity = new Symbol[10]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12468, 12521);

                MergedNamespaceSymbol
                mergedAssemblyNamespace = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12537, 12752) || true) && (f_10071_12541_12570(@namespace).Modules.Length > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 12537, 12752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12623, 12737);

                    mergedAssemblyNamespace = f_10071_12649_12711(f_10071_12649_12678(@namespace), @namespace) as MergedNamespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 12537, 12752);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12768, 16223);
                    foreach (var name in f_10071_12789_12800_I(f_10071_12789_12800(result)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 12768, 16223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12834, 12886);

                        f_10071_12834_12885(memberOfArity, 0, f_10071_12864_12884(memberOfArity));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12904, 16208);
                            foreach (var symbol in f_10071_12927_12939_I(f_10071_12927_12939(result, name)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 12904, 16208);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 12981, 13017);

                                var
                                nts = symbol as NamedTypeSymbol
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13039, 13089);

                                var
                                arity = (DynAbs.Tracing.TraceSender.Conditional_F1(10071, 13051, 13072) || ((((object)nts != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10071, 13075, 13084)) || DynAbs.Tracing.TraceSender.Conditional_F3(10071, 13087, 13088))) ? f_10071_13075_13084(nts) : 0
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13111, 13260) || true) && (arity >= f_10071_13124_13144(memberOfArity))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 13111, 13260);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13194, 13237);

                                    f_10071_13194_13236(ref memberOfArity, arity + 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 13111, 13260);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13284, 13317);

                                var
                                other = memberOfArity[arity]
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13341, 14771) || true) && ((object)other == null && (DynAbs.Tracing.TraceSender.Expression_True(10071, 13345, 13409) && (object)mergedAssemblyNamespace != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 13341, 14771);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13545, 14748);
                                        foreach (NamespaceSymbol constituent in f_10071_13585_13630_I(f_10071_13585_13630(mergedAssemblyNamespace)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 13545, 14748);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 13688, 14721) || true) && ((object)constituent != (object)@namespace)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 13688, 14721);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 14211, 14270);

                                                var
                                                types = f_10071_14223_14269(constituent, f_10071_14250_14261(symbol), arity)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 14306, 14690) || true) && (types.Length > 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 14306, 14690);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 14400, 14417);

                                                    other = types[0];
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10071, 14649, 14655);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 14306, 14690);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 13688, 14721);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 13545, 14748);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 1204);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 1204);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 13341, 14771);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 14795, 15518) || true) && ((object)other != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 14795, 15518);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 14905, 15495) || true) && (nts is SourceNamedTypeSymbol && (DynAbs.Tracing.TraceSender.Expression_True(10071, 14909, 14987) && f_10071_14941_14979(((SourceNamedTypeSymbol)nts)) == true) && (DynAbs.Tracing.TraceSender.Expression_True(10071, 14909, 15050) && other is SourceNamedTypeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10071, 14909, 15102) && f_10071_15054_15094(((SourceNamedTypeSymbol)other)) == true))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 14905, 15495);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15160, 15255);

                                        f_10071_15160_15254(diagnostics, ErrorCode.ERR_PartialTypeKindConflict, symbol.Locations.FirstOrNone(), symbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 14905, 15495);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 14905, 15495);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15369, 15468);

                                        f_10071_15369_15467(diagnostics, ErrorCode.ERR_DuplicateNameInNS, symbol.Locations.FirstOrNone(), name, @namespace);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 14905, 15495);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 14795, 15518);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15542, 15572);

                                memberOfArity[arity] = symbol;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15596, 16189) || true) && ((object)nts != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 15596, 16189);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15809, 15873);

                                    Accessibility
                                    declaredAccessibility = f_10071_15847_15872(nts)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 15899, 16166) || true) && (declaredAccessibility != Accessibility.Public && (DynAbs.Tracing.TraceSender.Expression_True(10071, 15903, 15999) && declaredAccessibility != Accessibility.Internal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 15899, 16166);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 16057, 16139);

                                        f_10071_16057_16138(diagnostics, ErrorCode.ERR_NoNamespacePrivate, symbol.Locations.FirstOrNone());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 15899, 16166);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 15596, 16189);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 12904, 16208);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 3305);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 3305);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 12768, 16223);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 3456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 3456);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10071, 12241, 16234);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10071_12541_12570(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 12541, 12570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10071_12649_12678(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 12649, 12678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10071_12649_12711(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetAssemblyNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12649, 12711);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.KeyCollection
                f_10071_12789_12800(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 12789, 12800);
                    return return_v;
                }


                int
                f_10071_12864_12884(Microsoft.CodeAnalysis.CSharp.Symbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 12864, 12884);
                    return return_v;
                }


                int
                f_10071_12834_12885(Microsoft.CodeAnalysis.CSharp.Symbol[]
                array, int
                index, int
                length)
                {
                    Array.Clear((System.Array)array, index, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12834, 12885);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10071_12927_12939(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 12927, 12939);
                    return return_v;
                }


                int
                f_10071_13075_13084(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 13075, 13084);
                    return return_v;
                }


                int
                f_10071_13124_13144(Microsoft.CodeAnalysis.CSharp.Symbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 13124, 13144);
                    return return_v;
                }


                int
                f_10071_13194_13236(ref Microsoft.CodeAnalysis.CSharp.Symbol[]
                array, int
                newSize)
                {
                    Array.Resize(ref array, newSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 13194, 13236);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10071_13585_13630(Microsoft.CodeAnalysis.CSharp.Symbols.MergedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ConstituentNamespaces;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 13585, 13630);
                    return return_v;
                }


                string
                f_10071_14250_14261(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 14250, 14261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10071_14223_14269(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 14223, 14269);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10071_13585_13630_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 13585, 13630);
                    return return_v;
                }


                bool
                f_10071_14941_14979(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 14941, 14979);
                    return return_v;
                }


                bool
                f_10071_15054_15094(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsPartial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 15054, 15094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10071_15160_15254(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 15160, 15254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10071_15369_15467(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 15369, 15467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10071_15847_15872(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 15847, 15872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10071_16057_16138(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 16057, 16138);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10071_12927_12939_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12927, 12939);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.KeyCollection
                f_10071_12789_12800_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 12789, 12800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 12241, 16234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 12241, 16234);
            }
        }

        private NamespaceOrTypeSymbol BuildSymbol(MergedNamespaceOrTypeDeclaration declaration, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 16246, 17558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 16385, 17547);

                switch (f_10071_16393_16409(declaration))
                {

                    case DeclarationKind.Namespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 16385, 17547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 16496, 16598);

                        return f_10071_16503_16597(_module, this, (MergedNamespaceDeclaration)declaration, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 16385, 17547);

                    case DeclarationKind.Struct:
                    case DeclarationKind.Interface:
                    case DeclarationKind.Enum:
                    case DeclarationKind.Delegate:
                    case DeclarationKind.Class:
                    case DeclarationKind.Record:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 16385, 17547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 16900, 16988);

                        return f_10071_16907_16987(this, (MergedTypeDeclaration)declaration, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 16385, 17547);

                    case DeclarationKind.Script:
                    case DeclarationKind.Submission:
                    case DeclarationKind.ImplicitClass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 16385, 17547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17161, 17251);

                        return f_10071_17168_17250(this, (MergedTypeDeclaration)declaration, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 16385, 17547);

                    case DeclarationKind.SimpleProgram:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 16385, 17547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17328, 17423);

                        return f_10071_17335_17422(this, (MergedTypeDeclaration)declaration, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 16385, 17547);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 16385, 17547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17473, 17532);

                        throw f_10071_17479_17531(f_10071_17514_17530(declaration));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 16385, 17547);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 16246, 17558);

                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10071_16393_16409(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 16393, 16409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                f_10071_16503_16597(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                module, Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                container, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                mergedDeclaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol(module, (Microsoft.CodeAnalysis.CSharp.Symbol)container, (Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration)mergedDeclaration, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 16503, 16597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                f_10071_16907_16987(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                declaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, (Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration)declaration, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 16907, 16987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                f_10071_17168_17250(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                declaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)containingSymbol, (Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration)declaration, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 17168, 17250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol
                f_10071_17335_17422(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                globalNamespace, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                declaration, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SimpleProgramNamedTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)globalNamespace, (Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration)declaration, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 17335, 17422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10071_17514_17530(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 17514, 17530);
                    return return_v;
                }


                System.Exception
                f_10071_17479_17531(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 17479, 17531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 16246, 17558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 16246, 17558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RegisterDeclaredCorTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 17709, 18684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17773, 17828);

                AssemblySymbol
                containingAssembly = f_10071_17809_17827()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17844, 18673) || true) && (f_10071_17848_17901(containingAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 17844, 18673);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 17989, 18658);
                        foreach (var array in f_10071_18011_18035_I(f_10071_18011_18035(_nameToMembersMap)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 17989, 18658);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18077, 18639);
                                foreach (var member in f_10071_18100_18105_I(array))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 18077, 18639);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18155, 18192);

                                    var
                                    type = member as NamedTypeSymbol
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18220, 18616) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10071, 18224, 18284) && f_10071_18248_18264(type) != SpecialType.None))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 18220, 18616);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18342, 18395);

                                        f_10071_18342_18394(containingAssembly, type);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18427, 18589) || true) && (f_10071_18431_18485_M(!containingAssembly.KeepLookingForDeclaredSpecialTypes))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 18427, 18589);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18551, 18558);

                                            return;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 18427, 18589);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 18220, 18616);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 18077, 18639);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 563);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 563);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 17989, 18658);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 670);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 670);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 17844, 18673);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 17709, 18684);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10071_17809_17827()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 17809, 17827);
                    return return_v;
                }


                bool
                f_10071_17848_17901(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.KeepLookingForDeclaredSpecialTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 17848, 17901);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.ValueCollection
                f_10071_18011_18035(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 18011, 18035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10071_18248_18264(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 18248, 18264);
                    return return_v;
                }


                int
                f_10071_18342_18394(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                corType)
                {
                    this_param.RegisterDeclaredSpecialType(corType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 18342, 18394);
                    return 0;
                }


                bool
                f_10071_18431_18485_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 18431, 18485);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10071_18100_18105_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 18100, 18105);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.ValueCollection
                f_10071_18011_18035_I(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 18011, 18035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 17709, 18684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 17709, 18684);
            }
        }

        internal override bool IsDefinedInSourceTree(SyntaxTree tree, TextSpan? definedWithinSpan, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 18696, 19871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18877, 18964) || true) && (f_10071_18881_18903(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 18877, 18964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 18937, 18949);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 18877, 18964);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19074, 19831);
                    foreach (var declaration in f_10071_19102_19133_I(f_10071_19102_19133(_mergedDeclaration)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 19074, 19831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19167, 19216);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19236, 19291);

                        var
                        declarationSyntaxRef = f_10071_19263_19290(declaration)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19309, 19422) || true) && (f_10071_19313_19344(declarationSyntaxRef) != tree)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 19309, 19422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19394, 19403);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 19309, 19422);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19442, 19546) || true) && (f_10071_19446_19473_M(!definedWithinSpan.HasValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 19442, 19546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19515, 19527);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 19442, 19546);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19566, 19666);

                        var
                        syntax = f_10071_19579_19665(declarationSyntaxRef, cancellationToken)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19684, 19816) || true) && (syntax.FullSpan.IntersectsWith(definedWithinSpan.Value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 19684, 19816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19785, 19797);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 19684, 19816);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 19074, 19831);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 19847, 19860);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 18696, 19871);

                bool
                f_10071_18881_18903(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 18881, 18903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10071_19102_19133(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 19102, 19133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxReference
                f_10071_19263_19290(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.SyntaxReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 19263, 19290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10071_19313_19344(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 19313, 19344);
                    return return_v;
                }


                bool
                f_10071_19446_19473_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 19446, 19473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10071_19579_19665(Microsoft.CodeAnalysis.SyntaxReference
                reference, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = NamespaceDeclarationSyntaxReference.GetSyntax(reference, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 19579, 19665);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10071_19102_19133_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 19102, 19133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 18696, 19871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 18696, 19871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct NameToSymbolMapBuilder
        {

            private readonly Dictionary<string, object> _dictionary;

            public NameToSymbolMapBuilder(int capacity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10071, 20017, 20195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20093, 20180);

                    // LAFHIS
                    //_dictionary = f_10071_20107_20179(capacity, StringOrdinalComparer.Instance);

                    _dictionary = new System.Collections.Generic.Dictionary<string, object>(capacity, StringOrdinalComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20107, 20179);

                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10071, 20017, 20195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 20017, 20195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 20017, 20195);
                }
            }

            public void Add(NamespaceOrTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 20211, 20986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20289, 20315);

                    string
                    name = f_10071_20303_20314(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20333, 20345);

                    object
                    item
                    = default(object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20363, 20971) || true) && (f_10071_20367_20406(_dictionary, name, out item))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 20363, 20971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20448, 20506);

                        var
                        builder = item as ArrayBuilder<NamespaceOrTypeSymbol>
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20528, 20801) || true) && (builder == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 20528, 20801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20597, 20657);

                            builder = f_10071_20607_20656();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20683, 20724);

                            f_10071_20683_20723(builder, item);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20750, 20778);

                            _dictionary[name] = builder;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 20528, 20801);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20823, 20843);

                        f_10071_20823_20842(builder, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 20363, 20971);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 20363, 20971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 20925, 20952);

                        _dictionary[name] = symbol;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 20363, 20971);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 20211, 20986);

                    string
                    f_10071_20303_20314(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 20303, 20314);
                        return return_v;
                    }


                    bool
                    f_10071_20367_20406(System.Collections.Generic.Dictionary<string, object>
                    this_param, string
                    key, out object
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20367, 20406);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    f_10071_20607_20656()
                    {
                        var return_v = ArrayBuilder<NamespaceOrTypeSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20607, 20656);
                        return return_v;
                    }


                    int
                    f_10071_20683_20723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param, object
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20683, 20723);
                        return 0;
                    }


                    int
                    f_10071_20823_20842(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20823, 20842);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 20211, 20986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 20211, 20986);
                }
            }

            public Dictionary<String, ImmutableArray<NamespaceOrTypeSymbol>> CreateMap()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10071, 21002, 22771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21111, 21237);

                    var
                    result = f_10071_21124_21236(f_10071_21186_21203(_dictionary), StringOrdinalComparer.Instance)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21257, 22722);
                        foreach (var kvp in f_10071_21277_21288_I(_dictionary))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 21257, 22722);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21330, 21355);

                            object
                            value = kvp.Value
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21377, 21423);

                            ImmutableArray<NamespaceOrTypeSymbol>
                            members
                            = default(ImmutableArray<NamespaceOrTypeSymbol>);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21447, 21506);

                            var
                            builder = value as ArrayBuilder<NamespaceOrTypeSymbol>
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21528, 22650) || true) && (builder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 21528, 22650);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21597, 21629);

                                f_10071_21597_21628(f_10071_21610_21623(builder) > 1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21655, 21682);

                                bool
                                hasNamespaces = false
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21717, 21722);
                                    for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21708, 21910) || true) && ((i < f_10071_21729_21742(builder)) && (DynAbs.Tracing.TraceSender.Expression_True(10071, 21724, 21761) && !hasNamespaces))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21763, 21766)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 21708, 21910))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 21708, 21910);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21824, 21883);

                                        hasNamespaces |= (f_10071_21842_21857(f_10071_21842_21852(builder, i)) == SymbolKind.Namespace);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 203);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 203);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 21938, 22135);

                                members = (DynAbs.Tracing.TraceSender.Conditional_F1(10071, 21948, 21961) || ((hasNamespaces
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10071, 21993, 22014)) || DynAbs.Tracing.TraceSender.Conditional_F3(10071, 22046, 22134))) ? f_10071_21993_22014(builder) : f_10071_22046_22134(f_10071_22085_22133(builder));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 22163, 22178);

                                f_10071_22163_22177(
                                                        builder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 21528, 22650);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10071, 21528, 22650);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 22276, 22336);

                                NamespaceOrTypeSymbol
                                symbol = (NamespaceOrTypeSymbol)value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 22362, 22627);

                                members = (DynAbs.Tracing.TraceSender.Conditional_F1(10071, 22372, 22407) || ((f_10071_22372_22383(symbol) == SymbolKind.Namespace
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10071, 22439, 22491)) || DynAbs.Tracing.TraceSender.Conditional_F3(10071, 22523, 22626))) ? f_10071_22439_22491(symbol) : f_10071_22523_22626(f_10071_22562_22625(symbol));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 21528, 22650);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 22674, 22703);

                            f_10071_22674_22702(
                                                result, kvp.Key, members);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10071, 21257, 22722);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10071, 1, 1466);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10071, 1, 1466);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 22742, 22756);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10071, 21002, 22771);

                    int
                    f_10071_21186_21203(System.Collections.Generic.Dictionary<string, object>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 21186, 21203);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                    f_10071_21124_21236(int
                    capacity, Roslyn.Utilities.StringOrdinalComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 21124, 21236);
                        return return_v;
                    }


                    int
                    f_10071_21610_21623(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 21610, 21623);
                        return return_v;
                    }


                    int
                    f_10071_21597_21628(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 21597, 21628);
                        return 0;
                    }


                    int
                    f_10071_21729_21742(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 21729, 21742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    f_10071_21842_21852(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 21842, 21852);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10071_21842_21857(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 21842, 21857);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    f_10071_21993_22014(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 21993, 22014);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10071_22085_22133(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToDowncastedImmutable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22085, 22133);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    f_10071_22046_22134(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    from)
                    {
                        var return_v = StaticCast<NamespaceOrTypeSymbol>.From(from);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22046, 22134);
                        return return_v;
                    }


                    int
                    f_10071_22163_22177(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22163, 22177);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10071_22372_22383(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 22372, 22383);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    f_10071_22439_22491(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<NamespaceOrTypeSymbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22439, 22491);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10071_22562_22625(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<NamedTypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22562, 22625);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    f_10071_22523_22626(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    from)
                    {
                        var return_v = StaticCast<NamespaceOrTypeSymbol>.From(from);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22523, 22626);
                        return return_v;
                    }


                    int
                    f_10071_22674_22702(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>>
                    this_param, string
                    key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 22674, 22702);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<string, object>
                    f_10071_21277_21288_I(System.Collections.Generic.Dictionary<string, object>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 21277, 21288);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10071, 21002, 22771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 21002, 22771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static NameToSymbolMapBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10071, 19883, 22782);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10071, 19883, 22782);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 19883, 22782);
            }

            System.Collections.Generic.Dictionary<string, object>
            f_10071_20107_20179(int
            capacity, Roslyn.Utilities.StringOrdinalComparer
            comparer)
            {
                var return_v = new System.Collections.Generic.Dictionary<string, object>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 20107, 20179);
                return return_v;
            }

        }

        static SourceNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10071, 532, 22789);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 1232, 1260);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10071, 3630, 3744);
            s_declaringSyntaxReferencesSelector = d =>
                        new NamespaceDeclarationSyntaxReference(d.SyntaxReference); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10071, 532, 22789);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10071, 532, 22789);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10071, 532, 22789);

        int
        f_10071_1642_1681(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 1642, 1681);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
        f_10071_1853_1883(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
        this_param)
        {
            var return_v = this_param.Declarations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 1853, 1883);
            return return_v;
        }


        int
        f_10071_1917_1968(Microsoft.CodeAnalysis.DiagnosticBag
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
        diagnostics)
        {
            this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 1917, 1968);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
        f_10071_1853_1883_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 1853, 1883);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10071_2253_2279(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2253, 2279);
            return return_v;
        }


        string
        f_10071_2770_2793(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10071, 2770, 2793);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
        f_10071_3847_3879(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamespaceSymbol
        this_param)
        {
            var return_v = this_param.ComputeDeclaringReferencesCore();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10071, 3847, 3879);
            return return_v;
        }

    }
}
