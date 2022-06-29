// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerDriver<TLanguageKindEnum> : AnalyzerDriver where TLanguageKindEnum : struct
    {
        private sealed class GroupedAnalyzerActions : IGroupedAnalyzerActions
        {
            public static readonly GroupedAnalyzerActions Empty;

            private GroupedAnalyzerActions(ImmutableArray<(DiagnosticAnalyzer, GroupedAnalyzerActionsForAnalyzer)> groupedActionsAndAnalyzers, in AnalyzerActions analyzerActions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(227, 1065, 1385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 1264, 1318);

                    GroupedActionsByAnalyzer = groupedActionsAndAnalyzers;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 1336, 1370);

                    AnalyzerActions = analyzerActions;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(227, 1065, 1385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(227, 1065, 1385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 1065, 1385);
                }
            }

            public ImmutableArray<(DiagnosticAnalyzer analyzer, GroupedAnalyzerActionsForAnalyzer groupedActions)> GroupedActionsByAnalyzer { get; }

            public AnalyzerActions AnalyzerActions { get; }

            public bool IsEmpty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(227, 1668, 1892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 1712, 1755);

                        var
                        isEmpty = f_227_1726_1754(this, Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 1777, 1836);

                        f_227_1777_1835(isEmpty || (DynAbs.Tracing.TraceSender.Expression_False(227, 1790, 1834) || f_227_1801_1834_M(!f_227_1802_1826().IsEmpty)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 1858, 1873);

                        return isEmpty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(227, 1668, 1892);

                        bool
                        f_227_1726_1754(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                        objA, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                        objB)
                        {
                            var return_v = ReferenceEquals((object)objA, (object)objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 1726, 1754);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer groupedActions)>
                        f_227_1802_1826()
                        {
                            var return_v = GroupedActionsByAnalyzer;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 1802, 1826);
                            return return_v;
                        }


                        bool
                        f_227_1801_1834_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 1801, 1834);
                            return return_v;
                        }


                        int
                        f_227_1777_1835(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 1777, 1835);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(227, 1616, 1907);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 1616, 1907);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public static GroupedAnalyzerActions Create(DiagnosticAnalyzer analyzer, in AnalyzerActions analyzerActions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(227, 1923, 2584);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2064, 2165) || true) && (analyzerActions.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(227, 2064, 2165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2133, 2146);

                        return Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(227, 2064, 2165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2185, 2308);

                    var
                    groupedActions = f_227_2206_2307(analyzer, analyzerActions, analyzerActionsNeedFiltering: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2326, 2469);

                    var
                    groupedActionsAndAnalyzers = ImmutableArray<(DiagnosticAnalyzer, GroupedAnalyzerActionsForAnalyzer)>.Empty.Add((analyzer, groupedActions))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2487, 2569);

                    return f_227_2494_2568(groupedActionsAndAnalyzers, analyzerActions);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(227, 1923, 2584);

                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer
                    f_227_2206_2307(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    analyzerActions, bool
                    analyzerActionsNeedFiltering)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer(analyzer, analyzerActions, analyzerActionsNeedFiltering: analyzerActionsNeedFiltering);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 2206, 2307);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                    f_227_2494_2568(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer)>
                    groupedActionsAndAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    analyzerActions)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions(groupedActionsAndAnalyzers, analyzerActions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 2494, 2568);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(227, 1923, 2584);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 1923, 2584);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static GroupedAnalyzerActions Create(ImmutableArray<DiagnosticAnalyzer> analyzers, in AnalyzerActions analyzerActions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(227, 2600, 3157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2758, 2800);

                    f_227_2758_2799(f_227_2771_2798_M(!analyzers.IsDefaultOrEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 2820, 3062);

                    var
                    groups = analyzers.SelectAsArray((analyzer, analyzerActions) => (analyzer, new GroupedAnalyzerActionsForAnalyzer(analyzer, analyzerActions, analyzerActionsNeedFiltering: true)), analyzerActions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3080, 3142);

                    return f_227_3087_3141(groups, analyzerActions);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(227, 2600, 3157);

                    bool
                    f_227_2771_2798_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 2771, 2798);
                        return return_v;
                    }


                    int
                    f_227_2758_2799(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 2758, 2799);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                    f_227_3087_3141(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer)>
                    groupedActionsAndAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    analyzerActions)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions(groupedActionsAndAnalyzers, analyzerActions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 3087, 3141);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(227, 2600, 3157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 2600, 3157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IGroupedAnalyzerActions IGroupedAnalyzerActions.Append(IGroupedAnalyzerActions igroupedAnalyzerActions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(227, 3173, 4070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3309, 3386);

                    var
                    groupedAnalyzerActions = (GroupedAnalyzerActions)igroupedAnalyzerActions
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3417, 3510);

                    var
                    inputAnalyzers = groupedAnalyzerActions.GroupedActionsByAnalyzer.Select(a => a.analyzer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3528, 3595);

                    var
                    myAnalyzers = f_227_3546_3570().Select(a => a.analyzer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3613, 3669);

                    var
                    intersected = f_227_3631_3668(inputAnalyzers, myAnalyzers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3687, 3723);

                    f_227_3687_3722(f_227_3700_3721(intersected));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3751, 3858);

                    var
                    newGroupedActions = f_227_3775_3799().AddRange(f_227_3809_3856(groupedAnalyzerActions))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3876, 3964);

                    var
                    newAnalyzerActions = f_227_3901_3916().Append(f_227_3924_3962(groupedAnalyzerActions))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 3982, 4055);

                    return f_227_3989_4054(newGroupedActions, newAnalyzerActions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(227, 3173, 4070);

                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer groupedActions)>
                    f_227_3546_3570()
                    {
                        var return_v = GroupedActionsByAnalyzer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 3546, 3570);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    f_227_3631_3668(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    second)
                    {
                        var return_v = first.Intersect<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>(second);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 3631, 3668);
                        return return_v;
                    }


                    bool
                    f_227_3700_3721(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>
                    source)
                    {
                        var return_v = source.IsEmpty<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 3700, 3721);
                        return return_v;
                    }


                    int
                    f_227_3687_3722(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 3687, 3722);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer groupedActions)>
                    f_227_3775_3799()
                    {
                        var return_v = GroupedActionsByAnalyzer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 3775, 3799);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer groupedActions)>
                    f_227_3809_3856(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                    this_param)
                    {
                        var return_v = this_param.GroupedActionsByAnalyzer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 3809, 3856);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    f_227_3901_3916()
                    {
                        var return_v = AnalyzerActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 3901, 3916);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    f_227_3924_3962(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                    this_param)
                    {
                        var return_v = this_param.AnalyzerActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(227, 3924, 3962);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
                    f_227_3989_4054(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer analyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer groupedActions)>
                    groupedActionsAndAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                    analyzerActions)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions(groupedActionsAndAnalyzers, analyzerActions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 3989, 4054);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(227, 3173, 4070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 3173, 4070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static GroupedAnalyzerActions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(227, 772, 4081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(227, 912, 1048);
                Empty = f_227_920_1048(ImmutableArray<(DiagnosticAnalyzer, GroupedAnalyzerActionsForAnalyzer)>.Empty, AnalyzerActions.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(227, 772, 4081);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(227, 772, 4081);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(227, 772, 4081);

            static Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions
            f_227_920_1048(System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer)>
            groupedActionsAndAnalyzers, Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            analyzerActions)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActions(groupedActionsAndAnalyzers, analyzerActions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(227, 920, 1048);
                return return_v;
            }

        }
    }
}
