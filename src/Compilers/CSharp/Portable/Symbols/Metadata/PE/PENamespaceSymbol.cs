// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal abstract class PENamespaceSymbol
            : NamespaceSymbol
    {
        protected Dictionary<string, PENestedNamespaceSymbol> lazyNamespaces;

        protected Dictionary<string, ImmutableArray<PENamedTypeSymbol>> lazyTypes;

        private Dictionary<string, TypeDefinitionHandle> _lazyNoPiaLocalTypes;

        private ImmutableArray<PENamedTypeSymbol> _lazyFlattenedTypes;

        internal sealed override NamespaceExtent Extent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 1913, 2016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 1949, 2001);

                    return f_10710_1956_2000(f_10710_1976_1999(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 1913, 2016);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10710_1976_1999(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 1976, 1999);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent
                    f_10710_1956_2000(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    module)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceExtent((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)module);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 1956, 2000);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 1841, 2027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 1841, 2027);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/23582",
                    Constraint = "Provide " + nameof(ArrayBuilder<Symbol>) + " capacity to reduce number of allocations.",
                    AllowGenericEnumeration = false)]
        public sealed override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 2039, 2797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2379, 2404);

                f_10710_2379_2403(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2420, 2462);

                var
                memberTypes = f_10710_2438_2461(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2476, 2566);

                var
                builder = f_10710_2490_2565(memberTypes.Length + f_10710_2544_2564(lazyNamespaces))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2582, 2612);

                f_10710_2582_2611(
                            builder, memberTypes);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2626, 2734);
                    foreach (var pair in f_10710_2647_2661_I(lazyNamespaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 2626, 2734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2695, 2719);

                        f_10710_2695_2718(builder, pair.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 2626, 2734);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10710, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10710, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2750, 2786);

                return f_10710_2757_2785(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 2039, 2797);

                int
                f_10710_2379_2403(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    this_param.EnsureAllMembersLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2379, 2403);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10710_2438_2461(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMemberTypesPrivate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2438, 2461);
                    return return_v;
                }


                int
                f_10710_2544_2564(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 2544, 2564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10710_2490_2565(int
                capacity)
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2490, 2565);
                    return return_v;
                }


                int
                f_10710_2582_2611(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                items)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2582, 2611);
                    return 0;
                }


                int
                f_10710_2695_2718(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2695, 2718);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                f_10710_2647_2661_I(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2647, 2661);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10710_2757_2785(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 2757, 2785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 2039, 2797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 2039, 2797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<NamedTypeSymbol> GetMemberTypesPrivate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 2809, 3275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 2974, 3187) || true) && (_lazyFlattenedTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 2974, 3187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3041, 3077);

                    var
                    flattened = f_10710_3057_3076(lazyTypes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3095, 3172);

                    f_10710_3095_3171(ref _lazyFlattenedTypes, flattened);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 2974, 3187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3203, 3264);

                return f_10710_3210_3263(_lazyFlattenedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 2809, 3275);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10710_3057_3076(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                dictionary)
                {
                    var return_v = dictionary.Flatten<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3057, 3076);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10710_3095_3171(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedExchange(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3095, 3171);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10710_3210_3263(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<NamedTypeSymbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3210, 3263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 2809, 3275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 2809, 3275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 3287, 4210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3381, 3406);

                f_10710_3381_3405(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3422, 3456);

                PENestedNamespaceSymbol
                ns = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3470, 3506);

                ImmutableArray<PENamedTypeSymbol>
                t
                = default(ImmutableArray<PENamedTypeSymbol>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3522, 4147) || true) && (f_10710_3526_3566(lazyNamespaces, name, out ns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 3522, 4147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3600, 3992) || true) && (f_10710_3604_3638(lazyTypes, name, out t))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 3600, 3992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3808, 3850);

                        return f_10710_3815_3841(t).Add(ns);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 3600, 3992);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 3600, 3992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 3932, 3973);

                        return f_10710_3939_3972(ns);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 3600, 3992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 3522, 4147);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 3522, 4147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4026, 4147) || true) && (f_10710_4030_4064(lazyTypes, name, out t))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 4026, 4147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4098, 4132);

                        return f_10710_4105_4131(t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 4026, 4147);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 3522, 4147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4163, 4199);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 3287, 4210);

                int
                f_10710_3381_3405(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    this_param.EnsureAllMembersLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3381, 3405);
                    return 0;
                }


                bool
                f_10710_3526_3566(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3526, 3566);
                    return return_v;
                }


                bool
                f_10710_3604_3638(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3604, 3638);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10710_3815_3841(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3815, 3841);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10710_3939_3972(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 3939, 3972);
                    return return_v;
                }


                bool
                f_10710_4030_4064(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4030, 4064);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10710_4105_4131(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4105, 4131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 3287, 4210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 3287, 4210);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 4222, 4401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4318, 4343);

                f_10710_4318_4342(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4359, 4390);

                return f_10710_4366_4389(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 4222, 4401);

                int
                f_10710_4318_4342(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    this_param.EnsureAllMembersLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4318, 4342);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10710_4366_4389(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMemberTypesPrivate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4366, 4389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 4222, 4401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 4222, 4401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 4413, 4778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4520, 4545);

                f_10710_4520_4544(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4561, 4597);

                ImmutableArray<PENamedTypeSymbol>
                t
                = default(ImmutableArray<PENamedTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4613, 4767);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10710, 4620, 4654) || ((f_10710_4620_4654(lazyTypes, name, out t) && DynAbs.Tracing.TraceSender.Conditional_F2(10710, 4674, 4709)) || DynAbs.Tracing.TraceSender.Conditional_F3(10710, 4729, 4766))) ? f_10710_4674_4709(t) : ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 4413, 4778);

                int
                f_10710_4520_4544(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    this_param.EnsureAllMembersLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4520, 4544);
                    return 0;
                }


                bool
                f_10710_4620_4654(System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                this_param, string
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4620, 4654);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10710_4674_4709(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<NamedTypeSymbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4674, 4709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 4413, 4778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 4413, 4778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 4790, 5005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 4908, 4994);

                return f_10710_4915_4935(this, name).WhereAsArray((type, arity) => type.Arity == arity, arity);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 4790, 5005);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10710_4915_4935(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 4915, 4935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 4790, 5005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 4790, 5005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 5099, 5228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 5135, 5213);

                    return f_10710_5142_5160().MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 5099, 5228);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10710_5142_5160()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 5142, 5160);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 5017, 5239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 5017, 5239);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 5349, 5445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 5385, 5430);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 5349, 5445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 5251, 5456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 5251, 5456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract PEModuleSymbol ContainingPEModule { get; }

        protected abstract void EnsureAllMembersLoaded();

        protected void LoadAllMembers(IEnumerable<IGrouping<string, TypeDefinitionHandle>> typesByNS)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 6683, 8002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 6801, 6833);

                f_10710_6801_6832(typesByNS != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 6960, 7032);

                IEnumerable<IGrouping<string, TypeDefinitionHandle>>
                nestedTypes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 7412, 7524);

                IEnumerable<KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>>
                nestedNamespaces = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 7538, 7586);

                bool
                isGlobalNamespace = f_10710_7563_7585(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 7602, 7883);

                f_10710_7602_7882(isGlobalNamespace, (DynAbs.Tracing.TraceSender.Conditional_F1(10710, 7708, 7725) || ((isGlobalNamespace && DynAbs.Tracing.TraceSender.Conditional_F2(10710, 7728, 7729)) || DynAbs.Tracing.TraceSender.Conditional_F3(10710, 7732, 7756))) ? 0 : f_10710_7732_7756(this), typesByNS, f_10710_7803_7825(), out nestedTypes, out nestedNamespaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 7899, 7942);

                f_10710_7899_7941(this, nestedNamespaces);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 7958, 7991);

                f_10710_7958_7990(this, nestedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 6683, 8002);

                int
                f_10710_6801_6832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 6801, 6832);
                    return 0;
                }


                bool
                f_10710_7563_7585(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 7563, 7585);
                    return return_v;
                }


                int
                f_10710_7732_7756(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetQualifiedNameLength();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 7732, 7756);
                    return return_v;
                }


                System.StringComparer
                f_10710_7803_7825()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 7803, 7825);
                    return return_v;
                }


                int
                f_10710_7602_7882(bool
                isGlobalNamespace, int
                namespaceNameLength, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                typesByNS, System.StringComparer
                nameComparer, out System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                types, out System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>>>
                namespaces)
                {
                    MetadataHelpers.GetInfoForImmediateNamespaceMembers(isGlobalNamespace, namespaceNameLength, typesByNS, nameComparer, out types, out namespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 7602, 7882);
                    return 0;
                }


                int
                f_10710_7899_7941(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>>>
                childNamespaces)
                {
                    this_param.LazyInitializeNamespaces(childNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 7899, 7941);
                    return 0;
                }


                int
                f_10710_7958_7990(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                typeGroups)
                {
                    this_param.LazyInitializeTypes(typeGroups);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 7958, 7990);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 6683, 8002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 6683, 8002);
            }
        }

        private int GetQualifiedNameLength()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 8014, 8435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8075, 8105);

                int
                length = f_10710_8088_8104(f_10710_8088_8097(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8121, 8154);

                var
                parent = f_10710_8134_8153()
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8168, 8394) || true) && (f_10710_8175_8200_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parent, 10710, 8175, 8200)?.IsGlobalNamespace) == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 8168, 8394);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8292, 8325);

                        length += f_10710_8302_8320(f_10710_8302_8313(parent)) + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8343, 8379);

                        parent = f_10710_8352_8378(parent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 8168, 8394);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10710, 8168, 8394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10710, 8168, 8394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8410, 8424);

                return length;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 8014, 8435);

                string
                f_10710_8088_8097(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8088, 8097);
                    return return_v;
                }


                int
                f_10710_8088_8104(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8088, 8104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10710_8134_8153()
                {
                    var return_v = ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8134, 8153);
                    return return_v;
                }


                bool?
                f_10710_8175_8200_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8175, 8200);
                    return return_v;
                }


                string
                f_10710_8302_8313(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8302, 8313);
                    return return_v;
                }


                int
                f_10710_8302_8320(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8302, 8320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10710_8352_8378(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 8352, 8378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 8014, 8435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 8014, 8435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LazyInitializeNamespaces(
                    IEnumerable<KeyValuePair<string, IEnumerable<IGrouping<string, TypeDefinitionHandle>>>> childNamespaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 8575, 9267);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8756, 9256) || true) && (this.lazyNamespaces == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 8756, 9256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8821, 8918);

                    var
                    namespaces = f_10710_8838_8917(StringOrdinalComparer.Instance)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 8938, 9150);
                        foreach (var child in f_10710_8960_8975_I(childNamespaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 8938, 9150);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9017, 9083);

                            var
                            c = f_10710_9025_9082(child.Key, this, child.Value)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9105, 9131);

                            f_10710_9105_9130(namespaces, f_10710_9120_9126(c), c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 8938, 9150);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10710, 1, 213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10710, 1, 213);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9170, 9241);

                    f_10710_9170_9240(ref this.lazyNamespaces, namespaces, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 8756, 9256);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 8575, 9267);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                f_10710_8838_8917(Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 8838, 8917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                f_10710_9025_9082(string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                containingNamespace, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                typesByNS)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol(name, containingNamespace, typesByNS);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9025, 9082);
                    return return_v;
                }


                string
                f_10710_9120_9126(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 9120, 9126);
                    return return_v;
                }


                int
                f_10710_9105_9130(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9105, 9130);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>>>
                f_10710_8960_8975_I(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 8960, 8975);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>?
                f_10710_9170_9240(ref System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>?
                location1, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>
                value, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9170, 9240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 8575, 9267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 8575, 9267);
            }
        }

        private void LazyInitializeTypes(IEnumerable<IGrouping<string, TypeDefinitionHandle>> typeGroups)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 9397, 11721);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9519, 11710) || true) && (this.lazyTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 9519, 11710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9579, 9617);

                    var
                    moduleSymbol = f_10710_9598_9616()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9637, 9698);

                    var
                    children = f_10710_9652_9697()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9716, 9789);

                    var
                    skipCheckForPiaType = !f_10710_9743_9788(f_10710_9743_9762(moduleSymbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9807, 9871);

                    Dictionary<string, TypeDefinitionHandle>
                    noPiaLocalTypes = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9891, 11002);
                        foreach (var g in f_10710_9909_9919_I(typeGroups))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 9891, 11002);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 9961, 10983);
                                foreach (var t in f_10710_9979_9980_I(g))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 9961, 10983);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10030, 10960) || true) && (skipCheckForPiaType || (DynAbs.Tracing.TraceSender.Expression_False(10710, 10034, 10097) || !f_10710_10058_10097(f_10710_10058_10077(moduleSymbol), t)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 10030, 10960);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10155, 10224);

                                        f_10710_10155_10223(children, f_10710_10168_10222(moduleSymbol, this, t, f_10710_10216_10221(g)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 10030, 10960);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 10030, 10960);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10406, 10472);

                                            string
                                            typeDefName = f_10710_10427_10471(f_10710_10427_10446(moduleSymbol), t)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10508, 10739) || true) && (noPiaLocalTypes == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 10508, 10739);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10609, 10704);

                                                noPiaLocalTypes = f_10710_10627_10703(StringOrdinalComparer.Instance);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 10508, 10739);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 10775, 10808);

                                            noPiaLocalTypes[typeDefName] = t;
                                        }
                                        catch (BadImageFormatException)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(10710, 10869, 10933);
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(10710, 10869, 10933);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 10030, 10960);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 9961, 10983);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10710, 1, 1023);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10710, 1, 1023);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 9891, 11002);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10710, 1, 1112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10710, 1, 1112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11022, 11105);

                    var
                    typesDict = f_10710_11038_11104(children, c => c.Name, StringOrdinalComparer.Instance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11123, 11139);

                    f_10710_11123_11138(children);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11159, 11324) || true) && (noPiaLocalTypes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 11159, 11324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11228, 11305);

                        f_10710_11228_11304(ref _lazyNoPiaLocalTypes, noPiaLocalTypes, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 11159, 11324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11344, 11424);

                    var
                    original = f_10710_11359_11423(ref this.lazyTypes, typesDict, null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11562, 11695) || true) && (original == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 11562, 11695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11624, 11676);

                        f_10710_11624_11675(moduleSymbol, typesDict);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 11562, 11695);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 9519, 11710);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 9397, 11721);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10710_9598_9616()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 9598, 9616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                f_10710_9652_9697()
                {
                    var return_v = ArrayBuilder<PENamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9652, 9697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10710_9743_9762(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 9743, 9762);
                    return return_v;
                }


                bool
                f_10710_9743_9788(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.ContainsNoPiaLocalTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9743, 9788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10710_10058_10077(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 10058, 10077);
                    return return_v;
                }


                bool
                f_10710_10058_10097(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.IsNoPiaLocalType(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 10058, 10097);
                    return return_v;
                }


                string
                f_10710_10216_10221(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 10216, 10221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                f_10710_10168_10222(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                containingNamespace, System.Reflection.Metadata.TypeDefinitionHandle
                handle, string
                emittedNamespaceName)
                {
                    var return_v = PENamedTypeSymbol.Create(moduleSymbol, containingNamespace, handle, emittedNamespaceName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 10168, 10222);
                    return return_v;
                }


                int
                f_10710_10155_10223(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 10155, 10223);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10710_10427_10446(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 10427, 10446);
                    return return_v;
                }


                string
                f_10710_10427_10471(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                typeDef)
                {
                    var return_v = this_param.GetTypeDefNameOrThrow(typeDef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 10427, 10471);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                f_10710_10627_10703(Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 10627, 10703);
                    return return_v;
                }


                System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                f_10710_9979_9980_I(System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9979, 9980);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                f_10710_9909_9919_I(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 9909, 9919);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                f_10710_11038_11104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol, string>
                keySelector, Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = this_param.ToDictionary<string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11038, 11104);
                    return return_v;
                }


                int
                f_10710_11123_11138(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11123, 11138);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                f_10710_11228_11304(ref System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                location1, System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                value, System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11228, 11304);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                f_10710_11359_11423(ref System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                location1, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                value, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11359, 11423);
                    return return_v;
                }


                int
                f_10710_11624_11675(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol>>
                typesDict)
                {
                    this_param.OnNewTypeDeclarationsLoaded(typesDict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11624, 11675);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 9397, 11721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 9397, 11721);
            }
        }

        internal NamedTypeSymbol LookupMetadataType(ref MetadataTypeName emittedTypeName, out bool isNoPiaLocalType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10710, 11733, 12668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11866, 11931);

                NamedTypeSymbol
                result = f_10710_11891_11930(this, ref emittedTypeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11945, 11970);

                isNoPiaLocalType = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 11986, 12627) || true) && (result is MissingMetadataTypeSymbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 11986, 12627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12059, 12084);

                    f_10710_12059_12083(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12102, 12131);

                    TypeDefinitionHandle
                    typeDef
                    = default(TypeDefinitionHandle);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12279, 12612) || true) && (_lazyNoPiaLocalTypes != null && (DynAbs.Tracing.TraceSender.Expression_True(10710, 12283, 12386) && f_10710_12315_12386(_lazyNoPiaLocalTypes, emittedTypeName.TypeName, out typeDef)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10710, 12279, 12612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12428, 12540);

                        result = (NamedTypeSymbol)f_10710_12454_12539(f_10710_12454_12493(f_10710_12474_12492()), typeDef, out isNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12562, 12593);

                        f_10710_12562_12592(isNoPiaLocalType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 12279, 12612);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10710, 11986, 12627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 12643, 12657);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10710, 11733, 12668);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10710_11891_11930(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedTypeName)
                {
                    var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 11891, 11930);
                    return return_v;
                }


                int
                f_10710_12059_12083(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                this_param)
                {
                    this_param.EnsureAllMembersLoaded();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 12059, 12083);
                    return 0;
                }


                bool
                f_10710_12315_12386(System.Collections.Generic.Dictionary<string, System.Reflection.Metadata.TypeDefinitionHandle>
                this_param, string
                key, out System.Reflection.Metadata.TypeDefinitionHandle
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 12315, 12386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10710_12474_12492()
                {
                    var return_v = ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10710, 12474, 12492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10710_12454_12493(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 12454, 12493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10710_12454_12539(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.TypeDefinitionHandle
                token, out bool
                isNoPiaLocalType)
                {
                    var return_v = this_param.GetTypeOfToken((System.Reflection.Metadata.EntityHandle)token, out isNoPiaLocalType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 12454, 12539);
                    return return_v;
                }


                int
                f_10710_12562_12592(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10710, 12562, 12592);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10710, 11733, 12668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 11733, 12668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PENamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10710, 749, 12675);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 1067, 1081);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 1333, 1342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10710, 1641, 1661);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10710, 749, 12675);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 749, 12675);
        }


        static PENamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10710, 749, 12675);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10710, 749, 12675);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10710, 749, 12675);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10710, 749, 12675);
    }
}
