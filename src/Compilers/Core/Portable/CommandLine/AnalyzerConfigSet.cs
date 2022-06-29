// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using static Microsoft.CodeAnalysis.AnalyzerConfig;
using AnalyzerOptions = System.Collections.Immutable.ImmutableDictionary<string, string>;
using TreeOptions = System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>;

namespace Microsoft.CodeAnalysis
{
    public sealed class AnalyzerConfigSet
    {
        private readonly ImmutableArray<AnalyzerConfig> _analyzerConfigs;

        private readonly GlobalAnalyzerConfig _globalConfig;

        private readonly ImmutableArray<ImmutableArray<SectionNameMatcher?>> _analyzerMatchers;

        private readonly ConcurrentDictionary<ReadOnlyMemory<char>, string> _diagnosticIdCache;

        private readonly ConcurrentCache<List<Section>, AnalyzerConfigOptionsResult> _optionsCache;

        private readonly ObjectPool<TreeOptions.Builder> _treeOptionsPool;

        private readonly ObjectPool<AnalyzerOptions.Builder> _analyzerOptionsPool;

        private readonly ObjectPool<List<Section>> _sectionKeyPool;

        private StrongBox<AnalyzerConfigOptionsResult>? _lazyConfigOptions;
        private sealed class SequenceEqualComparer : IEqualityComparer<List<Section>>
        {
            public static SequenceEqualComparer Instance { get; }

            public bool Equals(List<Section>? x, List<Section>? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 3601, 4199);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3688, 3805) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(120, 3692, 3714) || y is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 3688, 3805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3756, 3786);

