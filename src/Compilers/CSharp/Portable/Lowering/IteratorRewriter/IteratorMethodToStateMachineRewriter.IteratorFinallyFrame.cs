// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Collections.Generic;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class IteratorMethodToStateMachineRewriter
    {
        private sealed class IteratorFinallyFrame
        {
            public readonly int finalizeState;

            public readonly IteratorFinallyFrame parent;

            public readonly IteratorFinallyMethodSymbol handler;

            public Dictionary<int, IteratorFinallyFrame> knownStates;

            public readonly HashSet<LabelSymbol> labels;

            public Dictionary<LabelSymbol, LabelSymbol> proxyLabels;

            public IteratorFinallyFrame(
                            IteratorFinallyFrame parent,
                            int finalizeState,
                            IteratorFinallyMethodSymbol handler,
                            HashSet<LabelSymbol> labels)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10468, 2128, 2720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 738, 751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 871, 877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1061, 1068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1468, 1479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1631, 1637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2100, 2111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2371, 2437);

                    f_10468_2371_2436(parent != null, "non root frame must have a parent");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2455, 2531);

                    f_10468_2455_2530((object)handler != null, "non root frame must have a handler");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2551, 2572);

                    this.parent = parent;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2590, 2625);

                    this.finalizeState = finalizeState;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2643, 2666);

                    this.handler = handler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2684, 2705);

                    this.labels = labels;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10468, 2128, 2720);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 2128, 2720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 2128, 2720);
                }
            }

            public IteratorFinallyFrame()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10468, 2736, 2876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 738, 751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 871, 877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1061, 1068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1468, 1479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 1631, 1637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2100, 2111);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2798, 2861);

                    this.finalizeState = StateMachineStates.NotStartedStateMachine;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10468, 2736, 2876);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 2736, 2876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 2736, 2876);
                }
            }

            public bool IsRoot()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10468, 2892, 2987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 2945, 2972);

                    return this.parent == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10468, 2892, 2987);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 2892, 2987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 2892, 2987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public void AddState(int state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10468, 3003, 3190);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3067, 3175) || true) && (parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 3067, 3175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3127, 3156);

                        f_10468_3127_3155(parent, state, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 3067, 3175);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10468, 3003, 3190);

                    int
                    f_10468_3127_3155(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    this_param, int
                    state, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    innerHandler)
                    {
                        this_param.AddState(state, innerHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 3127, 3155);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 3003, 3190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 3003, 3190);
                }
            }

            private void AddState(int state, IteratorFinallyFrame innerHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10468, 3423, 4032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3523, 3558);

                    var
                    knownStates = this.knownStates
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3576, 3737) || true) && (knownStates == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 3576, 3737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3641, 3718);

                        this.knownStates = knownStates = f_10468_3674_3717();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 3576, 3737);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3757, 3794);

                    f_10468_3757_3793(
                                    knownStates, state, innerHandler);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3814, 4017) || true) && (parent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 3814, 4017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 3969, 3998);

                        f_10468_3969_3997(                    // Present ourselves to the parent as responsible for a handling a state.
                                            parent, state, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 3814, 4017);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10468, 3423, 4032);

                    System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame>
                    f_10468_3674_3717()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 3674, 3717);
                        return return_v;
                    }


                    int
                    f_10468_3757_3793(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame>
                    this_param, int
                    key, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 3757, 3793);
                        return 0;
                    }


                    int
                    f_10468_3969_3997(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    this_param, int
                    state, Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    innerHandler)
                    {
                        this_param.AddState(state, innerHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 3969, 3997);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 3423, 4032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 3423, 4032);
                }
            }

            public LabelSymbol ProxyLabelIfNeeded(LabelSymbol label)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10468, 4184, 5054);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4366, 4503) || true) && (f_10468_4370_4383(this) || (DynAbs.Tracing.TraceSender.Expression_False(10468, 4370, 4429) || (labels != null && (DynAbs.Tracing.TraceSender.Expression_True(10468, 4388, 4428) && f_10468_4406_4428(labels, label)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 4366, 4503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4471, 4484);

                        return label;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 4366, 4503);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4523, 4558);

                    var
                    proxyLabels = this.proxyLabels
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4576, 4736) || true) && (proxyLabels == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 4576, 4736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4641, 4717);

                        this.proxyLabels = proxyLabels = f_10468_4674_4716();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 4576, 4736);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4756, 4774);

                    LabelSymbol
                    proxy
                    = default(LabelSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4792, 5006) || true) && (!f_10468_4797_4838(proxyLabels, label, out proxy))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10468, 4792, 5006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4880, 4935);

                        proxy = f_10468_4888_4934("proxy" + f_10468_4923_4933(label));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 4957, 4987);

                        f_10468_4957_4986(proxyLabels, label, proxy);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10468, 4792, 5006);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10468, 5026, 5039);

                    return proxy;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10468, 4184, 5054);

                    bool
                    f_10468_4370_4383(Microsoft.CodeAnalysis.CSharp.IteratorMethodToStateMachineRewriter.IteratorFinallyFrame
                    this_param)
                    {
                        var return_v = this_param.IsRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4370, 4383);
                        return return_v;
                    }


                    bool
                    f_10468_4406_4428(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4406, 4428);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    f_10468_4674_4716()
                    {
                        var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4674, 4716);
                        return return_v;
                    }


                    bool
                    f_10468_4797_4838(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4797, 4838);
                        return return_v;
                    }


                    string
                    f_10468_4923_4933(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10468, 4923, 4933);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10468_4888_4934(string
                    name)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4888, 4934);
                        return return_v;
                    }


                    int
                    f_10468_4957_4986(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 4957, 4986);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10468, 4184, 5054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 4184, 5054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static IteratorFinallyFrame()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10468, 538, 5065);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10468, 538, 5065);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10468, 538, 5065);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10468, 538, 5065);

            int
            f_10468_2371_2436(bool
            condition, string
            message)
            {
                Debug.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 2371, 2436);
                return 0;
            }


            int
            f_10468_2455_2530(bool
            condition, string
            message)
            {
                Debug.Assert(condition, message);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10468, 2455, 2530);
                return 0;
            }

        }
    }
}
