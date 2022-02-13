// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class DeclarationTable
    {
        public static readonly DeclarationTable Empty;

        private readonly ImmutableSetWithInsertionOrder<RootSingleNamespaceDeclaration> _allOlderRootDeclarations;

        private readonly Lazy<RootSingleNamespaceDeclaration> _latestLazyRootDeclaration;

        private readonly Cache _cache;

        private MergedNamespaceDeclaration _mergedRoot;

        private readonly Lazy<ICollection<string>> _typeNames;

        private readonly Lazy<ICollection<string>> _namespaceNames;

        private readonly Lazy<ICollection<ReferenceDirective>> _referenceDirectives;

        private DeclarationTable(
                    ImmutableSetWithInsertionOrder<RootSingleNamespaceDeclaration> allOlderRootDeclarations,
                    Lazy<RootSingleNamespaceDeclaration> latestLazyRootDeclaration,
                    Cache cache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10045, 2228, 2937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 1652, 1677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 1742, 1768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 1871, 1877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 1983, 1994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2050, 2060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2114, 2129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2195, 2215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2483, 2536);

                _allOlderRootDeclarations = allOlderRootDeclarations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2550, 2605);

                _latestLazyRootDeclaration = latestLazyRootDeclaration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2619, 2653);

                _cache = cache ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache>(10045, 2628, 2652) ?? f_10045_2637_2652(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2667, 2730);

                _typeNames = f_10045_2680_2729(GetMergedTypeNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2744, 2817);

                _namespaceNames = f_10045_2762_2816(GetMergedNamespaceNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 2831, 2926);

                _referenceDirectives = f_10045_2854_2925(GetMergedReferenceDirectives);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10045, 2228, 2937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 2228, 2937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 2228, 2937);
            }
        }

        public DeclarationTable AddRootDeclaration(Lazy<RootSingleNamespaceDeclaration> lazyRootDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 2949, 3816);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 3196, 3805) || true) && (_latestLazyRootDeclaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 3196, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 3268, 3352);

                    return f_10045_3275_3351(_allOlderRootDeclarations, lazyRootDeclaration, _cache);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 3196, 3805);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 3196, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 3663, 3790);

                    return f_10045_3670_3789(f_10045_3691_3754(_allOlderRootDeclarations, f_10045_3721_3753(_latestLazyRootDeclaration)), lazyRootDeclaration, cache: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 3196, 3805);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 2949, 3816);

                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10045_3275_3351(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                allOlderRootDeclarations, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                latestLazyRootDeclaration, Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache
                cache)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable(allOlderRootDeclarations, latestLazyRootDeclaration, cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 3275, 3351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_3721_3753(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 3721, 3753);
                    return return_v;
                }


                Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                f_10045_3691_3754(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 3691, 3754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10045_3670_3789(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                allOlderRootDeclarations, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                latestLazyRootDeclaration, Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache
                cache)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable(allOlderRootDeclarations, latestLazyRootDeclaration, cache: cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 3670, 3789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 2949, 3816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 2949, 3816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DeclarationTable RemoveRootDeclaration(Lazy<RootSingleNamespaceDeclaration> lazyRootDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 3828, 4859);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 4048, 4848) || true) && (_latestLazyRootDeclaration == lazyRootDeclaration)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 4048, 4848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 4135, 4238);

                    return f_10045_4142_4237(_allOlderRootDeclarations, latestLazyRootDeclaration: null, cache: _cache);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 4048, 4848);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 4048, 4848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 4703, 4833);

                    return f_10045_4710_4832(f_10045_4731_4790(_allOlderRootDeclarations, f_10045_4764_4789(lazyRootDeclaration)), _latestLazyRootDeclaration, cache: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 4048, 4848);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 3828, 4859);

                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10045_4142_4237(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                allOlderRootDeclarations, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                latestLazyRootDeclaration, Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache
                cache)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable(allOlderRootDeclarations, latestLazyRootDeclaration: latestLazyRootDeclaration, cache: cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 4142, 4237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_4764_4789(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 4764, 4789);
                    return return_v;
                }


                Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                f_10045_4731_4790(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                value)
                {
                    var return_v = this_param.Remove(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 4731, 4790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10045_4710_4832(Roslyn.Utilities.ImmutableSetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                allOlderRootDeclarations, System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                latestLazyRootDeclaration, Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache
                cache)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable(allOlderRootDeclarations, latestLazyRootDeclaration, cache: cache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 4710, 4832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 3828, 4859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 3828, 4859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MergedNamespaceDeclaration GetMergedRoot(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 5846, 6211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 5949, 5996);

                f_10045_5949_5995(f_10045_5962_5986(compilation) == this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6010, 6167) || true) && (_mergedRoot == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 6010, 6167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6067, 6152);

                    f_10045_6067_6151(ref _mergedRoot, f_10045_6112_6144(this, compilation), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 6010, 6167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6181, 6200);

                return _mergedRoot;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 5846, 6211);

                Microsoft.CodeAnalysis.CSharp.DeclarationTable
                f_10045_5962_5986(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 5962, 5986);
                    return return_v;
                }


                int
                f_10045_5949_5995(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 5949, 5995);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10045_6112_6144(Microsoft.CodeAnalysis.CSharp.DeclarationTable
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CalculateMergedRoot(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6112, 6144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration?
                f_10045_6067_6151(ref Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration?
                location1, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                value, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6067, 6151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 5846, 6211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 5846, 6211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MergedNamespaceDeclaration CalculateMergedRoot(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 6265, 7397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6376, 6414);

                var
                oldRoot = f_10045_6390_6413(_cache.MergedRoot)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6428, 7386) || true) && (_latestLazyRootDeclaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 6428, 7386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6500, 6515);

                    return oldRoot;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 6428, 7386);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 6428, 7386);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6549, 7386) || true) && (oldRoot == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 6549, 7386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6602, 6677);

                        return f_10045_6609_6676(f_10045_6643_6675(_latestLazyRootDeclaration));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 6549, 7386);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 6549, 7386);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6743, 6790);

                        var
                        oldRootDeclarations = f_10045_6769_6789(oldRoot)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6808, 6907);

                        var
                        builder = f_10045_6822_6906(oldRootDeclarations.Length + 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6925, 6963);

                        f_10045_6925_6962(builder, oldRootDeclarations);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 6981, 7027);

                        f_10045_6981_7026(builder, f_10045_6993_7025(_latestLazyRootDeclaration));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 7137, 7282) || true) && (compilation != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 7137, 7282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 7202, 7263);

                            f_10045_7202_7262(builder, f_10045_7215_7261(compilation));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 7137, 7282);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 7300, 7371);

                        return f_10045_7307_7370(f_10045_7341_7369(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 6549, 7386);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 6428, 7386);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 6265, 7397);

                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10045_6390_6413(System.Lazy<Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 6390, 6413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_6643_6675(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 6643, 6675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10045_6609_6676(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                declaration)
                {
                    var return_v = MergedNamespaceDeclaration.Create((Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration)declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6609, 6676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10045_6769_6789(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 6769, 6789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10045_6822_6906(int
                capacity)
                {
                    var return_v = ArrayBuilder<SingleNamespaceDeclaration>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6822, 6906);
                    return return_v;
                }


                int
                f_10045_6925_6962(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6925, 6962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_6993_7025(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 6993, 7025);
                    return return_v;
                }


                int
                f_10045_6981_7026(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 6981, 7026);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationTable.RootNamespaceLocationComparer
                f_10045_7215_7261(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable.RootNamespaceLocationComparer(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 7215, 7261);
                    return return_v;
                }


                int
                f_10045_7202_7262(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.DeclarationTable.RootNamespaceLocationComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 7202, 7262);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                f_10045_7341_7369(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 7341, 7369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                f_10045_7307_7370(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration>
                declarations)
                {
                    var return_v = MergedNamespaceDeclaration.Create(declarations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 7307, 7370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 6265, 7397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 6265, 7397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class RootNamespaceLocationComparer : IComparer<SingleNamespaceDeclaration>
        {
            private readonly CSharpCompilation _compilation;

            internal RootNamespaceLocationComparer(CSharpCompilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10045, 7588, 7732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 7559, 7571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 7690, 7717);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10045, 7588, 7732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 7588, 7732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 7588, 7732);
                }
            }

            [PerformanceSensitive(
                            "https://github.com/dotnet/roslyn/issues/23582",
                            Constraint = "Avoid " + nameof(SingleNamespaceOrTypeDeclaration.Location) + " since it has a costly allocation on this fast path.")]
            public int Compare(SingleNamespaceDeclaration x, SingleNamespaceDeclaration y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 7748, 8207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8111, 8192);

                    return f_10045_8118_8191(_compilation, f_10045_8154_8171(x), f_10045_8173_8190(y));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 7748, 8207);

                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10045_8154_8171(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.SyntaxReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 8154, 8171);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10045_8173_8190(Microsoft.CodeAnalysis.CSharp.SingleNamespaceDeclaration
                    this_param)
                    {
                        var return_v = this_param.SyntaxReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 8173, 8190);
                        return return_v;
                    }


                    int
                    f_10045_8118_8191(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.SyntaxReference
                    loc1, Microsoft.CodeAnalysis.SyntaxReference
                    loc2)
                    {
                        var return_v = this_param.CompareSourceLocations(loc1, loc2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 8118, 8191);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 7748, 8207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 7748, 8207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static RootNamespaceLocationComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10045, 7409, 8218);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10045, 7409, 8218);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 7409, 8218);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10045, 7409, 8218);
        }

        private ICollection<string> GetMergedTypeNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 8230, 8654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8303, 8348);

                var
                cachedTypeNames = f_10045_8325_8347(_cache.TypeNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8364, 8643) || true) && (_latestLazyRootDeclaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 8364, 8643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8436, 8459);

                    return cachedTypeNames;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 8364, 8643);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 8364, 8643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8525, 8628);

                    return f_10045_8532_8627(cachedTypeNames, f_10045_8580_8626(f_10045_8593_8625(_latestLazyRootDeclaration)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 8364, 8643);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 8230, 8654);

                System.Collections.Generic.ISet<string>
                f_10045_8325_8347(System.Lazy<System.Collections.Generic.ISet<string>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 8325, 8347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_8593_8625(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 8593, 8625);
                    return return_v;
                }


                System.Collections.Generic.ISet<string>
                f_10045_8580_8626(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                declaration)
                {
                    var return_v = GetTypeNames((Microsoft.CodeAnalysis.CSharp.Declaration)declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 8580, 8626);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10045_8532_8627(System.Collections.Generic.ISet<string>
                coll1, System.Collections.Generic.ISet<string>
                coll2)
                {
                    var return_v = UnionCollection<string>.Create((System.Collections.Generic.ICollection<string>)coll1, (System.Collections.Generic.ICollection<string>)coll2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 8532, 8627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 8230, 8654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 8230, 8654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ICollection<string> GetMergedNamespaceNames()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 8666, 9120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8744, 8799);

                var
                cachedNamespaceNames = f_10045_8771_8798(_cache.NamespaceNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8815, 9109) || true) && (_latestLazyRootDeclaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 8815, 9109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8887, 8915);

                    return cachedNamespaceNames;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 8815, 9109);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 8815, 9109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 8981, 9094);

                    return f_10045_8988_9093(cachedNamespaceNames, f_10045_9041_9092(f_10045_9059_9091(_latestLazyRootDeclaration)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 8815, 9109);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 8666, 9120);

                System.Collections.Generic.ISet<string>
                f_10045_8771_8798(System.Lazy<System.Collections.Generic.ISet<string>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 8771, 8798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_9059_9091(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 9059, 9091);
                    return return_v;
                }


                System.Collections.Generic.ISet<string>
                f_10045_9041_9092(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                declaration)
                {
                    var return_v = GetNamespaceNames((Microsoft.CodeAnalysis.CSharp.Declaration)declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 9041, 9092);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10045_8988_9093(System.Collections.Generic.ISet<string>
                coll1, System.Collections.Generic.ISet<string>
                coll2)
                {
                    var return_v = UnionCollection<string>.Create((System.Collections.Generic.ICollection<string>)coll1, (System.Collections.Generic.ICollection<string>)coll2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 8988, 9093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 8666, 9120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 8666, 9120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ICollection<ReferenceDirective> GetMergedReferenceDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 9132, 9636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9227, 9292);

                var
                cachedReferenceDirectives = f_10045_9259_9291(_cache.ReferenceDirectives)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9308, 9625) || true) && (_latestLazyRootDeclaration == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 9308, 9625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9380, 9413);

                    return cachedReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 9308, 9625);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 9308, 9625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9479, 9610);

                    return f_10045_9486_9609(cachedReferenceDirectives, f_10045_9556_9608(f_10045_9556_9588(_latestLazyRootDeclaration)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 9308, 9625);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 9132, 9636);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10045_9259_9291(System.Lazy<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 9259, 9291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                f_10045_9556_9588(System.Lazy<Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration>
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 9556, 9588);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10045_9556_9608(Microsoft.CodeAnalysis.CSharp.RootSingleNamespaceDeclaration
                this_param)
                {
                    var return_v = this_param.ReferenceDirectives;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 9556, 9608);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>
                f_10045_9486_9609(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                coll1, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ReferenceDirective>
                coll2)
                {
                    var return_v = UnionCollection<ReferenceDirective>.Create((System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>)coll1, (System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>)coll2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 9486, 9609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 9132, 9636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 9132, 9636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Predicate<Declaration> s_isNamespacePredicate;

        private static readonly Predicate<Declaration> s_isTypePredicate;

        private static ISet<string> GetTypeNames(Declaration declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 9891, 10040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 9981, 10029);

                return f_10045_9988_10028(declaration, s_isTypePredicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 9891, 10040);

                System.Collections.Generic.ISet<string>
                f_10045_9988_10028(Microsoft.CodeAnalysis.CSharp.Declaration
                declaration, System.Predicate<Microsoft.CodeAnalysis.CSharp.Declaration>
                predicate)
                {
                    var return_v = GetNames(declaration, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 9988, 10028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 9891, 10040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 9891, 10040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ISet<string> GetNamespaceNames(Declaration declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 10052, 10211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10147, 10200);

                return f_10045_10154_10199(declaration, s_isNamespacePredicate);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 10052, 10211);

                System.Collections.Generic.ISet<string>
                f_10045_10154_10199(Microsoft.CodeAnalysis.CSharp.Declaration
                declaration, System.Predicate<Microsoft.CodeAnalysis.CSharp.Declaration>
                predicate)
                {
                    var return_v = GetNames(declaration, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10154, 10199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 10052, 10211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 10052, 10211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ISet<string> GetNames(Declaration declaration, Predicate<Declaration> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 10223, 11020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10343, 10375);

                var
                set = f_10045_10353_10374()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10389, 10426);

                var
                stack = f_10045_10401_10425()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10440, 10464);

                f_10045_10440_10463(stack, declaration);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10480, 10946) || true) && (f_10045_10487_10498(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 10480, 10946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10536, 10562);

                        var
                        current = f_10045_10550_10561(stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10580, 10669) || true) && (current == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 10580, 10669);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10641, 10650);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 10580, 10669);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10689, 10794) || true) && (f_10045_10693_10711(predicate, current))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 10689, 10794);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10753, 10775);

                            f_10045_10753_10774(set, f_10045_10761_10773(current));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 10689, 10794);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10814, 10931);
                            foreach (var child in f_10045_10836_10852_I(f_10045_10836_10852(current)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 10814, 10931);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10894, 10912);

                                f_10045_10894_10911(stack, child);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 10814, 10931);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10045, 1, 118);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10045, 1, 118);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 10480, 10946);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10045, 10480, 10946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10045, 10480, 10946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 10962, 11009);

                return f_10045_10969_11008(set);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 10223, 11020);

                System.Collections.Generic.HashSet<string>
                f_10045_10353_10374()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10353, 10374);
                    return return_v;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10045_10401_10425()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10401, 10425);
                    return return_v;
                }


                int
                f_10045_10440_10463(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>
                this_param, Microsoft.CodeAnalysis.CSharp.Declaration
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10440, 10463);
                    return 0;
                }


                int
                f_10045_10487_10498(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 10487, 10498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Declaration
                f_10045_10550_10561(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10550, 10561);
                    return return_v;
                }


                bool
                f_10045_10693_10711(System.Predicate<Microsoft.CodeAnalysis.CSharp.Declaration>
                this_param, Microsoft.CodeAnalysis.CSharp.Declaration
                obj)
                {
                    var return_v = this_param.Invoke(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10693, 10711);
                    return return_v;
                }


                string
                f_10045_10761_10773(Microsoft.CodeAnalysis.CSharp.Declaration
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 10761, 10773);
                    return return_v;
                }


                bool
                f_10045_10753_10774(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10753, 10774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10045_10836_10852(Microsoft.CodeAnalysis.CSharp.Declaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 10836, 10852);
                    return return_v;
                }


                int
                f_10045_10894_10911(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Declaration>
                this_param, Microsoft.CodeAnalysis.CSharp.Declaration
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10894, 10911);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10045_10836_10852_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10836, 10852);
                    return return_v;
                }


                System.Collections.Generic.ISet<string>
                f_10045_10969_11008(System.Collections.Generic.HashSet<string>
                set)
                {
                    var return_v = SpecializedCollections.ReadOnlySet((System.Collections.Generic.ISet<string>)set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 10969, 11008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 10223, 11020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 10223, 11020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 11093, 11168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 11129, 11153);

                    return f_10045_11136_11152(_typeNames);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 11093, 11168);

                    System.Collections.Generic.ICollection<string>
                    f_10045_11136_11152(System.Lazy<System.Collections.Generic.ICollection<string>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 11136, 11152);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 11032, 11179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 11032, 11179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 11257, 11337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 11293, 11322);

                    return f_10045_11300_11321(_namespaceNames);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 11257, 11337);

                    System.Collections.Generic.ICollection<string>
                    f_10045_11300_11321(System.Lazy<System.Collections.Generic.ICollection<string>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 11300, 11321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 11191, 11348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 11191, 11348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<ReferenceDirective> ReferenceDirectives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10045, 11443, 11528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 11479, 11513);

                    return f_10045_11486_11512(_referenceDirectives);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10045, 11443, 11528);

                    System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>
                    f_10045_11486_11512(System.Lazy<System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>>
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 11486, 11512);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 11360, 11539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 11360, 11539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static bool ContainsName(
                    MergedNamespaceDeclaration mergedRoot,
                    string name,
                    SymbolFilter filter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 11551, 11983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 11770, 11972);

                return f_10045_11777_11971(mergedRoot, n => n == name, filter, t => t.MemberNames.Contains(name), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 11551, 11983);

                bool
                f_10045_11777_11971(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                mergedRoot, System.Func<string, bool>
                predicate, Microsoft.CodeAnalysis.SymbolFilter
                filter, System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, bool>
                typePredicate, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ContainsNameHelper(mergedRoot, predicate, filter, typePredicate, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 11777, 11971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 11551, 11983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 11551, 11983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool ContainsName(
                    MergedNamespaceDeclaration mergedRoot,
                    Func<string, bool> predicate,
                    SymbolFilter filter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 11995, 12679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 12231, 12668);

                return f_10045_12238_12667(mergedRoot, predicate, filter, t =>
                                {
                                    foreach (var name in t.MemberNames)
                                    {
                                        if (predicate(name))
                                        {
                                            return true;
                                        }
                                    }

                                    return false;
                                }, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 11995, 12679);

                bool
                f_10045_12238_12667(Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                mergedRoot, System.Func<string, bool>
                predicate, Microsoft.CodeAnalysis.SymbolFilter
                filter, System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, bool>
                typePredicate, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = ContainsNameHelper(mergedRoot, predicate, filter, typePredicate, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 12238, 12667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 11995, 12679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 11995, 12679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainsNameHelper(
                    MergedNamespaceDeclaration mergedRoot,
                    Func<string, bool> predicate,
                    SymbolFilter filter,
                    Func<SingleTypeDeclaration, bool> typePredicate,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10045, 12691, 15079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 12996, 13079);

                var
                includeNamespace = (filter & SymbolFilter.Namespace) == SymbolFilter.Namespace
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13093, 13161);

                var
                includeType = (filter & SymbolFilter.Type) == SymbolFilter.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13175, 13249);

                var
                includeMember = (filter & SymbolFilter.Member) == SymbolFilter.Member
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13265, 13323);

                var
                stack = f_10045_13277_13322()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13337, 13360);

                f_10045_13337_13359(stack, mergedRoot);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13376, 15039) || true) && (f_10045_13383_13394(stack) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13376, 15039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13432, 13481);

                        cancellationToken.ThrowIfCancellationRequested();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13501, 13527);

                        var
                        current = f_10045_13515_13526(stack)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13545, 13634) || true) && (current == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13545, 13634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13606, 13615);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13545, 13634);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13654, 14558) || true) && (f_10045_13658_13670(current) == DeclarationKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13654, 14558);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13741, 13873) || true) && (includeNamespace && (DynAbs.Tracing.TraceSender.Expression_True(10045, 13745, 13788) && f_10045_13765_13788(predicate, f_10045_13775_13787(current))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13741, 13873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13838, 13850);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13741, 13873);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13654, 14558);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13654, 14558);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 13955, 14082) || true) && (includeType && (DynAbs.Tracing.TraceSender.Expression_True(10045, 13959, 13997) && f_10045_13974_13997(predicate, f_10045_13984_13996(current))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 13955, 14082);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14047, 14059);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13955, 14082);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14106, 14539) || true) && (includeMember)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14106, 14539);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14173, 14221);

                                var
                                mergedType = (MergedTypeDeclaration)current
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14247, 14516);
                                    foreach (var typeDecl in f_10045_14272_14295_I(f_10045_14272_14295(mergedType)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14247, 14516);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14353, 14489) || true) && (f_10045_14357_14380(typePredicate, typeDecl))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14353, 14489);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14446, 14458);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14353, 14489);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14247, 14516);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10045, 1, 270);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10045, 1, 270);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14106, 14539);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13654, 14558);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14578, 15024);
                            foreach (var child in f_10045_14600_14616_I(f_10045_14600_14616(current)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14578, 15024);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14658, 15005) || true) && (child is MergedNamespaceOrTypeDeclaration childNamespaceOrType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14658, 15005);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14774, 14982) || true) && (includeMember || (DynAbs.Tracing.TraceSender.Expression_False(10045, 14778, 14806) || includeType) || (DynAbs.Tracing.TraceSender.Expression_False(10045, 14778, 14864) || f_10045_14810_14835(childNamespaceOrType) == DeclarationKind.Namespace))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10045, 14774, 14982);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 14922, 14955);

                                        f_10045_14922_14954(stack, childNamespaceOrType);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14774, 14982);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14658, 15005);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 14578, 15024);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10045, 1, 447);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10045, 1, 447);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10045, 13376, 15039);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10045, 13376, 15039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10045, 13376, 15039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10045, 15055, 15068);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10045, 12691, 15079);

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                f_10045_13277_13322()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 13277, 13322);
                    return return_v;
                }


                int
                f_10045_13337_13359(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedNamespaceDeclaration
                item)
                {
                    this_param.Push((Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 13337, 13359);
                    return 0;
                }


                int
                f_10045_13383_13394(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 13383, 13394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                f_10045_13515_13526(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 13515, 13526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10045_13658_13670(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 13658, 13670);
                    return return_v;
                }


                string
                f_10045_13775_13787(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 13775, 13787);
                    return return_v;
                }


                bool
                f_10045_13765_13788(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 13765, 13788);
                    return return_v;
                }


                string
                f_10045_13984_13996(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 13984, 13996);
                    return return_v;
                }


                bool
                f_10045_13974_13997(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 13974, 13997);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10045_14272_14295(Microsoft.CodeAnalysis.CSharp.MergedTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 14272, 14295);
                    return return_v;
                }


                bool
                f_10045_14357_14380(System.Func<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 14357, 14380);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                f_10045_14272_14295_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.SingleTypeDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 14272, 14295);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10045_14600_14616(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Children;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 14600, 14616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeclarationKind
                f_10045_14810_14835(Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10045, 14810, 14835);
                    return return_v;
                }


                int
                f_10045_14922_14954(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration>
                this_param, Microsoft.CodeAnalysis.CSharp.MergedNamespaceOrTypeDeclaration
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 14922, 14954);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                f_10045_14600_14616_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Declaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 14600, 14616);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10045, 12691, 15079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10045, 12691, 15079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache
        f_10045_2637_2652(Microsoft.CodeAnalysis.CSharp.DeclarationTable
        table)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.DeclarationTable.Cache(table);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 2637, 2652);
            return return_v;
        }


        System.Lazy<System.Collections.Generic.ICollection<string>>
        f_10045_2680_2729(System.Func<System.Collections.Generic.ICollection<string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.ICollection<string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 2680, 2729);
            return return_v;
        }


        System.Lazy<System.Collections.Generic.ICollection<string>>
        f_10045_2762_2816(System.Func<System.Collections.Generic.ICollection<string>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.ICollection<string>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 2762, 2816);
            return return_v;
        }


        System.Lazy<System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>>
        f_10045_2854_2925(System.Func<System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>>
        valueFactory)
        {
            var return_v = new System.Lazy<System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.ReferenceDirective>>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10045, 2854, 2925);
            return return_v;
        }

    }
}