                        return x is null && (DynAbs.Tracing.TraceSender.Expression_True(120, 3763, 3785) && y is null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 3688, 3805);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3825, 3921) || true) && (f_120_3829_3836(x) != f_120_3840_3847(y))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 3825, 3921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3889, 3902);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 3825, 3921);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3950, 3955);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3941, 4152) || true) && (i < f_120_3961_3968(x))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3970, 3973)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 3941, 4152))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 3941, 4152);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4015, 4133) || true) && (!f_120_4020_4047(f_120_4036_4040(x, i), f_120_4042_4046(y, i)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 4015, 4133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4097, 4110);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 4015, 4133);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 212);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4172, 4184);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 3601, 4199);

                    int
                    f_120_3829_3836(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 3829, 3836);
                        return return_v;
                    }


                    int
                    f_120_3840_3847(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 3840, 3847);
                        return return_v;
                    }


                    int
                    f_120_3961_3968(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 3961, 3968);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_120_4036_4040(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 4036, 4040);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_120_4042_4046(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 4042, 4046);
                        return return_v;
                    }


                    bool
                    f_120_4020_4047(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    objA, Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 4020, 4047);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 3601, 4199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 3601, 4199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(List<Section> obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 4257, 4283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4260, 4283);
                    return f_120_4260_4283(obj); DynAbs.Tracing.TraceSender.TraceExitMethod(120, 4257, 4283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 4257, 4283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 4257, 4283);
                }
                throw new System.Exception("Slicer error: unreachable code");

                int
                f_120_4260_4283(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                values)
                {
                    var return_v = Hash.CombineValues((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AnalyzerConfig.Section>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 4260, 4283);
                    return return_v;
                }

            }

            public SequenceEqualComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(120, 3399, 4295);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(120, 3399, 4295);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 3399, 4295);
            }


            static SequenceEqualComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(120, 3399, 4295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3501, 3585);
                Instance = f_120_3557_3584(); 
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(120, 3399, 4295);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 3399, 4295);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(120, 3399, 4295);

            static Microsoft.CodeAnalysis.AnalyzerConfigSet.SequenceEqualComparer
            f_120_3557_3584()
            {
                var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigSet.SequenceEqualComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 3557, 3584);
                return return_v;
            }

        }

        private static readonly DiagnosticDescriptor InvalidAnalyzerConfigSeverityDescriptor
        ;

        private static readonly DiagnosticDescriptor MultipleGlobalAnalyzerKeysDescriptor
        ;

        private static readonly DiagnosticDescriptor InvalidGlobalAnalyzerSectionDescriptor
        ;

        public static AnalyzerConfigSet Create<TList>(TList analyzerConfigs) where TList : IReadOnlyCollection<AnalyzerConfig>
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 5680, 5872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 5823, 5861);

                return f_120_5830_5860(analyzerConfigs, out _);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 5680, 5872);

                Microsoft.CodeAnalysis.AnalyzerConfigSet
                f_120_5830_5860(TList
                analyzerConfigs, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = Create(analyzerConfigs, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 5830, 5860);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 5680, 5872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 5680, 5872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AnalyzerConfigSet Create<TList>(TList analyzerConfigs, out ImmutableArray<Diagnostic> diagnostics) where TList : IReadOnlyCollection<AnalyzerConfig>
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 5884, 6512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6071, 6163);

                var
                sortedAnalyzerConfigs = f_120_6099_6162(f_120_6140_6161(analyzerConfigs))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6177, 6225);

                f_120_6177_6224(sortedAnalyzerConfigs, analyzerConfigs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6239, 6306);

                f_120_6239_6305(sortedAnalyzerConfigs, f_120_6266_6304());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6322, 6400);

                var
                globalConfig = f_120_6341_6399(sortedAnalyzerConfigs, out diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6414, 6501);

                return f_120_6421_6500(f_120_6443_6485(sortedAnalyzerConfigs), globalConfig);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 5884, 6512);

                int
                f_120_6140_6161(TList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 6140, 6161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                f_120_6099_6162(int
                capacity)
                {
                    var return_v = ArrayBuilder<AnalyzerConfig>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6099, 6162);
                    return return_v;
                }


                int
                f_120_6177_6224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, TList
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AnalyzerConfig>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6177, 6224);
                    return 0;
                }


                System.Collections.Generic.Comparer<Microsoft.CodeAnalysis.AnalyzerConfig>
                f_120_6266_6304()
                {
                    var return_v = AnalyzerConfig.DirectoryLengthComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 6266, 6304);
                    return return_v;
                }


                int
                f_120_6239_6305(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, System.Collections.Generic.Comparer<Microsoft.CodeAnalysis.AnalyzerConfig>
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.AnalyzerConfig>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6239, 6305);
                    return 0;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                f_120_6341_6399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                analyzerConfigs, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = MergeGlobalConfigs(analyzerConfigs, out diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6341, 6399);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig>
                f_120_6443_6485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6443, 6485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigSet
                f_120_6421_6500(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig>
                analyzerConfigs, Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                globalConfig)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigSet(analyzerConfigs, globalConfig);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6421, 6500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 5884, 6512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 5884, 6512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerConfigSet(ImmutableArray<AnalyzerConfig> analyzerConfigs, GlobalAnalyzerConfig globalConfig)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(120, 6524, 7764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 1557, 1570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2260, 2385);
                this._diagnosticIdCache = f_120_2294_2385(CharMemoryEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2575, 2703);
                this._optionsCache = f_120_2604_2703(50, f_120_2672_2702()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 2783, 2948);
                this._treeOptionsPool = f_120_2815_2948(() => ImmutableDictionary.CreateBuilder<string, ReportDiagnostic>(Section.PropertiesKeyComparer)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3014, 3177);
                this._analyzerOptionsPool = f_120_3050_3177(() => ImmutableDictionary.CreateBuilder<string, string>(Section.PropertiesKeyComparer)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3233, 3307);
                this._sectionKeyPool = f_120_3251_3307(() => new List<Section>()); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 3368, 3386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6657, 6692);

                _analyzerConfigs = analyzerConfigs;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6706, 6735);

                _globalConfig = globalConfig;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6751, 6856);

                var
                allMatchers = f_120_6769_6855(_analyzerConfigs.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 6872, 7607);
                    foreach (var config in f_120_6895_6911_I(_analyzerConfigs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 6872, 7607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7105, 7194);

                        var
                        builder = f_120_7119_7193(config.NamedSections.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7212, 7447);
                            foreach (var section in f_120_7236_7256_I(f_120_7236_7256(config)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 7212, 7447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7298, 7385);

                                SectionNameMatcher?
                                matcher = f_120_7328_7384(f_120_7371_7383(section))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7407, 7428);

                                f_120_7407_7427(builder, matcher);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 7212, 7447);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 236);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 236);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7467, 7526);

                        f_120_7467_7525(f_120_7480_7493(builder) == config.NamedSections.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7546, 7592);

                        f_120_7546_7591(
                                        allMatchers, f_120_7562_7590(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 6872, 7607);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7623, 7682);

                f_120_7623_7681(f_120_7636_7653(allMatchers) == _analyzerConfigs.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 7698, 7751);

                _analyzerMatchers = f_120_7718_7750(allMatchers);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(120, 6524, 7764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 6524, 7764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 6524, 7764);
            }
        }

        public AnalyzerConfigOptionsResult GlobalConfigOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 8010, 8410);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 8046, 8343) || true) && (_lazyConfigOptions is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 8046, 8343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 8118, 8324);

                        f_120_8118_8323(ref _lazyConfigOptions, f_120_8221_8291(f_120_8264_8290(this)), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 8046, 8343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 8363, 8395);

                    return _lazyConfigOptions.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 8010, 8410);

                    Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                    f_120_8264_8290(Microsoft.CodeAnalysis.AnalyzerConfigSet
                    this_param)
                    {
                        var return_v = this_param.ParseGlobalConfigOptions();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 8264, 8290);
                        return return_v;
                    }


                    System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                    f_120_8221_8291(Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                    value)
                    {
                        var return_v = new System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 8221, 8291);
                        return return_v;
                    }


                    System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>?
                    f_120_8118_8323(ref System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>?
                    location1, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                    value, System.Runtime.CompilerServices.StrongBox<Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 8118, 8323);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 7931, 8421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 7931, 8421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AnalyzerConfigOptionsResult GetOptionsForSourcePath(string sourcePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 8948, 16161);
                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult result = default(Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9050, 9173) || true) && (sourcePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 9050, 9173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9106, 9158);

                    throw f_120_9112_9157(nameof(sourcePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 9050, 9173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9189, 9233);

                var
                sectionKey = f_120_9206_9232(_sectionKeyPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9249, 9322);

                var
                normalizedPath = f_120_9270_9321(sourcePath)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9425, 9671);
                    foreach (var section in f_120_9449_9476_I(f_120_9449_9476(_globalConfig)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 9425, 9671);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9510, 9656) || true) && (f_120_9514_9571(normalizedPath, f_120_9536_9548(section), f_120_9550_9570()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 9510, 9656);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9613, 9637);

                            f_120_9613_9636(sectionKey, section);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 9510, 9656);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 9425, 9671);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 247);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9685, 9733);

                int
                globalConfigOptionsCount = f_120_9716_9732(sectionKey)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9932, 9955);

                    // The editorconfig paths are sorted from shortest to longest, so matches
                    // are resolved from most nested to least nested, where last setting wins
                    for (int
        analyzerConfigIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 9923, 11910) || true) && (analyzerConfigIndex < _analyzerConfigs.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10004, 10025)
        , analyzerConfigIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 9923, 11910))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 9923, 11910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10059, 10110);

                        var
                        config = _analyzerConfigs[analyzerConfigIndex]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10130, 11895) || true) && (f_120_10134_10213(normalizedPath, f_120_10160_10186(config), StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 10130, 11895);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10407, 10591) || true) && (f_120_10411_10424(config))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 10407, 10591);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10474, 10568);

                                f_120_10474_10567(sectionKey, globalConfigOptionsCount, f_120_10523_10539(sectionKey) - globalConfigOptionsCount);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 10407, 10591);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10615, 10665);

                            int
                            dirLength = f_120_10631_10664(f_120_10631_10657(config))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 10958, 11095) || true) && (f_120_10962_11003(f_120_10962_10988(config), dirLength - 1) == '/')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 10958, 11095);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11060, 11072);

                                dirLength--;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 10958, 11095);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11117, 11175);

                            string
                            relativePath = f_120_11139_11174(normalizedPath, dirLength)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11199, 11285);

                            ImmutableArray<SectionNameMatcher?>
                            matchers = _analyzerMatchers[analyzerConfigIndex]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11316, 11332);
                                for (int
            sectionIndex = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11307, 11876) || true) && (sectionIndex < matchers.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11366, 11380)
            , sectionIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 11307, 11876))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 11307, 11876);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11552, 11586);

                                    var
                                    temp = matchers[sectionIndex]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11612, 11853) || true) && (temp.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(120, 11616, 11665) && temp.Value.IsMatch(relativePath)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 11612, 11853);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11723, 11772);

                                        var
                                        section = f_120_11737_11757(config)[sectionIndex]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 11802, 11826);

                                        f_120_11802_11825(sectionKey, section);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 11612, 11853);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 570);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 570);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 10130, 11895);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 1988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 1988);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12067, 15920) || true) && (!f_120_12072_12125(_optionsCache, sectionKey, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 12067, 15920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12159, 12212);

                    var
                    treeOptionsBuilder = f_120_12184_12211(_treeOptionsPool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12230, 12291);

                    var
                    analyzerOptionsBuilder = f_120_12259_12290(_analyzerOptionsPool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12309, 12372);

                    var
                    diagnosticBuilder = f_120_12333_12371()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12392, 12416);

                    int
                    sectionKeyIndex = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12436, 12505);

                    f_120_12436_12504(
                                    analyzerOptionsBuilder, f_120_12468_12487().AnalyzerOptions);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12523, 13339);
                        foreach (var configSection in f_120_12553_12580_I(f_120_12553_12580(_globalConfig)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 12523, 13339);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12622, 13320) || true) && (f_120_12626_12642(sectionKey) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(120, 12626, 12694) && configSection == f_120_12667_12694(sectionKey, sectionKeyIndex)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 12622, 13320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 12744, 13097);

                                f_120_12744_13096(f_120_12794_12821(sectionKey, sectionKeyIndex), treeOptionsBuilder, analyzerOptionsBuilder, diagnosticBuilder, GlobalAnalyzerConfigBuilder.GlobalConfigPath, _diagnosticIdCache);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13123, 13141);

                                sectionKeyIndex++;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13167, 13297) || true) && (sectionKeyIndex == f_120_13190_13206(sectionKey))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 13167, 13297);
                                    DynAbs.Tracing.TraceSender.TraceBreak(120, 13264, 13270);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 13167, 13297);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 12622, 13320);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 12523, 13339);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 817);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 817);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13368, 13391);

                        for (int
        analyzerConfigIndex = 0
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13359, 14837) || true) && (analyzerConfigIndex < _analyzerConfigs.Length && (DynAbs.Tracing.TraceSender.Expression_True(120, 13414, 13497) && sectionKeyIndex < f_120_13481_13497(sectionKey)))
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13520, 13541)
        , analyzerConfigIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 13359, 14837))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 13359, 14837);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13583, 13645);

                            AnalyzerConfig
                            config = _analyzerConfigs[analyzerConfigIndex]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13667, 13753);

                            ImmutableArray<SectionNameMatcher?>
                            matchers = _analyzerMatchers[analyzerConfigIndex]
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13784, 13800);
                                for (int
            matcherIndex = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13775, 14818) || true) && (matcherIndex < matchers.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13834, 13848)
            , matcherIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 13775, 14818))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 13775, 14818);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 13898, 14795) || true) && (f_120_13902_13929(sectionKey, sectionKeyIndex) == f_120_13933_13953(config)[matcherIndex])
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 13898, 14795);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 14025, 14375);

                                        f_120_14025_14374(f_120_14079_14106(sectionKey, sectionKeyIndex), treeOptionsBuilder, analyzerOptionsBuilder, diagnosticBuilder, f_120_14303_14320(config), _diagnosticIdCache);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 14405, 14423);

                                        sectionKeyIndex++;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 14453, 14768) || true) && (sectionKeyIndex == f_120_14476_14492(sectionKey))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 14453, 14768);
                                            DynAbs.Tracing.TraceSender.TraceBreak(120, 14731, 14737);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 14453, 14768);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 13898, 14795);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 1044);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 1044);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 1479);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 1479);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 14857, 15216);

                    result = f_120_14866_15215((DynAbs.Tracing.TraceSender.Conditional_F1(120, 14920, 14948) || ((f_120_14920_14944(treeOptionsBuilder) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(120, 14951, 14983)) || DynAbs.Tracing.TraceSender.Conditional_F3(120, 14986, 15019))) ? f_120_14951_14983(treeOptionsBuilder) : SyntaxTree.EmptyDiagnosticOptions, (DynAbs.Tracing.TraceSender.Conditional_F1(120, 15042, 15074) || ((f_120_15042_15070(analyzerOptionsBuilder) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(120, 15077, 15113)) || DynAbs.Tracing.TraceSender.Conditional_F3(120, 15116, 15153))) ? f_120_15077_15113(analyzerOptionsBuilder) : AnalyzerConfigOptions.EmptyDictionary, f_120_15176_15214(diagnosticBuilder));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15236, 15578) || true) && (f_120_15240_15280(_optionsCache, sectionKey, result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 15236, 15578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15392, 15440);

                        f_120_15392_15439(                    // Release the pooled object to be used as a key
                                            _sectionKeyPool, sectionKey);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 15236, 15578);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 15236, 15578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15522, 15559);

                        f_120_15522_15558(sectionKey, _sectionKeyPool);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 15236, 15578);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15598, 15625);

                    f_120_15598_15624(
                                    treeOptionsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15643, 15674);

                    f_120_15643_15673(analyzerOptionsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15692, 15734);

                    f_120_15692_15733(_treeOptionsPool, treeOptionsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15752, 15802);

                    f_120_15752_15801(_analyzerOptionsPool, analyzerOptionsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 12067, 15920);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 12067, 15920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15868, 15905);

                    f_120_15868_15904(sectionKey, _sectionKeyPool);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 12067, 15920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 15936, 15950);

                return result;

                static void freeKey(List<Section> sectionKey, ObjectPool<List<Section>> pool)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 15966, 16150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16076, 16095);

                        f_120_16076_16094(sectionKey);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16113, 16135);

                        f_120_16113_16134(pool, sectionKey);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 15966, 16150);

                        int
                        f_120_16076_16094(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16076, 16094);
                            return 0;
                        }


                        int
                        f_120_16113_16134(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
                        this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                        obj)
                        {
                            this_param.Free(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16113, 16134);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 15966, 16150);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 15966, 16150);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 8948, 16161);

                System.ArgumentNullException
                f_120_9112_9157(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9112, 9157);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_9206_9232(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9206, 9232);
                    return return_v;
                }


                string
                f_120_9270_9321(string
                p)
                {
                    var return_v = PathUtilities.NormalizeWithForwardSlash(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9270, 9321);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_9449_9476(Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NamedSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 9449, 9476);
                    return return_v;
                }


                string
                f_120_9536_9548(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 9536, 9548);
                    return return_v;
                }


                System.StringComparison
                f_120_9550_9570()
                {
                    var return_v = Section.NameComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 9550, 9570);
                    return return_v;
                }


                bool
                f_120_9514_9571(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9514, 9571);
                    return return_v;
                }


                int
                f_120_9613_9636(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfig.Section
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9613, 9636);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_9449_9476_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 9449, 9476);
                    return return_v;
                }


                int
                f_120_9716_9732(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 9716, 9732);
                    return return_v;
                }


                string
                f_120_10160_10186(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NormalizedDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10160, 10186);
                    return return_v;
                }


                bool
                f_120_10134_10213(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 10134, 10213);
                    return return_v;
                }


                bool
                f_120_10411_10424(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.IsRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10411, 10424);
                    return return_v;
                }


                int
                f_120_10523_10539(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10523, 10539);
                    return return_v;
                }


                int
                f_120_10474_10567(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, int
                index, int
                count)
                {
                    this_param.RemoveRange(index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 10474, 10567);
                    return 0;
                }


                string
                f_120_10631_10657(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NormalizedDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10631, 10657);
                    return return_v;
                }


                int
                f_120_10631_10664(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10631, 10664);
                    return return_v;
                }


                string
                f_120_10962_10988(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NormalizedDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10962, 10988);
                    return return_v;
                }


                char
                f_120_10962_11003(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 10962, 11003);
                    return return_v;
                }


                string
                f_120_11139_11174(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 11139, 11174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_11737_11757(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NamedSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 11737, 11757);
                    return return_v;
                }


                int
                f_120_11802_11825(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, Microsoft.CodeAnalysis.AnalyzerConfig.Section
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 11802, 11825);
                    return 0;
                }


                bool
                f_120_12072_12125(Microsoft.CodeAnalysis.ConcurrentCache<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                key, out Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12072, 12125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                f_120_12184_12211(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12184, 12211);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                f_120_12259_12290(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12259, 12290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                f_120_12333_12371()
                {
                    var return_v = ArrayBuilder<Diagnostic>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12333, 12371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_120_12468_12487()
                {
                    var return_v = GlobalConfigOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 12468, 12487);
                    return return_v;
                }


                int
                f_120_12436_12504(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param, System.Collections.Immutable.ImmutableDictionary<string, string>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12436, 12504);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_12553_12580(Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NamedSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 12553, 12580);
                    return return_v;
                }


                int
                f_120_12626_12642(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 12626, 12642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.Section
                f_120_12667_12694(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 12667, 12694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.Section
                f_120_12794_12821(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 12794, 12821);
                    return return_v;
                }


                int
                f_120_12744_13096(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                section, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                treeBuilder, System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                analyzerBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                diagnosticBuilder, string
                analyzerConfigPath, System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
                diagIdCache)
                {
                    ParseSectionOptions(section, treeBuilder, analyzerBuilder, diagnosticBuilder, analyzerConfigPath, diagIdCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12744, 13096);
                    return 0;
                }


                int
                f_120_13190_13206(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 13190, 13206);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_12553_12580_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 12553, 12580);
                    return return_v;
                }


                int
                f_120_13481_13497(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 13481, 13497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.Section
                f_120_13902_13929(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 13902, 13929);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                f_120_13933_13953(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.NamedSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 13933, 13953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.Section
                f_120_14079_14106(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 14079, 14106);
                    return return_v;
                }


                string
                f_120_14303_14320(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.PathToFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 14303, 14320);
                    return return_v;
                }


                int
                f_120_14025_14374(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                section, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                treeBuilder, System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                analyzerBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                diagnosticBuilder, string
                analyzerConfigPath, System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
                diagIdCache)
                {
                    ParseSectionOptions(section, treeBuilder, analyzerBuilder, diagnosticBuilder, analyzerConfigPath, diagIdCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 14025, 14374);
                    return 0;
                }


                int
                f_120_14476_14492(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 14476, 14492);
                    return return_v;
                }


                int
                f_120_14920_14944(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 14920, 14944);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_120_14951_14983(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 14951, 14983);
                    return return_v;
                }


                int
                f_120_15042_15070(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 15042, 15070);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_120_15077_15113(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15077, 15113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_120_15176_15214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15176, 15214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_120_14866_15215(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                treeOptions, System.Collections.Immutable.ImmutableDictionary<string, string>
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult(treeOptions, analyzerOptions, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 14866, 15215);
                    return return_v;
                }


                bool
                f_120_15240_15280(Microsoft.CodeAnalysis.ConcurrentCache<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                key, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15240, 15280);
                    return return_v;
                }


                int
                f_120_15392_15439(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
                this_param, System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                old)
                {
                    this_param.ForgetTrackedObject(old);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15392, 15439);
                    return 0;
                }


                int
                f_120_15522_15558(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                sectionKey, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
                pool)
                {
                    freeKey(sectionKey, pool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15522, 15558);
                    return 0;
                }


                int
                f_120_15598_15624(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15598, 15624);
                    return 0;
                }


                int
                f_120_15643_15673(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15643, 15673);
                    return 0;
                }


                int
                f_120_15692_15733(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15692, 15733);
                    return 0;
                }


                int
                f_120_15752_15801(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>
                this_param, System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15752, 15801);
                    return 0;
                }


                int
                f_120_15868_15904(System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                sectionKey, Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
                pool)
                {
                    freeKey(sectionKey, pool);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 15868, 15904);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 8948, 16161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 8948, 16161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryParseSeverity(string value, out ReportDiagnostic severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 16173, 17452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16280, 16328);

                var
                comparer = f_120_16295_16327()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16342, 17379) || true) && (f_120_16346_16379(comparer, value, "default"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16342, 17379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16413, 16449);

                    severity = ReportDiagnostic.Default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16467, 16479);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16342, 17379);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16342, 17379);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16513, 17379) || true) && (f_120_16517_16548(comparer, value, "error"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16513, 17379);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16582, 16616);

                        severity = ReportDiagnostic.Error;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16634, 16646);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16513, 17379);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16513, 17379);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16680, 17379) || true) && (f_120_16684_16717(comparer, value, "warning"))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16680, 17379);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16751, 16784);

                            severity = ReportDiagnostic.Warn;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16802, 16814);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16680, 17379);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16680, 17379);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16848, 17379) || true) && (f_120_16852_16888(comparer, value, "suggestion"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16848, 17379);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16922, 16955);

                                severity = ReportDiagnostic.Info;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 16973, 16985);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16848, 17379);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 16848, 17379);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17019, 17379) || true) && (f_120_17023_17055(comparer, value, "silent") || (DynAbs.Tracing.TraceSender.Expression_False(120, 17023, 17096) || f_120_17059_17096(comparer, value, "refactoring")))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 17019, 17379);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17130, 17165);

                                    severity = ReportDiagnostic.Hidden;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17183, 17195);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 17019, 17379);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 17019, 17379);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17229, 17379) || true) && (f_120_17233_17263(comparer, value, "none"))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 17229, 17379);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17297, 17334);

                                        severity = ReportDiagnostic.Suppress;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17352, 17364);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 17229, 17379);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 17019, 17379);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16848, 17379);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16680, 17379);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16513, 17379);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 16342, 17379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17395, 17414);

                severity = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17428, 17441);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 16173, 17452);

                System.StringComparer
                f_120_16295_16327()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 16295, 16327);
                    return return_v;
                }


                bool
                f_120_16346_16379(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16346, 16379);
                    return return_v;
                }


                bool
                f_120_16517_16548(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16517, 16548);
                    return return_v;
                }


                bool
                f_120_16684_16717(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16684, 16717);
                    return return_v;
                }


                bool
                f_120_16852_16888(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 16852, 16888);
                    return return_v;
                }


                bool
                f_120_17023_17055(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17023, 17055);
                    return return_v;
                }


                bool
                f_120_17059_17096(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17059, 17096);
                    return return_v;
                }


                bool
                f_120_17233_17263(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17233, 17263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 16173, 17452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 16173, 17452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AnalyzerConfigOptionsResult ParseGlobalConfigOptions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 17464, 18551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17551, 17604);

                var
                treeOptionsBuilder = f_120_17576_17603(_treeOptionsPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17618, 17679);

                var
                analyzerOptionsBuilder = f_120_17647_17678(_analyzerOptionsPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17693, 17756);

                var
                diagnosticBuilder = f_120_17717_17755()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 17772, 18075);

                f_120_17772_18074(f_120_17792_17819(_globalConfig), treeOptionsBuilder, analyzerOptionsBuilder, diagnosticBuilder, GlobalAnalyzerConfigBuilder.GlobalConfigPath, _diagnosticIdCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18091, 18301);

                var
                options = f_120_18105_18300(f_120_18155_18187(treeOptionsBuilder), f_120_18206_18242(analyzerOptionsBuilder), f_120_18261_18299(diagnosticBuilder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18317, 18344);

                f_120_18317_18343(
                            treeOptionsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18358, 18389);

                f_120_18358_18388(analyzerOptionsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18403, 18445);

                f_120_18403_18444(_treeOptionsPool, treeOptionsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18459, 18509);

                f_120_18459_18508(_analyzerOptionsPool, analyzerOptionsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18525, 18540);

                return options;
                DynAbs.Tracing.TraceSender.TraceExitMethod(120, 17464, 18551);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                f_120_17576_17603(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17576, 17603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                f_120_17647_17678(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17647, 17678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                f_120_17717_17755()
                {
                    var return_v = ArrayBuilder<Diagnostic>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17717, 17755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig.Section
                f_120_17792_17819(Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                this_param)
                {
                    var return_v = this_param.GlobalSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 17792, 17819);
                    return return_v;
                }


                int
                f_120_17772_18074(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                section, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                treeBuilder, System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                analyzerBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                diagnosticBuilder, string
                analyzerConfigPath, System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
                diagIdCache)
                {
                    ParseSectionOptions(section, treeBuilder, analyzerBuilder, diagnosticBuilder, analyzerConfigPath, diagIdCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 17772, 18074);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_120_18155_18187(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18155, 18187);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_120_18206_18242(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18206, 18242);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_120_18261_18299(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18261, 18299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult
                f_120_18105_18300(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                treeOptions, System.Collections.Immutable.ImmutableDictionary<string, string>
                analyzerOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult(treeOptions, analyzerOptions, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18105, 18300);
                    return return_v;
                }


                int
                f_120_18317_18343(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18317, 18343);
                    return 0;
                }


                int
                f_120_18358_18388(System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18358, 18388);
                    return 0;
                }


                int
                f_120_18403_18444(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>
                this_param, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18403, 18444);
                    return 0;
                }


                int
                f_120_18459_18508(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>
                this_param, System.Collections.Immutable.ImmutableDictionary<string, string>.Builder
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 18459, 18508);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 17464, 18551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 17464, 18551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ParseSectionOptions(Section section, TreeOptions.Builder treeBuilder, AnalyzerOptions.Builder analyzerBuilder, ArrayBuilder<Diagnostic> diagnosticBuilder, string analyzerConfigPath, ConcurrentDictionary<ReadOnlyMemory<char>, string> diagIdCache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 18563, 21316);
                string diagId = default(string);
                Microsoft.CodeAnalysis.ReportDiagnostic severity = default(Microsoft.CodeAnalysis.ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18853, 18912);

                const string
                diagnosticOptionPrefix = "dotnet_diagnostic."
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18926, 18976);

                const string
                diagnosticOptionSuffix = ".severity"
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 18992, 21305);
                    foreach (var (key, value) in f_120_19021_19039_I(f_120_19021_19039(section)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 18992, 21305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19137, 19159);

                        int
                        diagIdLength = -1
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19177, 19485) || true) && (f_120_19181_19245(key, diagnosticOptionPrefix, StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(120, 19181, 19332) && f_120_19270_19332(key, diagnosticOptionSuffix, StringComparison.Ordinal)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 19177, 19485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19374, 19466);

                            diagIdLength = f_120_19389_19399(key) - (f_120_19403_19432(diagnosticOptionPrefix) + f_120_19435_19464(diagnosticOptionSuffix));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 19177, 19485);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19505, 21290) || true) && (diagIdLength >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 19505, 21290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19568, 19665);

                            ReadOnlyMemory<char>
                            idSlice = f_120_19599_19613(key).Slice(f_120_19620_19649(diagnosticOptionPrefix), diagIdLength)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 19888, 20598) || true) && (!f_120_19893_19941(diagIdCache, idSlice, out diagId))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 19888, 20598);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 20464, 20492);

                                diagId = idSlice.ToString();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 20518, 20575);

                                diagId = f_120_20527_20574(diagIdCache, f_120_20548_20565(diagId), diagId);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 19888, 20598);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 20622, 21160) || true) && (f_120_20626_20680(value, out severity))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 20622, 21160);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 20730, 20761);

                                treeBuilder[diagId] = severity;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 20622, 21160);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 20622, 21160);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 20859, 21137);

                                f_120_20859_21136(diagnosticBuilder, f_120_20881_21135(InvalidAnalyzerConfigSeverityDescriptor, f_120_20999_21012(), diagId, value, analyzerConfigPath));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 20622, 21160);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 19505, 21290);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 19505, 21290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 21242, 21271);

                            analyzerBuilder[key] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 19505, 21290);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 18992, 21305);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 2314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 2314);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 18563, 21316);

                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_120_19021_19039(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 19021, 19039);
                    return return_v;
                }


                bool
                f_120_19181_19245(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 19181, 19245);
                    return return_v;
                }


                bool
                f_120_19270_19332(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 19270, 19332);
                    return return_v;
                }


                int
                f_120_19389_19399(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 19389, 19399);
                    return return_v;
                }


                int
                f_120_19403_19432(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 19403, 19432);
                    return return_v;
                }


                int
                f_120_19435_19464(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 19435, 19464);
                    return return_v;
                }


                System.ReadOnlyMemory<char>
                f_120_19599_19613(string
                text)
                {
                    var return_v = text.AsMemory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 19599, 19613);
                    return return_v;
                }


                int
                f_120_19620_19649(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 19620, 19649);
                    return return_v;
                }


                bool
                f_120_19893_19941(System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
                this_param, System.ReadOnlyMemory<char>
                key, out string
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 19893, 19941);
                    return return_v;
                }


                System.ReadOnlyMemory<char>
                f_120_20548_20565(string
                text)
                {
                    var return_v = text.AsMemory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 20548, 20565);
                    return return_v;
                }


                string
                f_120_20527_20574(System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
                this_param, System.ReadOnlyMemory<char>
                key, string
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 20527, 20574);
                    return return_v;
                }


                bool
                f_120_20626_20680(string
                value, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = TryParseSeverity(value, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 20626, 20680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_120_20999_21012()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 20999, 21012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_120_20881_21135(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 20881, 21135);
                    return return_v;
                }


                int
                f_120_20859_21136(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 20859, 21136);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, string>
                f_120_19021_19039_I(System.Collections.Immutable.ImmutableDictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 19021, 19039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 18563, 21316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 18563, 21316);
            }
        }

        internal static GlobalAnalyzerConfig MergeGlobalConfigs(ArrayBuilder<AnalyzerConfig> analyzerConfigs, out ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(120, 21928, 22815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22098, 22190);

                GlobalAnalyzerConfigBuilder
                globalAnalyzerConfigBuilder = f_120_22156_22189()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22204, 22262);

                DiagnosticBag
                diagnosticBag = f_120_22234_22261()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22285, 22290);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22276, 22624) || true) && (i < f_120_22296_22317(analyzerConfigs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22319, 22322)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(120, 22276, 22624))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 22276, 22624);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22356, 22609) || true) && (f_120_22360_22387(f_120_22360_22378(analyzerConfigs, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 22356, 22609);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22429, 22514);

                            globalAnalyzerConfigBuilder.MergeIntoGlobalConfig(f_120_22479_22497(analyzerConfigs, i), diagnosticBag);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22536, 22564);

                            f_120_22536_22563(analyzerConfigs, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22586, 22590);

                            i--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 22356, 22609);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22640, 22708);

                var
                globalConfig = globalAnalyzerConfigBuilder.Build(diagnosticBag)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22722, 22770);

                diagnostics = f_120_22736_22769(diagnosticBag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 22784, 22804);

                return globalConfig;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(120, 21928, 22815);

                Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfigBuilder
                f_120_22156_22189()
                {
                    var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfigBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 22156, 22189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_120_22234_22261()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 22234, 22261);
                    return return_v;
                }


                int
                f_120_22296_22317(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 22296, 22317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_120_22360_22378(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 22360, 22378);
                    return return_v;
                }


                bool
                f_120_22360_22387(Microsoft.CodeAnalysis.AnalyzerConfig
                this_param)
                {
                    var return_v = this_param.IsGlobal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 22360, 22387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AnalyzerConfig
                f_120_22479_22497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 22479, 22497);
                    return return_v;
                }


                int
                f_120_22536_22563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 22536, 22563);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_120_22736_22769(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 22736, 22769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 21928, 22815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 21928, 22815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal struct GlobalAnalyzerConfigBuilder
        {

            private ImmutableDictionary<string, ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder? _values;

            private ImmutableDictionary<string, ImmutableDictionary<string, (int globalLevel, ArrayBuilder<string> configPaths)>.Builder>.Builder? _duplicates;

            internal const string
            GlobalConfigPath = "<Global Config>"
            ;

            internal const string
            GlobalSectionName = "Global Section"
            ;

            internal void MergeIntoGlobalConfig(AnalyzerConfig config, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 23487, 24796);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 23605, 24001) || true) && (_values is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 23605, 24001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 23666, 23808);

                        _values = f_120_23676_23807(f_120_23778_23806());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 23830, 23982);

                        _duplicates = f_120_23844_23981(f_120_23952_23980());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 23605, 24001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24021, 24118);

                    MergeSection(f_120_24034_24051(config), f_120_24053_24073(config), f_120_24075_24093(config), isGlobalSection: true);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24136, 24781);
                        foreach (var section in f_120_24160_24180_I(f_120_24160_24180(config)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 24136, 24781);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24222, 24762) || true) && (f_120_24226_24266(f_120_24253_24265(section)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 24222, 24762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24316, 24401);

                                MergeSection(f_120_24329_24346(config), section, f_120_24357_24375(config), isGlobalSection: false);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 24222, 24762);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 24222, 24762);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24499, 24739);

                                f_120_24499_24738(diagnostics, f_120_24515_24737(InvalidGlobalAnalyzerSectionDescriptor, f_120_24632_24645(), f_120_24676_24688(section), f_120_24719_24736(config)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 24222, 24762);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 24136, 24781);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 646);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 23487, 24796);

                    System.Collections.Generic.IEqualityComparer<string>
                    f_120_23778_23806()
                    {
                        var return_v = Section.NameEqualityComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 23778, 23806);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string, string, int)>.Builder>.Builder
                    f_120_23676_23807(System.Collections.Generic.IEqualityComparer<string>
                    keyComparer)
                    {
                        var return_v = ImmutableDictionary.CreateBuilder<string, ImmutableDictionary<string, (string, string, int)>.Builder>(keyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 23676, 23807);
                        return return_v;
                    }


                    System.Collections.Generic.IEqualityComparer<string>
                    f_120_23952_23980()
                    {
                        var return_v = Section.NameEqualityComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 23952, 23980);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (int, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>)>.Builder>.Builder
                    f_120_23844_23981(System.Collections.Generic.IEqualityComparer<string>
                    keyComparer)
                    {
                        var return_v = ImmutableDictionary.CreateBuilder<string, ImmutableDictionary<string, (int, ArrayBuilder<string>)>.Builder>(keyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 23844, 23981);
                        return return_v;
                    }


                    string
                    f_120_24034_24051(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.PathToFile;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24034, 24051);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_120_24053_24073(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.GlobalSection;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24053, 24073);
                        return return_v;
                    }


                    int
                    f_120_24075_24093(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.GlobalLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24075, 24093);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    f_120_24160_24180(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.NamedSections;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24160, 24180);
                        return return_v;
                    }


                    string
                    f_120_24253_24265(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24253, 24265);
                        return return_v;
                    }


                    bool
                    f_120_24226_24266(string
                    sectionName)
                    {
                        var return_v = IsAbsoluteEditorConfigPath(sectionName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 24226, 24266);
                        return return_v;
                    }


                    string
                    f_120_24329_24346(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.PathToFile;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24329, 24346);
                        return return_v;
                    }


                    int
                    f_120_24357_24375(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.GlobalLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24357, 24375);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_120_24632_24645()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24632, 24645);
                        return return_v;
                    }


                    string
                    f_120_24676_24688(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24676, 24688);
                        return return_v;
                    }


                    string
                    f_120_24719_24736(Microsoft.CodeAnalysis.AnalyzerConfig
                    this_param)
                    {
                        var return_v = this_param.PathToFile;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 24719, 24736);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_120_24515_24737(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 24515, 24737);
                        return return_v;
                    }


                    int
                    f_120_24499_24738(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 24499, 24738);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    f_120_24160_24180_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 24160, 24180);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 23487, 24796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 23487, 24796);
                }
            }

            internal GlobalAnalyzerConfig Build(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 24812, 26664);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24907, 25128) || true) && (_values is null || (DynAbs.Tracing.TraceSender.Expression_False(120, 24911, 24949) || _duplicates is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 24907, 25128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 24991, 25109);

                        return f_120_24998_25108(f_120_25023_25076(GlobalSectionName, AnalyzerOptions.Empty), ImmutableArray<Section>.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 24907, 25128);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25209, 25904);
                        foreach ((var section, var keys) in f_120_25245_25256_I(_duplicates))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 25209, 25904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25298, 25356);

                            bool
                            isGlobalSection = f_120_25321_25355(section)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25378, 25445);

                            string
                            sectionName = (DynAbs.Tracing.TraceSender.Conditional_F1(120, 25399, 25414) || ((isGlobalSection && DynAbs.Tracing.TraceSender.Conditional_F2(120, 25417, 25434)) || DynAbs.Tracing.TraceSender.Conditional_F3(120, 25437, 25444))) ? GlobalSectionName : section
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25467, 25885);
                                foreach ((var keyName, (_, var configPaths)) in f_120_25515_25519_I(keys))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 25467, 25885);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25569, 25862);

                                    f_120_25569_25861(diagnostics, f_120_25585_25860(MultipleGlobalAnalyzerKeysDescriptor, f_120_25702_25715(), keyName, sectionName, f_120_25829_25859(", ", configPaths)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 25467, 25885);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 419);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 419);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 25209, 25904);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 696);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 696);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 25922, 25941);

                    _duplicates = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26018, 26067);

                    Section
                    globalSection = GetSection(string.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26085, 26114);

                    f_120_26085_26113(_values, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26134, 26219);

                    ArrayBuilder<Section>
                    namedSectionBuilder = f_120_26178_26218(f_120_26204_26217(_values))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26237, 26395);
                        foreach (var sectionName in f_120_26265_26285_I(f_120_26265_26285(f_120_26265_26277(_values))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 26237, 26395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26327, 26376);

                            f_120_26327_26375(namedSectionBuilder, GetSection(sectionName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 26237, 26395);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 159);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 159);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26460, 26578);

                    GlobalAnalyzerConfig
                    globalConfig = f_120_26496_26577(globalSection, f_120_26536_26576(namedSectionBuilder))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26596, 26611);

                    _values = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26629, 26649);

                    return globalConfig;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 24812, 26664);

                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_120_25023_25076(string
                    name, System.Collections.Immutable.ImmutableDictionary<string, string>
                    properties)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.Section(name, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25023, 25076);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                    f_120_24998_25108(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    globalSection, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    namedSections)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig(globalSection, namedSections);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 24998, 25108);
                        return return_v;
                    }


                    bool
                    f_120_25321_25355(string
                    value)
                    {
                        var return_v = string.IsNullOrWhiteSpace(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25321, 25355);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location
                    f_120_25702_25715()
                    {
                        var return_v = Location.None;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 25702, 25715);
                        return return_v;
                    }


                    string
                    f_120_25829_25859(string
                    separator, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    values)
                    {
                        var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25829, 25859);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_120_25585_25860(Microsoft.CodeAnalysis.DiagnosticDescriptor
                    descriptor, Microsoft.CodeAnalysis.Location
                    location, params object?[]
                    messageArgs)
                    {
                        var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25585, 25860);
                        return return_v;
                    }


                    int
                    f_120_25569_25861(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25569, 25861);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder
                    f_120_25515_25519_I(System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25515, 25519);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder>.Builder
                    f_120_25245_25256_I(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 25245, 25256);
                        return return_v;
                    }


                    bool
                    f_120_26085_26113(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param, string
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26085, 26113);
                        return return_v;
                    }


                    int
                    f_120_26204_26217(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 26204, 26217);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    f_120_26178_26218(int
                    size)
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.Section>(size);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26178, 26218);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_120_26265_26277(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param)
                    {
                        var return_v = this_param.Keys;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 26265, 26277);
                        return return_v;
                    }


                    System.Linq.IOrderedEnumerable<string>
                    f_120_26265_26285(System.Collections.Generic.IEnumerable<string>
                    source)
                    {
                        var return_v = source.Order<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26265, 26285);
                        return return_v;
                    }


                    int
                    f_120_26327_26375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param, Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26327, 26375);
                        return 0;
                    }


                    System.Linq.IOrderedEnumerable<string>
                    f_120_26265_26285_I(System.Linq.IOrderedEnumerable<string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26265, 26285);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    f_120_26536_26576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26536, 26576);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig
                    f_120_26496_26577(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    globalSection, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
                    namedSections)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AnalyzerConfigSet.GlobalAnalyzerConfig(globalSection, namedSections);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26496, 26577);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 24812, 26664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 24812, 26664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Section GetSection(string sectionName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 26680, 27037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26759, 26791);

                    f_120_26759_26790(_values is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26811, 26843);

                    var
                    dict = f_120_26822_26842(_values, sectionName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26861, 26964);

                    var
                    result = f_120_26874_26963(dict, d => d.Key, d => d.Value.value, f_120_26933_26962())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 26982, 27022);

                    return f_120_26989_27021(sectionName, result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 26680, 27037);

                    int
                    f_120_26759_26790(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26759, 26790);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    f_120_26822_26842(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 26822, 26842);
                        return return_v;
                    }


                    System.StringComparer
                    f_120_26933_26962()
                    {
                        var return_v = Section.PropertiesKeyComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 26933, 26962);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, string>
                    f_120_26874_26963(System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    source, System.Func<System.Collections.Generic.KeyValuePair<string, (string value, string configPath, int globalLevel)>, string>
                    keySelector, System.Func<System.Collections.Generic.KeyValuePair<string, (string value, string configPath, int globalLevel)>, string>
                    elementSelector, System.StringComparer
                    keyComparer)
                    {
                        var return_v = source.ToImmutableDictionary<System.Collections.Generic.KeyValuePair<string, (string value, string configPath, int globalLevel)>, string, string>(keySelector, elementSelector, (System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26874, 26963);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    f_120_26989_27021(string
                    name, System.Collections.Immutable.ImmutableDictionary<string, string>
                    properties)
                    {
                        var return_v = new Microsoft.CodeAnalysis.AnalyzerConfig.Section(name, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 26989, 27021);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 26680, 27037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 26680, 27037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void MergeSection(string configPath, Section section, int globalLevel, bool isGlobalSection)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(120, 27053, 30691);
                    System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder sectionDict = default(System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder);
                    System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder duplicateDict = default(System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder);
                    (string value, string configPath, int globalLevel) sectionValue = default((string value, string configPath, int globalLevel));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27186, 27218);

                    f_120_27186_27217(_values is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27236, 27272);

                    f_120_27236_27271(_duplicates is object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27292, 27583) || true) && (!f_120_27297_27351(_values, f_120_27317_27329(section), out sectionDict))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 27292, 27583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27393, 27503);

                        sectionDict = f_120_27407_27502(f_120_27472_27501());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27525, 27564);

                        f_120_27525_27563(_values, f_120_27537_27549(section), sectionDict);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 27292, 27583);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27603, 27664);

                    f_120_27603_27663(
                                    _duplicates, f_120_27627_27639(section), out duplicateDict);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27682, 30676);
                        foreach ((var key, var value) in f_120_27715_27733_I(f_120_27715_27733(section)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 27682, 30676);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27775, 27995) || true) && (isGlobalSection && (DynAbs.Tracing.TraceSender.Expression_True(120, 27779, 27913) && (f_120_27799_27851(f_120_27799_27828(), key, GlobalKey) || (DynAbs.Tracing.TraceSender.Expression_False(120, 27799, 27912) || f_120_27855_27912(f_120_27855_27884(), key, GlobalLevelKey)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 27775, 27995);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 27963, 27972);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 27775, 27995);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28019, 28090);

                            bool
                            keyInSection = f_120_28039_28089(sectionDict, key, out sectionValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28114, 28191);

                            (int globalLevel, ArrayBuilder<string> configPaths)
                            duplicateValue = default
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28213, 28311);

                            bool
                            keyDuplicated = !keyInSection && (DynAbs.Tracing.TraceSender.Expression_True(120, 28234, 28310) && f_120_28251_28302_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(duplicateDict, 120, 28251, 28302)?.TryGetValue(key, out duplicateValue)) == true)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28436, 30657) || true) && (!keyInSection && (DynAbs.Tracing.TraceSender.Expression_True(120, 28440, 28471) && !keyDuplicated))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 28436, 30657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28521, 28576);

                                f_120_28521_28575(sectionDict, key, (value, configPath, globalLevel));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 28436, 30657);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 28436, 30657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28674, 28768);

                                int
                                currentGlobalLevel = (DynAbs.Tracing.TraceSender.Conditional_F1(120, 28699, 28711) || ((keyInSection && DynAbs.Tracing.TraceSender.Conditional_F2(120, 28714, 28738)) || DynAbs.Tracing.TraceSender.Conditional_F3(120, 28741, 28767))) ? sectionValue.globalLevel : duplicateValue.globalLevel
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28887, 30634) || true) && (currentGlobalLevel < globalLevel)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 28887, 30634);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 28981, 29033);

                                    sectionDict[key] = (value, configPath, globalLevel);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29063, 29204) || true) && (keyDuplicated)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 29063, 29204);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29146, 29173);

                                        f_120_29146_29172(duplicateDict!, key);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 29063, 29204);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 28887, 30634);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 28887, 30634);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29329, 30634) || true) && (currentGlobalLevel == globalLevel)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 29329, 30634);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29424, 29743) || true) && (duplicateDict is null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 29424, 29743);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29515, 29633);

                                            duplicateDict = f_120_29531_29632(f_120_29602_29631());
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29667, 29712);

                                            f_120_29667_29711(_duplicates, f_120_29683_29695(section), duplicateDict);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 29424, 29743);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29847, 29946);

                                        ArrayBuilder<string>
                                        configList = duplicateValue.configPaths ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>?>(120, 29881, 29945) ?? f_120_29911_29945())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 29976, 30003);

                                        f_120_29976_30002(configList, configPath);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30033, 30080);

                                        duplicateDict[key] = (globalLevel, configList);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30231, 30607) || true) && (keyInSection)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(120, 30231, 30607);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30313, 30346);

                                            var
                                            originalEntry = sectionValue
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30380, 30435);

                                            f_120_30380_30434(originalEntry.globalLevel == globalLevel);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30471, 30495);

                                            f_120_30471_30494(
                                                                            sectionDict, key);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 30529, 30576);

                                            f_120_30529_30575(configList, 0, originalEntry.configPath);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 30231, 30607);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(120, 29329, 30634);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(120, 28887, 30634);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(120, 28436, 30657);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(120, 27682, 30676);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(120, 1, 2995);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(120, 1, 2995);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(120, 27053, 30691);

                    int
                    f_120_27186_27217(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27186, 27217);
                        return 0;
                    }


                    int
                    f_120_27236_27271(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27236, 27271);
                        return 0;
                    }


                    string
                    f_120_27317_27329(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27317, 27329);
                        return return_v;
                    }


                    bool
                    f_120_27297_27351(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param, string
                    key, out System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27297, 27351);
                        return return_v;
                    }


                    System.StringComparer
                    f_120_27472_27501()
                    {
                        var return_v = Section.PropertiesKeyComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27472, 27501);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, (string, string, int)>.Builder
                    f_120_27407_27502(System.StringComparer
                    keyComparer)
                    {
                        var return_v = ImmutableDictionary.CreateBuilder<string, (string, string, int)>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27407, 27502);
                        return return_v;
                    }


                    string
                    f_120_27537_27549(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27537, 27549);
                        return return_v;
                    }


                    int
                    f_120_27525_27563(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder>.Builder
                    this_param, string
                    key, System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27525, 27563);
                        return 0;
                    }


                    string
                    f_120_27627_27639(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27627, 27639);
                        return return_v;
                    }


                    bool
                    f_120_27603_27663(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder>.Builder
                    this_param, string
                    key, out System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27603, 27663);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, string>
                    f_120_27715_27733(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27715, 27733);
                        return return_v;
                    }


                    System.StringComparer
                    f_120_27799_27828()
                    {
                        var return_v = Section.PropertiesKeyComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27799, 27828);
                        return return_v;
                    }


                    bool
                    f_120_27799_27851(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27799, 27851);
                        return return_v;
                    }


                    System.StringComparer
                    f_120_27855_27884()
                    {
                        var return_v = Section.PropertiesKeyComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 27855, 27884);
                        return return_v;
                    }


                    bool
                    f_120_27855_27912(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27855, 27912);
                        return return_v;
                    }


                    bool
                    f_120_28039_28089(System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    this_param, string
                    key, out (string value, string configPath, int globalLevel)
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 28039, 28089);
                        return return_v;
                    }


                    bool?
                    f_120_28251_28302_I(bool?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 28251, 28302);
                        return return_v;
                    }


                    int
                    f_120_28521_28575(System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    this_param, string
                    key, (string value, string configPath, int globalLevel)
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 28521, 28575);
                        return 0;
                    }


                    bool
                    f_120_29146_29172(System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder
                    this_param, string
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 29146, 29172);
                        return return_v;
                    }


                    System.StringComparer
                    f_120_29602_29631()
                    {
                        var return_v = Section.PropertiesKeyComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 29602, 29631);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, (int, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>)>.Builder
                    f_120_29531_29632(System.StringComparer
                    keyComparer)
                    {
                        var return_v = ImmutableDictionary.CreateBuilder<string, (int, ArrayBuilder<string>)>((System.Collections.Generic.IEqualityComparer<string>)keyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 29531, 29632);
                        return return_v;
                    }


                    string
                    f_120_29683_29695(Microsoft.CodeAnalysis.AnalyzerConfig.Section
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 29683, 29695);
                        return return_v;
                    }


                    int
                    f_120_29667_29711(System.Collections.Immutable.ImmutableDictionary<string, System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder>.Builder
                    this_param, string
                    key, System.Collections.Immutable.ImmutableDictionary<string, (int globalLevel, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string> configPaths)>.Builder
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 29667, 29711);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    f_120_29911_29945()
                    {
                        var return_v = ArrayBuilder<string>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 29911, 29945);
                        return return_v;
                    }


                    int
                    f_120_29976_30002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param, string
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 29976, 30002);
                        return 0;
                    }


                    int
                    f_120_30380_30434(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 30380, 30434);
                        return 0;
                    }


                    bool
                    f_120_30471_30494(System.Collections.Immutable.ImmutableDictionary<string, (string value, string configPath, int globalLevel)>.Builder
                    this_param, string
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 30471, 30494);
                        return return_v;
                    }


                    int
                    f_120_30529_30575(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
                    this_param, int
                    index, string
                    item)
                    {
                        this_param.Insert(index, item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 30529, 30575);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableDictionary<string, string>
                    f_120_27715_27733_I(System.Collections.Immutable.ImmutableDictionary<string, string>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 27715, 27733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 27053, 30691);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 27053, 30691);
                }
            }
            static GlobalAnalyzerConfigBuilder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(120, 22952, 30702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 23361, 23397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 23434, 23470);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(120, 22952, 30702);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 22952, 30702);
            }
        }
        internal sealed class GlobalAnalyzerConfig
        {
            internal AnalyzerConfig.Section GlobalSection { get; }

            internal ImmutableArray<AnalyzerConfig.Section> NamedSections { get; }

            public GlobalAnalyzerConfig(AnalyzerConfig.Section globalSection, ImmutableArray<AnalyzerConfig.Section> namedSections)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(120, 31523, 31768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 31367, 31421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 31675, 31705);

                    GlobalSection = globalSection;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 31723, 31753);

                    NamedSections = namedSections;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(120, 31523, 31768);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(120, 31523, 31768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 31523, 31768);
                }
            }

            static GlobalAnalyzerConfig()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(120, 31300, 31779);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(120, 31300, 31779);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 31300, 31779);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(120, 31300, 31779);
        }

        static AnalyzerConfigSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(120, 1188, 31786);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4352, 4765);
            InvalidAnalyzerConfigSeverityDescriptor = f_120_4407_4765("InvalidSeverityInAnalyzerConfig", f_120_4502_4565(), f_120_4584_4641(), "AnalyzerConfig", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 4823, 5218);
            MultipleGlobalAnalyzerKeysDescriptor = f_120_4875_5218("MultipleGlobalAnalyzerKeys", f_120_4965_5023(), f_120_5042_5094(), "AnalyzerConfig", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceSimpleStatement(120, 5276, 5667);
            InvalidGlobalAnalyzerSectionDescriptor = f_120_5330_5667("InvalidGlobalSectionName", f_120_5418_5474(), f_120_5493_5543(), "AnalyzerConfig", DiagnosticSeverity.Warning, isEnabledByDefault: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(120, 1188, 31786);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(120, 1188, 31786);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(120, 1188, 31786);

        System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>
        f_120_2294_2385(Roslyn.Utilities.CharMemoryEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.ReadOnlyMemory<char>, string>((System.Collections.Generic.IEqualityComparer<System.ReadOnlyMemory<char>>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 2294, 2385);
            return return_v;
        }


        Microsoft.CodeAnalysis.AnalyzerConfigSet.SequenceEqualComparer
        f_120_2672_2702()
        {
            var return_v = SequenceEqualComparer.Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 2672, 2702);
            return return_v;
        }


        Microsoft.CodeAnalysis.ConcurrentCache<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>
        f_120_2604_2703(int
        size, Microsoft.CodeAnalysis.AnalyzerConfigSet.SequenceEqualComparer
        keyComparer)
        {
            var return_v = new Microsoft.CodeAnalysis.ConcurrentCache<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>, Microsoft.CodeAnalysis.AnalyzerConfigOptionsResult>(size, (System.Collections.Generic.IEqualityComparer<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 2604, 2703);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>
        f_120_2815_2948(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 2815, 2948);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>
        f_120_3050_3177(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Immutable.ImmutableDictionary<string, string>.Builder>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 3050, 3177);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>
        f_120_3251_3307(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>.Factory
        factory)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<System.Collections.Generic.List<Microsoft.CodeAnalysis.AnalyzerConfig.Section>>(factory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 3251, 3307);
            return return_v;
        }


        static string
        f_120_4502_4565()
        {
            var return_v = CodeAnalysisResources.WRN_InvalidSeverityInAnalyzerConfig_Title;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 4502, 4565);
            return return_v;
        }


        static string
        f_120_4584_4641()
        {
            var return_v = CodeAnalysisResources.WRN_InvalidSeverityInAnalyzerConfig;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 4584, 4641);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_120_4407_4765(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(
                id, title, messageFormat, category, defaultSeverity, 
                isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 4407, 4765);
            return return_v;
        }


        static string
        f_120_4965_5023()
        {
            var return_v = CodeAnalysisResources.WRN_MultipleGlobalAnalyzerKeys_Title;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 4965, 5023);
            return return_v;
        }


        static string
        f_120_5042_5094()
        {
            var return_v = CodeAnalysisResources.WRN_MultipleGlobalAnalyzerKeys;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 5042, 5094);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_120_4875_5218(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, 
                messageFormat, category, defaultSeverity, 
                isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 4875, 5218);
            return return_v;
        }


        static string
        f_120_5418_5474()
        {
            var return_v = CodeAnalysisResources.WRN_InvalidGlobalSectionName_Title;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 5418, 5474);
            return return_v;
        }


        static string
        f_120_5493_5543()
        {
            var return_v = CodeAnalysisResources.WRN_InvalidGlobalSectionName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 5493, 5543);
            return return_v;
        }


        static Microsoft.CodeAnalysis.DiagnosticDescriptor
        f_120_5330_5667(string
        id, string
        title, string
        messageFormat, string
        category, Microsoft.CodeAnalysis.DiagnosticSeverity
        defaultSeverity, bool
        isEnabledByDefault, params string[]
        customTags)
        {
            var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, 
                category, defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 5330, 5667);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>>
        f_120_6769_6855(int
        capacity)
        {
            var return_v = ArrayBuilder<ImmutableArray<SectionNameMatcher?>>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6769, 6855);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        f_120_7119_7193(int
        capacity)
        {
            var return_v = ArrayBuilder<SectionNameMatcher?>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7119, 7193);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
        f_120_7236_7256(Microsoft.CodeAnalysis.AnalyzerConfig
        this_param)
        {
            var return_v = this_param.NamedSections;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 7236, 7256);
            return return_v;
        }


        static string
        f_120_7371_7383(Microsoft.CodeAnalysis.AnalyzerConfig.Section
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 7371, 7383);
            return return_v;
        }


        static Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?
        f_120_7328_7384(string
        sectionName)
        {
            var return_v = AnalyzerConfig.TryCreateSectionNameMatcher(sectionName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7328, 7384);
            return return_v;
        }


        static int
        f_120_7407_7427(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        this_param, Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7407, 7427);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
        f_120_7236_7256_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.Section>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7236, 7256);
            return return_v;
        }


        static int
        f_120_7480_7493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 7480, 7493);
            return return_v;
        }


        static int
        f_120_7467_7525(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7467, 7525);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        f_120_7562_7590(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7562, 7590);
            return return_v;
        }


        static int
        f_120_7546_7591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>>
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7546, 7591);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig>
        f_120_6895_6911_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 6895, 6911);
            return return_v;
        }


        static int
        f_120_7636_7653(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(120, 7636, 7653);
            return return_v;
        }


        static int
        f_120_7623_7681(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7623, 7681);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>>
        f_120_7718_7750(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AnalyzerConfig.SectionNameMatcher?>>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(120, 7718, 7750);
            return return_v;
        }

    }
}
