// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class AnalyzerDriver<TLanguageKindEnum> : AnalyzerDriver where TLanguageKindEnum : struct
    {
        private sealed class GroupedAnalyzerActionsForAnalyzer
        {
            private readonly DiagnosticAnalyzer _analyzer;

            private readonly bool _analyzerActionsNeedFiltering;

            private ImmutableDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>? _lazyNodeActionsByKind;

            private ImmutableDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>>? _lazyOperationActionsByKind;

            private ImmutableArray<CodeBlockStartAnalyzerAction<TLanguageKindEnum>> _lazyCodeBlockStartActions;

            private ImmutableArray<CodeBlockAnalyzerAction> _lazyCodeBlockEndActions;

            private ImmutableArray<CodeBlockAnalyzerAction> _lazyCodeBlockActions;

            private ImmutableArray<OperationBlockStartAnalyzerAction> _lazyOperationBlockStartActions;

            private ImmutableArray<OperationBlockAnalyzerAction> _lazyOperationBlockActions;

            private ImmutableArray<OperationBlockAnalyzerAction> _lazyOperationBlockEndActions;

            public GroupedAnalyzerActionsForAnalyzer(DiagnosticAnalyzer analyzer, in AnalyzerActions analyzerActions, bool analyzerActionsNeedFiltering)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(228, 1636, 2035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 690, 699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 736, 765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 891, 913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 1013, 1040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 1809, 1848);

                    f_228_1809_1847(f_228_1822_1846_M(!analyzerActions.IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 1868, 1889);

                    _analyzer = analyzer;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 1907, 1941);

                    AnalyzerActions = analyzerActions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 1959, 2020);

                    _analyzerActionsNeedFiltering = analyzerActionsNeedFiltering;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(228, 1636, 2035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 1636, 2035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 1636, 2035);
                }
            }

            public AnalyzerActions AnalyzerActions { get; }

            [Conditional("DEBUG")]
            private static void VerifyActions<TAnalyzerAction>(in ImmutableArray<TAnalyzerAction> actions, DiagnosticAnalyzer analyzer)
                            where TAnalyzerAction : AnalyzerAction
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(228, 2114, 2510);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 2362, 2495);
                        foreach (var action in f_228_2385_2392_I(actions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 2362, 2495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 2434, 2476);

                            f_228_2434_2475(f_228_2447_2462(action) == analyzer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(228, 2362, 2495);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(228, 1, 134);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(228, 1, 134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(228, 2114, 2510);

                    Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    f_228_2447_2462(TAnalyzerAction
                    this_param)
                    {
                        var return_v = this_param.Analyzer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 2447, 2462);
                        return return_v;
                    }


                    int
                    f_228_2434_2475(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 2434, 2475);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                    f_228_2385_2392_I(System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 2385, 2392);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 2114, 2510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 2114, 2510);
                }
            }

            private ImmutableArray<TAnalyzerAction> GetFilteredActions<TAnalyzerAction>(in ImmutableArray<TAnalyzerAction> actions)
                            where TAnalyzerAction : AnalyzerAction
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 2719, 2791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 2722, 2791);
                    return f_228_2722_2791(actions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 2719, 2791);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 2719, 2791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 2719, 2791);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                f_228_2722_2791(System.Collections.Immutable.ImmutableArray<TAnalyzerAction>
                actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                analyzer, bool
                analyzerActionsNeedFiltering)
                {
                    var return_v = GetFilteredActions(actions, analyzer, analyzerActionsNeedFiltering);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 2722, 2791);
                    return return_v;
                }

            }

            private static ImmutableArray<TAnalyzerAction> GetFilteredActions<TAnalyzerAction>(
                            in ImmutableArray<TAnalyzerAction> actions,
                            DiagnosticAnalyzer analyzer,
                            bool analyzerActionsNeedFiltering)
                            where TAnalyzerAction : AnalyzerAction
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(228, 2808, 3372);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3139, 3248) || true) && (!analyzerActionsNeedFiltering)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 3139, 3248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3214, 3229);

                        return actions;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(228, 3139, 3248);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3268, 3357);

                    return actions.WhereAsArray((action, analyzer) => action.Analyzer == analyzer, analyzer);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(228, 2808, 3372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 2808, 3372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 2808, 3372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>> NodeActionsByAnalyzerAndKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 3556, 4484);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3600, 4411) || true) && (_lazyNodeActionsByKind == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 3600, 4411);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3684, 3919);

                            var
                            nodeActions = (DynAbs.Tracing.TraceSender.Conditional_F1(228, 3702, 3731) || ((_analyzerActionsNeedFiltering && DynAbs.Tracing.TraceSender.Conditional_F2(228, 3763, 3829)) || DynAbs.Tracing.TraceSender.Conditional_F3(228, 3861, 3918))) ? f_228_3763_3778().GetSyntaxNodeActions<TLanguageKindEnum>(_analyzer) : f_228_3861_3876().GetSyntaxNodeActions<TLanguageKindEnum>()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 3945, 3983);

                            f_228_3945_3982(nodeActions, _analyzer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4009, 4277);

                            var
                            analyzerActionsByKind = (DynAbs.Tracing.TraceSender.Conditional_F1(228, 4037, 4057) || ((f_228_4037_4057_M(!nodeActions.IsEmpty) && DynAbs.Tracing.TraceSender.Conditional_F2(228, 4089, 4139)) || DynAbs.Tracing.TraceSender.Conditional_F3(228, 4171, 4276))) ? f_228_4089_4139(nodeActions) : ImmutableDictionary<TLanguageKindEnum, ImmutableArray<SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>.Empty
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4303, 4388);

                            f_228_4303_4387(ref _lazyNodeActionsByKind, analyzerActionsByKind, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(228, 3600, 4411);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4435, 4465);

                        return _lazyNodeActionsByKind;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(228, 3556, 4484);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_228_3763_3778()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 3763, 3778);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_228_3861_3876()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 3861, 3876);
                            return return_v;
                        }


                        int
                        f_228_3945_3982(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                        actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            VerifyActions(actions, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 3945, 3982);
                            return 0;
                        }


                        bool
                        f_228_4037_4057_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 4037, 4057);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                        f_228_4089_4139(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>
                        nodeActions)
                        {
                            var return_v = AnalyzerExecutor.GetNodeActionsByKind((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>)nodeActions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 4089, 4139);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>?
                        f_228_4303_4387(ref System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>?
                        location1, System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>
                        value, System.Collections.Immutable.ImmutableDictionary<TLanguageKindEnum, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.SyntaxNodeAnalyzerAction<TLanguageKindEnum>>>?
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 4303, 4387);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 3388, 4499);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 3388, 4499);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>> OperationActionsByAnalyzerAndKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 4664, 5441);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4708, 5363) || true) && (_lazyOperationActionsByKind == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 4708, 5363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4797, 4873);

                            var
                            operationActions = f_228_4820_4872(this, f_228_4839_4854().OperationActions)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4899, 4942);

                            f_228_4899_4941(operationActions, _analyzer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 4968, 5224);

                            var
                            analyzerActionsByKind = (DynAbs.Tracing.TraceSender.Conditional_F1(228, 4996, 5018) || ((operationActions.Any() && DynAbs.Tracing.TraceSender.Conditional_F2(228, 5050, 5110)) || DynAbs.Tracing.TraceSender.Conditional_F3(228, 5142, 5223))) ? f_228_5050_5110(operationActions) : ImmutableDictionary<OperationKind, ImmutableArray<OperationAnalyzerAction>>.Empty
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5250, 5340);

                            f_228_5250_5339(ref _lazyOperationActionsByKind, analyzerActionsByKind, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(228, 4708, 5363);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5387, 5422);

                        return _lazyOperationActionsByKind;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(228, 4664, 5441);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_228_4839_4854()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 4839, 4854);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                        f_228_4820_4872(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                        actions)
                        {
                            var return_v = this_param.GetFilteredActions<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>(actions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 4820, 4872);
                            return return_v;
                        }


                        int
                        f_228_4899_4941(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                        actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            VerifyActions(actions, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 4899, 4941);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                        f_228_5050_5110(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>
                        operationActions)
                        {
                            var return_v = AnalyzerExecutor.GetOperationActionsByKind((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>)operationActions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 5050, 5110);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>?
                        f_228_5250_5339(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>?
                        location1, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>
                        value, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.OperationKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationAnalyzerAction>>?
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 5250, 5339);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 4515, 5456);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 4515, 5456);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<CodeBlockStartAnalyzerAction<TLanguageKindEnum>> CodeBlockStartActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 5598, 6125);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5642, 6048) || true) && (_lazyCodeBlockStartActions.IsDefault)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 5642, 6048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5732, 5837);

                            var
                            codeBlockActions = f_228_5755_5836(this, f_228_5774_5789().GetCodeBlockStartActions<TLanguageKindEnum>())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5863, 5906);

                            f_228_5863_5905(codeBlockActions, _analyzer);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 5932, 6025);

                            f_228_5932_6024(ref _lazyCodeBlockStartActions, codeBlockActions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(228, 5642, 6048);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 6072, 6106);

                        return _lazyCodeBlockStartActions;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(228, 5598, 6125);

                        Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
                        f_228_5774_5789()
                        {
                            var return_v = AnalyzerActions;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 5774, 5789);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                        f_228_5755_5836(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver<TLanguageKindEnum>.GroupedAnalyzerActionsForAnalyzer
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                        actions)
                        {
                            var return_v = this_param.GetFilteredActions<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>(actions);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 5755, 5836);
                            return return_v;
                        }


                        int
                        f_228_5863_5905(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                        actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                        analyzer)
                        {
                            VerifyActions(actions, analyzer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 5863, 5905);
                            return 0;
                        }


                        bool
                        f_228_5932_6024(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                        location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                        value)
                        {
                            var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 5932, 6024);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 5472, 6140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 5472, 6140);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<CodeBlockAnalyzerAction> CodeBlockEndActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 6241, 6377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 6244, 6377);
                        return f_228_6244_6377(ref _lazyCodeBlockEndActions, f_228_6299_6314().CodeBlockEndActions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 6241, 6377);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 6241, 6377);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 6241, 6377);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<CodeBlockAnalyzerAction> CodeBlockActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 6476, 6606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 6479, 6606);
                        return f_228_6479_6606(ref _lazyCodeBlockActions, f_228_6531_6546().CodeBlockActions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 6476, 6606);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 6476, 6606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 6476, 6606);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<OperationBlockStartAnalyzerAction> OperationBlockStartActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 6725, 6875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 6728, 6875);
                        return f_228_6728_6875(ref _lazyOperationBlockStartActions, f_228_6790_6805().OperationBlockStartActions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 6725, 6875);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 6725, 6875);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 6725, 6875);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<OperationBlockAnalyzerAction> OperationBlockEndActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 6987, 7133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 6990, 7133);
                        return f_228_6990_7133(ref _lazyOperationBlockEndActions, f_228_7050_7065().OperationBlockEndActions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 6987, 7133);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 6987, 7133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 6987, 7133);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ImmutableArray<OperationBlockAnalyzerAction> OperationBlockActions
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 7242, 7382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 7245, 7382);
                        return f_228_7245_7382(ref _lazyOperationBlockActions, f_228_7302_7317().OperationBlockActions, _analyzer, _analyzerActionsNeedFiltering); DynAbs.Tracing.TraceSender.TraceExitMethod(228, 7242, 7382);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 7242, 7382);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 7242, 7382);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private static ImmutableArray<ActionType> GetExecutableCodeActions<ActionType>(
                            ref ImmutableArray<ActionType> lazyCodeBlockActions,
                            ImmutableArray<ActionType> codeBlockActions,
                            DiagnosticAnalyzer analyzer,
                            bool analyzerActionsNeedFiltering)
                            where ActionType : AnalyzerAction
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(228, 7399, 8219);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 7792, 8156) || true) && (lazyCodeBlockActions.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 7792, 8156);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 7868, 7964);

                        codeBlockActions = f_228_7887_7963(codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 7986, 8028);

                        f_228_7986_8027(codeBlockActions, analyzer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 8050, 8137);

                        f_228_8050_8136(ref lazyCodeBlockActions, codeBlockActions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(228, 7792, 8156);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 8176, 8204);

                    return lazyCodeBlockActions;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(228, 7399, 8219);

                    System.Collections.Immutable.ImmutableArray<ActionType>
                    f_228_7887_7963(System.Collections.Immutable.ImmutableArray<ActionType>
                    actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer, bool
                    analyzerActionsNeedFiltering)
                    {
                        var return_v = GetFilteredActions(actions, analyzer, analyzerActionsNeedFiltering);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 7887, 7963);
                        return return_v;
                    }


                    int
                    f_228_7986_8027(System.Collections.Immutable.ImmutableArray<ActionType>
                    actions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                    analyzer)
                    {
                        VerifyActions(actions, analyzer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 7986, 8027);
                        return 0;
                    }


                    bool
                    f_228_8050_8136(ref System.Collections.Immutable.ImmutableArray<ActionType>
                    location, System.Collections.Immutable.ImmutableArray<ActionType>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 8050, 8136);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 7399, 8219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 7399, 8219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetExecutableCodeBlockActions(out ExecutableCodeBlockAnalyzerActions actions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(228, 8235, 9426);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 8360, 9342) || true) && (f_228_8364_8399_M(!f_228_8365_8391().IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(228, 8364, 8454) || f_228_8424_8454_M(!f_228_8425_8446().IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(228, 8364, 8512) || f_228_8479_8512_M(!f_228_8480_8504().IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(228, 8364, 8567) || f_228_8537_8567_M(!f_228_8538_8559().IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(228, 8364, 8617) || f_228_8592_8617_M(!f_228_8593_8609().IsEmpty)) || (DynAbs.Tracing.TraceSender.Expression_False(228, 8364, 8670) || f_228_8642_8670_M(!f_228_8643_8662().IsEmpty)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(228, 8360, 9342);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 8712, 9287);

                        actions = new ExecutableCodeBlockAnalyzerActions
                        {
                            Analyzer = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _analyzer, 228, 8722, 9286),
                            CodeBlockStartActions = f_228_8880_8901(),
                            CodeBlockActions = f_228_8947_8963(),
                            CodeBlockEndActions = f_228_9012_9031(),
                            OperationBlockStartActions = f_228_9087_9113(),
                            OperationBlockActions = f_228_9164_9185(),
                            OperationBlockEndActions = f_228_9239_9263()
                        };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 9311, 9323);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(228, 8360, 9342);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 9362, 9380);

                    actions = default;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(228, 9398, 9411);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(228, 8235, 9426);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
                    f_228_8365_8391()
                    {
                        var return_v = OperationBlockStartActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8365, 8391);
                        return return_v;
                    }


                    bool
                    f_228_8364_8399_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8364, 8399);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                    f_228_8425_8446()
                    {
                        var return_v = OperationBlockActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8425, 8446);
                        return return_v;
                    }


                    bool
                    f_228_8424_8454_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8424, 8454);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                    f_228_8480_8504()
                    {
                        var return_v = OperationBlockEndActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8480, 8504);
                        return return_v;
                    }


                    bool
                    f_228_8479_8512_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8479, 8512);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                    f_228_8538_8559()
                    {
                        var return_v = CodeBlockStartActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8538, 8559);
                        return return_v;
                    }


                    bool
                    f_228_8537_8567_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8537, 8567);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                    f_228_8593_8609()
                    {
                        var return_v = CodeBlockActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8593, 8609);
                        return return_v;
                    }


                    bool
                    f_228_8592_8617_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8592, 8617);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                    f_228_8643_8662()
                    {
                        var return_v = CodeBlockEndActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8643, 8662);
                        return return_v;
                    }


                    bool
                    f_228_8642_8670_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8642, 8670);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockStartAnalyzerAction<TLanguageKindEnum>>
                    f_228_8880_8901()
                    {
                        var return_v = CodeBlockStartActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8880, 8901);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                    f_228_8947_8963()
                    {
                        var return_v = CodeBlockActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 8947, 8963);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
                    f_228_9012_9031()
                    {
                        var return_v = CodeBlockEndActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 9012, 9031);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
                    f_228_9087_9113()
                    {
                        var return_v = OperationBlockStartActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 9087, 9113);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                    f_228_9164_9185()
                    {
                        var return_v = OperationBlockActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 9164, 9185);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
                    f_228_9239_9263()
                    {
                        var return_v = OperationBlockEndActions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 9239, 9263);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(228, 8235, 9426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 8235, 9426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static GroupedAnalyzerActionsForAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(228, 575, 9437);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(228, 575, 9437);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(228, 575, 9437);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(228, 575, 9437);

            bool
            f_228_1822_1846_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 1822, 1846);
                return return_v;
            }


            static int
            f_228_1809_1847(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 1809, 1847);
                return 0;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            f_228_6299_6314()
            {
                var return_v = AnalyzerActions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 6299, 6314);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            f_228_6244_6377(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            lazyCodeBlockActions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            codeBlockActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, bool
            analyzerActionsNeedFiltering)
            {
                var return_v = GetExecutableCodeActions(ref lazyCodeBlockActions, codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 6244, 6377);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            f_228_6531_6546()
            {
                var return_v = AnalyzerActions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 6531, 6546);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            f_228_6479_6606(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            lazyCodeBlockActions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.CodeBlockAnalyzerAction>
            codeBlockActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, bool
            analyzerActionsNeedFiltering)
            {
                var return_v = GetExecutableCodeActions(ref lazyCodeBlockActions, codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 6479, 6606);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            f_228_6790_6805()
            {
                var return_v = AnalyzerActions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 6790, 6805);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
            f_228_6728_6875(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
            lazyCodeBlockActions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockStartAnalyzerAction>
            codeBlockActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, bool
            analyzerActionsNeedFiltering)
            {
                var return_v = GetExecutableCodeActions(ref lazyCodeBlockActions, codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 6728, 6875);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            f_228_7050_7065()
            {
                var return_v = AnalyzerActions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 7050, 7065);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            f_228_6990_7133(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            lazyCodeBlockActions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            codeBlockActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, bool
            analyzerActionsNeedFiltering)
            {
                var return_v = GetExecutableCodeActions(ref lazyCodeBlockActions, codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 6990, 7133);
                return return_v;
            }


            Microsoft.CodeAnalysis.Diagnostics.AnalyzerActions
            f_228_7302_7317()
            {
                var return_v = AnalyzerActions;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(228, 7302, 7317);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            f_228_7245_7382(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            lazyCodeBlockActions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostics.OperationBlockAnalyzerAction>
            codeBlockActions, Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
            analyzer, bool
            analyzerActionsNeedFiltering)
            {
                var return_v = GetExecutableCodeActions(ref lazyCodeBlockActions, codeBlockActions, analyzer, analyzerActionsNeedFiltering);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(228, 7245, 7382);
                return return_v;
            }

        }
    }
}
