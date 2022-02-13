// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class AbstractFlowPass<TLocalState, TLocalFunctionState> : BoundTreeVisitor
            where TLocalState : AbstractFlowPass<TLocalState, TLocalFunctionState>.ILocalState
            where TLocalFunctionState : AbstractFlowPass<TLocalState, TLocalFunctionState>.AbstractLocalFunctionState
    {
        protected int _recursionDepth;

        protected readonly CSharpCompilation compilation;

        protected readonly Symbol _symbol;

        protected Symbol CurrentSymbol;

        protected readonly BoundNode methodMainNode;

        private readonly PooledDictionary<LabelSymbol, TLocalState> _labels;

        protected bool stateChangedAfterUse;

        private PooledHashSet<BoundStatement> _labelsSeen;

        protected ArrayBuilder<PendingBranch> PendingBranches { get; private set; }

        protected TLocalState State;

        protected TLocalState StateWhenTrue;

        protected TLocalState StateWhenFalse;

        protected bool IsConditionalState;

        private readonly bool _nonMonotonicTransfer;

        protected void SetConditionalState(TLocalState whenTrue, TLocalState whenFalse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 6908, 7172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7012, 7038);

                IsConditionalState = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7052, 7081);

                State = default(TLocalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7095, 7120);

                StateWhenTrue = whenTrue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7134, 7161);

                StateWhenFalse = whenFalse;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 6908, 7172);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 6908, 7172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 6908, 7172);
            }
        }

        protected void SetState(TLocalState newState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 7184, 7436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7254, 7285);

                f_10877_7254_7284(newState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7299, 7353);

                StateWhenTrue = StateWhenFalse = default(TLocalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7367, 7394);

                IsConditionalState = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7408, 7425);

                State = newState;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 7184, 7436);

                int
                f_10877_7254_7284(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 7254, 7284);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 7184, 7436);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 7184, 7436);
            }
        }

        protected void Split()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 7448, 7620);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7495, 7609) || true) && (!IsConditionalState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 7495, 7609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7552, 7594);

                    f_10877_7552_7593(this, State, f_10877_7579_7592(State));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 7495, 7609);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 7448, 7620);

                TLocalState
                f_10877_7579_7592(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 7579, 7592);
                    return return_v;
                }


                int
                f_10877_7552_7593(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 7552, 7593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 7448, 7620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 7448, 7620);
            }
        }

        protected void Unsplit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 7632, 7849);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7681, 7838) || true) && (IsConditionalState)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 7681, 7838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7737, 7781);

                    f_10877_7737_7780(this, ref StateWhenTrue, ref StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7799, 7823);

                    f_10877_7799_7822(this, StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 7681, 7838);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 7632, 7849);

                bool
                f_10877_7737_7780(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 7737, 7780);
                    return return_v;
                }


                int
                f_10877_7799_7822(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 7799, 7822);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 7632, 7849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 7632, 7849);
            }
        }

        protected DiagnosticBag Diagnostics { get; }

        protected RegionPlace regionPlace;

        protected readonly BoundNode firstInRegion, lastInRegion;

        protected readonly bool TrackingRegions;

        private readonly Dictionary<BoundLoopStatement, TLocalState> _loopHeadState;

        protected AbstractFlowPass(
                    CSharpCompilation compilation,
                    Symbol symbol,
                    BoundNode node,
                    BoundNode firstInRegion = null,
                    BoundNode lastInRegion = null,
                    bool trackRegions = false,
                    bool nonMonotonicTransferFunction = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10877, 8697, 10480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 2018, 2033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 2310, 2321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 2859, 2866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 3057, 3070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 3232, 3246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 4317, 4324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 4757, 4777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 4951, 4962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 5547, 5622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 5805, 5810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 5843, 5856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 5889, 5903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 5929, 5947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 6874, 6895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 7958, 8002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 8122, 8133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 8258, 8271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 8273, 8285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 8320, 8335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 8643, 8657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10879, 2032, 2058);
                this._localFuncVarUsages = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9035, 9062);

                f_10877_9035_9061(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9078, 9196) || true) && (firstInRegion != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 9082, 9127) && lastInRegion != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 9078, 9196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9161, 9181);

                    trackRegions = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 9078, 9196);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9212, 9702) || true) && (trackRegions)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 9212, 9702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9262, 9298);

                    f_10877_9262_9297(firstInRegion != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9316, 9351);

                    f_10877_9316_9350(lastInRegion != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9369, 9420);

                    int
                    startLocation = f_10877_9389_9419(firstInRegion.Syntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9438, 9485);

                    int
                    endLocation = lastInRegion.Syntax.Span.End
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9503, 9544);

                    int
                    length = endLocation - startLocation
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9562, 9615);

                    f_10877_9562_9614(length >= 0, "last comes before first");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9633, 9687);

                    this.RegionSpan = f_10877_9651_9686(startLocation, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 9212, 9702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9718, 9778);

                PendingBranches = f_10877_9736_9777();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9792, 9850);

                _labelsSeen = f_10877_9806_9849();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9864, 9931);

                _labels = f_10877_9874_9930();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 9945, 9992);

                this.Diagnostics = f_10877_9964_9991();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10006, 10037);

                this.compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10051, 10068);

                _symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10082, 10105);

                CurrentSymbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10119, 10146);

                this.methodMainNode = node;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10160, 10195);

                this.firstInRegion = firstInRegion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10209, 10242);

                this.lastInRegion = lastInRegion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10256, 10357);

                _loopHeadState = f_10877_10273_10356(ReferenceEqualityComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10371, 10402);

                TrackingRegions = trackRegions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10416, 10469);

                _nonMonotonicTransfer = nonMonotonicTransferFunction;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10877, 8697, 10480);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 8697, 10480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 8697, 10480);
            }
        }

        protected abstract string Dump(TLocalState state);

        protected string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 10554, 10765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10602, 10754);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 10609, 10627) || ((IsConditionalState
                && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 10647, 10717)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 10737, 10753))) ? $"true: {f_10877_10656_10680(this, this.StateWhenTrue)} false: {f_10877_10690_10715(this, this.StateWhenFalse)}"
                : f_10877_10737_10753(this, this.State);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 10554, 10765);

                string
                f_10877_10656_10680(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state)
                {
                    var return_v = this_param.Dump(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10656, 10680);
                    return return_v;
                }


                string
                f_10877_10690_10715(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state)
                {
                    var return_v = this_param.Dump(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10690, 10715);
                    return return_v;
                }


                string
                f_10877_10737_10753(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state)
                {
                    var return_v = this_param.Dump(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10737, 10753);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 10554, 10765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 10554, 10765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected string DumpLabels()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 10788, 11531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10842, 10885);

                StringBuilder
                result = f_10877_10865_10884()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10899, 10924);

                f_10877_10899_10923(result, "Labels{");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10938, 10956);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 10970, 11448);
                    foreach (var key in f_10877_10990_11002_I(f_10877_10990_11002(_labels)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 10970, 11448);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11036, 11127) || true) && (!first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 11036, 11127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11088, 11108);

                            f_10877_11088_11107(result, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 11036, 11127);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11147, 11170);

                        string
                        name = f_10877_11161_11169(key)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11188, 11316) || true) && (f_10877_11192_11218(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 11188, 11316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11260, 11297);

                            name = "<Label>" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10877_11279_11296(key)).ToString(), 10877, 11279, 11296);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 11188, 11316);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11336, 11401);

                        f_10877_11336_11400(f_10877_11336_11368(f_10877_11336_11355(
                                        result, name), ": "), f_10877_11376_11399(this, f_10877_11386_11398(_labels, key)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11419, 11433);

                        first = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 10970, 11448);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11462, 11481);

                f_10877_11462_11480(result, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11495, 11520);

                return f_10877_11502_11519(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 10788, 11531);

                System.Text.StringBuilder
                f_10877_10865_10884()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10865, 10884);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_10899_10923(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10899, 10923);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>.KeyCollection
                f_10877_10990_11002(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 10990, 11002);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_11088_11107(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11088, 11107);
                    return return_v;
                }


                string
                f_10877_11161_11169(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 11161, 11169);
                    return return_v;
                }


                bool
                f_10877_11192_11218(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11192, 11218);
                    return return_v;
                }


                int
                f_10877_11279_11296(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11279, 11296);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_11336_11355(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11336, 11355);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_11336_11368(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11336, 11368);
                    return return_v;
                }


                TLocalState
                f_10877_11386_11398(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 11386, 11398);
                    return return_v;
                }


                string
                f_10877_11376_11399(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state)
                {
                    var return_v = this_param.Dump(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11376, 11399);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_11336_11400(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11336, 11400);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>.KeyCollection
                f_10877_10990_11002_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10990, 11002);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10877_11462_11480(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11462, 11480);
                    return return_v;
                }


                string
                f_10877_11502_11519(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11502, 11519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 10788, 11531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 10788, 11531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 11698, 11875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11759, 11812);

                f_10877_11759_11811(this.regionPlace == RegionPlace.Before);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 11826, 11864);

                this.regionPlace = RegionPlace.Inside;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 11698, 11875);

                int
                f_10877_11759_11811(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 11759, 11811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 11698, 11875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 11698, 11875);
            }
        }

        protected virtual void LeaveRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 12031, 12177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12092, 12115);

                f_10877_12092_12114(f_10877_12105_12113());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12129, 12166);

                this.regionPlace = RegionPlace.After;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 12031, 12177);

                bool
                f_10877_12105_12113()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 12105, 12113);
                    return return_v;
                }


                int
                f_10877_12092_12114(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 12092, 12114);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 12031, 12177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 12031, 12177);
            }
        }

        protected readonly TextSpan RegionSpan;

        protected bool RegionContains(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 12240, 12667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12457, 12487);

                f_10877_12457_12486(span.Length > 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12501, 12609) || true) && (span.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 12501, 12609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12555, 12594);

                    return RegionSpan.Contains(span.Start);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 12501, 12609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12623, 12656);

                return RegionSpan.Contains(span);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 12240, 12667);

                int
                f_10877_12457_12486(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 12457, 12486);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 12240, 12667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 12240, 12667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool IsInside
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 12727, 12819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12763, 12804);

                    return regionPlace == RegionPlace.Inside;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 12727, 12819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 12679, 12830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 12679, 12830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected virtual void EnterParameters(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 12842, 13071);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 12949, 13060);
                    foreach (var parameter in f_10877_12975_12985_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 12949, 13060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13019, 13045);

                        f_10877_13019_13044(this, parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 12949, 13060);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 112);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 12842, 13071);

                int
                f_10877_13019_13044(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter)
                {
                    this_param.EnterParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 13019, 13044);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10877_12975_12985_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 12975, 12985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 12842, 13071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 12842, 13071);
            }
        }

        protected virtual void EnterParameter(ParameterSymbol parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 13083, 13160);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 13083, 13160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 13083, 13160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 13083, 13160);
            }
        }

        protected virtual void LeaveParameters(
                    ImmutableArray<ParameterSymbol> parameters,
                    SyntaxNode syntax,
                    Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 13172, 13509);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13357, 13498);
                    foreach (ParameterSymbol parameter in f_10877_13395_13405_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 13357, 13498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13439, 13483);

                        f_10877_13439_13482(this, parameter, syntax, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 13357, 13498);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 142);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 13172, 13509);

                int
                f_10877_13439_13482(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.LeaveParameter(parameter, syntax, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 13439, 13482);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10877_13395_13405_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 13395, 13405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 13172, 13509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 13172, 13509);
            }
        }

        protected virtual void LeaveParameter(ParameterSymbol parameter, SyntaxNode syntax, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 13521, 13636);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 13521, 13636);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 13521, 13636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 13521, 13636);
            }
        }

        public override BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 13650, 13758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13722, 13747);

                return f_10877_13729_13746(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 13650, 13758);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_13729_13746(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.VisitAlways(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 13729, 13746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 13650, 13758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 13650, 13758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected BoundNode VisitAlways(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 13770, 14680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13842, 13866);

                BoundNode
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 13979, 14639) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 13979, 14639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14029, 14624) || true) && (TrackingRegions)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 14029, 14624);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14090, 14249) || true) && (node == this.firstInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 14094, 14162) && this.regionPlace == RegionPlace.Before))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 14090, 14249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14212, 14226);

                            f_10877_14212_14225(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 14090, 14249);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14273, 14308);

                        result = f_10877_14282_14307(this, node);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14330, 14488) || true) && (node == this.lastInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 14334, 14401) && this.regionPlace == RegionPlace.Inside))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 14330, 14488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14451, 14465);

                            f_10877_14451_14464(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 14330, 14488);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 14029, 14624);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 14029, 14624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14570, 14605);

                        result = f_10877_14579_14604(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 14029, 14624);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 13979, 14639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14655, 14669);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 13770, 14680);

                int
                f_10877_14212_14225(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.EnterRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 14212, 14225);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_14282_14307(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.VisitWithStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 14282, 14307);
                    return return_v;
                }


                int
                f_10877_14451_14464(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.LeaveRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 14451, 14464);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_14579_14604(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.VisitWithStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 14579, 14604);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 13770, 14680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 13770, 14680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerStepThrough]
        private BoundNode VisitWithStackGuard(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 14692, 15048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14801, 14842);

                var
                expression = node as BoundExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14856, 14997) || true) && (expression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 14856, 14997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 14912, 14982);

                    return f_10877_14919_14981(this, ref _recursionDepth, expression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 14856, 14997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 15013, 15037);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10877, 15020, 15036);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 14692, 15048);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_14919_14981(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref int
                recursionDepth, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(ref recursionDepth, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 14919, 14981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 14692, 15048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 14692, 15048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerStepThrough]
        protected override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 15060, 15257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 15205, 15246);

                return (BoundExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10877, 15229, 15245);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 15060, 15257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 15060, 15257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 15060, 15257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 15269, 15464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 15394, 15407);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 15269, 15464);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 15269, 15464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 15269, 15464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class PendingBranch
        {
            public readonly BoundNode Branch;

            public bool IsConditionalState;

            public TLocalState State;

            public TLocalState StateWhenTrue;

            public TLocalState StateWhenFalse;

            public readonly LabelSymbol Label;

            public PendingBranch(BoundNode branch, TLocalState state, LabelSymbol label, bool isConditionalState = false, TLocalState stateWhenTrue = default, TLocalState stateWhenFalse = default)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10877, 16537, 17146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16287, 16293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16320, 16338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16372, 16377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16411, 16424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16458, 16472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16515, 16520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16754, 16775);

                    this.Branch = branch;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16793, 16820);

                    this.State = f_10877_16806_16819(state);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16838, 16883);

                    this.IsConditionalState = isConditionalState;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16901, 17094) || true) && (isConditionalState)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 16901, 17094);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 16965, 17008);

                        this.StateWhenTrue = f_10877_16986_17007(stateWhenTrue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17030, 17075);

                        this.StateWhenFalse = f_10877_17052_17074(stateWhenFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 16901, 17094);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17112, 17131);

                    this.Label = label;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10877, 16537, 17146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 16537, 17146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 16537, 17146);
                }
            }

            static PendingBranch()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10877, 16208, 17157);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10877, 16208, 17157);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 16208, 17157);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10877, 16208, 17157);

            TLocalState
            f_10877_16806_16819(TLocalState
            this_param)
            {
                var return_v = this_param.Clone();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 16806, 16819);
                return return_v;
            }


            TLocalState
            f_10877_16986_17007(TLocalState?
            this_param)
            {
                var return_v = this_param.Clone();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 16986, 17007);
                return return_v;
            }


            TLocalState
            f_10877_17052_17074(TLocalState?
            this_param)
            {
                var return_v = this_param.Clone();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17052, 17074);
                return return_v;
            }

        }

        protected virtual ImmutableArray<PendingBranch> Scan(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 17378, 17857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17475, 17506);

                var
                oldPending = f_10877_17492_17505(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17520, 17542);

                f_10877_17520_17541(this, methodMainNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17556, 17571);

                f_10877_17556_17570(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17585, 17612);

                f_10877_17585_17611(this, oldPending);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17626, 17747) || true) && (TrackingRegions && (DynAbs.Tracing.TraceSender.Expression_True(10877, 17630, 17681) && regionPlace != RegionPlace.After))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 17626, 17747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17715, 17732);

                    badRegion = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 17626, 17747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17763, 17818);

                ImmutableArray<PendingBranch>
                result = f_10877_17802_17817(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 17832, 17846);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 17378, 17857);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10877_17492_17505(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17492, 17505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_17520_17541(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17520, 17541);
                    return return_v;
                }


                int
                f_10877_17556_17570(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17556, 17570);
                    return 0;
                }


                int
                f_10877_17585_17611(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17585, 17611);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_17802_17817(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.RemoveReturns();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 17802, 17817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 17378, 17857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 17378, 17857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected ImmutableArray<PendingBranch> Analyze(ref bool badRegion, Optional<TLocalState> initialState = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 17869, 18578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18007, 18045);

                ImmutableArray<PendingBranch>
                returns
                = default(ImmutableArray<PendingBranch>);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 18059, 18536);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18163, 18196);

                            regionPlace = RegionPlace.Before;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18214, 18283);

                            this.State = (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 18227, 18248) || ((initialState.HasValue && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 18251, 18269)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 18272, 18282))) ? initialState.Value : f_10877_18272_18282(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18301, 18325);

                            f_10877_18301_18324(f_10877_18301_18316());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18343, 18377);

                            this.stateChangedAfterUse = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18395, 18420);

                            f_10877_18395_18419(f_10877_18395_18411(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18438, 18473);

                            returns = f_10877_18448_18472(this, ref badRegion);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 18059, 18536);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18059, 18536) || true) && (this.stateChangedAfterUse)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 18059, 18536);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 18059, 18536);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18552, 18567);

                return returns;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 17869, 18578);

                TLocalState
                f_10877_18272_18282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.TopState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18272, 18282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_18301_18316()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 18301, 18316);
                    return return_v;
                }


                int
                f_10877_18301_18324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18301, 18324);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10877_18395_18411(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 18395, 18411);
                    return return_v;
                }


                int
                f_10877_18395_18419(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18395, 18419);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_18448_18472(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Scan(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18448, 18472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 17869, 18578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 17869, 18578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 18590, 18778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18644, 18668);

                f_10877_18644_18667(f_10877_18644_18660(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18682, 18705);

                f_10877_18682_18704(f_10877_18682_18697());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18719, 18738);

                f_10877_18719_18737(_labelsSeen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 18752, 18767);

                f_10877_18752_18766(_labels);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 18590, 18778);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10877_18644_18660(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 18644, 18660);
                    return return_v;
                }


                int
                f_10877_18644_18667(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18644, 18667);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_18682_18697()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 18682, 18697);
                    return return_v;
                }


                int
                f_10877_18682_18704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18682, 18704);
                    return 0;
                }


                int
                f_10877_18719_18737(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18719, 18737);
                    return 0;
                }


                int
                f_10877_18752_18766(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 18752, 18766);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 18590, 18778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 18590, 18778);
            }
        }

        protected ImmutableArray<ParameterSymbol> MethodParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 19044, 19240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19080, 19117);

                    var
                    method = _symbol as MethodSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19135, 19225);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 19142, 19164) || (((object)method == null && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 19167, 19204)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 19207, 19224))) ? ImmutableArray<ParameterSymbol>.Empty : f_10877_19207_19224(method);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 19044, 19240);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10877_19207_19224(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 19207, 19224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 18961, 19251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 18961, 19251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected ParameterSymbol MethodThisParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 19500, 19785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19536, 19573);

                    ParameterSymbol
                    thisParameter = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19618, 19731) || true) && (_symbol is MethodSymbol)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 19618, 19731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19668, 19731);

                        f_10877_19668_19730(((MethodSymbol)_symbol), out thisParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 19618, 19731);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 19749, 19770);

                    return thisParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 19500, 19785);

                    bool
                    f_10877_19668_19730(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    thisParameter)
                    {
                        var return_v = this_param.TryGetThisParameter(out thisParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 19668, 19730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 19430, 19796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 19430, 19796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool ShouldAnalyzeOutParameters(out Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 20276, 20708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20365, 20402);

                var
                method = _symbol as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20416, 20697) || true) && ((object)method == null || (DynAbs.Tracing.TraceSender.Expression_False(10877, 20420, 20474) || method.Locations.Length != 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 20416, 20697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20508, 20524);

                    location = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20542, 20555);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 20416, 20697);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 20416, 20697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20621, 20652);

                    location = f_10877_20632_20648(method)[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20670, 20682);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 20416, 20697);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 20276, 20708);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10877_20632_20648(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 20632, 20648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 20276, 20708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 20276, 20708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TLocalState LabelState(LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 20911, 21257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 20995, 21014);

                TLocalState
                result
                = default(TLocalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21028, 21133) || true) && (f_10877_21032_21070(_labels, label, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 21028, 21133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21104, 21118);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 21028, 21133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21149, 21177);

                result = f_10877_21158_21176(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21191, 21218);

                f_10877_21191_21217(_labels, label, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21232, 21246);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 20911, 21257);

                bool
                f_10877_21032_21070(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, out TLocalState
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21032, 21070);
                    return return_v;
                }


                TLocalState
                f_10877_21158_21176(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21158, 21176);
                    return return_v;
                }


                int
                f_10877_21191_21217(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                key, TLocalState
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21191, 21217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 20911, 21257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 20911, 21257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual ImmutableArray<PendingBranch> RemoveReturns()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 21421, 21800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21509, 21546);

                ImmutableArray<PendingBranch>
                result
                = default(ImmutableArray<PendingBranch>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21560, 21599);

                result = f_10877_21569_21598(f_10877_21569_21584());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21613, 21637);

                f_10877_21613_21636(f_10877_21613_21628());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21724, 21761);

                f_10877_21724_21760(f_10877_21737_21754(_labelsSeen) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21775, 21789);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 21421, 21800);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_21569_21584()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 21569, 21584);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_21569_21598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21569, 21598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_21613_21628()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 21613, 21628);
                    return return_v;
                }


                int
                f_10877_21613_21636(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21613, 21636);
                    return 0;
                }


                int
                f_10877_21737_21754(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 21737, 21754);
                    return return_v;
                }


                int
                f_10877_21724_21760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 21724, 21760);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 21421, 21800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 21421, 21800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void SetUnreachable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 21940, 22039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 21996, 22028);

                this.State = f_10877_22009_22027(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 21940, 22039);

                TLocalState
                f_10877_22009_22027(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 22009, 22027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 21940, 22039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 21940, 22039);
            }
        }

        protected void VisitLvalue(BoundExpression node)
        {
            if (TrackingRegions && node == this.firstInRegion && this.regionPlace == RegionPlace.Before)
            {
                EnterRegion();
            }

            switch (node?.Kind)
            {
                case BoundKind.Parameter:
                    VisitLvalueParameter((BoundParameter)node);
                    break;

                case BoundKind.Local:
                    VisitLvalue((BoundLocal)node);
                    break;

                case BoundKind.ThisReference:
                case BoundKind.BaseReference:
                    break;

                case BoundKind.PropertyAccess:
                    var access = (BoundPropertyAccess)node;

                    if (Binder.AccessingAutoPropertyFromConstructor(access, _symbol))
                    {
                        // LAFHIS
                        var backingField = (access.PropertySymbol is SourcePropertySymbolBase) ? ((SourcePropertySymbolBase)access.PropertySymbol).BackingField : null;
                        if (backingField != null)
                        {
                            VisitFieldAccessInternal(access.ReceiverOpt, backingField);
                            break;
                        }
                    }

                    goto default;

                case BoundKind.FieldAccess:
                    {
                        BoundFieldAccess node1 = (BoundFieldAccess)node;
                        VisitFieldAccessInternal(node1.ReceiverOpt, node1.FieldSymbol);
                        break;
                    }

                case BoundKind.EventAccess:
                    {
                        BoundEventAccess node1 = (BoundEventAccess)node;
                        VisitFieldAccessInternal(node1.ReceiverOpt, node1.EventSymbol.AssociatedField);
                        break;
                    }

                case BoundKind.TupleLiteral:
                case BoundKind.ConvertedTupleLiteral:
                    ((BoundTupleExpression)node).VisitAllElements((x, self) => self.VisitLvalue(x), this);
                    break;

                default:
                    VisitRvalue(node);
                    break;
            }

            if (TrackingRegions && node == this.lastInRegion && this.regionPlace == RegionPlace.Inside)
            {
                LeaveRegion();
            }
        }

        protected virtual void VisitLvalue(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 24560, 24633);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 24560, 24633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 24560, 24633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 24560, 24633);
            }
        }

        protected void VisitCondition(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 24784, 24926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 24860, 24872);

                f_10877_24860_24871(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 24886, 24915);

                f_10877_24886_24914(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 24784, 24926);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_24860_24871(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 24860, 24871);
                    return return_v;
                }


                int
                f_10877_24886_24914(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.AdjustConditionalState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 24886, 24914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 24784, 24926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 24784, 24926);
            }
        }

        private void AdjustConditionalState(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 24938, 25613);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25020, 25578) || true) && (f_10877_25024_25044(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 25020, 25578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25078, 25088);

                    f_10877_25078_25087(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25106, 25158);

                    f_10877_25106_25157(this, this.State, f_10877_25138_25156(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 25020, 25578);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 25020, 25578);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25192, 25578) || true) && (f_10877_25196_25217(node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 25192, 25578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25251, 25261);

                        f_10877_25251_25260(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25279, 25331);

                        f_10877_25279_25330(this, f_10877_25299_25317(this), this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 25192, 25578);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 25192, 25578);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25365, 25578) || true) && ((object)f_10877_25377_25386(node) == null || (DynAbs.Tracing.TraceSender.Expression_False(10877, 25369, 25449) || f_10877_25398_25419(f_10877_25398_25407(node)) != SpecialType.System_Boolean))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 25365, 25578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25553, 25563);

                            f_10877_25553_25562(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 25365, 25578);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 25192, 25578);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 25020, 25578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 25594, 25602);

                f_10877_25594_25601(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 24938, 25613);

                bool
                f_10877_25024_25044(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantTrue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25024, 25044);
                    return return_v;
                }


                int
                f_10877_25078_25087(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25078, 25087);
                    return 0;
                }


                TLocalState
                f_10877_25138_25156(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25138, 25156);
                    return return_v;
                }


                int
                f_10877_25106_25157(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25106, 25157);
                    return 0;
                }


                bool
                f_10877_25196_25217(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantFalse(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25196, 25217);
                    return return_v;
                }


                int
                f_10877_25251_25260(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25251, 25260);
                    return 0;
                }


                TLocalState
                f_10877_25299_25317(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25299, 25317);
                    return return_v;
                }


                int
                f_10877_25279_25330(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25279, 25330);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10877_25377_25386(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 25377, 25386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10877_25398_25407(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 25398, 25407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10877_25398_25419(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 25398, 25419);
                    return return_v;
                }


                int
                f_10877_25553_25562(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25553, 25562);
                    return 0;
                }


                int
                f_10877_25594_25601(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Split();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 25594, 25601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 24938, 25613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 24938, 25613);
            }
        }

        protected virtual void VisitRvalue(BoundExpression node, bool isKnownToBeAnLvalue = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 26128, 26290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26243, 26255);

                f_10877_26243_26254(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26269, 26279);

                f_10877_26269_26278(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 26128, 26290);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_26243_26254(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 26243, 26254);
                    return return_v;
                }


                int
                f_10877_26269_26278(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 26269, 26278);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 26128, 26290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 26128, 26290);
            }
        }

        [DebuggerHidden]
        protected virtual void VisitStatement(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 26381, 26576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26495, 26512);

                f_10877_26495_26511(this, statement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26526, 26565);

                f_10877_26526_26564(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 26381, 26576);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_26495_26511(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 26495, 26511);
                    return return_v;
                }


                int
                f_10877_26526_26564(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 26526, 26564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 26381, 26576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 26381, 26576);
            }
        }

        protected static bool IsConstantTrue(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10877, 26588, 26730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26671, 26719);

                return f_10877_26678_26696(node) == f_10877_26700_26718();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10877, 26588, 26730);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10877_26678_26696(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 26678, 26696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10877_26700_26718()
                {
                    var return_v = ConstantValue.True;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 26700, 26718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 26588, 26730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 26588, 26730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static bool IsConstantFalse(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10877, 26742, 26886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26826, 26875);

                return f_10877_26833_26851(node) == f_10877_26855_26874();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10877, 26742, 26886);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10877_26833_26851(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 26833, 26851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10877_26855_26874()
                {
                    var return_v = ConstantValue.False;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 26855, 26874);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 26742, 26886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 26742, 26886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static bool IsConstantNull(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10877, 26898, 27040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 26981, 27029);

                return f_10877_26988_27006(node) == f_10877_27010_27028();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10877, 26898, 27040);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10877_26988_27006(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 26988, 27006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10877_27010_27028()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 27010, 27028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 26898, 27040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 26898, 27040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoopHead(BoundLoopStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 27182, 27506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27253, 27279);

                TLocalState
                previousState
                = default(TLocalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27293, 27437) || true) && (f_10877_27297_27348(_loopHeadState, node, out previousState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 27293, 27437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27382, 27422);

                    f_10877_27382_27421(this, ref this.State, ref previousState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 27293, 27437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27453, 27495);

                _loopHeadState[node] = f_10877_27476_27494(this.State);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 27182, 27506);

                bool
                f_10877_27297_27348(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundLoopStatement, TLocalState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                key, out TLocalState
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 27297, 27348);
                    return return_v;
                }


                bool
                f_10877_27382_27421(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 27382, 27421);
                    return return_v;
                }


                TLocalState
                f_10877_27476_27494(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 27476, 27494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 27182, 27506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 27182, 27506);
            }
        }

        private void LoopTail(BoundLoopStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 27645, 27947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27716, 27752);

                var
                oldState = f_10877_27731_27751(_loopHeadState, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27766, 27936) || true) && (f_10877_27770_27804(this, ref oldState, ref this.State))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 27766, 27936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27838, 27870);

                    _loopHeadState[node] = oldState;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 27888, 27921);

                    this.stateChangedAfterUse = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 27766, 27936);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 27645, 27947);

                TLocalState
                f_10877_27731_27751(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundLoopStatement, TLocalState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLoopStatement
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 27731, 27751);
                    return return_v;
                }


                bool
                f_10877_27770_27804(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 27770, 27804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 27645, 27947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 27645, 27947);
            }
        }

        private void ResolveBreaks(TLocalState breakState, LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 28132, 29103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28226, 28264);

                var
                pendingBranches = f_10877_28248_28263()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28278, 28312);

                var
                count = f_10877_28290_28311(pendingBranches)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28328, 29055) || true) && (count != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 28328, 29055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28376, 28397);

                    int
                    stillPending = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28424, 28429);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28415, 28985) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28442, 28445)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 28415, 28985))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 28415, 28985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28487, 28520);

                            var
                            pending = f_10877_28501_28519(pendingBranches, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28542, 28966) || true) && (pending.Label == label)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 28542, 28966);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28618, 28658);

                                f_10877_28618_28657(this, ref breakState, ref pending.State);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 28542, 28966);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 28542, 28966);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28756, 28902) || true) && (stillPending != i)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 28756, 28902);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28835, 28875);

                                    pendingBranches[stillPending] = pending;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 28756, 28902);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 28928, 28943);

                                stillPending++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 28542, 28966);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 571);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 571);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29005, 29040);

                    f_10877_29005_29039(
                                    pendingBranches, stillPending);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 28328, 29055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29071, 29092);

                f_10877_29071_29091(this, breakState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 28132, 29103);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_28248_28263()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 28248, 28263);
                    return return_v;
                }


                int
                f_10877_28290_28311(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 28290, 28311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_28501_28519(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 28501, 28519);
                    return return_v;
                }


                bool
                f_10877_28618_28657(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 28618, 28657);
                    return return_v;
                }


                int
                f_10877_29005_29039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 29005, 29039);
                    return 0;
                }


                int
                f_10877_29071_29091(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 29071, 29091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 28132, 29103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 28132, 29103);
            }
        }

        private void ResolveContinues(LabelSymbol continueLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 29252, 30916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29333, 29371);

                var
                pendingBranches = f_10877_29355_29370()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29385, 29419);

                var
                count = f_10877_29397_29418(pendingBranches)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29435, 30905) || true) && (count != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 29435, 30905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29483, 29504);

                    int
                    stillPending = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29531, 29536);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29522, 30835) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29549, 29552)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 29522, 30835))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 29522, 30835);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29594, 29627);

                            var
                            pending = f_10877_29608_29626(pendingBranches, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 29649, 30816) || true) && (pending.Label == continueLabel)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 29649, 30816);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 30468, 30508);

                                f_10877_30468_30507(this, ref this.State, ref pending.State);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 29649, 30816);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 29649, 30816);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 30606, 30752) || true) && (stillPending != i)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 30606, 30752);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 30685, 30725);

                                    pendingBranches[stillPending] = pending;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 30606, 30752);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 30778, 30793);

                                stillPending++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 29649, 30816);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 1314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 1314);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 30855, 30890);

                    f_10877_30855_30889(
                                    pendingBranches, stillPending);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 29435, 30905);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 29252, 30916);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_29355_29370()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 29355, 29370);
                    return return_v;
                }


                int
                f_10877_29397_29418(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 29397, 29418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_29608_29626(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 29608, 29626);
                    return return_v;
                }


                bool
                f_10877_30468_30507(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 30468, 30507);
                    return return_v;
                }


                int
                f_10877_30855_30889(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 30855, 30889);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 29252, 30916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 29252, 30916);
            }
        }

        protected virtual void NoteBranch(PendingBranch pending, BoundNode gotoStmt, BoundStatement target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 31147, 31316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31271, 31305);

                f_10877_31271_31304(target);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 31147, 31316);

                int
                f_10877_31271_31304(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    node.AssertIsLabeledStatement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 31271, 31304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 31147, 31316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 31147, 31316);
            }
        }

        private bool ResolveBranches(LabelSymbol label, BoundStatement target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 31654, 32820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31772, 31857) || true) && (target != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 31772, 31857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31809, 31857);

                    f_10877_31809_31856(target, label);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 31772, 31857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31873, 31904);

                bool
                labelStateChanged = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31918, 31956);

                var
                pendingBranches = f_10877_31940_31955()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 31970, 32004);

                var
                count = f_10877_31982_32003(pendingBranches)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32020, 32768) || true) && (count != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 32020, 32768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32068, 32089);

                    int
                    stillPending = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32116, 32121);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32107, 32698) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32134, 32137)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 32107, 32698))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 32107, 32698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32179, 32212);

                            var
                            pending = f_10877_32193_32211(pendingBranches, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32234, 32679) || true) && (pending.Label == label)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 32234, 32679);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32310, 32371);

                                f_10877_32310_32370(this, pending, label, target, ref labelStateChanged);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 32234, 32679);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 32234, 32679);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32469, 32615) || true) && (stillPending != i)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 32469, 32615);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32548, 32588);

                                    pendingBranches[stillPending] = pending;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 32469, 32615);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32641, 32656);

                                stillPending++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 32234, 32679);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 592);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 592);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32718, 32753);

                    f_10877_32718_32752(
                                    pendingBranches, stillPending);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 32020, 32768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32784, 32809);

                return labelStateChanged;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 31654, 32820);

                int
                f_10877_31809_31856(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    node.AssertIsLabeledStatementWithLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 31809, 31856);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_31940_31955()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 31940, 31955);
                    return return_v;
                }


                int
                f_10877_31982_32003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 31982, 32003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_32193_32211(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 32193, 32211);
                    return return_v;
                }


                int
                f_10877_32310_32370(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                pending, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                target, ref bool
                labelStateChanged)
                {
                    this_param.ResolveBranch(pending, label, target, ref labelStateChanged);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 32310, 32370);
                    return 0;
                }


                int
                f_10877_32718_32752(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, int
                limit)
                {
                    this_param.Clip(limit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 32718, 32752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 31654, 32820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 31654, 32820);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void ResolveBranch(PendingBranch pending, LabelSymbol label, BoundStatement target, ref bool labelStateChanged)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 32832, 33357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 32986, 33016);

                var
                state = f_10877_32998_33015(this, label)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33030, 33141) || true) && (target != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 33030, 33141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33082, 33126);

                    f_10877_33082_33125(this, pending, pending.Branch, target);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 33030, 33141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33157, 33206);

                var
                changed = f_10877_33171_33205(this, ref state, ref pending.State)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33220, 33346) || true) && (changed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 33220, 33346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33265, 33290);

                    labelStateChanged = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33308, 33331);

                    _labels[label] = state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 33220, 33346);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 32832, 33357);

                TLocalState
                f_10877_32998_33015(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.LabelState(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 32998, 33015);
                    return return_v;
                }


                int
                f_10877_33082_33125(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                pending, Microsoft.CodeAnalysis.CSharp.BoundNode
                gotoStmt, Microsoft.CodeAnalysis.CSharp.BoundStatement
                target)
                {
                    this_param.NoteBranch(pending, gotoStmt, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 33082, 33125);
                    return 0;
                }


                bool
                f_10877_33171_33205(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 33171, 33205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 32832, 33357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 32832, 33357);
            }
        }

        protected struct SavedPending
        {

            public readonly ArrayBuilder<PendingBranch> PendingBranches;

            public readonly PooledHashSet<BoundStatement> LabelsSeen;

            public SavedPending(ArrayBuilder<PendingBranch> pendingBranches, PooledHashSet<BoundStatement> labelsSeen)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10877, 33570, 33810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33709, 33748);

                    this.PendingBranches = pendingBranches;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 33766, 33795);

                    this.LabelsSeen = labelsSeen;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10877, 33570, 33810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 33570, 33810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 33570, 33810);
                }
            }
            static SavedPending()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10877, 33369, 33821);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10877, 33369, 33821);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 33369, 33821);
            }
        }

        protected SavedPending SavePending()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 34143, 34506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 34204, 34243);

                f_10877_34204_34242(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 34257, 34317);

                var
                result = f_10877_34270_34316(f_10877_34287_34302(), _labelsSeen)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 34333, 34393);

                PendingBranches = f_10877_34351_34392();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 34407, 34465);

                _labelsSeen = f_10877_34421_34464();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 34481, 34495);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 34143, 34506);

                int
                f_10877_34204_34242(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 34204, 34242);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_34287_34302()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 34287, 34302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10877_34270_34316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                pendingBranches, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                labelsSeen)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending(pendingBranches, labelsSeen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 34270, 34316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_34351_34392()
                {
                    var return_v = ArrayBuilder<PendingBranch>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 34351, 34392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_34421_34464()
                {
                    var return_v = PooledHashSet<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 34421, 34464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 34143, 34506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 34143, 34506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void RestorePending(SavedPending oldPending)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 34943, 36957);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35022, 36351);
                    foreach (var node in f_10877_35043_35054_I(_labelsSeen))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35022, 36351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35088, 36336);

                        switch (f_10877_35096_35105(node))
                        {

                            case BoundKind.LabeledStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35088, 36336);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35236, 35276);

                                    var
                                    label = (BoundLabeledStatement)node
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35306, 35366);

                                    stateChangedAfterUse |= f_10877_35330_35365(this, f_10877_35346_35357(label), label);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 35419, 35425);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35088, 36336);

                            case BoundKind.LabelStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35088, 36336);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35534, 35572);

                                    var
                                    label = (BoundLabelStatement)node
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35602, 35662);

                                    stateChangedAfterUse |= f_10877_35626_35661(this, f_10877_35642_35653(label), label);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 35715, 35721);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35088, 36336);

                            case BoundKind.SwitchSection:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35088, 36336);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35829, 35864);

                                    var
                                    sec = (BoundSwitchSection)node
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35894, 36087);
                                        foreach (var label in f_10877_35916_35932_I(f_10877_35916_35932(sec)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35894, 36087);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 35998, 36056);

                                            stateChangedAfterUse |= f_10877_36022_36055(this, f_10877_36038_36049(label), sec);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35894, 36087);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 194);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 194);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 36140, 36146);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35088, 36336);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 35088, 36336);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36265, 36317);

                                throw f_10877_36271_36316(f_10877_36306_36315(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35088, 36336);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 35022, 36351);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 1330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 1330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36367, 36425);

                f_10877_36367_36424(
                            oldPending.PendingBranches, f_10877_36403_36423(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36441, 36464);

                f_10877_36441_36463(f_10877_36441_36456());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36478, 36523);

                PendingBranches = oldPending.PendingBranches;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36877, 36896);

                f_10877_36877_36895(
                            // We only use SavePending/RestorePending when there could be no branch into the region between them.
                            // So there is no need to save the labels seen between the calls.  If there were such a need, we would
                            // do "this.labelsSeen.UnionWith(oldPending.LabelsSeen);" instead of the following assignment
                            _labelsSeen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 36910, 36946);

                _labelsSeen = oldPending.LabelsSeen;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 34943, 36957);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_35096_35105(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 35096, 35105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_35346_35357(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 35346, 35357);
                    return return_v;
                }


                bool
                f_10877_35330_35365(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                target)
                {
                    var return_v = this_param.ResolveBranches(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 35330, 35365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_35642_35653(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 35642, 35653);
                    return return_v;
                }


                bool
                f_10877_35626_35661(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                target)
                {
                    var return_v = this_param.ResolveBranches(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 35626, 35661);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10877_35916_35932(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 35916, 35932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_36038_36049(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 36038, 36049);
                    return return_v;
                }


                bool
                f_10877_36022_36055(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                target)
                {
                    var return_v = this_param.ResolveBranches(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 36022, 36055);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10877_35916_35932_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 35916, 35932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_36306_36315(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 36306, 36315);
                    return return_v;
                }


                System.Exception
                f_10877_36271_36316(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 36271, 36316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_35043_35054_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 35043, 35054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_36403_36423(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 36403, 36423);
                    return return_v;
                }


                int
                f_10877_36367_36424(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 36367, 36424);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_36441_36456()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 36441, 36456);
                    return return_v;
                }


                int
                f_10877_36441_36463(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 36441, 36463);
                    return 0;
                }


                int
                f_10877_36877_36895(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 36877, 36895);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 34943, 36957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 34943, 36957);
            }
        }

        public override BoundNode DefaultVisit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 37266, 37551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37345, 37433);

                f_10877_37345_37432(false, $"Should Visit{f_10877_37380_37389(node)} be overridden in {f_10877_37409_37428(f_10877_37409_37423(this))}?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37447, 37514);

                f_10877_37447_37513(f_10877_37447_37458(), ErrorCode.ERR_InternalError, f_10877_37492_37512(node.Syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37528, 37540);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 37266, 37551);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_37380_37389(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 37380, 37389);
                    return return_v;
                }


                System.Type
                f_10877_37409_37423(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 37409, 37423);
                    return return_v;
                }


                string
                f_10877_37409_37428(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 37409, 37428);
                    return return_v;
                }


                int
                f_10877_37345_37432(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 37345, 37432);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10877_37447_37458()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 37447, 37458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10877_37492_37512(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 37492, 37512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10877_37447_37513(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 37447, 37513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 37266, 37551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 37266, 37551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAttribute(BoundAttribute node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 37563, 37754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37731, 37743);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 37563, 37754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 37563, 37754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 37563, 37754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowExpression(BoundThrowExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 37766, 37961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37864, 37893);

                f_10877_37864_37892(this, f_10877_37876_37891(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37907, 37924);

                f_10877_37907_37923(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 37938, 37950);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 37766, 37961);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_37876_37891(Microsoft.CodeAnalysis.CSharp.BoundThrowExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 37876, 37891);
                    return return_v;
                }


                int
                f_10877_37864_37892(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 37864, 37892);
                    return 0;
                }


                int
                f_10877_37907_37923(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 37907, 37923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 37766, 37961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 37766, 37961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPassByCopy(BoundPassByCopy node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 37973, 38127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38061, 38090);

                f_10877_38061_38089(this, f_10877_38073_38088(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38104, 38116);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 37973, 38127);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_38073_38088(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38073, 38088);
                    return return_v;
                }


                int
                f_10877_38061_38089(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38061, 38089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 37973, 38127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 37973, 38127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIsPatternExpression(BoundIsPatternExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 38139, 39159);
                Microsoft.CodeAnalysis.CSharp.BoundPattern pattern = default(Microsoft.CodeAnalysis.CSharp.BoundPattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38245, 38279);

                f_10877_38245_38278(!IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38293, 38322);

                f_10877_38293_38321(this, f_10877_38305_38320(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38338, 38393);

                bool
                negated = f_10877_38353_38392(f_10877_38353_38365(node), out pattern)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38407, 38447);

                f_10877_38407_38446(negated == f_10877_38431_38445(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38463, 38485);

                f_10877_38463_38484(this, pattern);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38499, 38554);

                var
                reachableLabels = f_10877_38521_38553(f_10877_38521_38537(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38568, 38983) || true) && (!f_10877_38573_38617(reachableLabels, f_10877_38598_38616(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 38568, 38983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38651, 38681);

                    f_10877_38651_38680(this, this.StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38699, 38751);

                    f_10877_38699_38750(this, f_10877_38719_38737(this), this.State);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 38568, 38983);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 38568, 38983);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38785, 38983) || true) && (!f_10877_38790_38835(reachableLabels, f_10877_38815_38834(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 38785, 38983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38869, 38898);

                        f_10877_38869_38897(this, this.StateWhenTrue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38916, 38968);

                        f_10877_38916_38967(this, this.State, f_10877_38948_38966(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 38785, 38983);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 38568, 38983);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 38999, 39120) || true) && (negated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 38999, 39120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39044, 39105);

                    f_10877_39044_39104(this, this.StateWhenFalse, this.StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 38999, 39120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39136, 39148);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 38139, 39159);

                int
                f_10877_38245_38278(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38245, 38278);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_38305_38320(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38305, 38320);
                    return return_v;
                }


                int
                f_10877_38293_38321(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38293, 38321);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10877_38353_38365(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38353, 38365);
                    return return_v;
                }


                bool
                f_10877_38353_38392(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param, out Microsoft.CodeAnalysis.CSharp.BoundPattern
                innerPattern)
                {
                    var return_v = this_param.IsNegated(out innerPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38353, 38392);
                    return return_v;
                }


                bool
                f_10877_38431_38445(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.IsNegated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38431, 38445);
                    return return_v;
                }


                int
                f_10877_38407_38446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38407, 38446);
                    return 0;
                }


                int
                f_10877_38463_38484(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern)
                {
                    this_param.VisitPattern(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38463, 38484);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10877_38521_38537(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.DecisionDag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38521, 38537);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10877_38521_38553(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38521, 38553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_38598_38616(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenTrueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38598, 38616);
                    return return_v;
                }


                bool
                f_10877_38573_38617(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38573, 38617);
                    return return_v;
                }


                int
                f_10877_38651_38680(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38651, 38680);
                    return 0;
                }


                TLocalState
                f_10877_38719_38737(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38719, 38737);
                    return return_v;
                }


                int
                f_10877_38699_38750(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38699, 38750);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_38815_38834(Microsoft.CodeAnalysis.CSharp.BoundIsPatternExpression
                this_param)
                {
                    var return_v = this_param.WhenFalseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 38815, 38834);
                    return return_v;
                }


                bool
                f_10877_38790_38835(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38790, 38835);
                    return return_v;
                }


                int
                f_10877_38869_38897(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38869, 38897);
                    return 0;
                }


                TLocalState
                f_10877_38948_38966(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38948, 38966);
                    return return_v;
                }


                int
                f_10877_38916_38967(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 38916, 38967);
                    return 0;
                }


                int
                f_10877_39044_39104(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 39044, 39104);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 38139, 39159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 38139, 39159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual void VisitPattern(BoundPattern pattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 39171, 39269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39250, 39258);

                f_10877_39250_39257(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 39171, 39269);

                int
                f_10877_39250_39257(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Split();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 39250, 39257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 39171, 39269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 39171, 39269);
            }
        }

        public override BoundNode VisitConstantPattern(BoundConstantPattern node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 39281, 39484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39436, 39473);

                throw f_10877_39442_39472();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 39281, 39484);

                System.Exception
                f_10877_39442_39472()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 39442, 39472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 39281, 39484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 39281, 39484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTupleLiteral(BoundTupleLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 39496, 39633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39588, 39622);

                return f_10877_39595_39621(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 39496, 39633);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_39595_39621(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                node)
                {
                    var return_v = this_param.VisitTupleExpression((Microsoft.CodeAnalysis.CSharp.BoundTupleExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 39595, 39621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 39496, 39633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 39496, 39633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedTupleLiteral(BoundConvertedTupleLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 39645, 39800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39755, 39789);

                return f_10877_39762_39788(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 39645, 39800);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_39762_39788(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConvertedTupleLiteral
                node)
                {
                    var return_v = this_param.VisitTupleExpression((Microsoft.CodeAnalysis.CSharp.BoundTupleExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 39762, 39788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 39645, 39800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 39645, 39800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitTupleExpression(BoundTupleExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 39812, 40010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39902, 39973);

                f_10877_39902_39972(this, f_10877_39917_39931(node), default(ImmutableArray<RefKind>), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 39987, 39999);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 39812, 40010);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_39917_39931(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 39917, 39931);
                    return return_v;
                }


                int
                f_10877_39902_39972(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 39902, 39972);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 39812, 40010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 39812, 40010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTupleBinaryOperator(BoundTupleBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 40022, 40226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40128, 40151);

                f_10877_40128_40150(this, f_10877_40140_40149(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40165, 40189);

                f_10877_40165_40188(this, f_10877_40177_40187(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40203, 40215);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 40022, 40226);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_40140_40149(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40140, 40149);
                    return return_v;
                }


                int
                f_10877_40128_40150(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40128, 40150);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_40177_40187(Microsoft.CodeAnalysis.CSharp.BoundTupleBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40177, 40187);
                    return return_v;
                }


                int
                f_10877_40165_40188(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40165, 40188);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 40022, 40226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 40022, 40226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicObjectCreationExpression(BoundDynamicObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 40238, 40525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40368, 40431);

                f_10877_40368_40430(this, f_10877_40383_40397(node), f_10877_40399_40423(node), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40445, 40488);

                f_10877_40445_40487(this, f_10877_40457_40486(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40502, 40514);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 40238, 40525);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_40383_40397(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40383, 40397);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_40399_40423(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40399, 40423);
                    return return_v;
                }


                int
                f_10877_40368_40430(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40368, 40430);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10877_40457_40486(Microsoft.CodeAnalysis.CSharp.BoundDynamicObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40457, 40486);
                    return return_v;
                }


                int
                f_10877_40445_40487(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40445, 40487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 40238, 40525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 40238, 40525);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicIndexerAccess(BoundDynamicIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 40537, 40786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40645, 40672);

                f_10877_40645_40671(this, f_10877_40657_40670(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40686, 40749);

                f_10877_40686_40748(this, f_10877_40701_40715(node), f_10877_40717_40741(node), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40763, 40775);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 40537, 40786);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_40657_40670(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40657, 40670);
                    return return_v;
                }


                int
                f_10877_40645_40671(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40645, 40671);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_40701_40715(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40701, 40715);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_40717_40741(Microsoft.CodeAnalysis.CSharp.BoundDynamicIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40717, 40741);
                    return return_v;
                }


                int
                f_10877_40686_40748(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40686, 40748);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 40537, 40786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 40537, 40786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicMemberAccess(BoundDynamicMemberAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 40798, 40968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40904, 40931);

                f_10877_40904_40930(this, f_10877_40916_40929(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 40945, 40957);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 40798, 40968);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_40916_40929(Microsoft.CodeAnalysis.CSharp.BoundDynamicMemberAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 40916, 40929);
                    return return_v;
                }


                int
                f_10877_40904_40930(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 40904, 40930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 40798, 40968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 40798, 40968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicInvocation(BoundDynamicInvocation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 40980, 41225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41082, 41111);

                f_10877_41082_41110(this, f_10877_41094_41109(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41125, 41188);

                f_10877_41125_41187(this, f_10877_41140_41154(node), f_10877_41156_41180(node), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41202, 41214);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 40980, 41225);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_41094_41109(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41094, 41109);
                    return return_v;
                }


                int
                f_10877_41082_41110(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41082, 41110);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_41140_41154(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41140, 41154);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_41156_41180(Microsoft.CodeAnalysis.CSharp.BoundDynamicInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41156, 41180);
                    return return_v;
                }


                int
                f_10877_41125_41187(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41125, 41187);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 40980, 41225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 40980, 41225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitInterpolatedString(BoundInterpolatedString node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 41237, 41476);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41341, 41439);
                    foreach (var expr in f_10877_41362_41372_I(f_10877_41362_41372(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 41341, 41439);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41406, 41424);

                        f_10877_41406_41423(this, expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 41341, 41439);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 99);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 99);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41453, 41465);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 41237, 41476);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_41362_41372(Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString
                this_param)
                {
                    var return_v = this_param.Parts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41362, 41372);
                    return return_v;
                }


                int
                f_10877_41406_41423(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41406, 41423);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_41362_41372_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41362, 41372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 41237, 41476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 41237, 41476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitStringInsert(BoundStringInsert node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 41488, 41873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41580, 41604);

                f_10877_41580_41603(this, f_10877_41592_41602(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41618, 41721) || true) && (f_10877_41622_41636(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 41618, 41721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41678, 41706);

                    f_10877_41678_41705(this, f_10877_41690_41704(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 41618, 41721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41737, 41834) || true) && (f_10877_41741_41752(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 41737, 41834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41794, 41819);

                    f_10877_41794_41818(this, f_10877_41806_41817(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 41737, 41834);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 41850, 41862);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 41488, 41873);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_41592_41602(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41592, 41602);
                    return return_v;
                }


                int
                f_10877_41580_41603(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41580, 41603);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_41622_41636(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41622, 41636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_41690_41704(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41690, 41704);
                    return return_v;
                }


                int
                f_10877_41678_41705(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41678, 41705);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral?
                f_10877_41741_41752(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                this_param)
                {
                    var return_v = this_param.Format;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41741, 41752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10877_41806_41817(Microsoft.CodeAnalysis.CSharp.BoundStringInsert
                this_param)
                {
                    var return_v = this_param.Format;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 41806, 41817);
                    return return_v;
                }


                int
                f_10877_41794_41818(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 41794, 41818);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 41488, 41873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 41488, 41873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArgList(BoundArgList node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 41885, 42142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42119, 42131);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 41885, 42142);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 41885, 42142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 41885, 42142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArgListOperator(BoundArgListOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 42154, 42429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42329, 42392);

                f_10877_42329_42391(this, f_10877_42344_42358(node), f_10877_42360_42384(node), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42406, 42418);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 42154, 42429);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_42344_42358(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 42344, 42358);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_42360_42384(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 42360, 42384);
                    return return_v;
                }


                int
                f_10877_42329_42391(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 42329, 42391);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 42154, 42429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 42154, 42429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRefTypeOperator(BoundRefTypeOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 42441, 42602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42539, 42565);

                f_10877_42539_42564(this, f_10877_42551_42563(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42579, 42591);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 42441, 42602);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_42551_42563(Microsoft.CodeAnalysis.CSharp.BoundRefTypeOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 42551, 42563);
                    return return_v;
                }


                int
                f_10877_42539_42564(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 42539, 42564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 42441, 42602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 42441, 42602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMakeRefOperator(BoundMakeRefOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 42614, 42985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42895, 42948);

                f_10877_42895_42947(this, f_10877_42907_42919(node), isKnownToBeAnLvalue: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 42962, 42974);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 42614, 42985);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_42907_42919(Microsoft.CodeAnalysis.CSharp.BoundMakeRefOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 42907, 42919);
                    return return_v;
                }


                int
                f_10877_42895_42947(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 42895, 42947);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 42614, 42985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 42614, 42985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRefValueOperator(BoundRefValueOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 42997, 43160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43097, 43123);

                f_10877_43097_43122(this, f_10877_43109_43121(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43137, 43149);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 42997, 43160);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_43109_43121(Microsoft.CodeAnalysis.CSharp.BoundRefValueOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43109, 43121);
                    return return_v;
                }


                int
                f_10877_43097_43122(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 43097, 43122);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 42997, 43160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 42997, 43160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGlobalStatementInitializer(BoundGlobalStatementInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 43172, 43360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43292, 43323);

                f_10877_43292_43322(this, f_10877_43307_43321(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43337, 43349);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 43172, 43360);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_43307_43321(Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer
                this_param)
                {
                    var return_v = this_param.Statement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43307, 43321);
                    return return_v;
                }


                int
                f_10877_43292_43322(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 43292, 43322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 43172, 43360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 43172, 43360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 43428, 43435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43431, 43435);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 43428, 43435);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 43428, 43435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 43428, 43435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 43502, 43509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43505, 43509);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 43502, 43509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 43502, 43509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 43502, 43509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLocalDeclaration(BoundLocalDeclaration node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 43522, 44143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43622, 44104) || true) && (f_10877_43626_43645(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 43622, 44104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43730, 43826);

                    f_10877_43730_43825(this, f_10877_43742_43761(node), isKnownToBeAnLvalue: f_10877_43784_43808(f_10877_43784_43800(node)) != RefKind.None);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43909, 44089) || true) && (f_10877_43913_43937(f_10877_43913_43929(node)) != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 43909, 44089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 43995, 44070);

                        f_10877_43995_44069(this, f_10877_44009_44028(node), f_10877_44030_44054(f_10877_44030_44046(node)), method: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 43909, 44089);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 43622, 44104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44120, 44132);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 43522, 44143);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_43626_43645(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43626, 43645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_43742_43761(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43742, 43761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10877_43784_43800(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43784, 43800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_43784_43808(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43784, 43808);
                    return return_v;
                }


                int
                f_10877_43730_43825(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 43730, 43825);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10877_43913_43929(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43913, 43929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_43913_43937(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 43913, 43937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_44009_44028(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44009, 44028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10877_44030_44046(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44030, 44046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_44030_44054(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44030, 44054);
                    return return_v;
                }


                int
                f_10877_43995_44069(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 43995, 44069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 43522, 44143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 43522, 44143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 44155, 44303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44233, 44266);

                f_10877_44233_44265(this, f_10877_44249_44264(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44280, 44292);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 44155, 44303);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_44249_44264(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44249, 44264);
                    return return_v;
                }


                int
                f_10877_44233_44265(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.VisitStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 44233, 44265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 44155, 44303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 44155, 44303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitStatements(ImmutableArray<BoundStatement> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 44315, 44533);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44411, 44522);
                    foreach (var statement in f_10877_44437_44447_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 44411, 44522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44481, 44507);

                        f_10877_44481_44506(this, statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 44411, 44522);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 112);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 44315, 44533);

                int
                f_10877_44481_44506(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 44481, 44506);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_44437_44447_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 44437, 44447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 44315, 44533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 44315, 44533);
            }
        }

        public override BoundNode VisitScope(BoundScope node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 44545, 44693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44623, 44656);

                f_10877_44623_44655(this, f_10877_44639_44654(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44670, 44682);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 44545, 44693);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_44639_44654(Microsoft.CodeAnalysis.CSharp.BoundScope
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44639, 44654);
                    return return_v;
                }


                int
                f_10877_44623_44655(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    this_param.VisitStatements(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 44623, 44655);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 44545, 44693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 44545, 44693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitExpressionStatement(BoundExpressionStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 44705, 44877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44811, 44840);

                f_10877_44811_44839(this, f_10877_44823_44838(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 44854, 44866);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 44705, 44877);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_44823_44838(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 44823, 44838);
                    return return_v;
                }


                int
                f_10877_44811_44839(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 44811, 44839);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 44705, 44877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 44705, 44877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 44889, 46168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45234, 45302);

                bool
                callsAreOmitted = f_10877_45257_45301(f_10877_45257_45268(node), f_10877_45285_45300(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45316, 45362);

                TLocalState
                savedState = default(TLocalState)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45378, 45513) || true) && (callsAreOmitted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 45378, 45513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45431, 45463);

                    savedState = f_10877_45444_45462(this.State);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45481, 45498);

                    f_10877_45481_45497(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 45378, 45513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45529, 45584);

                f_10877_45529_45583(this, f_10877_45553_45569(node), f_10877_45571_45582(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45598, 45665);

                f_10877_45598_45664(this, f_10877_45623_45637(node), f_10877_45639_45663(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45681, 45858) || true) && (f_10877_45685_45716_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10877_45685_45696(node), 10877, 45685, 45716)?.OriginalDefinition) is LocalFunctionSymbol localFunc)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 45681, 45858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45783, 45843);

                    f_10877_45783_45842(this, localFunc, node.Syntax, isCall: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 45681, 45858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45874, 45953);

                f_10877_45874_45952(this, f_10877_45898_45912(node), f_10877_45914_45938(node), f_10877_45940_45951(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 45967, 46021);

                f_10877_45967_46020(this, f_10877_45990_46006(node), f_10877_46008_46019(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46037, 46129) || true) && (callsAreOmitted)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 46037, 46129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46090, 46114);

                    this.State = savedState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 46037, 46129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46145, 46157);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 44889, 46168);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_45257_45268(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45257, 45268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10877_45285_45300(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45285, 45300);
                    return return_v;
                }


                bool
                f_10877_45257_45301(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45257, 45301);
                    return return_v;
                }


                TLocalState
                f_10877_45444_45462(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45444, 45462);
                    return return_v;
                }


                int
                f_10877_45481_45497(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45481, 45497);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_45553_45569(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45553, 45569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_45571_45582(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45571, 45582);
                    return return_v;
                }


                int
                f_10877_45529_45583(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45529, 45583);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_45623_45637(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45623, 45637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_45639_45663(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45639, 45663);
                    return return_v;
                }


                int
                f_10877_45598_45664(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt)
                {
                    this_param.VisitArgumentsBeforeCall(arguments, refKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45598, 45664);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_45685_45696(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45685, 45696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_45685_45716_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45685, 45716);
                    return return_v;
                }


                int
                f_10877_45783_45842(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isCall)
                {
                    this_param.VisitLocalFunctionUse(symbol, syntax, isCall: isCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45783, 45842);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_45898_45912(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45898, 45912);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_45914_45938(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45914, 45938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_45940_45951(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45940, 45951);
                    return return_v;
                }


                int
                f_10877_45874_45952(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitArgumentsAfterCall(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45874, 45952);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_45990_46006(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 45990, 46006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_46008_46019(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 46008, 46019);
                    return return_v;
                }


                int
                f_10877_45967_46020(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 45967, 46020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 44889, 46168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 44889, 46168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void VisitLocalFunctionUse(LocalFunctionSymbol symbol, SyntaxNode syntax, bool isCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 46180, 46444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46301, 46357);

                var
                localFuncState = f_10877_46322_46356(this, symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46371, 46433);

                f_10877_46371_46432(this, symbol, localFuncState, syntax, isCall);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 46180, 46444);

                TLocalFunctionState
                f_10877_46322_46356(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                localFunc)
                {
                    var return_v = this_param.GetOrCreateLocalFuncUsages(localFunc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 46322, 46356);
                    return return_v;
                }


                int
                f_10877_46371_46432(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, TLocalFunctionState
                localFunctionState, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isCall)
                {
                    this_param.VisitLocalFunctionUse(symbol, localFunctionState, syntax, isCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 46371, 46432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 46180, 46444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 46180, 46444);
            }
        }

        protected virtual void VisitLocalFunctionUse(
                    LocalFunctionSymbol symbol,
                    TLocalFunctionState localFunctionState,
                    SyntaxNode syntax,
                    bool isCall)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 46456, 46923);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46678, 46864) || true) && (isCall)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 46678, 46864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46722, 46778);

                    f_10877_46722_46777(this, ref State, ref localFunctionState.StateFromBottom);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46796, 46849);

                    f_10877_46796_46848(this, ref State, ref localFunctionState.StateFromTop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 46678, 46864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 46878, 46912);

                localFunctionState.Visited = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 46456, 46923);

                bool
                f_10877_46722_46777(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 46722, 46777);
                    return return_v;
                }


                bool
                f_10877_46796_46848(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Meet(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 46796, 46848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 46456, 46923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 46456, 46923);
            }
        }

        private void VisitReceiverBeforeCall(BoundExpression receiverOpt, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 46935, 47196);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47046, 47185) || true) && (method is null || (DynAbs.Tracing.TraceSender.Expression_False(10877, 47050, 47111) || f_10877_47068_47085(method) != MethodKind.Constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47046, 47185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47145, 47170);

                    f_10877_47145_47169(this, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47046, 47185);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 46935, 47196);

                Microsoft.CodeAnalysis.MethodKind
                f_10877_47068_47085(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 47068, 47085);
                    return return_v;
                }


                int
                f_10877_47145_47169(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47145, 47169);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 46935, 47196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 46935, 47196);
            }
        }

        private void VisitReceiverAfterCall(BoundExpression receiverOpt, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 47208, 47971);
                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol thisParameter = default(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47318, 47397) || true) && (receiverOpt is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47318, 47397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47375, 47382);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47318, 47397);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47413, 47960) || true) && (method is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47413, 47960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47465, 47519);

                    f_10877_47465_47518(this, receiverOpt, RefKind.Ref, method: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47413, 47960);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47413, 47960);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47553, 47960) || true) && (f_10877_47557_47606(method, out thisParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 47557, 47650) && thisParameter is object
                    ) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 47557, 47707) && !f_10877_47672_47707(f_10877_47688_47706(thisParameter))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47553, 47960);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47741, 47781);

                        var
                        thisRefKind = f_10877_47759_47780(thisParameter)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47799, 47945) || true) && (f_10877_47803_47836(thisRefKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 47799, 47945);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 47878, 47926);

                            f_10877_47878_47925(this, receiverOpt, thisRefKind, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47799, 47945);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47553, 47960);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 47413, 47960);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 47208, 47971);

                int
                f_10877_47465_47518(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47465, 47518);
                    return 0;
                }


                bool
                f_10877_47557_47606(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                thisParameter)
                {
                    var return_v = this_param.TryGetThisParameter(out thisParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47557, 47606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10877_47688_47706(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 47688, 47706);
                    return return_v;
                }


                bool
                f_10877_47672_47707(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t)
                {
                    var return_v = TypeIsImmutable(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47672, 47707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_47759_47780(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 47759, 47780);
                    return return_v;
                }


                bool
                f_10877_47803_47836(Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = refKind.IsWritableReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47803, 47836);
                    return return_v;
                }


                int
                f_10877_47878_47925(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 47878, 47925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 47208, 47971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 47208, 47971);
            }
        }

        private static bool TypeIsImmutable(TypeSymbol t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10877, 48293, 49220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 48367, 49209);

                switch (f_10877_48375_48388(t))
                {

                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_DateTime:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 48367, 49209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49108, 49120);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 48367, 49209);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 48367, 49209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49168, 49194);

                        return f_10877_49175_49193(t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 48367, 49209);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10877, 48293, 49220);

                Microsoft.CodeAnalysis.SpecialType
                f_10877_48375_48388(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 48375, 48388);
                    return return_v;
                }


                bool
                f_10877_49175_49193(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 49175, 49193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 48293, 49220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 48293, 49220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIndexerAccess(BoundIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 49232, 49687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49326, 49367);

                var
                method = f_10877_49339_49366(f_10877_49353_49365(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49381, 49431);

                f_10877_49381_49430(this, f_10877_49405_49421(node), method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49445, 49510);

                f_10877_49445_49509(this, f_10877_49460_49474(node), f_10877_49476_49500(node), method);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49524, 49648) || true) && ((object)method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 49524, 49648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49584, 49633);

                    f_10877_49584_49632(this, f_10877_49607_49623(node), method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 49524, 49648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 49664, 49676);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 49232, 49687);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_49353_49365(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Indexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 49353, 49365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_49339_49366(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 49339, 49366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_49405_49421(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 49405, 49421);
                    return return_v;
                }


                int
                f_10877_49381_49430(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 49381, 49430);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_49460_49474(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 49460, 49474);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_49476_49500(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 49476, 49500);
                    return return_v;
                }


                int
                f_10877_49445_49509(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 49445, 49509);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_49607_49623(Microsoft.CodeAnalysis.CSharp.BoundIndexerAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 49607, 49623);
                    return return_v;
                }


                int
                f_10877_49584_49632(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 49584, 49632);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 49232, 49687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 49232, 49687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIndexOrRangePatternIndexerAccess(BoundIndexOrRangePatternIndexerAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 49699, 50642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50091, 50118);

                f_10877_50091_50117(this, f_10877_50103_50116(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50132, 50187);

                var
                method = f_10877_50145_50186(f_10877_50159_50185(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50201, 50247);

                f_10877_50201_50246(this, f_10877_50224_50237(node), method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50261, 50288);

                f_10877_50261_50287(this, f_10877_50273_50286(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50302, 50543);

                method = f_10877_50311_50329(node) switch
                {
                    PropertySymbol p when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50369, 50405) && DynAbs.Tracing.TraceSender.Expression_True(10877, 50369, 50405))
    => f_10877_50389_50405(p),
                    MethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50424, 50443) && DynAbs.Tracing.TraceSender.Expression_True(10877, 50424, 50443))
    => m,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50462, 50527) && DynAbs.Tracing.TraceSender.Expression_True(10877, 50462, 50527))
    => throw f_10877_50473_50527(f_10877_50508_50526(node))
                };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50557, 50603);

                f_10877_50557_50602(this, f_10877_50580_50593(node), method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50619, 50631);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 49699, 50642);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_50103_50116(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50103, 50116);
                    return return_v;
                }


                int
                f_10877_50091_50117(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50091, 50117);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_50159_50185(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.LengthOrCountProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50159, 50185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_50145_50186(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50145, 50186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_50224_50237(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50224, 50237);
                    return return_v;
                }


                int
                f_10877_50201_50246(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50201, 50246);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_50273_50286(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50273, 50286);
                    return return_v;
                }


                int
                f_10877_50261_50287(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50261, 50287);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10877_50311_50329(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50311, 50329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_50389_50405(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50389, 50405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10877_50508_50526(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.PatternSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50508, 50526);
                    return return_v;
                }


                System.Exception
                f_10877_50473_50527(Microsoft.CodeAnalysis.CSharp.Symbol
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50473, 50527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_50580_50593(Microsoft.CodeAnalysis.CSharp.BoundIndexOrRangePatternIndexerAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50580, 50593);
                    return return_v;
                }


                int
                f_10877_50557_50602(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50557, 50602);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 49699, 50642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 49699, 50642);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitEventAssignmentOperator(BoundEventAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 50654, 50876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50768, 50798);

                f_10877_50768_50797(this, f_10877_50780_50796(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50812, 50839);

                f_10877_50812_50838(this, f_10877_50824_50837(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 50853, 50865);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 50654, 50876);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_50780_50796(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50780, 50796);
                    return return_v;
                }


                int
                f_10877_50768_50797(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50768, 50797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_50824_50837(Microsoft.CodeAnalysis.CSharp.BoundEventAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 50824, 50837);
                    return return_v;
                }


                int
                f_10877_50812_50838(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 50812, 50838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 50654, 50876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 50654, 50876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VisitArguments(ImmutableArray<BoundExpression> arguments, ImmutableArray<RefKind> refKindsOpt, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 50982, 51428);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51168, 51284) || true) && (method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 51168, 51284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51205, 51284);

                    f_10877_51205_51283(f_10877_51218_51254(f_10877_51218_51243(method)) != MethodKind.LocalFunction);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 51168, 51284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51298, 51347);

                f_10877_51298_51346(this, arguments, refKindsOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51361, 51417);

                f_10877_51361_51416(this, arguments, refKindsOpt, method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 50982, 51428);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_51218_51243(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 51218, 51243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10877_51218_51254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 51218, 51254);
                    return return_v;
                }


                int
                f_10877_51205_51283(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 51205, 51283);
                    return 0;
                }


                int
                f_10877_51298_51346(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt)
                {
                    this_param.VisitArgumentsBeforeCall(arguments, refKindsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 51298, 51346);
                    return 0;
                }


                int
                f_10877_51361_51416(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitArgumentsAfterCall(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 51361, 51416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 50982, 51428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 50982, 51428);
            }
        }

        private void VisitArgumentsBeforeCall(ImmutableArray<BoundExpression> arguments, ImmutableArray<RefKind> refKindsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 51440, 52072);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51650, 51655);
                    // first value and ref parameters are read...
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51641, 52061) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51679, 51682)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 51641, 52061))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 51641, 52061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51716, 51761);

                        RefKind
                        refKind = f_10877_51734_51760(refKindsOpt, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51779, 52046) || true) && (refKind != RefKind.Out)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 51779, 52046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 51847, 51919);

                            f_10877_51847_51918(this, arguments[i], isKnownToBeAnLvalue: refKind != RefKind.None);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 51779, 52046);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 51779, 52046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52001, 52027);

                            f_10877_52001_52026(this, arguments[i]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 51779, 52046);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 421);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 51440, 52072);

                Microsoft.CodeAnalysis.RefKind
                f_10877_51734_51760(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, int
                index)
                {
                    var return_v = GetRefKind(refKindsOpt, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 51734, 51760);
                    return return_v;
                }


                int
                f_10877_51847_51918(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 51847, 51918);
                    return 0;
                }


                int
                f_10877_52001_52026(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 52001, 52026);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 51440, 52072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 51440, 52072);
            }
        }

        private void VisitArgumentsAfterCall(ImmutableArray<BoundExpression> arguments, ImmutableArray<RefKind> refKindsOpt, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 52174, 52707);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52345, 52350);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52336, 52696) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52374, 52377)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 52336, 52696))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 52336, 52696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52411, 52456);

                        RefKind
                        refKind = f_10877_52429_52455(refKindsOpt, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52548, 52681) || true) && (refKind != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 52548, 52681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52617, 52662);

                            f_10877_52617_52661(this, arguments[i], refKind, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 52548, 52681);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 361);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 52174, 52707);

                Microsoft.CodeAnalysis.RefKind
                f_10877_52429_52455(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, int
                index)
                {
                    var return_v = GetRefKind(refKindsOpt, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 52429, 52455);
                    return return_v;
                }


                int
                f_10877_52617_52661(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 52617, 52661);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 52174, 52707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 52174, 52707);
            }
        }

        protected static RefKind GetRefKind(ImmutableArray<RefKind> refKindsOpt, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10877, 52719, 52934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 52827, 52923);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 52834, 52886) || 
                    (((refKindsOpt.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10877, 52834, 52886) || 
                    refKindsOpt.Length <= index)) && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 52889, 52901)) || 
                    DynAbs.Tracing.TraceSender.Conditional_F3(10877, 52904, 52922))) ? RefKind.None : refKindsOpt[index];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10877, 52719, 52934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 52719, 52934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 52719, 52934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void WriteArgument(BoundExpression arg, RefKind refKind, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 52946, 53063);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 52946, 53063);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 52946, 53063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 52946, 53063);
            }
        }

        public override BoundNode VisitBadExpression(BoundBadExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 53075, 53337);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53169, 53298);
                    foreach (var child in f_10877_53191_53211_I(f_10877_53191_53211(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 53169, 53298);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53245, 53283);

                        f_10877_53245_53282(this, child as BoundExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 53169, 53298);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53314, 53326);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 53075, 53337);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_53191_53211(Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                this_param)
                {
                    var return_v = this_param.ChildBoundNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 53191, 53211);
                    return return_v;
                }


                int
                f_10877_53245_53282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 53245, 53282);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_53191_53211_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 53191, 53211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 53075, 53337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 53075, 53337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBadStatement(BoundBadStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 53349, 53819);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53441, 53780);
                    foreach (var child in f_10877_53463_53483_I(f_10877_53463_53483(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 53441, 53780);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53517, 53765) || true) && (child is BoundStatement)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 53517, 53765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53586, 53626);

                            f_10877_53586_53625(this, child as BoundStatement);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 53517, 53765);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 53517, 53765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53708, 53746);

                            f_10877_53708_53745(this, child as BoundExpression);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 53517, 53765);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 53441, 53780);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53796, 53808);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 53349, 53819);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10877_53463_53483(Microsoft.CodeAnalysis.CSharp.BoundBadStatement
                this_param)
                {
                    var return_v = this_param.ChildBoundNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 53463, 53483);
                    return return_v;
                }


                int
                f_10877_53586_53625(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                statement)
                {
                    this_param.VisitStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement?)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 53586, 53625);
                    return 0;
                }


                int
                f_10877_53708_53745(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 53708, 53745);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                f_10877_53463_53483_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 53463, 53483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 53349, 53819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 53349, 53819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayInitialization(BoundArrayInitialization node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 53886, 54138);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 53992, 54099);
                    foreach (var child in f_10877_54014_54031_I(f_10877_54014_54031(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 53992, 54099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54065, 54084);

                        f_10877_54065_54083(this, child);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 53992, 54099);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54115, 54127);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 53886, 54138);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_54014_54031(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54014, 54031);
                    return return_v;
                }


                int
                f_10877_54065_54083(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 54065, 54083);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_54014_54031_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 54014, 54031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 53886, 54138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 53886, 54138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 54150, 55537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54270, 54322);

                var
                methodGroup = f_10877_54288_54301(node) as BoundMethodGroup
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54336, 55498) || true) && (methodGroup != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54336, 55498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54393, 55390) || true) && ((object)f_10877_54405_54419(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 54397, 54470) && f_10877_54431_54470(f_10877_54431_54445(node))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54393, 55390);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54512, 55155) || true) && (TrackingRegions)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54512, 55155);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54581, 54759) || true) && (methodGroup == this.firstInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 54585, 54660) && this.regionPlace == RegionPlace.Before))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54581, 54759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54718, 54732);

                                f_10877_54718_54731(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54581, 54759);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54787, 54824);

                            f_10877_54787_54823(this, f_10877_54799_54822(methodGroup));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54850, 54997) || true) && (methodGroup == this.lastInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 54854, 54898) && f_10877_54890_54898()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54850, 54997);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 54956, 54970);

                                f_10877_54956_54969(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54850, 54997);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54512, 55155);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54512, 55155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55095, 55132);

                            f_10877_55095_55131(this, f_10877_55107_55130(methodGroup));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54512, 55155);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54393, 55390);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54393, 55390);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55197, 55390) || true) && (f_10877_55201_55235_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10877_55201_55215(node), 10877, 55201, 55235)?.OriginalDefinition) is LocalFunctionSymbol localFunc)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 55197, 55390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55310, 55371);

                            f_10877_55310_55370(this, localFunc, node.Syntax, isCall: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 55197, 55390);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54393, 55390);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54336, 55498);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 54336, 55498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55456, 55483);

                    f_10877_55456_55482(this, f_10877_55468_55481(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 54336, 55498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55514, 55526);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 54150, 55537);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_54288_54301(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54288, 54301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_54405_54419(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54405, 54419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_54431_54445(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54431, 54445);
                    return return_v;
                }


                bool
                f_10877_54431_54470(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54431, 54470);
                    return return_v;
                }


                int
                f_10877_54718_54731(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.EnterRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 54718, 54731);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_54799_54822(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54799, 54822);
                    return return_v;
                }


                int
                f_10877_54787_54823(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 54787, 54823);
                    return 0;
                }


                bool
                f_10877_54890_54898()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 54890, 54898);
                    return return_v;
                }


                int
                f_10877_54956_54969(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.LeaveRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 54956, 54969);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_55107_55130(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 55107, 55130);
                    return return_v;
                }


                int
                f_10877_55095_55131(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 55095, 55131);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_55201_55215(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 55201, 55215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_55201_55235_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 55201, 55235);
                    return return_v;
                }


                int
                f_10877_55310_55370(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isCall)
                {
                    this_param.VisitLocalFunctionUse(symbol, syntax, isCall: isCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 55310, 55370);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_55468_55481(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 55468, 55481);
                    return return_v;
                }


                int
                f_10877_55456_55482(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 55456, 55482);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 54150, 55537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 54150, 55537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeExpression(BoundTypeExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 55549, 55668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 55645, 55657);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 55549, 55668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 55549, 55668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 55549, 55668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeOrValueExpression(BoundTypeOrValueExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 55680, 56118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56062, 56107);

                return f_10877_56069_56106(this, node.Data.ValueExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 55680, 56118);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_56069_56106(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 56069, 56106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 55680, 56118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 55680, 56118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLiteral(BoundLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56130, 56235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56212, 56224);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56130, 56235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56130, 56235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56130, 56235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodDefIndex(BoundMethodDefIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56247, 56366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56343, 56355);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56247, 56366);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56247, 56366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56247, 56366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMaximumMethodDefIndex(BoundMaximumMethodDefIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56378, 56511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56488, 56500);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56378, 56511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56378, 56511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56378, 56511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitModuleVersionId(BoundModuleVersionId node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56523, 56644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56621, 56633);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56523, 56644);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56523, 56644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56523, 56644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitModuleVersionIdString(BoundModuleVersionIdString node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56656, 56789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56766, 56778);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56656, 56789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56656, 56789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56656, 56789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitInstrumentationPayloadRoot(BoundInstrumentationPayloadRoot node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56801, 56944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 56921, 56933);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56801, 56944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56801, 56944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56801, 56944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSourceDocumentIndex(BoundSourceDocumentIndex node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 56956, 57085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57062, 57074);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 56956, 57085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 56956, 57085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 56956, 57085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 57097, 58595);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57185, 58556) || true) && (f_10877_57189_57208(node) == ConversionKind.MethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57185, 58556);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57272, 58455) || true) && (f_10877_57276_57298(node) || (DynAbs.Tracing.TraceSender.Expression_False(10877, 57276, 57377) || ((object)f_10877_57311_57325(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 57303, 57376) && f_10877_57337_57376(f_10877_57337_57351(node))))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57272, 58455);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57419, 57491);

                        BoundExpression
                        receiver = f_10877_57446_57490(((BoundMethodGroup)f_10877_57465_57477(node)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57605, 58220) || true) && (TrackingRegions)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57605, 58220);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57674, 57853) || true) && (f_10877_57678_57690(node) == this.firstInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 57678, 57754) && this.regionPlace == RegionPlace.Before))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57674, 57853);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57812, 57826);

                                f_10877_57812_57825(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57674, 57853);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57881, 57903);

                            f_10877_57881_57902(this, receiver);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 57929, 58077) || true) && (f_10877_57933_57945(node) == this.lastInRegion && (DynAbs.Tracing.TraceSender.Expression_True(10877, 57933, 57978) && f_10877_57970_57978()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57929, 58077);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58036, 58050);

                                f_10877_58036_58049(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57929, 58077);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57605, 58220);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57605, 58220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58175, 58197);

                            f_10877_58175_58196(this, receiver);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57605, 58220);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57272, 58455);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57272, 58455);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58262, 58455) || true) && (f_10877_58266_58300_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10877_58266_58280(node), 10877, 58266, 58300)?.OriginalDefinition) is LocalFunctionSymbol localFunc)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 58262, 58455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58375, 58436);

                            f_10877_58375_58435(this, localFunc, node.Syntax, isCall: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 58262, 58455);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57272, 58455);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57185, 58556);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 57185, 58556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58521, 58541);

                    f_10877_58521_58540(this, f_10877_58527_58539(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 57185, 58556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58572, 58584);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 57097, 58595);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10877_57189_57208(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57189, 57208);
                    return return_v;
                }


                bool
                f_10877_57276_57298(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57276, 57298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_57311_57325(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57311, 57325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_57337_57351(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57337, 57351);
                    return return_v;
                }


                bool
                f_10877_57337_57376(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57337, 57376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_57465_57477(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57465, 57477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_57446_57490(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57446, 57490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_57678_57690(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57678, 57690);
                    return return_v;
                }


                int
                f_10877_57812_57825(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.EnterRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 57812, 57825);
                    return 0;
                }


                int
                f_10877_57881_57902(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 57881, 57902);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_57933_57945(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57933, 57945);
                    return return_v;
                }


                bool
                f_10877_57970_57978()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 57970, 57978);
                    return return_v;
                }


                int
                f_10877_58036_58049(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.LeaveRegion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58036, 58049);
                    return 0;
                }


                int
                f_10877_58175_58196(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58175, 58196);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_58266_58280(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 58266, 58280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_58266_58300_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 58266, 58300);
                    return return_v;
                }


                int
                f_10877_58375_58435(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isCall)
                {
                    this_param.VisitLocalFunctionUse(symbol, syntax, isCall: isCall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58375, 58435);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_58527_58539(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 58527, 58539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_58521_58540(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58521, 58540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 57097, 58595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 57097, 58595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIfStatement(BoundIfStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 58607, 59244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58735, 58766);

                f_10877_58735_58765(this, f_10877_58750_58764(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58780, 58818);

                TLocalState
                trueState = StateWhenTrue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58832, 58872);

                TLocalState
                falseState = StateWhenFalse
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58886, 58906);

                f_10877_58886_58905(this, trueState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58920, 58953);

                f_10877_58920_58952(this, f_10877_58935_58951(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 58967, 58990);

                trueState = this.State;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59004, 59025);

                f_10877_59004_59024(this, falseState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59039, 59155) || true) && (f_10877_59043_59062(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 59039, 59155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59104, 59140);

                    f_10877_59104_59139(this, f_10877_59119_59138(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 59039, 59155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59171, 59207);

                f_10877_59171_59206(this, ref this.State, ref trueState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59221, 59233);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 58607, 59244);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_58750_58764(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 58750, 58764);
                    return return_v;
                }


                int
                f_10877_58735_58765(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58735, 58765);
                    return 0;
                }


                int
                f_10877_58886_58905(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58886, 58905);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_58935_58951(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 58935, 58951);
                    return return_v;
                }


                int
                f_10877_58920_58952(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 58920, 58952);
                    return 0;
                }


                int
                f_10877_59004_59024(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59004, 59024);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10877_59043_59062(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.AlternativeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 59043, 59062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_59119_59138(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.AlternativeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 59119, 59138);
                    return return_v;
                }


                int
                f_10877_59104_59139(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59104, 59139);
                    return 0;
                }


                bool
                f_10877_59171_59206(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59171, 59206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 58607, 59244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 58607, 59244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTryStatement(BoundTryStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 59256, 63117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59348, 59379);

                var
                oldPending = f_10877_59365_59378(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59442, 59480);

                var
                initialState = f_10877_59461_59479(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59592, 59629);

                var
                pendingBeforeTry = f_10877_59615_59628(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59645, 59721);

                f_10877_59645_59720(this, f_10877_59682_59695(node), node, ref initialState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59735, 59775);

                var
                finallyState = f_10877_59754_59774(initialState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59789, 59815);

                var
                endState = this.State
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59829, 60092);
                    foreach (var catchBlock in f_10877_59856_59872_I(f_10877_59856_59872(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 59829, 60092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59906, 59937);

                        f_10877_59906_59936(this, f_10877_59915_59935(initialState));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 59955, 60024);

                        f_10877_59955_60023(this, catchBlock, ref finallyState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 60042, 60077);

                        f_10877_60042_60076(this, ref endState, ref this.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 59829, 60092);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 60235, 60268);

                f_10877_60235_60267(this, pendingBeforeTry);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 60842, 62646) || true) && (f_10877_60846_60866(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 60842, 62646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61153, 61176);

                    f_10877_61153_61175(this, finallyState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61353, 61392);

                    var
                    tryAndCatchPending = f_10877_61378_61391(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61410, 61461);

                    var
                    stateMovedUpInFinally = f_10877_61438_61460(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61479, 61569);

                    f_10877_61479_61568(this, f_10877_61520_61540(node), ref stateMovedUpInFinally);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61587, 62373);
                        foreach (var pend in f_10877_61608_61642_I(tryAndCatchPending.PendingBranches))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 61587, 62373);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61684, 61812) || true) && (pend.Branch == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 61684, 61812);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61757, 61766);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 61684, 61812);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61836, 62354) || true) && (f_10877_61840_61856(pend.Branch) != BoundKind.YieldReturnStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 61836, 62354);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 61940, 62008);

                                f_10877_61940_62007(ref pend.State, ref stateMovedUpInFinally);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62036, 62331) || true) && (pend.IsConditionalState)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 62036, 62331);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62121, 62197);

                                    f_10877_62121_62196(ref pend.StateWhenTrue, ref stateMovedUpInFinally);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62227, 62304);

                                    f_10877_62227_62303(ref pend.StateWhenFalse, ref stateMovedUpInFinally);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 62036, 62331);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 61836, 62354);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 61587, 62373);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 787);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 787);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62393, 62428);

                    f_10877_62393_62427(this, tryAndCatchPending);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62446, 62481);

                    f_10877_62446_62480(this, ref endState, ref this.State);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62499, 62631) || true) && (_nonMonotonicTransfer)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 62499, 62631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62566, 62612);

                        f_10877_62566_62611(this, ref endState, ref stateMovedUpInFinally);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 62499, 62631);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 60842, 62646);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62662, 62681);

                f_10877_62662_62680(this, endState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62695, 62722);

                f_10877_62695_62721(this, oldPending);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62736, 62748);

                return null;

                void updatePendingBranchState(ref TLocalState stateToUpdate, ref TLocalState stateMovedUpInFinally)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 62764, 63106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62896, 62936);

                        f_10877_62896_62935(this, ref stateToUpdate, ref this.State);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 62954, 63091) || true) && (_nonMonotonicTransfer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 62954, 63091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63021, 63072);

                            f_10877_63021_63071(this, ref stateToUpdate, ref stateMovedUpInFinally);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 62954, 63091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 62764, 63106);

                        bool
                        f_10877_62896_62935(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                        this_param, ref TLocalState
                        self, ref TLocalState
                        other)
                        {
                            var return_v = this_param.Meet(ref self, ref other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62896, 62935);
                            return return_v;
                        }


                        bool
                        f_10877_63021_63071(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                        this_param, ref TLocalState
                        self, ref TLocalState
                        other)
                        {
                            var return_v = this_param.Join(ref self, ref other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 63021, 63071);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 62764, 63106);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 62764, 63106);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 59256, 63117);

                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10877_59365_59378(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59365, 59378);
                    return return_v;
                }


                TLocalState
                f_10877_59461_59479(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59461, 59479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10877_59615_59628(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59615, 59628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10877_59682_59695(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.TryBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 59682, 59695);
                    return return_v;
                }


                int
                f_10877_59645_59720(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                tryBlock, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node, ref TLocalState
                tryState)
                {
                    this_param.VisitTryBlockWithAnyTransferFunction((Microsoft.CodeAnalysis.CSharp.BoundStatement)tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59645, 59720);
                    return 0;
                }


                TLocalState
                f_10877_59754_59774(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59754, 59774);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10877_59856_59872(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.CatchBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 59856, 59872);
                    return return_v;
                }


                TLocalState
                f_10877_59915_59935(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59915, 59935);
                    return return_v;
                }


                int
                f_10877_59906_59936(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59906, 59936);
                    return 0;
                }


                int
                f_10877_59955_60023(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock, ref TLocalState
                finallyState)
                {
                    this_param.VisitCatchBlockWithAnyTransferFunction(catchBlock, ref finallyState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59955, 60023);
                    return 0;
                }


                bool
                f_10877_60042_60076(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 60042, 60076);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                f_10877_59856_59872_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 59856, 59872);
                    return return_v;
                }


                int
                f_10877_60235_60267(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 60235, 60267);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10877_60846_60866(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 60846, 60866);
                    return return_v;
                }


                int
                f_10877_61153_61175(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61153, 61175);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                f_10877_61378_61391(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.SavePending();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61378, 61391);
                    return return_v;
                }


                TLocalState
                f_10877_61438_61460(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61438, 61460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10877_61520_61540(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                this_param)
                {
                    var return_v = this_param.FinallyBlockOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 61520, 61540);
                    return return_v;
                }


                int
                f_10877_61479_61568(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                finallyBlock, ref TLocalState
                stateMovedUp)
                {
                    this_param.VisitFinallyBlockWithAnyTransferFunction((Microsoft.CodeAnalysis.CSharp.BoundStatement)finallyBlock, ref stateMovedUp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61479, 61568);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_61840_61856(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 61840, 61856);
                    return return_v;
                }


                int
                f_10877_61940_62007(ref TLocalState
                stateToUpdate, ref TLocalState
                stateMovedUpInFinally)
                {
                    updatePendingBranchState(ref stateToUpdate, ref stateMovedUpInFinally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61940, 62007);
                    return 0;
                }


                int
                f_10877_62121_62196(ref TLocalState
                stateToUpdate, ref TLocalState
                stateMovedUpInFinally)
                {
                    updatePendingBranchState(ref stateToUpdate, ref stateMovedUpInFinally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62121, 62196);
                    return 0;
                }


                int
                f_10877_62227_62303(ref TLocalState
                stateToUpdate, ref TLocalState
                stateMovedUpInFinally)
                {
                    updatePendingBranchState(ref stateToUpdate, ref stateMovedUpInFinally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62227, 62303);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_61608_61642_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 61608, 61642);
                    return return_v;
                }


                int
                f_10877_62393_62427(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62393, 62427);
                    return 0;
                }


                bool
                f_10877_62446_62480(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Meet(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62446, 62480);
                    return return_v;
                }


                bool
                f_10877_62566_62611(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62566, 62611);
                    return return_v;
                }


                int
                f_10877_62662_62680(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62662, 62680);
                    return 0;
                }


                int
                f_10877_62695_62721(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.SavedPending
                oldPending)
                {
                    this_param.RestorePending(oldPending);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 62695, 62721);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 59256, 63117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 59256, 63117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected Optional<TLocalState> NonMonotonicState;

        protected virtual void JoinTryBlockState(ref TLocalState self, ref TLocalState other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 63316, 63463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63426, 63452);

                f_10877_63426_63451(this, ref self, ref other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 63316, 63463);

                bool
                f_10877_63426_63451(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 63426, 63451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 63316, 63463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 63316, 63463);
            }
        }

        private void VisitTryBlockWithAnyTransferFunction(BoundStatement tryBlock, BoundTryStatement node, ref TLocalState tryState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 63475, 64456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63624, 64445) || true) && (_nonMonotonicTransfer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 63624, 64445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63683, 63737);

                    Optional<TLocalState>
                    oldTryState = NonMonotonicState
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63755, 63798);

                    NonMonotonicState = f_10877_63775_63797(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63816, 63860);

                    f_10877_63816_63859(this, tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63878, 63926);

                    var
                    tempTryStateValue = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 63944, 63986);

                    f_10877_63944_63985(this, ref tryState, ref tempTryStateValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64004, 64268) || true) && (oldTryState.HasValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 64004, 64268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64070, 64111);

                        var
                        oldTryStateValue = oldTryState.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64133, 64196);

                        f_10877_64133_64195(this, ref oldTryStateValue, ref tempTryStateValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64218, 64249);

                        oldTryState = oldTryStateValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 64004, 64268);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64288, 64320);

                    NonMonotonicState = oldTryState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 63624, 64445);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 63624, 64445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64386, 64430);

                    f_10877_64386_64429(this, tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 63624, 64445);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 63475, 64456);

                TLocalState
                f_10877_63775_63797(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 63775, 63797);
                    return return_v;
                }


                int
                f_10877_63816_63859(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                tryBlock, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node, ref TLocalState
                tryState)
                {
                    this_param.VisitTryBlock(tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 63816, 63859);
                    return 0;
                }


                bool
                f_10877_63944_63985(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 63944, 63985);
                    return return_v;
                }


                int
                f_10877_64133_64195(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    this_param.JoinTryBlockState(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 64133, 64195);
                    return 0;
                }


                int
                f_10877_64386_64429(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                tryBlock, Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                node, ref TLocalState
                tryState)
                {
                    this_param.VisitTryBlock(tryBlock, node, ref tryState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 64386, 64429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 63475, 64456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 63475, 64456);
            }
        }

        protected virtual void VisitTryBlock(BoundStatement tryBlock, BoundTryStatement node, ref TLocalState tryState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 64468, 64640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64604, 64629);

                f_10877_64604_64628(this, tryBlock);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 64468, 64640);

                int
                f_10877_64604_64628(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 64604, 64628);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 64468, 64640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 64468, 64640);
            }
        }

        private void VisitCatchBlockWithAnyTransferFunction(BoundCatchBlock catchBlock, ref TLocalState finallyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 64652, 65626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64786, 65615) || true) && (_nonMonotonicTransfer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 64786, 65615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64845, 64899);

                    Optional<TLocalState>
                    oldTryState = NonMonotonicState
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64917, 64960);

                    NonMonotonicState = f_10877_64937_64959(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 64978, 65024);

                    f_10877_64978_65023(this, catchBlock, ref finallyState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65042, 65090);

                    var
                    tempTryStateValue = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65108, 65154);

                    f_10877_65108_65153(this, ref finallyState, ref tempTryStateValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65172, 65436) || true) && (oldTryState.HasValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 65172, 65436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65238, 65279);

                        var
                        oldTryStateValue = oldTryState.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65301, 65364);

                        f_10877_65301_65363(this, ref oldTryStateValue, ref tempTryStateValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65386, 65417);

                        oldTryState = oldTryStateValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 65172, 65436);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65456, 65488);

                    NonMonotonicState = oldTryState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 64786, 65615);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 64786, 65615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65554, 65600);

                    f_10877_65554_65599(this, catchBlock, ref finallyState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 64786, 65615);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 64652, 65626);

                TLocalState
                f_10877_64937_64959(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 64937, 64959);
                    return return_v;
                }


                int
                f_10877_64978_65023(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock, ref TLocalState
                finallyState)
                {
                    this_param.VisitCatchBlock(catchBlock, ref finallyState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 64978, 65023);
                    return 0;
                }


                bool
                f_10877_65108_65153(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 65108, 65153);
                    return return_v;
                }


                int
                f_10877_65301_65363(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    this_param.JoinTryBlockState(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 65301, 65363);
                    return 0;
                }


                int
                f_10877_65554_65599(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                catchBlock, ref TLocalState
                finallyState)
                {
                    this_param.VisitCatchBlock(catchBlock, ref finallyState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 65554, 65599);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 64652, 65626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 64652, 65626);
            }
        }

        protected virtual void VisitCatchBlock(BoundCatchBlock catchBlock, ref TLocalState finallyState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 65638, 66316);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65759, 65892) || true) && (f_10877_65763_65792(catchBlock) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 65759, 65892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65834, 65877);

                    f_10877_65834_65876(this, f_10877_65846_65875(catchBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 65759, 65892);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65908, 66063) || true) && (f_10877_65912_65949(catchBlock) is { })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 65908, 66063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 65990, 66048);

                    f_10877_65990_66047(this, f_10877_66009_66046(catchBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 65908, 66063);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66079, 66257) || true) && (f_10877_66083_66112(catchBlock) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 66079, 66257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66154, 66200);

                    f_10877_66154_66199(this, f_10877_66169_66198(catchBlock));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66218, 66242);

                    f_10877_66218_66241(this, StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 66079, 66257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66273, 66305);

                f_10877_66273_66304(this, f_10877_66288_66303(catchBlock));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 65638, 66316);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_65763_65792(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 65763, 65792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_65846_65875(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 65846, 65875);
                    return return_v;
                }


                int
                f_10877_65834_65876(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 65834, 65876);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10877_65912_65949(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 65912, 65949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10877_66009_66046(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 66009, 66046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_65990_66047(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node)
                {
                    var return_v = this_param.VisitStatementList(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 65990, 66047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_66083_66112(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 66083, 66112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_66169_66198(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 66169, 66198);
                    return return_v;
                }


                int
                f_10877_66154_66199(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66154, 66199);
                    return 0;
                }


                int
                f_10877_66218_66241(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66218, 66241);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10877_66288_66303(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 66288, 66303);
                    return return_v;
                }


                int
                f_10877_66273_66304(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                statement)
                {
                    this_param.VisitStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66273, 66304);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 65638, 66316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 65638, 66316);
            }
        }

        private void VisitFinallyBlockWithAnyTransferFunction(BoundStatement finallyBlock, ref TLocalState stateMovedUp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 66328, 67313);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66465, 67302) || true) && (_nonMonotonicTransfer)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 66465, 67302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66524, 66578);

                    Optional<TLocalState>
                    oldTryState = NonMonotonicState
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66596, 66639);

                    NonMonotonicState = f_10877_66616_66638(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66657, 66707);

                    f_10877_66657_66706(this, finallyBlock, ref stateMovedUp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66725, 66773);

                    var
                    tempTryStateValue = NonMonotonicState.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66791, 66837);

                    f_10877_66791_66836(this, ref stateMovedUp, ref tempTryStateValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66855, 67119) || true) && (oldTryState.HasValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 66855, 67119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66921, 66962);

                        var
                        oldTryStateValue = oldTryState.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 66984, 67047);

                        f_10877_66984_67046(this, ref oldTryStateValue, ref tempTryStateValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67069, 67100);

                        oldTryState = oldTryStateValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 66855, 67119);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67139, 67171);

                    NonMonotonicState = oldTryState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 66465, 67302);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 66465, 67302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67237, 67287);

                    f_10877_67237_67286(this, finallyBlock, ref stateMovedUp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 66465, 67302);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 66328, 67313);

                TLocalState
                f_10877_66616_66638(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.ReachableBottomState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66616, 66638);
                    return return_v;
                }


                int
                f_10877_66657_66706(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                finallyBlock, ref TLocalState
                stateMovedUp)
                {
                    this_param.VisitFinallyBlock(finallyBlock, ref stateMovedUp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66657, 66706);
                    return 0;
                }


                bool
                f_10877_66791_66836(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66791, 66836);
                    return return_v;
                }


                int
                f_10877_66984_67046(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    this_param.JoinTryBlockState(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 66984, 67046);
                    return 0;
                }


                int
                f_10877_67237_67286(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                finallyBlock, ref TLocalState
                stateMovedUp)
                {
                    this_param.VisitFinallyBlock(finallyBlock, ref stateMovedUp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67237, 67286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 66328, 67313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 66328, 67313);
            }
        }

        protected virtual void VisitFinallyBlock(BoundStatement finallyBlock, ref TLocalState stateMovedUp)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 67325, 67533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67449, 67478);

                f_10877_67449_67477(this, finallyBlock);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 67325, 67533);

                int
                f_10877_67449_67477(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67449, 67477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 67325, 67533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 67325, 67533);
            }
        }

        public override BoundNode VisitExtractedFinallyBlock(BoundExtractedFinallyBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 67545, 67703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67655, 67692);

                return f_10877_67662_67691(this, f_10877_67673_67690(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 67545, 67703);

                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10877_67673_67690(Microsoft.CodeAnalysis.CSharp.BoundExtractedFinallyBlock
                this_param)
                {
                    var return_v = this_param.FinallyBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 67673, 67690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_67662_67691(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.VisitBlock(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67662, 67691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 67545, 67703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 67545, 67703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReturnStatement(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 67715, 68015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67813, 67861);

                var
                result = f_10877_67826_67860(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67875, 67945);

                f_10877_67875_67944(f_10877_67875_67890(), f_10877_67895_67943(node, this.State, label: null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67959, 67976);

                f_10877_67959_67975(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 67990, 68004);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 67715, 68015);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_67826_67860(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                node)
                {
                    var return_v = this_param.VisitReturnStatementNoAdjust(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67826, 67860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_67875_67890()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 67875, 67890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_67895_67943(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67895, 67943);
                    return return_v;
                }


                int
                f_10877_67875_67944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67875, 67944);
                    return 0;
                }


                int
                f_10877_67959_67975(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 67959, 67975);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 67715, 68015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 67715, 68015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundNode VisitReturnStatementNoAdjust(BoundReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 68027, 68471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68135, 68218);

                f_10877_68135_68217(this, f_10877_68147_68165(node), isKnownToBeAnLvalue: f_10877_68188_68200(node) != RefKind.None);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68289, 68432) || true) && (f_10877_68293_68305(node) != RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 68289, 68432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68355, 68417);

                    f_10877_68355_68416(this, f_10877_68369_68387(node), f_10877_68389_68401(node), method: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 68289, 68432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68448, 68460);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 68027, 68471);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_68147_68165(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 68147, 68165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_68188_68200(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 68188, 68200);
                    return return_v;
                }


                int
                f_10877_68135_68217(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 68135, 68217);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_68293_68305(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 68293, 68305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_68369_68387(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 68369, 68387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_68389_68401(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 68389, 68401);
                    return return_v;
                }


                int
                f_10877_68355_68416(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 68355, 68416);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 68027, 68471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 68027, 68471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThisReference(BoundThisReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 68483, 68600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68577, 68589);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 68483, 68600);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 68483, 68600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 68483, 68600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPreviousSubmissionReference(BoundPreviousSubmissionReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 68612, 68757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68734, 68746);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 68612, 68757);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 68612, 68757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 68612, 68757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitHostObjectMemberReference(BoundHostObjectMemberReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 68769, 68910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 68887, 68899);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 68769, 68910);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 68769, 68910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 68769, 68910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 68922, 69031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69008, 69020);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 68922, 69031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 68922, 69031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 68922, 69031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VisitLvalueParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 69043, 69129);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 69043, 69129);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 69043, 69129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 69043, 69129);
            }
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 69141, 69428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69259, 69334);

                f_10877_69259_69333(this, f_10877_69274_69288(node), f_10877_69290_69314(node), f_10877_69316_69332(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69348, 69391);

                f_10877_69348_69390(this, f_10877_69360_69389(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69405, 69417);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 69141, 69428);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_69274_69288(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69274, 69288);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_69290_69314(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69290, 69314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_69316_69332(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69316, 69332);
                    return return_v;
                }


                int
                f_10877_69259_69333(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 69259, 69333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10877_69360_69389(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69360, 69389);
                    return return_v;
                }


                int
                f_10877_69348_69390(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 69348, 69390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 69141, 69428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 69141, 69428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNewT(BoundNewT node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 69440, 69596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69516, 69559);

                f_10877_69516_69558(this, f_10877_69528_69557(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69573, 69585);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 69440, 69596);

                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10877_69528_69557(Microsoft.CodeAnalysis.CSharp.BoundNewT
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69528, 69557);
                    return return_v;
                }


                int
                f_10877_69516_69558(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 69516, 69558);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 69440, 69596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 69440, 69596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNoPiaObjectCreationExpression(BoundNoPiaObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 69608, 69814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69734, 69777);

                f_10877_69734_69776(this, f_10877_69746_69775(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 69791, 69803);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 69608, 69814);

                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10877_69746_69775(Microsoft.CodeAnalysis.CSharp.BoundNoPiaObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 69746, 69775);
                    return return_v;
                }


                int
                f_10877_69734_69776(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 69734, 69776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 69608, 69814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 69608, 69814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void PropertySetter(BoundExpression node, BoundExpression receiver, MethodSymbol setter, BoundExpression value = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 69911, 70124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70072, 70113);

                f_10877_70072_70112(this, receiver, setter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 69911, 70124);

                int
                f_10877_70072_70112(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 70072, 70112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 69911, 70124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 69911, 70124);
            }
        }

        private bool RegularPropertyAccess(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 70308, 70607);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70389, 70492) || true) && (f_10877_70393_70402(expr) != BoundKind.PropertyAccess)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 70389, 70492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70464, 70477);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 70389, 70492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70508, 70596);

                return !f_10877_70516_70595(expr, _symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 70308, 70607);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_70393_70402(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 70393, 70402);
                    return return_v;
                }


                bool
                f_10877_70516_70595(Microsoft.CodeAnalysis.CSharp.BoundExpression
                propertyAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                fromMember)
                {
                    var return_v = Binder.AccessingAutoPropertyFromConstructor((Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess)propertyAccess, fromMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 70516, 70595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 70308, 70607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 70308, 70607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 70619, 71957);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70785, 71351) || true) && (f_10877_70789_70821(this, f_10877_70811_70820(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 70785, 71351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70855, 70897);

                    var
                    left = (BoundPropertyAccess)f_10877_70887_70896(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70915, 70950);

                    var
                    property = f_10877_70930_70949(left)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 70968, 71336) || true) && (f_10877_70972_70988(property) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 70968, 71336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71046, 71084);

                        var
                        method = f_10877_71059_71083(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71106, 71156);

                        f_10877_71106_71155(this, f_10877_71130_71146(left), method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71178, 71202);

                        f_10877_71178_71201(this, f_10877_71190_71200(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71224, 71283);

                        f_10877_71224_71282(this, node, f_10877_71245_71261(left), method, f_10877_71271_71281(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71305, 71317);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 70968, 71336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 70785, 71351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71367, 71390);

                f_10877_71367_71389(this, f_10877_71379_71388(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71404, 71461);

                f_10877_71404_71460(this, f_10877_71416_71426(node), isKnownToBeAnLvalue: f_10877_71449_71459(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71536, 71918) || true) && (f_10877_71540_71550(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 71536, 71918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71699, 71836);

                    var
                    refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 71713, 71754) || ((f_10877_71713_71727(f_10877_71713_71722(node)) == BoundKind.BadExpression
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 71778, 71789)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 71813, 71835))) ? RefKind.Ref
                    : f_10877_71813_71835(f_10877_71813_71822(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71854, 71903);

                    f_10877_71854_71902(this, f_10877_71868_71878(node), refKind, method: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 71536, 71918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 71934, 71946);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 70619, 71957);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_70811_70820(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 70811, 70820);
                    return return_v;
                }


                bool
                f_10877_70789_70821(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.RegularPropertyAccess(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 70789, 70821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_70887_70896(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 70887, 70896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_70930_70949(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 70930, 70949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_70972_70988(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 70972, 70988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_71059_71083(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetWriteMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71059, 71083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_71130_71146(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71130, 71146);
                    return return_v;
                }


                int
                f_10877_71106_71155(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71106, 71155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71190_71200(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71190, 71200);
                    return return_v;
                }


                int
                f_10877_71178_71201(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71178, 71201);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_71245_71261(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71245, 71261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71271_71281(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71271, 71281);
                    return return_v;
                }


                int
                f_10877_71224_71282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setter, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.PropertySetter((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, receiver, setter, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71224, 71282);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71379_71388(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71379, 71388);
                    return return_v;
                }


                int
                f_10877_71367_71389(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71367, 71389);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71416_71426(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71416, 71426);
                    return return_v;
                }


                bool
                f_10877_71449_71459(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71449, 71459);
                    return return_v;
                }


                int
                f_10877_71404_71460(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71404, 71460);
                    return 0;
                }


                bool
                f_10877_71540_71550(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71540, 71550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71713_71722(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71713, 71722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_71713_71727(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71713, 71727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71813_71822(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71813, 71822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_71813_71835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.GetRefKind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71813, 71835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_71868_71878(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 71868, 71878);
                    return return_v;
                }


                int
                f_10877_71854_71902(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 71854, 71902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 70619, 71957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 70619, 71957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructionAssignmentOperator(BoundDeconstructionAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 71969, 72199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72101, 72124);

                f_10877_72101_72123(this, f_10877_72113_72122(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72138, 72162);

                f_10877_72138_72161(this, f_10877_72150_72160(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72176, 72188);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 71969, 72199);

                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10877_72113_72122(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 72113, 72122);
                    return return_v;
                }


                int
                f_10877_72101_72123(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                node)
                {
                    this_param.VisitLvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72101, 72123);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10877_72150_72160(Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 72150, 72160);
                    return return_v;
                }


                int
                f_10877_72138_72161(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConversion
                node)
                {
                    this_param.VisitRvalue((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72138, 72161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 71969, 72199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 71969, 72199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitOutDeconstructVarPendingInference(OutDeconstructVarPendingInference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 72211, 72523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72475, 72512);

                throw f_10877_72481_72511();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 72211, 72523);

                System.Exception
                f_10877_72481_72511()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 72481, 72511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 72211, 72523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 72211, 72523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 72535, 72811);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72655, 72691);

                f_10877_72655_72690(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72705, 72729);

                f_10877_72705_72728(this, f_10877_72717_72727(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72743, 72774);

                f_10877_72743_72773(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72788, 72800);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 72535, 72811);

                int
                f_10877_72655_72690(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.VisitCompoundAssignmentTarget(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72655, 72690);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_72717_72727(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 72717, 72727);
                    return return_v;
                }


                int
                f_10877_72705_72728(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72705, 72728);
                    return 0;
                }


                int
                f_10877_72743_72773(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.AfterRightHasBeenVisited(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72743, 72773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 72535, 72811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 72535, 72811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void VisitCompoundAssignmentTarget(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 72823, 73697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 72992, 73620) || true) && (f_10877_72996_73028(this, f_10877_73018_73027(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 72992, 73620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73062, 73104);

                    var
                    left = (BoundPropertyAccess)f_10877_73094_73103(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73122, 73157);

                    var
                    property = f_10877_73137_73156(left)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73175, 73605) || true) && (f_10877_73179_73195(property) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 73175, 73605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73253, 73294);

                        var
                        readMethod = f_10877_73270_73293(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73316, 73406);

                        f_10877_73316_73405(f_10877_73329_73346(node) || (DynAbs.Tracing.TraceSender.Expression_False(10877, 73329, 73404) || (object)readMethod != (object)f_10877_73380_73404(property)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73428, 73482);

                        f_10877_73428_73481(this, f_10877_73452_73468(left), readMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73504, 73557);

                        f_10877_73504_73556(this, f_10877_73527_73543(left), readMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73579, 73586);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 73175, 73605);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 72992, 73620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73636, 73686);

                f_10877_73636_73685(this, f_10877_73648_73657(node), isKnownToBeAnLvalue: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 72823, 73697);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_73018_73027(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73018, 73027);
                    return return_v;
                }


                bool
                f_10877_72996_73028(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.RegularPropertyAccess(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 72996, 73028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_73094_73103(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73094, 73103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_73137_73156(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73137, 73156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_73179_73195(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73179, 73195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_73270_73293(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73270, 73293);
                    return return_v;
                }


                bool
                f_10877_73329_73346(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73329, 73346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_73380_73404(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetWriteMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73380, 73404);
                    return return_v;
                }


                int
                f_10877_73316_73405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73316, 73405);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_73452_73468(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73452, 73468);
                    return return_v;
                }


                int
                f_10877_73428_73481(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73428, 73481);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_73527_73543(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73527, 73543);
                    return return_v;
                }


                int
                f_10877_73504_73556(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73504, 73556);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_73648_73657(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73648, 73657);
                    return return_v;
                }


                int
                f_10877_73636_73685(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73636, 73685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 72823, 73697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 72823, 73697);
            }
        }

        protected void AfterRightHasBeenVisited(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 73709, 74341);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73811, 74328) || true) && (f_10877_73815_73847(this, f_10877_73837_73846(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 73811, 74328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73881, 73923);

                    var
                    left = (BoundPropertyAccess)f_10877_73913_73922(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73941, 73976);

                    var
                    property = f_10877_73956_73975(left)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 73994, 74313) || true) && (f_10877_73998_74014(property) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 73994, 74313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74072, 74115);

                        var
                        writeMethod = f_10877_74090_74114(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74137, 74189);

                        f_10877_74137_74188(this, node, f_10877_74158_74174(left), writeMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74211, 74265);

                        f_10877_74211_74264(this, f_10877_74234_74250(left), writeMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74287, 74294);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 73994, 74313);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 73811, 74328);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 73709, 74341);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_73837_73846(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73837, 73846);
                    return return_v;
                }


                bool
                f_10877_73815_73847(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.RegularPropertyAccess(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 73815, 73847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_73913_73922(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73913, 73922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_73956_73975(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73956, 73975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_73998_74014(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 73998, 74014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_74090_74114(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetWriteMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 74090, 74114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_74158_74174(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74158, 74174);
                    return return_v;
                }


                int
                f_10877_74137_74188(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setter)
                {
                    this_param.PropertySetter((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, receiver, setter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 74137, 74188);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_74234_74250(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74234, 74250);
                    return return_v;
                }


                int
                f_10877_74211_74264(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 74211, 74264);
                    return 0;
                }


            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 73709, 74341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 73709, 74341);
            }
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 74353, 74541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74443, 74504);

                f_10877_74443_74503(this, f_10877_74468_74484(node), f_10877_74486_74502(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74518, 74530);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 74353, 74541);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_74468_74484(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74468, 74484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10877_74486_74502(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74486, 74502);
                    return return_v;
                }


                int
                f_10877_74443_74503(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    this_param.VisitFieldAccessInternal(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 74443, 74503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 74353, 74541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 74353, 74541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitFieldAccessInternal(BoundExpression receiverOpt, FieldSymbol fieldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 74553, 75309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 74669, 75107);

                bool
                asLvalue = (object)fieldSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74685, 75106) && (f_10877_74734_74763(fieldSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10877, 74734, 75105) || f_10877_74784_74805_M(!fieldSymbol.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74784, 74880) && f_10877_74826_74861(f_10877_74826_74852(fieldSymbol)) == TypeKind.Struct) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74784, 74920) && receiverOpt != null) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74784, 74985) && f_10877_74941_74957(receiverOpt) != BoundKind.TypeExpression) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74784, 75038) && (object)f_10877_75014_75030(receiverOpt) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 74784, 75105) && !f_10877_75060_75105(f_10877_75060_75076(receiverOpt))))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75121, 75298) || true) && (asLvalue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 75121, 75298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75167, 75192);

                    f_10877_75167_75191(this, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 75121, 75298);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 75121, 75298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75258, 75283);

                    f_10877_75258_75282(this, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 75121, 75298);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 74553, 75309);

                bool
                f_10877_74734_74763(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsFixedSizeBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74734, 74763);
                    return return_v;
                }


                bool
                f_10877_74784_74805_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74784, 74805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10877_74826_74852(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74826, 74852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10877_74826_74861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74826, 74861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_74941_74957(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 74941, 74957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10877_75014_75030(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 75014, 75030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10877_75060_75076(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 75060, 75076);
                    return return_v;
                }


                bool
                f_10877_75060_75105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t)
                {
                    var return_v = t.IsPrimitiveRecursiveStruct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 75060, 75105);
                    return return_v;
                }


                int
                f_10877_75167_75191(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 75167, 75191);
                    return 0;
                }


                int
                f_10877_75258_75282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 75258, 75282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 74553, 75309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 74553, 75309);
            }
        }

        public override BoundNode VisitFieldInfo(BoundFieldInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 75321, 75430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75407, 75419);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 75321, 75430);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 75321, 75430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 75321, 75430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodInfo(BoundMethodInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 75442, 75553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75530, 75542);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 75442, 75553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 75442, 75553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 75442, 75553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 75565, 77148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75661, 75696);

                var
                property = f_10877_75676_75695(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75712, 76161) || true) && (f_10877_75716_75774(node, _symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 75712, 76161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75835, 75952);

                    var
                    backingField = (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 75854, 75892) || (((property is SourcePropertySymbolBase) && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 75895, 75944)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 75947, 75951))) ? f_10877_75895_75944(((SourcePropertySymbolBase)property)) : null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 75970, 76146) || true) && (backingField != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 75970, 76146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76036, 76093);

                        f_10877_76036_76092(this, f_10877_76061_76077(node), backingField);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76115, 76127);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 75970, 76146);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 75712, 76161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76177, 76214);

                var
                method = f_10877_76190_76213(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76228, 76278);

                f_10877_76228_76277(this, f_10877_76252_76268(node), method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76292, 76341);

                f_10877_76292_76340(this, f_10877_76315_76331(node), method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 76355, 76367);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 75565, 77148);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_75676_75695(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 75676, 75695);
                    return return_v;
                }


                bool
                f_10877_75716_75774(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                propertyAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                fromMember)
                {
                    var return_v = Binder.AccessingAutoPropertyFromConstructor(propertyAccess, fromMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 75716, 75774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10877_75895_75944(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbolBase
                this_param)
                {
                    var return_v = this_param.BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 75895, 75944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_76061_76077(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 76061, 76077);
                    return return_v;
                }


                int
                f_10877_76036_76092(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                fieldSymbol)
                {
                    this_param.VisitFieldAccessInternal(receiverOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 76036, 76092);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_76190_76213(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 76190, 76213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_76252_76268(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 76252, 76268);
                    return return_v;
                }


                int
                f_10877_76228_76277(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 76228, 76277);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_76315_76331(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 76315, 76331);
                    return return_v;
                }


                int
                f_10877_76292_76340(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 76292, 76340);
                    return 0;
                }

                // TODO: In an expression such as
                //    M().Prop = G();
                // Exceptions thrown from M() occur before those from G(), but exceptions from the property accessor
                // occur after both.  The precise abstract flow pass does not yet currently have this quite right.
                // Probably what is needed is a VisitPropertyAccessInternal(BoundPropertyAccess node, bool read)
                // which should assume that the receiver will have been handled by the caller.  This can be invoked
                // twice for read/write operations such as
                //    M().Prop += 1
                // or at the appropriate place in the sequence for read or write operations.
                // Do events require any special handling too?
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 75565, 77148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 75565, 77148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitEventAccess(BoundEventAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 77160, 77364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77250, 77327);

                f_10877_77250_77326(this, f_10877_77275_77291(node), f_10877_77293_77325(f_10877_77293_77309(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77341, 77353);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 77160, 77364);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_77275_77291(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77275, 77291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10877_77293_77309(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77293, 77309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10877_77293_77325(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77293, 77325);
                    return return_v;
                }


                int
                f_10877_77250_77326(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                fieldSymbol)
                {
                    this_param.VisitFieldAccessInternal(receiverOpt, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 77250, 77326);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 77160, 77364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 77160, 77364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRangeVariable(BoundRangeVariable node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 77376, 77493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77470, 77482);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 77376, 77493);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 77376, 77493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 77376, 77493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitQueryClause(BoundQueryClause node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 77505, 77680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77595, 77643);

                f_10877_77595_77642(this, f_10877_77607_77627(node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundExpression?>(10877, 77607, 77641) ?? f_10877_77631_77641(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77657, 77669);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 77505, 77680);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_77607_77627(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.UnoptimizedForm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77607, 77627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_77631_77641(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77631, 77641);
                    return return_v;
                }


                int
                f_10877_77595_77642(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 77595, 77642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 77505, 77680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 77505, 77680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitMultipleLocalDeclarationsBase(BoundMultipleLocalDeclarationsBase node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 77692, 77947);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77810, 77908);
                    foreach (var v in f_10877_77828_77850_I(f_10877_77828_77850(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 77810, 77908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77884, 77893);

                        f_10877_77884_77892(this, v);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 77810, 77908);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 99);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 99);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 77924, 77936);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 77692, 77947);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                f_10877_77828_77850(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase
                this_param)
                {
                    var return_v = this_param.LocalDeclarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 77828, 77850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_77884_77892(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 77884, 77892);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                f_10877_77828_77850_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 77828, 77850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 77692, 77947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 77692, 77947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMultipleLocalDeclarations(BoundMultipleLocalDeclarations node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 77959, 78136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78077, 78125);

                return f_10877_78084_78124(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 77959, 78136);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_78084_78124(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                node)
                {
                    var return_v = this_param.VisitMultipleLocalDeclarationsBase((Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78084, 78124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 77959, 78136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 77959, 78136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUsingLocalDeclarations(BoundUsingLocalDeclarations node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 78148, 78511);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78260, 78438) || true) && (f_10877_78264_78301() && (DynAbs.Tracing.TraceSender.Expression_True(10877, 78264, 78326) && f_10877_78305_78318(node) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 78260, 78438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78360, 78423);

                    f_10877_78360_78422(f_10877_78360_78375(), f_10877_78380_78421(node, this.State, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 78260, 78438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78452, 78500);

                return f_10877_78459_78499(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 78148, 78511);

                bool
                f_10877_78264_78301()
                {
                    var return_v = AwaitUsingAndForeachAddsPendingBranch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78264, 78301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10877_78305_78318(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78305, 78318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_78360_78375()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78360, 78375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_78380_78421(Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78380, 78421);
                    return return_v;
                }


                int
                f_10877_78360_78422(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78360, 78422);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_78459_78499(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUsingLocalDeclarations
                node)
                {
                    var return_v = this_param.VisitMultipleLocalDeclarationsBase((Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78459, 78499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 78148, 78511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 78148, 78511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWhileStatement(BoundWhileStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 78523, 79124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78710, 78725);

                f_10877_78710_78724(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78739, 78770);

                f_10877_78739_78769(this, f_10877_78754_78768(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78784, 78822);

                TLocalState
                bodyState = StateWhenTrue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78836, 78876);

                TLocalState
                breakState = StateWhenFalse
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78890, 78910);

                f_10877_78890_78909(this, bodyState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78924, 78950);

                f_10877_78924_78949(this, f_10877_78939_78948(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 78964, 79001);

                f_10877_78964_79000(this, f_10877_78981_78999(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79015, 79030);

                f_10877_79015_79029(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79044, 79087);

                f_10877_79044_79086(this, breakState, f_10877_79070_79085(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79101, 79113);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 78523, 79124);

                int
                f_10877_78710_78724(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                node)
                {
                    this_param.LoopHead((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78710, 78724);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_78754_78768(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78754, 78768);
                    return return_v;
                }


                int
                f_10877_78739_78769(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78739, 78769);
                    return 0;
                }


                int
                f_10877_78890_78909(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78890, 78909);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_78939_78948(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78939, 78948);
                    return return_v;
                }


                int
                f_10877_78924_78949(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78924, 78949);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_78981_78999(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 78981, 78999);
                    return return_v;
                }


                int
                f_10877_78964_79000(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    this_param.ResolveContinues((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 78964, 79000);
                    return 0;
                }


                int
                f_10877_79015_79029(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                node)
                {
                    this_param.LoopTail((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79015, 79029);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_79070_79085(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79070, 79085);
                    return return_v;
                }


                int
                f_10877_79044_79086(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                breakState, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    this_param.ResolveBreaks(breakState, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79044, 79086);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 78523, 79124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 78523, 79124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWithExpression(BoundWithExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 79136, 79396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79232, 79259);

                f_10877_79232_79258(this, f_10877_79244_79257(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79273, 79359);

                f_10877_79273_79358(this, f_10877_79318_79357(f_10877_79318_79344(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79373, 79385);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 79136, 79396);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_79244_79257(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79244, 79257);
                    return return_v;
                }


                int
                f_10877_79232_79258(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79232, 79258);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                f_10877_79318_79344(Microsoft.CodeAnalysis.CSharp.BoundWithExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79318, 79344);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_79318_79357(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79318, 79357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_79273_79358(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.VisitObjectOrCollectionInitializerExpression(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79273, 79358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 79136, 79396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 79136, 79396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 79408, 79674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79498, 79527);

                f_10877_79498_79526(this, f_10877_79510_79525(node));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79541, 79635);
                    foreach (var i in f_10877_79559_79571_I(f_10877_79559_79571(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 79541, 79635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79605, 79620);

                        f_10877_79605_79619(this, i);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 79541, 79635);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 95);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 95);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79651, 79663);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 79408, 79674);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_79510_79525(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79510, 79525);
                    return return_v;
                }


                int
                f_10877_79498_79526(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79498, 79526);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_79559_79571(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79559, 79571);
                    return return_v;
                }


                int
                f_10877_79605_79619(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79605, 79619);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_79559_79571_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79559, 79571);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 79408, 79674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 79408, 79674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 79686, 80111);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79782, 80072) || true) && (f_10877_79786_79815(f_10877_79786_79803(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 79782, 80072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79849, 79898);

                    f_10877_79849_79897(!f_10877_79863_79896(f_10877_79863_79880(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 79916, 79957);

                    f_10877_79916_79956(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 79782, 80072);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 79782, 80072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80023, 80057);

                    f_10877_80023_80056(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 79782, 80072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80088, 80100);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 79686, 80111);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_79786_79803(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79786, 79803);
                    return return_v;
                }


                bool
                f_10877_79786_79815(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79786, 79815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_79863_79880(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 79863, 79880);
                    return return_v;
                }


                bool
                f_10877_79863_79896(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsUserDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79863, 79896);
                    return return_v;
                }


                int
                f_10877_79849_79897(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79849, 79897);
                    return 0;
                }


                int
                f_10877_79916_79956(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.VisitBinaryLogicalOperatorChildren((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 79916, 79956);
                    return 0;
                }


                int
                f_10877_80023_80056(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.VisitBinaryOperatorChildren(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 80023, 80056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 79686, 80111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 79686, 80111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 80123, 80343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80265, 80306);

                f_10877_80265_80305(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80320, 80332);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 80123, 80343);

                int
                f_10877_80265_80305(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                node)
                {
                    this_param.VisitBinaryLogicalOperatorChildren((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 80265, 80305);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 80123, 80343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 80123, 80343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitBinaryLogicalOperatorChildren(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 80355, 83391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80524, 80580);

                var
                stack = f_10877_80536_80579()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80596, 80619);

                BoundExpression
                binary
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80633, 80662);

                BoundExpression
                child = node
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80678, 81594) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 80678, 81594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80723, 80750);

                        var
                        childKind = f_10877_80739_80749(child)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80770, 81540) || true) && (childKind == BoundKind.BinaryOperator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 80770, 81540);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80853, 80892);

                            var
                            binOp = (BoundBinaryOperator)child
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 80916, 81030) || true) && (!f_10877_80921_80951(f_10877_80921_80939(binOp)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 80916, 81030);
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 81001, 81007);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 80916, 81030);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81054, 81104);

                            f_10877_81054_81103(!f_10877_81068_81102(f_10877_81068_81086(binOp)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81126, 81141);

                            binary = child;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81163, 81182);

                            child = f_10877_81171_81181(binOp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 80770, 81540);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 80770, 81540);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81224, 81540) || true) && (childKind == BoundKind.UserDefinedConditionalLogicalOperator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81224, 81540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81330, 81345);

                                binary = child;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81367, 81433);

                                child = f_10877_81375_81432(((BoundUserDefinedConditionalLogicalOperator)binary));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81224, 81540);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81224, 81540);
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 81515, 81521);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81224, 81540);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 80770, 81540);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81560, 81579);

                        f_10877_81560_81578(
                                        stack, binary);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 80678, 81594);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 80678, 81594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 80678, 81594);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81610, 81640);

                f_10877_81610_81639(f_10877_81623_81634(stack) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81656, 81678);

                f_10877_81656_81677(this, child);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81694, 83300) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81694, 83300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81739, 81760);

                        binary = f_10877_81748_81759(stack);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81780, 81804);

                        BinaryOperatorKind
                        kind
                        = default(BinaryOperatorKind);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81822, 81844);

                        BoundExpression
                        right
                        = default(BoundExpression);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81862, 82578);

                        switch (f_10877_81870_81881(binary))
                        {

                            case BoundKind.BinaryOperator:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81862, 82578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 81979, 82019);

                                var
                                binOp = (BoundBinaryOperator)binary
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82045, 82071);

                                kind = f_10877_82052_82070(binOp);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82097, 82117);

                                right = f_10877_82105_82116(binOp);
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 82143, 82149);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81862, 82578);

                            case BoundKind.UserDefinedConditionalLogicalOperator:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81862, 82578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82250, 82315);

                                var
                                udBinOp = (BoundUserDefinedConditionalLogicalOperator)binary
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82341, 82369);

                                kind = f_10877_82348_82368(udBinOp);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82395, 82417);

                                right = f_10877_82403_82416(udBinOp);
                                DynAbs.Tracing.TraceSender.TraceBreak(10877, 82443, 82449);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81862, 82578);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 81862, 82578);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82505, 82559);

                                throw f_10877_82511_82558(f_10877_82546_82557(binary));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81862, 82578);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82598, 82623);

                        var
                        op = f_10877_82607_82622(kind)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82641, 82682);

                        var
                        isAnd = op == BinaryOperatorKind.And
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82700, 82760);

                        var
                        isBool = f_10877_82713_82732(kind) == BinaryOperatorKind.Bool
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82780, 82831);

                        f_10877_82780_82830(isAnd || (DynAbs.Tracing.TraceSender.Expression_False(10877, 82793, 82829) || op == BinaryOperatorKind.Or));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82851, 82885);

                        var
                        leftTrue = this.StateWhenTrue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82903, 82939);

                        var
                        leftFalse = this.StateWhenFalse
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 82957, 82996);

                        f_10877_82957_82995(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10877, 82966, 82971) || ((isAnd && DynAbs.Tracing.TraceSender.Conditional_F2(10877, 82974, 82982)) || DynAbs.Tracing.TraceSender.Conditional_F3(10877, 82985, 82994))) ? leftTrue : leftFalse);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83016, 83127);

                        f_10877_83016_83126(this, binary, right, isAnd, isBool, ref leftTrue, ref leftFalse);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83147, 83234) || true) && (f_10877_83151_83162(stack) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 83147, 83234);
                            DynAbs.Tracing.TraceSender.TraceBreak(10877, 83209, 83215);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 83147, 83234);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83254, 83285);

                        f_10877_83254_83284(this, binary);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 81694, 83300);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 81694, 83300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 81694, 83300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83316, 83353);

                f_10877_83316_83352((object)binary == node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83367, 83380);

                f_10877_83367_83379(stack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 80355, 83391);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_80536_80579()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 80536, 80579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_80739_80749(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 80739, 80749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_80921_80939(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 80921, 80939);
                    return return_v;
                }


                bool
                f_10877_80921_80951(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 80921, 80951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_81068_81086(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 81068, 81086);
                    return return_v;
                }


                bool
                f_10877_81068_81102(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsUserDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81068, 81102);
                    return return_v;
                }


                int
                f_10877_81054_81103(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81054, 81103);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_81171_81181(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 81171, 81181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_81375_81432(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 81375, 81432);
                    return return_v;
                }


                int
                f_10877_81560_81578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundExpression>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81560, 81578);
                    return 0;
                }


                int
                f_10877_81623_81634(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 81623, 81634);
                    return return_v;
                }


                int
                f_10877_81610_81639(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81610, 81639);
                    return 0;
                }


                int
                f_10877_81656_81677(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81656, 81677);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_81748_81759(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 81748, 81759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_81870_81881(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 81870, 81881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_82052_82070(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 82052, 82070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_82105_82116(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 82105, 82116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_82348_82368(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 82348, 82368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_82403_82416(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 82403, 82416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_82546_82557(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 82546, 82557);
                    return return_v;
                }


                System.Exception
                f_10877_82511_82558(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 82511, 82558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_82607_82622(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 82607, 82622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_82713_82732(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 82713, 82732);
                    return return_v;
                }


                int
                f_10877_82780_82830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 82780, 82830);
                    return 0;
                }


                int
                f_10877_82957_82995(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 82957, 82995);
                    return 0;
                }


                int
                f_10877_83016_83126(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                binary, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isAnd, bool
                isBool, ref TLocalState
                leftTrue, ref TLocalState
                leftFalse)
                {
                    this_param.AfterLeftChildOfBinaryLogicalOperatorHasBeenVisited(binary, right, isAnd, isBool, ref leftTrue, ref leftFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83016, 83126);
                    return 0;
                }


                int
                f_10877_83151_83162(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 83151, 83162);
                    return return_v;
                }


                int
                f_10877_83254_83284(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.AdjustConditionalState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83254, 83284);
                    return 0;
                }


                int
                f_10877_83316_83352(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83316, 83352);
                    return 0;
                }


                int
                f_10877_83367_83379(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83367, 83379);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 80355, 83391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 80355, 83391);
            }
        }

        protected virtual void AfterLeftChildOfBinaryLogicalOperatorHasBeenVisited(BoundExpression binary, BoundExpression right, bool isAnd, bool isBool, ref TLocalState leftTrue, ref TLocalState leftFalse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 83403, 83809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83627, 83640);

                f_10877_83627_83639(this, right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 83686, 83798);

                f_10877_83686_83797(this, binary, right, isAnd, isBool, ref leftTrue, ref leftFalse);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 83403, 83809);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_83627_83639(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83627, 83639);
                    return return_v;
                }


                int
                f_10877_83686_83797(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                binary, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, bool
                isAnd, bool
                isBool, ref TLocalState
                leftTrue, ref TLocalState
                leftFalse)
                {
                    this_param.AfterRightChildOfBinaryLogicalOperatorHasBeenVisited(binary, right, isAnd, isBool, ref leftTrue, ref leftFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 83686, 83797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 83403, 83809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 83403, 83809);
            }
        }

        protected void AfterRightChildOfBinaryLogicalOperatorHasBeenVisited(BoundExpression binary, BoundExpression right, bool isAnd, bool isBool, ref TLocalState leftTrue, ref TLocalState leftFalse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 83821, 84698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84038, 84068);

                f_10877_84038_84067(this, right);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84117, 84223) || true) && (!isBool)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 84117, 84223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84162, 84177);

                    f_10877_84162_84176(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84195, 84208);

                    f_10877_84195_84207(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 84117, 84223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84239, 84275);

                var
                resultTrue = this.StateWhenTrue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84289, 84327);

                var
                resultFalse = this.StateWhenFalse
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84341, 84537) || true) && (isAnd)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 84341, 84537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84384, 84421);

                    f_10877_84384_84420(this, ref resultFalse, ref leftFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 84341, 84537);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 84341, 84537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84487, 84522);

                    f_10877_84487_84521(this, ref resultTrue, ref leftTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 84341, 84537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84551, 84596);

                f_10877_84551_84595(this, resultTrue, resultFalse);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84612, 84687) || true) && (!isBool)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 84612, 84687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 84657, 84672);

                    f_10877_84657_84671(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 84612, 84687);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 83821, 84698);

                int
                f_10877_84038_84067(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.AdjustConditionalState(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84038, 84067);
                    return 0;
                }


                int
                f_10877_84162_84176(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84162, 84176);
                    return 0;
                }


                int
                f_10877_84195_84207(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Split();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84195, 84207);
                    return 0;
                }


                bool
                f_10877_84384_84420(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84384, 84420);
                    return return_v;
                }


                bool
                f_10877_84487_84521(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84487, 84521);
                    return return_v;
                }


                int
                f_10877_84551_84595(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84551, 84595);
                    return 0;
                }


                int
                f_10877_84657_84671(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 84657, 84671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 83821, 84698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 83821, 84698);
            }
        }

        private void VisitBinaryOperatorChildren(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 84710, 85658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85241, 85301);

                var
                stack = f_10877_85253_85300()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85317, 85351);

                BoundBinaryOperator
                binary = node
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 85365, 85569);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85400, 85419);

                            f_10877_85400_85418(stack, binary);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85437, 85481);

                            binary = f_10877_85446_85457(binary) as BoundBinaryOperator;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 85365, 85569);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85365, 85569) || true) && (binary != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 85517, 85567) && !f_10877_85536_85567(f_10877_85536_85555(binary))))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 85365, 85569);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 85365, 85569);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85585, 85620);

                f_10877_85585_85619(this, stack);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85634, 85647);

                f_10877_85634_85646(stack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 84710, 85658);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                f_10877_85253_85300()
                {
                    var return_v = ArrayBuilder<BoundBinaryOperator>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85253, 85300);
                    return return_v;
                }


                int
                f_10877_85400_85418(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85400, 85418);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_85446_85457(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 85446, 85457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10877_85536_85555(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 85536, 85555);
                    return return_v;
                }


                bool
                f_10877_85536_85567(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85536, 85567);
                    return return_v;
                }


                int
                f_10877_85585_85619(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                stack)
                {
                    this_param.VisitBinaryOperatorChildren(stack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85585, 85619);
                    return 0;
                }


                int
                f_10877_85634_85646(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85634, 85646);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 84710, 85658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 84710, 85658);
            }
        }

        protected virtual void VisitBinaryOperatorChildren(ArrayBuilder<BoundBinaryOperator> stack)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 85670, 86164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85786, 85811);

                var
                binary = f_10877_85799_85810(stack)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85825, 85850);

                f_10877_85825_85849(this, f_10877_85837_85848(binary));
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85866, 86153) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 85866, 86153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85911, 85937);

                        f_10877_85911_85936(this, f_10877_85923_85935(binary));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 85957, 86044) || true) && (f_10877_85961_85972(stack) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 85957, 86044);
                            DynAbs.Tracing.TraceSender.TraceBreak(10877, 86019, 86025);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 85957, 86044);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86064, 86074);

                        f_10877_86064_86073(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86117, 86138);

                        binary = f_10877_86126_86137(stack);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 85866, 86153);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 85866, 86153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 85866, 86153);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 85670, 86164);

                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10877_85799_85810(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85799, 85810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_85837_85848(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 85837, 85848);
                    return return_v;
                }


                int
                f_10877_85825_85849(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85825, 85849);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_85923_85935(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 85923, 85935);
                    return return_v;
                }


                int
                f_10877_85911_85936(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 85911, 85936);
                    return 0;
                }


                int
                f_10877_85961_85972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 85961, 85972);
                    return return_v;
                }


                int
                f_10877_86064_86073(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86064, 86073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10877_86126_86137(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86126, 86137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 85670, 86164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 85670, 86164);
            }
        }

        public override BoundNode VisitUnaryOperator(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 86176, 86811);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86270, 86774) || true) && (f_10877_86274_86291(node) == UnaryOperatorKind.BoolLogicalNegation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 86270, 86774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86485, 86514);

                    f_10877_86485_86513(this, f_10877_86500_86512(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86616, 86667);

                    f_10877_86616_86666(this, StateWhenFalse, StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 86270, 86774);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 86270, 86774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86733, 86759);

                    f_10877_86733_86758(this, f_10877_86745_86757(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 86270, 86774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86788, 86800);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 86176, 86811);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10877_86274_86291(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 86274, 86291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_86500_86512(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 86500, 86512);
                    return return_v;
                }


                int
                f_10877_86485_86513(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86485, 86513);
                    return 0;
                }


                int
                f_10877_86616_86666(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                whenTrue, TLocalState
                whenFalse)
                {
                    this_param.SetConditionalState(whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86616, 86666);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_86745_86757(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 86745, 86757);
                    return return_v;
                }


                int
                f_10877_86733_86758(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86733, 86758);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 86176, 86811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 86176, 86811);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRangeExpression(BoundRangeExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 86823, 87204);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86921, 87034) || true) && (f_10877_86925_86944(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 86921, 87034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 86986, 87019);

                    f_10877_86986_87018(this, f_10877_86998_87017(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 86921, 87034);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87050, 87165) || true) && (f_10877_87054_87074(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 87050, 87165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87116, 87150);

                    f_10877_87116_87149(this, f_10877_87128_87148(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 87050, 87165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87181, 87193);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 86823, 87204);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_86925_86944(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.LeftOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 86925, 86944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_86998_87017(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.LeftOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 86998, 87017);
                    return return_v;
                }


                int
                f_10877_86986_87018(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 86986, 87018);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_87054_87074(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.RightOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87054, 87074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_87128_87148(Microsoft.CodeAnalysis.CSharp.BoundRangeExpression
                this_param)
                {
                    var return_v = this_param.RightOperandOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87128, 87148);
                    return return_v;
                }


                int
                f_10877_87116_87149(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87116, 87149);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 86823, 87204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 86823, 87204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFromEndIndexExpression(BoundFromEndIndexExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 87216, 87391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87328, 87354);

                f_10877_87328_87353(this, f_10877_87340_87352(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87368, 87380);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 87216, 87391);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_87340_87352(Microsoft.CodeAnalysis.CSharp.BoundFromEndIndexExpression
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87340, 87352);
                    return return_v;
                }


                int
                f_10877_87328_87353(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87328, 87353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 87216, 87391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 87216, 87391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitExpression(BoundAwaitExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 87403, 87644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87501, 87530);

                f_10877_87501_87529(this, f_10877_87513_87528(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87544, 87607);

                f_10877_87544_87606(f_10877_87544_87559(), f_10877_87564_87605(node, this.State, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87621, 87633);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 87403, 87644);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_87513_87528(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87513, 87528);
                    return return_v;
                }


                int
                f_10877_87501_87529(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87501, 87529);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_87544_87559()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87544, 87559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_87564_87605(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87564, 87605);
                    return return_v;
                }


                int
                f_10877_87544_87606(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87544, 87606);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 87403, 87644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 87403, 87644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIncrementOperator(BoundIncrementOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 87656, 88689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87820, 88608) || true) && (f_10877_87824_87859(this, f_10877_87846_87858(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 87820, 88608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87893, 87938);

                    var
                    left = (BoundPropertyAccess)f_10877_87925_87937(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 87956, 87991);

                    var
                    property = f_10877_87971_87990(left)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88009, 88593) || true) && (f_10877_88013_88029(property) == RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 88009, 88593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88087, 88128);

                        var
                        readMethod = f_10877_88104_88127(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88150, 88193);

                        var
                        writeMethod = f_10877_88168_88192(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88215, 88292);

                        f_10877_88215_88291(f_10877_88228_88245(node) || (DynAbs.Tracing.TraceSender.Expression_False(10877, 88228, 88290) || (object)readMethod != (object)writeMethod));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88314, 88368);

                        f_10877_88314_88367(this, f_10877_88338_88354(left), readMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88390, 88443);

                        f_10877_88390_88442(this, f_10877_88413_88429(left), readMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88465, 88517);

                        f_10877_88465_88516(this, node, f_10877_88486_88502(left), writeMethod);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88562, 88574);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 88009, 88593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 87820, 88608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88624, 88650);

                f_10877_88624_88649(this, f_10877_88636_88648(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88666, 88678);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 87656, 88689);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_87846_87858(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87846, 87858);
                    return return_v;
                }


                bool
                f_10877_87824_87859(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.RegularPropertyAccess(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 87824, 87859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_87925_87937(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87925, 87937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_87971_87990(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 87971, 87990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_88013_88029(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88013, 88029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_88104_88127(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88104, 88127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_88168_88192(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetWriteMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88168, 88192);
                    return return_v;
                }


                bool
                f_10877_88228_88245(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88228, 88245);
                    return return_v;
                }


                int
                f_10877_88215_88291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88215, 88291);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_88338_88354(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88338, 88354);
                    return return_v;
                }


                int
                f_10877_88314_88367(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88314, 88367);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_88413_88429(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88413, 88429);
                    return return_v;
                }


                int
                f_10877_88390_88442(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88390, 88442);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_88486_88502(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88486, 88502);
                    return return_v;
                }


                int
                f_10877_88465_88516(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                setter)
                {
                    this_param.PropertySetter((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, receiver, setter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88465, 88516);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_88636_88648(Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88636, 88648);
                    return return_v;
                }


                int
                f_10877_88624_88649(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88624, 88649);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 87656, 88689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 87656, 88689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayCreation(BoundArrayCreation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 88701, 89089);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88795, 88894);
                    foreach (var expr in f_10877_88816_88827_I(f_10877_88816_88827(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 88795, 88894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88861, 88879);

                        f_10877_88861_88878(this, expr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 88795, 88894);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 100);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88910, 89050) || true) && (f_10877_88914_88933(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 88910, 89050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 88975, 89035);

                    f_10877_88975_89034(this, node, f_10877_89014_89033(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 88910, 89050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89066, 89078);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 88701, 89089);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_88816_88827(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Bounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88816, 88827);
                    return return_v;
                }


                int
                f_10877_88861_88878(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88861, 88878);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_88816_88827_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88816, 88827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10877_88914_88933(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 88914, 88933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10877_89014_89033(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89014, 89033);
                    return return_v;
                }


                int
                f_10877_88975_89034(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                arrayCreation, Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                node)
                {
                    this_param.VisitArrayInitializationInternal(arrayCreation, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 88975, 89034);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 88701, 89089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 88701, 89089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitArrayInitializationInternal(BoundArrayCreation arrayCreation, BoundArrayInitialization node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 89101, 89625);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89236, 89614);
                    foreach (var child in f_10877_89258_89275_I(f_10877_89258_89275(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89236, 89614);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89309, 89599) || true) && (f_10877_89313_89323(child) == BoundKind.ArrayInitialization)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89309, 89599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89398, 89479);

                            f_10877_89398_89478(this, arrayCreation, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89309, 89599);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89309, 89599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89561, 89580);

                            f_10877_89561_89579(this, child);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89309, 89599);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89236, 89614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 379);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 89101, 89625);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_89258_89275(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89258, 89275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10877_89313_89323(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89313, 89323);
                    return return_v;
                }


                int
                f_10877_89398_89478(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                arrayCreation, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitArrayInitializationInternal(arrayCreation, (Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89398, 89478);
                    return 0;
                }


                int
                f_10877_89561_89579(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89561, 89579);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_89258_89275_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89258, 89275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 89101, 89625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 89101, 89625);
            }
        }

        public override BoundNode VisitForStatement(BoundForStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 89637, 90647);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89729, 89839) || true) && (f_10877_89733_89749(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89729, 89839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89791, 89824);

                    f_10877_89791_89823(this, f_10877_89806_89822(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89729, 89839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89853, 89868);

                f_10877_89853_89867(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89882, 89916);

                TLocalState
                bodyState
                = default(TLocalState),
                breakState
                = default(TLocalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89930, 90275) || true) && (f_10877_89934_89948(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89930, 90275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 89990, 90021);

                    f_10877_89990_90020(this, f_10877_90005_90019(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90039, 90070);

                    bodyState = this.StateWhenTrue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90088, 90121);

                    breakState = this.StateWhenFalse;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89930, 90275);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 89930, 90275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90187, 90210);

                    bodyState = this.State;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90228, 90260);

                    breakState = f_10877_90241_90259(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 89930, 90275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90291, 90311);

                f_10877_90291_90310(this, bodyState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90325, 90351);

                f_10877_90325_90350(this, f_10877_90340_90349(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90365, 90402);

                f_10877_90365_90401(this, f_10877_90382_90400(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90416, 90522) || true) && (f_10877_90420_90434(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 90416, 90522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90476, 90507);

                    f_10877_90476_90506(this, f_10877_90491_90505(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 90416, 90522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90538, 90553);

                f_10877_90538_90552(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90567, 90610);

                f_10877_90567_90609(this, breakState, f_10877_90593_90608(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90624, 90636);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 89637, 90647);

                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10877_89733_89749(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89733, 89749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_89806_89822(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89806, 89822);
                    return return_v;
                }


                int
                f_10877_89791_89823(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89791, 89823);
                    return 0;
                }


                int
                f_10877_89853_89867(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForStatement
                node)
                {
                    this_param.LoopHead((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89853, 89867);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_89934_89948(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 89934, 89948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_90005_90019(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90005, 90019);
                    return return_v;
                }


                int
                f_10877_89990_90020(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 89990, 90020);
                    return 0;
                }


                TLocalState
                f_10877_90241_90259(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90241, 90259);
                    return return_v;
                }


                int
                f_10877_90291_90310(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90291, 90310);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_90340_90349(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90340, 90349);
                    return return_v;
                }


                int
                f_10877_90325_90350(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90325, 90350);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_90382_90400(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90382, 90400);
                    return return_v;
                }


                int
                f_10877_90365_90401(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    this_param.ResolveContinues((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90365, 90401);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10877_90420_90434(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Increment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90420, 90434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_90491_90505(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Increment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90491, 90505);
                    return return_v;
                }


                int
                f_10877_90476_90506(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90476, 90506);
                    return 0;
                }


                int
                f_10877_90538_90552(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForStatement
                node)
                {
                    this_param.LoopTail((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90538, 90552);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_90593_90608(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 90593, 90608);
                    return return_v;
                }


                int
                f_10877_90567_90609(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                breakState, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    this_param.ResolveBreaks(breakState, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90567, 90609);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 89637, 90647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 89637, 90647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitForEachStatement(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 90659, 91487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90872, 90901);

                f_10877_90872_90900(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90915, 90951);

                var
                breakState = f_10877_90932_90950(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90965, 90980);

                f_10877_90965_90979(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 90994, 91031);

                f_10877_90994_91030(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91045, 91071);

                f_10877_91045_91070(this, f_10877_91060_91069(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91085, 91122);

                f_10877_91085_91121(this, f_10877_91102_91120(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91136, 91151);

                f_10877_91136_91150(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91165, 91208);

                f_10877_91165_91207(this, breakState, f_10877_91191_91206(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91224, 91448) || true) && (f_10877_91228_91265() && (DynAbs.Tracing.TraceSender.Expression_True(10877, 91228, 91336) && f_10877_91269_91325(((CommonForEachStatementSyntax)node.Syntax)) != default))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 91224, 91448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91370, 91433);

                    f_10877_91370_91432(f_10877_91370_91385(), f_10877_91390_91431(node, this.State, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 91224, 91448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91464, 91476);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 90659, 91487);

                int
                f_10877_90872_90900(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                node)
                {
                    this_param.VisitForEachExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90872, 90900);
                    return 0;
                }


                TLocalState
                f_10877_90932_90950(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90932, 90950);
                    return return_v;
                }


                int
                f_10877_90965_90979(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                node)
                {
                    this_param.LoopHead((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90965, 90979);
                    return 0;
                }


                int
                f_10877_90994_91030(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                node)
                {
                    this_param.VisitForEachIterationVariables(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 90994, 91030);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_91060_91069(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91060, 91069);
                    return return_v;
                }


                int
                f_10877_91045_91070(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91045, 91070);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_91102_91120(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91102, 91120);
                    return return_v;
                }


                int
                f_10877_91085_91121(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    this_param.ResolveContinues((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91085, 91121);
                    return 0;
                }


                int
                f_10877_91136_91150(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                node)
                {
                    this_param.LoopTail((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91136, 91150);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_91191_91206(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91191, 91206);
                    return return_v;
                }


                int
                f_10877_91165_91207(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                breakState, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    this_param.ResolveBreaks(breakState, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91165, 91207);
                    return 0;
                }


                bool
                f_10877_91228_91265()
                {
                    var return_v = AwaitUsingAndForeachAddsPendingBranch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91228, 91265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10877_91269_91325(Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.AwaitKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91269, 91325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_91370_91385()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91370, 91385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_91390_91431(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91390, 91431);
                    return return_v;
                }


                int
                f_10877_91370_91432(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91370, 91432);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 90659, 91487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 90659, 91487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VisitForEachExpression(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 91499, 91637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91597, 91626);

                f_10877_91597_91625(this, f_10877_91609_91624(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 91499, 91637);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_91609_91624(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91609, 91624);
                    return return_v;
                }


                int
                f_10877_91597_91625(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91597, 91625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 91499, 91637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 91499, 91637);
            }
        }

        public virtual void VisitForEachIterationVariables(BoundForEachStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 91649, 91749);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 91649, 91749);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 91649, 91749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 91649, 91749);
            }
        }

        public override BoundNode VisitAsOperator(BoundAsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 91761, 91912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91849, 91875);

                f_10877_91849_91874(this, f_10877_91861_91873(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 91889, 91901);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 91761, 91912);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_91861_91873(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 91861, 91873);
                    return return_v;
                }


                int
                f_10877_91849_91874(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 91849, 91874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 91761, 91912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 91761, 91912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitIsOperator(BoundIsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 91924, 92075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92012, 92038);

                f_10877_92012_92037(this, f_10877_92024_92036(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92052, 92064);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 91924, 92075);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92024_92036(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92024, 92036);
                    return return_v;
                }


                int
                f_10877_92012_92037(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92012, 92037);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 91924, 92075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 91924, 92075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodGroup(BoundMethodGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 92087, 92477);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92177, 92438) || true) && (f_10877_92181_92197(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 92177, 92438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92393, 92423);

                    f_10877_92393_92422(this, f_10877_92405_92421(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 92177, 92438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92454, 92466);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 92087, 92477);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_92181_92197(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92181, 92197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92405_92421(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92405, 92421);
                    return return_v;
                }


                int
                f_10877_92393_92422(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92393, 92422);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 92087, 92477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 92087, 92477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 92489, 93142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92601, 92631);

                f_10877_92601_92630(this, f_10877_92613_92629(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92645, 93105) || true) && (f_10877_92649_92681(f_10877_92664_92680(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 92645, 93105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92715, 92746);

                    f_10877_92715_92745(this, f_10877_92727_92744(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 92645, 93105);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 92645, 93105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92812, 92848);

                    var
                    savedState = f_10877_92829_92847(this.State)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92866, 92986) || true) && (f_10877_92870_92900(f_10877_92870_92886(node)) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 92866, 92986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 92950, 92967);

                        f_10877_92950_92966(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 92866, 92986);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93004, 93035);

                    f_10877_93004_93034(this, f_10877_93016_93033(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93053, 93090);

                    f_10877_93053_93089(this, ref this.State, ref savedState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 92645, 93105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93119, 93131);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 92489, 93142);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92613_92629(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92613, 92629);
                    return return_v;
                }


                int
                f_10877_92601_92630(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92601, 92630);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92664_92680(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92664, 92680);
                    return return_v;
                }


                bool
                f_10877_92649_92681(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantNull(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92649, 92681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92727_92744(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92727, 92744);
                    return return_v;
                }


                int
                f_10877_92715_92745(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92715, 92745);
                    return 0;
                }


                TLocalState
                f_10877_92829_92847(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92829, 92847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_92870_92886(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92870, 92886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10877_92870_92900(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 92870, 92900);
                    return return_v;
                }


                int
                f_10877_92950_92966(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 92950, 92966);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93016_93033(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93016, 93033);
                    return return_v;
                }


                int
                f_10877_93004_93034(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93004, 93034);
                    return 0;
                }


                bool
                f_10877_93053_93089(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93053, 93089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 92489, 93142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 92489, 93142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalAccess(BoundConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 93154, 93834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93256, 93283);

                f_10877_93256_93282(this, f_10877_93268_93281(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93299, 93797) || true) && (f_10877_93303_93330(f_10877_93303_93316(node)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 93303, 93372) && !f_10877_93343_93372(f_10877_93358_93371(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 93299, 93797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93406, 93441);

                    f_10877_93406_93440(this, f_10877_93418_93439(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 93299, 93797);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 93299, 93797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93507, 93543);

                    var
                    savedState = f_10877_93524_93542(this.State)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93561, 93672) || true) && (f_10877_93565_93594(f_10877_93580_93593(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 93561, 93672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93636, 93653);

                        f_10877_93636_93652(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 93561, 93672);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93692, 93727);

                    f_10877_93692_93726(this, f_10877_93704_93725(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93745, 93782);

                    f_10877_93745_93781(this, ref this.State, ref savedState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 93299, 93797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93811, 93823);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 93154, 93834);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93268_93281(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93268, 93281);
                    return return_v;
                }


                int
                f_10877_93256_93282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93256, 93282);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93303_93316(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93303, 93316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10877_93303_93330(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93303, 93330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93358_93371(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93358, 93371);
                    return return_v;
                }


                bool
                f_10877_93343_93372(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantNull(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93343, 93372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93418_93439(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.AccessExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93418, 93439);
                    return return_v;
                }


                int
                f_10877_93406_93440(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93406, 93440);
                    return 0;
                }


                TLocalState
                f_10877_93524_93542(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93524, 93542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93580_93593(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93580, 93593);
                    return return_v;
                }


                bool
                f_10877_93565_93594(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantNull(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93565, 93594);
                    return return_v;
                }


                int
                f_10877_93636_93652(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93636, 93652);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93704_93725(Microsoft.CodeAnalysis.CSharp.BoundConditionalAccess
                this_param)
                {
                    var return_v = this_param.AccessExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93704, 93725);
                    return return_v;
                }


                int
                f_10877_93692_93726(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93692, 93726);
                    return 0;
                }


                bool
                f_10877_93745_93781(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93745, 93781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 93154, 93834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 93154, 93834);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLoweredConditionalAccess(BoundLoweredConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 93846, 94405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 93962, 93989);

                f_10877_93962_93988(this, f_10877_93974_93987(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94005, 94041);

                var
                savedState = f_10877_94022_94040(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94057, 94087);

                f_10877_94057_94086(this, f_10877_94069_94085(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94101, 94138);

                f_10877_94101_94137(this, ref this.State, ref savedState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94154, 94366) || true) && (f_10877_94158_94174(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 94154, 94366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94216, 94248);

                    savedState = f_10877_94229_94247(this.State);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94266, 94296);

                    f_10877_94266_94295(this, f_10877_94278_94294(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94314, 94351);

                    f_10877_94314_94350(this, ref this.State, ref savedState);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 94154, 94366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94382, 94394);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 93846, 94405);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_93974_93987(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 93974, 93987);
                    return return_v;
                }


                int
                f_10877_93962_93988(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 93962, 93988);
                    return 0;
                }


                TLocalState
                f_10877_94022_94040(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94022, 94040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_94069_94085(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 94069, 94085);
                    return return_v;
                }


                int
                f_10877_94057_94086(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94057, 94086);
                    return 0;
                }


                bool
                f_10877_94101_94137(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94101, 94137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_94158_94174(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 94158, 94174);
                    return return_v;
                }


                TLocalState
                f_10877_94229_94247(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94229, 94247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_94278_94294(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 94278, 94294);
                    return return_v;
                }


                int
                f_10877_94266_94295(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94266, 94295);
                    return 0;
                }


                bool
                f_10877_94314_94350(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94314, 94350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 93846, 94405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 93846, 94405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalReceiver(BoundConditionalReceiver node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 94417, 94546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94523, 94535);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 94417, 94546);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 94417, 94546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 94417, 94546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitComplexConditionalReceiver(BoundComplexConditionalReceiver node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 94558, 95009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94678, 94714);

                var
                savedState = f_10877_94695_94713(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94730, 94766);

                f_10877_94730_94765(this, f_10877_94742_94764(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94780, 94817);

                f_10877_94780_94816(this, ref this.State, ref savedState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94833, 94865);

                savedState = f_10877_94846_94864(this.State);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94879, 94919);

                f_10877_94879_94918(this, f_10877_94891_94917(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94933, 94970);

                f_10877_94933_94969(this, ref this.State, ref savedState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 94986, 94998);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 94558, 95009);

                TLocalState
                f_10877_94695_94713(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94695, 94713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_94742_94764(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ValueTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 94742, 94764);
                    return return_v;
                }


                int
                f_10877_94730_94765(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94730, 94765);
                    return 0;
                }


                bool
                f_10877_94780_94816(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94780, 94816);
                    return return_v;
                }


                TLocalState
                f_10877_94846_94864(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94846, 94864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_94891_94917(Microsoft.CodeAnalysis.CSharp.BoundComplexConditionalReceiver
                this_param)
                {
                    var return_v = this_param.ReferenceTypeReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 94891, 94917);
                    return return_v;
                }


                int
                f_10877_94879_94918(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94879, 94918);
                    return 0;
                }


                bool
                f_10877_94933_94969(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 94933, 94969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 94558, 95009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 94558, 95009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 95021, 95411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95105, 95140);

                var
                sideEffects = f_10877_95123_95139(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95154, 95334) || true) && (f_10877_95158_95178_M(!sideEffects.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 95154, 95334);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95212, 95319);
                        foreach (var se in f_10877_95231_95242_I(sideEffects))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 95212, 95319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95284, 95300);

                            f_10877_95284_95299(this, se);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 95212, 95319);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 108);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 108);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 95154, 95334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95350, 95374);

                f_10877_95350_95373(this, f_10877_95362_95372(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95388, 95400);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 95021, 95411);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_95123_95139(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95123, 95139);
                    return return_v;
                }


                bool
                f_10877_95158_95178_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95158, 95178);
                    return return_v;
                }


                int
                f_10877_95284_95299(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 95284, 95299);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_95231_95242_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 95231, 95242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_95362_95372(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95362, 95372);
                    return return_v;
                }


                int
                f_10877_95350_95373(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 95350, 95373);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 95021, 95411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 95021, 95411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequencePoint(BoundSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 95423, 95668);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95517, 95629) || true) && (f_10877_95521_95538(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 95517, 95629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95580, 95614);

                    f_10877_95580_95613(this, f_10877_95595_95612(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 95517, 95629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95645, 95657);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 95423, 95668);

                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10877_95521_95538(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95521, 95538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_95595_95612(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95595, 95612);
                    return return_v;
                }


                int
                f_10877_95580_95613(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 95580, 95613);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 95423, 95668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 95423, 95668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequencePointExpression(BoundSequencePointExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 95680, 95860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95794, 95823);

                f_10877_95794_95822(this, f_10877_95806_95821(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95837, 95849);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 95680, 95860);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_95806_95821(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95806, 95821);
                    return return_v;
                }


                int
                f_10877_95794_95822(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 95794, 95822);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 95680, 95860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 95680, 95860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSequencePointWithSpan(BoundSequencePointWithSpan node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 95872, 96133);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 95982, 96094) || true) && (f_10877_95986_96003(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 95982, 96094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96045, 96079);

                    f_10877_96045_96078(this, f_10877_96060_96077(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 95982, 96094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96110, 96122);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 95872, 96133);

                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10877_95986_96003(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 95986, 96003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_96060_96077(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 96060, 96077);
                    return return_v;
                }


                int
                f_10877_96045_96078(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96045, 96078);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 95872, 96133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 95872, 96133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitStatementList(BoundStatementList node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 96145, 96288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96239, 96277);

                return f_10877_96246_96276(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 96145, 96288);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_96246_96276(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                node)
                {
                    var return_v = this_param.VisitStatementListWorker(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96246, 96276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 96145, 96288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 96145, 96288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitStatementListWorker(BoundStatementList node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 96300, 96547);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96392, 96508);
                    foreach (var statement in f_10877_96418_96433_I(f_10877_96418_96433(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 96392, 96508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96467, 96493);

                        f_10877_96467_96492(this, statement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 96392, 96508);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96524, 96536);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 96300, 96547);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_96418_96433(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 96418, 96433);
                    return return_v;
                }


                int
                f_10877_96467_96492(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96467, 96492);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10877_96418_96433_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96418, 96433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 96300, 96547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 96300, 96547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeOrInstanceInitializers(BoundTypeOrInstanceInitializers node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 96559, 96728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96679, 96717);

                return f_10877_96686_96716(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 96559, 96728);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_96686_96716(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeOrInstanceInitializers
                node)
                {
                    var return_v = this_param.VisitStatementListWorker((Microsoft.CodeAnalysis.CSharp.BoundStatementList)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96686, 96716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 96559, 96728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 96559, 96728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnboundLambda(UnboundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 96740, 96982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 96923, 96971);

                return f_10877_96930_96970(this, f_10877_96942_96969(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 96740, 96982);

                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10877_96942_96969(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.BindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96942, 96969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_96930_96970(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node)
                {
                    var return_v = this_param.VisitLambda(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 96930, 96970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 96740, 96982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 96740, 96982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBreakStatement(BoundBreakStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 96994, 97280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97090, 97129);

                f_10877_97090_97128(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97143, 97212);

                f_10877_97143_97211(f_10877_97143_97158(), f_10877_97163_97210(node, this.State, f_10877_97199_97209(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97226, 97243);

                f_10877_97226_97242(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97257, 97269);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 96994, 97280);

                int
                f_10877_97090_97128(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97090, 97128);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_97143_97158()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97143, 97158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_97199_97209(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97199, 97209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_97163_97210(Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97163, 97210);
                    return return_v;
                }


                int
                f_10877_97143_97211(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97143, 97211);
                    return 0;
                }


                int
                f_10877_97226_97242(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97226, 97242);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 96994, 97280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 96994, 97280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitContinueStatement(BoundContinueStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 97292, 97584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97394, 97433);

                f_10877_97394_97432(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97447, 97516);

                f_10877_97447_97515(f_10877_97447_97462(), f_10877_97467_97514(node, this.State, f_10877_97503_97513(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97530, 97547);

                f_10877_97530_97546(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97561, 97573);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 97292, 97584);

                int
                f_10877_97394_97432(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97394, 97432);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_97447_97462()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97447, 97462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_97503_97513(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97503, 97513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_97467_97514(Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97467, 97514);
                    return return_v;
                }


                int
                f_10877_97447_97515(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97447, 97515);
                    return 0;
                }


                int
                f_10877_97530_97546(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97530, 97546);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 97292, 97584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 97292, 97584);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedConditionalOperator(BoundUnconvertedConditionalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 97596, 97845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97724, 97834);

                return f_10877_97731_97833(this, node, isByRef: false, f_10877_97782_97796(node), f_10877_97798_97814(node), f_10877_97816_97832(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 97596, 97845);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_97782_97796(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97782, 97796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_97798_97814(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97798, 97814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_97816_97832(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 97816, 97832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_97731_97833(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                node, bool
                isByRef, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative)
                {
                    var return_v = this_param.VisitConditionalOperatorCore((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, isByRef: isByRef, condition, consequence, alternative);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97731, 97833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 97596, 97845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 97596, 97845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalOperator(BoundConditionalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 97857, 98080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 97963, 98069);

                return f_10877_97970_98068(this, node, f_10877_98005_98015(node), f_10877_98017_98031(node), f_10877_98033_98049(node), f_10877_98051_98067(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 97857, 98080);

                bool
                f_10877_98005_98015(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 98005, 98015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_98017_98031(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 98017, 98031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_98033_98049(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 98033, 98049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_98051_98067(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 98051, 98067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_97970_98068(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                node, bool
                isByRef, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundExpression
                consequence, Microsoft.CodeAnalysis.CSharp.BoundExpression
                alternative)
                {
                    var return_v = this_param.VisitConditionalOperatorCore((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, isByRef, condition, consequence, alternative);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 97970, 98068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 97857, 98080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 97857, 98080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundNode VisitConditionalOperatorCore(
                    BoundExpression node,
                    bool isByRef,
                    BoundExpression condition,
                    BoundExpression consequence,
                    BoundExpression alternative)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 98092, 99594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98360, 98386);

                f_10877_98360_98385(this, condition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98400, 98442);

                var
                consequenceState = this.StateWhenTrue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98456, 98499);

                var
                alternativeState = this.StateWhenFalse
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98513, 99555) || true) && (f_10877_98517_98542(condition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 98513, 99555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98576, 98640);

                    f_10877_98576_98639(this, alternativeState, alternative, isByRef);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98658, 98722);

                    f_10877_98658_98721(this, consequenceState, consequence, isByRef);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 98513, 99555);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 98513, 99555);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98817, 99555) || true) && (f_10877_98821_98847(condition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 98817, 99555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98881, 98945);

                        f_10877_98881_98944(this, consequenceState, consequence, isByRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 98963, 99027);

                        f_10877_98963_99026(this, alternativeState, alternative, isByRef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 98817, 99555);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 98817, 99555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99154, 99218);

                        f_10877_99154_99217(this, consequenceState, consequence, isByRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99236, 99246);

                        f_10877_99236_99245(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99264, 99294);

                        consequenceState = this.State;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99312, 99376);

                        f_10877_99312_99375(this, alternativeState, alternative, isByRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99394, 99404);

                        f_10877_99394_99403(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99422, 99465);

                        f_10877_99422_99464(this, ref this.State, ref consequenceState);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 98817, 99555);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 98513, 99555);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99571, 99583);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 98092, 99594);

                int
                f_10877_98360_98385(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98360, 98385);
                    return 0;
                }


                bool
                f_10877_98517_98542(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantTrue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98517, 98542);
                    return return_v;
                }


                int
                f_10877_98576_98639(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98576, 98639);
                    return 0;
                }


                int
                f_10877_98658_98721(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98658, 98721);
                    return 0;
                }


                bool
                f_10877_98821_98847(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsConstantFalse(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98821, 98847);
                    return return_v;
                }


                int
                f_10877_98881_98944(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98881, 98944);
                    return 0;
                }


                int
                f_10877_98963_99026(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 98963, 99026);
                    return 0;
                }


                int
                f_10877_99154_99217(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99154, 99217);
                    return 0;
                }


                int
                f_10877_99236_99245(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99236, 99245);
                    return 0;
                }


                int
                f_10877_99312_99375(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                isByRef)
                {
                    this_param.VisitConditionalOperand(state, operand, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99312, 99375);
                    return 0;
                }


                int
                f_10877_99394_99403(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.Unsplit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99394, 99403);
                    return 0;
                }


                bool
                f_10877_99422_99464(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99422, 99464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 98092, 99594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 98092, 99594);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void VisitConditionalOperand(TLocalState state, BoundExpression operand, bool isByRef)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 99606, 100050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99725, 99741);

                f_10877_99725_99740(this, state);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99755, 100039) || true) && (isByRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 99755, 100039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99800, 99821);

                    f_10877_99800_99820(this, operand);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 99893, 99943);

                    f_10877_99893_99942(this, operand, RefKind.Ref, method: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 99755, 100039);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 99755, 100039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100009, 100024);

                    f_10877_100009_100023(this, operand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 99755, 100039);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 99606, 100050);

                int
                f_10877_99725_99740(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99725, 99740);
                    return 0;
                }


                int
                f_10877_99800_99820(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99800, 99820);
                    return 0;
                }


                int
                f_10877_99893_99942(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 99893, 99942);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_100009_100023(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100009, 100023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 99606, 100050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 99606, 100050);
            }
        }

        public override BoundNode VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 100062, 100179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100156, 100168);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 100062, 100179);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 100062, 100179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 100062, 100179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDoStatement(BoundDoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 100191, 100752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100376, 100391);

                f_10877_100376_100390(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100405, 100431);

                f_10877_100405_100430(this, f_10877_100420_100429(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100445, 100482);

                f_10877_100445_100481(this, f_10877_100462_100480(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100496, 100527);

                f_10877_100496_100526(this, f_10877_100511_100525(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100541, 100586);

                TLocalState
                breakState = this.StateWhenFalse
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100600, 100629);

                f_10877_100600_100628(this, this.StateWhenTrue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100643, 100658);

                f_10877_100643_100657(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100672, 100715);

                f_10877_100672_100714(this, breakState, f_10877_100698_100713(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100729, 100741);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 100191, 100752);

                int
                f_10877_100376_100390(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                node)
                {
                    this_param.LoopHead((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100376, 100390);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_100420_100429(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100420, 100429);
                    return return_v;
                }


                int
                f_10877_100405_100430(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100405, 100430);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_100462_100480(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100462, 100480);
                    return return_v;
                }


                int
                f_10877_100445_100481(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    this_param.ResolveContinues((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100445, 100481);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_100511_100525(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100511, 100525);
                    return return_v;
                }


                int
                f_10877_100496_100526(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100496, 100526);
                    return 0;
                }


                int
                f_10877_100600_100628(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100600, 100628);
                    return 0;
                }


                int
                f_10877_100643_100657(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                node)
                {
                    this_param.LoopTail((Microsoft.CodeAnalysis.CSharp.BoundLoopStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100643, 100657);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10877_100698_100713(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100698, 100713);
                    return return_v;
                }


                int
                f_10877_100672_100714(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                breakState, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                label)
                {
                    this_param.ResolveBreaks(breakState, (Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100672, 100714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 100191, 100752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 100191, 100752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitGotoStatement(BoundGotoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 100764, 101048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100858, 100897);

                f_10877_100858_100896(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100911, 100980);

                f_10877_100911_100979(f_10877_100911_100926(), f_10877_100931_100978(node, this.State, f_10877_100967_100977(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 100994, 101011);

                f_10877_100994_101010(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101025, 101037);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 100764, 101048);

                int
                f_10877_100858_100896(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100858, 100896);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_100911_100926()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100911, 100926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_100967_100977(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 100967, 100977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_100931_100978(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100931, 100978);
                    return return_v;
                }


                int
                f_10877_100911_100979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100911, 100979);
                    return 0;
                }


                int
                f_10877_100994_101010(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 100994, 101010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 100764, 101048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 100764, 101048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void VisitLabel(LabelSymbol label, BoundStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 101060, 101426);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101150, 101196);

                f_10877_101150_101195(node, label);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101210, 101239);

                f_10877_101210_101238(this, label, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101253, 101283);

                var
                state = f_10877_101265_101282(this, label)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101297, 101329);

                f_10877_101297_101328(this, ref this.State, ref state);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101343, 101379);

                _labels[label] = f_10877_101360_101378(this.State);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101393, 101415);

                f_10877_101393_101414(_labelsSeen, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 101060, 101426);

                int
                f_10877_101150_101195(Microsoft.CodeAnalysis.CSharp.BoundStatement
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    node.AssertIsLabeledStatementWithLabel(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101150, 101195);
                    return 0;
                }


                bool
                f_10877_101210_101238(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundStatement
                target)
                {
                    var return_v = this_param.ResolveBranches(label, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101210, 101238);
                    return return_v;
                }


                TLocalState
                f_10877_101265_101282(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.LabelState(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101265, 101282);
                    return return_v;
                }


                bool
                f_10877_101297_101328(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101297, 101328);
                    return return_v;
                }


                TLocalState
                f_10877_101360_101378(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101360, 101378);
                    return return_v;
                }


                bool
                f_10877_101393_101414(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101393, 101414);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 101060, 101426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 101060, 101426);
            }
        }

        protected virtual void VisitLabel(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 101438, 101564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101524, 101553);

                f_10877_101524_101552(this, f_10877_101535_101545(node), node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 101438, 101564);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_101535_101545(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 101535, 101545);
                    return return_v;
                }


                int
                f_10877_101524_101552(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                node)
                {
                    this_param.VisitLabel(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101524, 101552);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 101438, 101564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 101438, 101564);
            }
        }

        public override BoundNode VisitLabelStatement(BoundLabelStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 101576, 101738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101672, 101701);

                f_10877_101672_101700(this, f_10877_101683_101693(node), node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101715, 101727);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 101576, 101738);

                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_101683_101693(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 101683, 101693);
                    return return_v;
                }


                int
                f_10877_101672_101700(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                node)
                {
                    this_param.VisitLabel(label, (Microsoft.CodeAnalysis.CSharp.BoundStatement)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101672, 101700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 101576, 101738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 101576, 101738);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLabeledStatement(BoundLabeledStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 101750, 101944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101850, 101867);

                f_10877_101850_101866(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101881, 101907);

                f_10877_101881_101906(this, f_10877_101896_101905(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 101921, 101933);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 101750, 101944);

                int
                f_10877_101850_101866(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                node)
                {
                    this_param.VisitLabel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101850, 101866);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_101896_101905(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 101896, 101905);
                    return return_v;
                }


                int
                f_10877_101881_101906(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 101881, 101906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 101750, 101944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 101750, 101944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLockStatement(BoundLockStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 101956, 102154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102050, 102077);

                f_10877_102050_102076(this, f_10877_102062_102075(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102091, 102117);

                f_10877_102091_102116(this, f_10877_102106_102115(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102131, 102143);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 101956, 102154);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_102062_102075(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102062, 102075);
                    return return_v;
                }


                int
                f_10877_102050_102076(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102050, 102076);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_102106_102115(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102106, 102115);
                    return return_v;
                }


                int
                f_10877_102091_102116(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102091, 102116);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 101956, 102154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 101956, 102154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNoOpStatement(BoundNoOpStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 102166, 102283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102260, 102272);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 102166, 102283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 102166, 102283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 102166, 102283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNamespaceExpression(BoundNamespaceExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 102295, 102424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102401, 102413);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 102295, 102424);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 102295, 102424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 102295, 102424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUsingStatement(BoundUsingStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 102436, 103050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102532, 102643) || true) && (f_10877_102536_102554(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 102532, 102643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102596, 102628);

                    f_10877_102596_102627(this, f_10877_102608_102626(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 102532, 102643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102659, 102777) || true) && (f_10877_102663_102683(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 102659, 102777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102725, 102762);

                    f_10877_102725_102761(this, f_10877_102740_102760(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 102659, 102777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102793, 102819);

                f_10877_102793_102818(this, f_10877_102808_102817(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102835, 103013) || true) && (f_10877_102839_102876() && (DynAbs.Tracing.TraceSender.Expression_True(10877, 102839, 102901) && f_10877_102880_102893(node) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 102835, 103013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 102935, 102998);

                    f_10877_102935_102997(f_10877_102935_102950(), f_10877_102955_102996(node, this.State, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 102835, 103013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103027, 103039);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 102436, 103050);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_102536_102554(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102536, 102554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_102608_102626(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102608, 102626);
                    return return_v;
                }


                int
                f_10877_102596_102627(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102596, 102627);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                f_10877_102663_102683(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.DeclarationsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102663, 102683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                f_10877_102740_102760(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.DeclarationsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102740, 102760);
                    return return_v;
                }


                int
                f_10877_102725_102761(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                statement)
                {
                    this_param.VisitStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102725, 102761);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_102808_102817(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102808, 102817);
                    return return_v;
                }


                int
                f_10877_102793_102818(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102793, 102818);
                    return 0;
                }


                bool
                f_10877_102839_102876()
                {
                    var return_v = AwaitUsingAndForeachAddsPendingBranch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102839, 102876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10877_102880_102893(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102880, 102893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_102935_102950()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 102935, 102950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_102955_102996(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102955, 102996);
                    return return_v;
                }


                int
                f_10877_102935_102997(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 102935, 102997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 102436, 103050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 102436, 103050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract bool AwaitUsingAndForeachAddsPendingBranch { get; }

        public override BoundNode VisitFixedStatement(BoundFixedStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 103141, 103348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103237, 103271);

                f_10877_103237_103270(this, f_10877_103252_103269(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103285, 103311);

                f_10877_103285_103310(this, f_10877_103300_103309(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103325, 103337);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 103141, 103348);

                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                f_10877_103252_103269(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 103252, 103269);
                    return return_v;
                }


                int
                f_10877_103237_103270(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                statement)
                {
                    this_param.VisitStatement((Microsoft.CodeAnalysis.CSharp.BoundStatement)statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103237, 103270);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10877_103300_103309(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 103300, 103309);
                    return return_v;
                }


                int
                f_10877_103285_103310(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    this_param.VisitStatement(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103285, 103310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 103141, 103348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 103141, 103348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFixedLocalCollectionInitializer(BoundFixedLocalCollectionInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 103360, 103556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103490, 103519);

                f_10877_103490_103518(this, f_10877_103502_103517(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103533, 103545);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 103360, 103556);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_103502_103517(Microsoft.CodeAnalysis.CSharp.BoundFixedLocalCollectionInitializer
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 103502, 103517);
                    return return_v;
                }


                int
                f_10877_103490_103518(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103490, 103518);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 103360, 103556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 103360, 103556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitThrowStatement(BoundThrowStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 103568, 103806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103664, 103706);

                BoundExpression
                expr = f_10877_103687_103705(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103720, 103738);

                f_10877_103720_103737(this, expr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103752, 103769);

                f_10877_103752_103768(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103783, 103795);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 103568, 103806);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_103687_103705(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 103687, 103705);
                    return return_v;
                }


                int
                f_10877_103720_103737(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103720, 103737);
                    return 0;
                }


                int
                f_10877_103752_103768(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103752, 103768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 103568, 103806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 103568, 103806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldBreakStatement(BoundYieldBreakStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 103818, 104108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103924, 103963);

                f_10877_103924_103962(!this.IsConditionalState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 103977, 104040);

                f_10877_103977_104039(f_10877_103977_103992(), f_10877_103997_104038(node, this.State, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104054, 104071);

                f_10877_104054_104070(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104085, 104097);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 103818, 104108);

                int
                f_10877_103924_103962(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103924, 103962);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_103977_103992()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 103977, 103992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_103997_104038(Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103997, 104038);
                    return return_v;
                }


                int
                f_10877_103977_104039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 103977, 104039);
                    return 0;
                }


                int
                f_10877_104054_104070(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 104054, 104070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 103818, 104108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 103818, 104108);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitYieldReturnStatement(BoundYieldReturnStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 104120, 104371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104228, 104257);

                f_10877_104228_104256(this, f_10877_104240_104255(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104271, 104334);

                f_10877_104271_104333(f_10877_104271_104286(), f_10877_104291_104332(node, this.State, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104348, 104360);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 104120, 104371);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_104240_104255(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 104240, 104255);
                    return return_v;
                }


                int
                f_10877_104228_104256(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 104228, 104256);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_104271_104286()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 104271, 104286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_104291_104332(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 104291, 104332);
                    return return_v;
                }


                int
                f_10877_104271_104333(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 104271, 104333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 104120, 104371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 104120, 104371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDefaultLiteral(BoundDefaultLiteral node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 104383, 104502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104479, 104491);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 104383, 104502);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 104383, 104502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 104383, 104502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDefaultExpression(BoundDefaultExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 104514, 104639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104616, 104628);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 104514, 104639);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 104514, 104639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 104514, 104639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedObjectCreationExpression(BoundUnconvertedObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 104651, 104837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104789, 104826);

                throw f_10877_104795_104825();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 104651, 104837);

                System.Exception
                f_10877_104795_104825()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 104795, 104825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 104651, 104837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 104651, 104837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitTypeOfOperator(BoundTypeOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 104849, 105019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104945, 104982);

                f_10877_104945_104981(this, f_10877_104965_104980(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 104996, 105008);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 104849, 105019);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10877_104965_104980(Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator
                this_param)
                {
                    var return_v = this_param.SourceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 104965, 104980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_104945_104981(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                node)
                {
                    var return_v = this_param.VisitTypeExpression(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 104945, 104981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 104849, 105019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 104849, 105019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNameOfOperator(BoundNameOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 105031, 105305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105127, 105155);

                var
                savedState = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105169, 105198);

                f_10877_105169_105197(this, f_10877_105178_105196(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105212, 105233);

                f_10877_105212_105232(this, f_10877_105218_105231(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105247, 105268);

                f_10877_105247_105267(this, savedState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105282, 105294);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 105031, 105305);

                TLocalState
                f_10877_105178_105196(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    var return_v = this_param.UnreachableState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105178, 105196);
                    return return_v;
                }


                int
                f_10877_105169_105197(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105169, 105197);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_105218_105231(Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 105218, 105231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_105212_105232(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105212, 105232);
                    return return_v;
                }


                int
                f_10877_105247_105267(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105247, 105267);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 105031, 105305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 105031, 105305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAddressOfOperator(BoundAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 105317, 105518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105419, 105481);

                f_10877_105419_105480(this, f_10877_105441_105453(node), shouldReadOperand: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105495, 105507);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 105317, 105518);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_105441_105453(Microsoft.CodeAnalysis.CSharp.BoundAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 105441, 105453);
                    return return_v;
                }


                int
                f_10877_105419_105480(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, bool
                shouldReadOperand)
                {
                    this_param.VisitAddressOfOperand(operand, shouldReadOperand: shouldReadOperand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105419, 105480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 105317, 105518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 105317, 105518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void VisitAddressOfOperand(BoundExpression operand, bool shouldReadOperand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 105530, 105956);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105640, 105828) || true) && (shouldReadOperand)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 105640, 105828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105695, 105721);

                    f_10877_105695_105720(this, operand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 105640, 105828);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 105640, 105828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105787, 105813);

                    f_10877_105787_105812(this, operand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 105640, 105828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 105844, 105891);

                f_10877_105844_105890(
                            this, operand, RefKind.Out, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 105530, 105956);

                int
                f_10877_105695_105720(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105695, 105720);
                    return 0;
                }


                int
                f_10877_105787_105812(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitLvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105787, 105812);
                    return 0;
                }


                int
                f_10877_105844_105890(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.WriteArgument(arg, refKind, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 105844, 105890);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 105530, 105956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 105530, 105956);
            }
        }

        public override BoundNode VisitPointerIndirectionOperator(BoundPointerIndirectionOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 105968, 106151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106088, 106114);

                f_10877_106088_106113(this, f_10877_106100_106112(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106128, 106140);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 105968, 106151);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_106100_106112(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106100, 106112);
                    return return_v;
                }


                int
                f_10877_106088_106113(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106088, 106113);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 105968, 106151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 105968, 106151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPointerElementAccess(BoundPointerElementAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 106163, 106375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106271, 106300);

                f_10877_106271_106299(this, f_10877_106283_106298(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106314, 106338);

                f_10877_106314_106337(this, f_10877_106326_106336(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106352, 106364);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 106163, 106375);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_106283_106298(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106283, 106298);
                    return return_v;
                }


                int
                f_10877_106271_106299(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106271, 106299);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_106326_106336(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106326, 106336);
                    return return_v;
                }


                int
                f_10877_106314_106337(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106314, 106337);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 106163, 106375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 106163, 106375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitSizeOfOperator(BoundSizeOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 106387, 106506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106483, 106495);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 106387, 106506);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 106387, 106506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 106387, 106506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitStackAllocArrayCreationBase(BoundStackAllocArrayCreationBase node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 106518, 106976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106632, 106656);

                f_10877_106632_106655(this, f_10877_106644_106654(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106672, 106937) || true) && (f_10877_106676_106695(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10877, 106676, 106750) && f_10877_106707_106750_M(!f_10877_106708_106727(node).Initializers.IsDefault)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 106672, 106937);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106784, 106922);
                        foreach (var element in f_10877_106808_106840_I(f_10877_106808_106840(f_10877_106808_106827(node))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 106784, 106922);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106882, 106903);

                            f_10877_106882_106902(this, element);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 106784, 106922);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 139);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 139);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 106672, 106937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 106953, 106965);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 106518, 106976);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_106644_106654(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106644, 106654);
                    return return_v;
                }


                int
                f_10877_106632_106655(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106632, 106655);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10877_106676_106695(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106676, 106695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10877_106708_106727(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106708, 106727);
                    return return_v;
                }


                bool
                f_10877_106707_106750_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106707, 106750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10877_106808_106827(Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106808, 106827);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_106808_106840(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 106808, 106840);
                    return return_v;
                }


                int
                f_10877_106882_106902(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106882, 106902);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_106808_106840_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 106808, 106840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 106518, 106976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 106518, 106976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitStackAllocArrayCreation(BoundStackAllocArrayCreation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 106988, 107159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107102, 107148);

                return f_10877_107109_107147(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 106988, 107159);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_107109_107147(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation
                node)
                {
                    var return_v = this_param.VisitStackAllocArrayCreationBase((Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107109, 107147);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 106988, 107159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 106988, 107159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConvertedStackAllocExpression(BoundConvertedStackAllocExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 107171, 107354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107297, 107343);

                return f_10877_107304_107342(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 107171, 107354);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_107304_107342(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundConvertedStackAllocExpression
                node)
                {
                    var return_v = this_param.VisitStackAllocArrayCreationBase((Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreationBase)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107304, 107342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 107171, 107354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 107171, 107354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAnonymousObjectCreationExpression(BoundAnonymousObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 107366, 107667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107545, 107628);

                f_10877_107545_107627(this, f_10877_107560_107574(node), default(ImmutableArray<RefKind>), f_10877_107610_107626(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107644, 107656);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 107366, 107667);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_107560_107574(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 107560, 107574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_107610_107626(Microsoft.CodeAnalysis.CSharp.BoundAnonymousObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 107610, 107626);
                    return return_v;
                }


                int
                f_10877_107545_107627(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107545, 107627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 107366, 107667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 107366, 107667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitArrayLength(BoundArrayLength node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 107679, 107835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107769, 107798);

                f_10877_107769_107797(this, f_10877_107781_107796(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107812, 107824);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 107679, 107835);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_107781_107796(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 107781, 107796);
                    return return_v;
                }


                int
                f_10877_107769_107797(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107769, 107797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 107679, 107835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 107679, 107835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 107847, 108475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107945, 107976);

                f_10877_107945_107975(this, f_10877_107960_107974(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 107990, 108028);

                f_10877_107990_108027(this.IsConditionalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108042, 108436) || true) && (f_10877_108046_108061(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 108042, 108436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108095, 108172);

                    f_10877_108095_108171(f_10877_108095_108110(), f_10877_108115_108170(node, this.StateWhenTrue, f_10877_108159_108169(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108190, 108225);

                    f_10877_108190_108224(this, this.StateWhenFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 108042, 108436);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 108042, 108436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108291, 108369);

                    f_10877_108291_108368(f_10877_108291_108306(), f_10877_108311_108367(node, this.StateWhenFalse, f_10877_108356_108366(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108387, 108421);

                    f_10877_108387_108420(this, this.StateWhenTrue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 108042, 108436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108452, 108464);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 107847, 108475);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_107960_107974(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 107960, 107974);
                    return return_v;
                }


                int
                f_10877_107945_107975(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitCondition(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107945, 107975);
                    return 0;
                }


                int
                f_10877_107990_108027(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 107990, 108027);
                    return 0;
                }


                bool
                f_10877_108046_108061(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.JumpIfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108046, 108061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_108095_108110()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108095, 108110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_108159_108169(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108159, 108169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_108115_108170(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108115, 108170);
                    return return_v;
                }


                int
                f_10877_108095_108171(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108095, 108171);
                    return 0;
                }


                int
                f_10877_108190_108224(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108190, 108224);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                f_10877_108291_108306()
                {
                    var return_v = PendingBranches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108291, 108306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10877_108356_108366(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108356, 108366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                f_10877_108311_108367(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                branch, TLocalState
                state, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch((Microsoft.CodeAnalysis.CSharp.BoundNode)branch, state, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108311, 108367);
                    return return_v;
                }


                int
                f_10877_108291_108368(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
                this_param, Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108291, 108368);
                    return 0;
                }


                int
                f_10877_108387_108420(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108387, 108420);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 107847, 108475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 107847, 108475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectInitializerExpression(BoundObjectInitializerExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 108487, 108691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108609, 108680);

                return f_10877_108616_108679(this, f_10877_108661_108678(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 108487, 108691);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_108661_108678(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108661, 108678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_108616_108679(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.VisitObjectOrCollectionInitializerExpression(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108616, 108679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 108487, 108691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 108487, 108691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCollectionInitializerExpression(BoundCollectionInitializerExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 108703, 108915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 108833, 108904);

                return f_10877_108840_108903(this, f_10877_108885_108902(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 108703, 108915);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_108885_108902(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 108885, 108902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_108840_108903(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                initializers)
                {
                    var return_v = this_param.VisitObjectOrCollectionInitializerExpression(initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 108840, 108903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 108703, 108915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 108703, 108915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitObjectOrCollectionInitializerExpression(ImmutableArray<BoundExpression> initializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 108927, 109213);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109060, 109174);
                    foreach (var initializer in f_10877_109088_109100_I(initializers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 109060, 109174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109134, 109159);

                        f_10877_109134_109158(this, initializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 109060, 109174);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10877, 1, 115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10877, 1, 115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109190, 109202);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 108927, 109213);

                int
                f_10877_109134_109158(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 109134, 109158);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_109088_109100_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 109088, 109100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 108927, 109213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 108927, 109213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectInitializerMember(BoundObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 109225, 109850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109339, 109370);

                var
                arguments = f_10877_109355_109369(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109384, 109811) || true) && (f_10877_109388_109415_M(!arguments.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 109384, 109811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109449, 109476);

                    MethodSymbol
                    method = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109496, 109711) || true) && (f_10877_109500_109523_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10877_109500_109517(node), 10877, 109500, 109523)?.Kind) == SymbolKind.Property)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 109496, 109711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109588, 109637);

                        var
                        property = (PropertySymbol)f_10877_109619_109636(node)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109659, 109692);

                        method = f_10877_109668_109691(property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 109496, 109711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109731, 109796);

                    f_10877_109731_109795(this, f_10877_109746_109760(node), f_10877_109762_109786(node), method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 109384, 109811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109827, 109839);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 109225, 109850);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_109355_109369(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109355, 109369);
                    return return_v;
                }


                bool
                f_10877_109388_109415_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109388, 109415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10877_109500_109517(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109500, 109517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10877_109500_109523_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109500, 109523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10877_109619_109636(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109619, 109636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_109668_109691(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = GetReadMethod(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 109668, 109691);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_109746_109760(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109746, 109760);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_109762_109786(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 109762, 109786);
                    return return_v;
                }


                int
                f_10877_109731_109795(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 109731, 109795);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 109225, 109850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 109225, 109850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicObjectInitializerMember(BoundDynamicObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 109862, 110013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 109990, 110002);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 109862, 110013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 109862, 110013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 109862, 110013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCollectionElementInitializer(BoundCollectionElementInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 110025, 110942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110149, 110903) || true) && (f_10877_110153_110200(f_10877_110153_110167(node), f_10877_110184_110199(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 110149, 110903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110504, 110561);

                    TLocalState
                    savedState = savedState = f_10877_110542_110560(this.State)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110579, 110596);

                    f_10877_110579_110595(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110616, 110697);

                    f_10877_110616_110696(this, f_10877_110631_110645(node), default(ImmutableArray<RefKind>), f_10877_110681_110695(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110717, 110741);

                    this.State = savedState;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 110149, 110903);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 110149, 110903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110807, 110888);

                    f_10877_110807_110887(this, f_10877_110822_110836(node), default(ImmutableArray<RefKind>), f_10877_110872_110886(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 110149, 110903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 110919, 110931);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 110025, 110942);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_110153_110167(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110153, 110167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10877_110184_110199(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110184, 110199);
                    return return_v;
                }


                bool
                f_10877_110153_110200(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree?
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 110153, 110200);
                    return return_v;
                }


                TLocalState
                f_10877_110542_110560(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 110542, 110560);
                    return return_v;
                }


                int
                f_10877_110579_110595(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param)
                {
                    this_param.SetUnreachable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 110579, 110595);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_110631_110645(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110631, 110645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_110681_110695(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110681, 110695);
                    return return_v;
                }


                int
                f_10877_110616_110696(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 110616, 110696);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_110822_110836(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110822, 110836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10877_110872_110886(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 110872, 110886);
                    return return_v;
                }


                int
                f_10877_110807_110887(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 110807, 110887);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 110025, 110942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 110025, 110942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDynamicCollectionElementInitializer(BoundDynamicCollectionElementInitializer node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 110954, 111208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111092, 111171);

                f_10877_111092_111170(this, f_10877_111107_111121(node), default(ImmutableArray<RefKind>), method: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111185, 111197);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 110954, 111208);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_111107_111121(Microsoft.CodeAnalysis.CSharp.BoundDynamicCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 111107, 111121);
                    return return_v;
                }


                int
                f_10877_111092_111170(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, method: method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 111092, 111170);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 110954, 111208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 110954, 111208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitImplicitReceiver(BoundImplicitReceiver node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 111220, 111343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111320, 111332);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 111220, 111343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 111220, 111343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 111220, 111343);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFieldEqualsValue(BoundFieldEqualsValue node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 111355, 111516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111455, 111479);

                f_10877_111455_111478(this, f_10877_111467_111477(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111493, 111505);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 111355, 111516);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_111467_111477(Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 111467, 111477);
                    return return_v;
                }


                int
                f_10877_111455_111478(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 111455, 111478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 111355, 111516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 111355, 111516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPropertyEqualsValue(BoundPropertyEqualsValue node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 111528, 111695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111634, 111658);

                f_10877_111634_111657(this, f_10877_111646_111656(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111672, 111684);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 111528, 111695);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_111646_111656(Microsoft.CodeAnalysis.CSharp.BoundPropertyEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 111646, 111656);
                    return return_v;
                }


                int
                f_10877_111634_111657(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 111634, 111657);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 111528, 111695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 111528, 111695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitParameterEqualsValue(BoundParameterEqualsValue node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 111707, 111876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111815, 111839);

                f_10877_111815_111838(this, f_10877_111827_111837(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 111853, 111865);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 111707, 111876);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_111827_111837(Microsoft.CodeAnalysis.CSharp.BoundParameterEqualsValue
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 111827, 111837);
                    return return_v;
                }


                int
                f_10877_111815_111838(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 111815, 111838);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 111707, 111876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 111707, 111876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDeconstructValuePlaceholder(BoundDeconstructValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 111888, 112033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112010, 112022);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 111888, 112033);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 111888, 112033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 111888, 112033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectOrCollectionValuePlaceholder(BoundObjectOrCollectionValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112045, 112204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112181, 112193);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112045, 112204);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112045, 112204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112045, 112204);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitableValuePlaceholder(BoundAwaitableValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112216, 112357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112334, 112346);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112216, 112357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112216, 112357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112216, 112357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitOutVariablePendingInference(OutVariablePendingInference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112369, 112541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112493, 112530);

                throw f_10877_112499_112529();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112369, 112541);

                System.Exception
                f_10877_112499_112529()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 112499, 112529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112369, 112541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112369, 112541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitDeconstructionVariablePendingInference(DeconstructionVariablePendingInference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112553, 112747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112699, 112736);

                throw f_10877_112705_112735();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112553, 112747);

                System.Exception
                f_10877_112705_112735()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 112705, 112735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112553, 112747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112553, 112747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDiscardExpression(BoundDiscardExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112759, 112884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112861, 112873);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112759, 112884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112759, 112884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112759, 112884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol GetReadMethod(PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 112963, 113038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 112979, 113038);
                return f_10877_112979_113016(property) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10877, 112979, 113038) ?? f_10877_113020_113038(property)); DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 112963, 113038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 112963, 113038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 112963, 113038);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            f_10877_112979_113016(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            property)
            {
                var return_v = property.GetOwnOrInheritedGetMethod();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 112979, 113016);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10877_113020_113038(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.SetMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113020, 113038);
                return return_v;
            }

        }

        private static MethodSymbol GetWriteMethod(PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 113119, 113194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113135, 113194);
                return f_10877_113135_113172(property) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10877, 113135, 113194) ?? f_10877_113176_113194(property)); DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 113119, 113194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 113119, 113194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 113119, 113194);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
            f_10877_113135_113172(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            property)
            {
                var return_v = property.GetOwnOrInheritedSetMethod();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 113135, 113172);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10877_113176_113194(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.GetMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113176, 113194);
                return return_v;
            }

        }

        public override BoundNode VisitConstructorMethodBody(BoundConstructorMethodBody node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 113207, 113447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113317, 113341);

                f_10877_113317_113340(this, f_10877_113323_113339(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113355, 113410);

                f_10877_113355_113409(this, f_10877_113373_113387(node), f_10877_113389_113408(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113424, 113436);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 113207, 113447);

                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement?
                f_10877_113323_113339(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113323, 113339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_113317_113340(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 113317, 113340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10877_113373_113387(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113373, 113387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10877_113389_113408(Microsoft.CodeAnalysis.CSharp.BoundConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113389, 113408);
                    return return_v;
                }


                int
                f_10877_113355_113409(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                blockBody, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                expressionBody)
                {
                    this_param.VisitMethodBodies(blockBody, expressionBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 113355, 113409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 113207, 113447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 113207, 113447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNonConstructorMethodBody(BoundNonConstructorMethodBody node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 113459, 113667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113575, 113630);

                f_10877_113575_113629(this, f_10877_113593_113607(node), f_10877_113609_113628(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113644, 113656);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 113459, 113667);

                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10877_113593_113607(Microsoft.CodeAnalysis.CSharp.BoundNonConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.BlockBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113593, 113607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock?
                f_10877_113609_113628(Microsoft.CodeAnalysis.CSharp.BoundNonConstructorMethodBody
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113609, 113628);
                    return return_v;
                }


                int
                f_10877_113575_113629(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                blockBody, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                expressionBody)
                {
                    this_param.VisitMethodBodies(blockBody, expressionBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 113575, 113629);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 113459, 113667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 113459, 113667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitNullCoalescingAssignmentOperator(BoundNullCoalescingAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 113679, 115127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113811, 113833);

                TLocalState
                leftState
                = default(TLocalState);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 113847, 115038) || true) && (f_10877_113851_113890(this, f_10877_113873_113889(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 113851, 113960) && (BoundPropertyAccess)f_10877_113932_113948(node) is var left) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 113851, 114016) && f_10877_113981_114000(left) is var property) && (DynAbs.Tracing.TraceSender.Expression_True(10877, 113851, 114069) && f_10877_114037_114053(property) == RefKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 113847, 115038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114103, 114158);

                    var
                    readMethod = f_10877_114120_114157(property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114178, 114232);

                    f_10877_114178_114231(this, f_10877_114202_114218(left), readMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114250, 114303);

                    f_10877_114250_114302(this, f_10877_114273_114289(left), readMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114323, 114359);

                    var
                    savedState = f_10877_114340_114358(this.State)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114377, 114433);

                    f_10877_114377_114432(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114451, 114482);

                    leftState = f_10877_114463_114481(this.State);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114500, 114521);

                    f_10877_114500_114520(this, savedState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114539, 114593);

                    f_10877_114539_114592(this, node, left);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 113847, 115038);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 113847, 115038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114659, 114716);

                    f_10877_114659_114715(this, f_10877_114671_114687(node), isKnownToBeAnLvalue: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114734, 114770);

                    var
                    savedState = f_10877_114751_114769(this.State)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114788, 114844);

                    f_10877_114788_114843(this, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114862, 114893);

                    leftState = f_10877_114874_114892(this.State);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114911, 114932);

                    f_10877_114911_114931(this, savedState);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 114950, 115023);

                    f_10877_114950_115022(this, node, propertyAccessOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 113847, 115038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115054, 115090);

                f_10877_115054_115089(this, ref this.State, ref leftState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115104, 115116);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 113679, 115127);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_113873_113889(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113873, 113889);
                    return return_v;
                }


                bool
                f_10877_113851_113890(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.RegularPropertyAccess(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 113851, 113890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_113932_113948(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113932, 113948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_113981_114000(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 113981, 114000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10877_114037_114053(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 114037, 114053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_114120_114157(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114120, 114157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_114202_114218(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 114202, 114218);
                    return return_v;
                }


                int
                f_10877_114178_114231(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitReceiverBeforeCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114178, 114231);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_114273_114289(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 114273, 114289);
                    return return_v;
                }


                int
                f_10877_114250_114302(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    this_param.VisitReceiverAfterCall(receiverOpt, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114250, 114302);
                    return 0;
                }


                TLocalState
                f_10877_114340_114358(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114340, 114358);
                    return return_v;
                }


                int
                f_10877_114377_114432(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node)
                {
                    this_param.AdjustStateForNullCoalescingAssignmentNonNullCase(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114377, 114432);
                    return 0;
                }


                TLocalState
                f_10877_114463_114481(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114463, 114481);
                    return return_v;
                }


                int
                f_10877_114500_114520(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114500, 114520);
                    return 0;
                }


                int
                f_10877_114539_114592(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                propertyAccessOpt)
                {
                    this_param.VisitAssignmentOfNullCoalescingAssignment(node, propertyAccessOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114539, 114592);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_114671_114687(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 114671, 114687);
                    return return_v;
                }


                int
                f_10877_114659_114715(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, bool
                isKnownToBeAnLvalue)
                {
                    this_param.VisitRvalue(node, isKnownToBeAnLvalue: isKnownToBeAnLvalue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114659, 114715);
                    return 0;
                }


                TLocalState
                f_10877_114751_114769(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114751, 114769);
                    return return_v;
                }


                int
                f_10877_114788_114843(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node)
                {
                    this_param.AdjustStateForNullCoalescingAssignmentNonNullCase(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114788, 114843);
                    return 0;
                }


                TLocalState
                f_10877_114874_114892(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114874, 114892);
                    return return_v;
                }


                int
                f_10877_114911_114931(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114911, 114931);
                    return 0;
                }


                int
                f_10877_114950_115022(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                propertyAccessOpt)
                {
                    this_param.VisitAssignmentOfNullCoalescingAssignment(node, propertyAccessOpt: propertyAccessOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 114950, 115022);
                    return 0;
                }


                bool
                f_10877_115054_115089(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 115054, 115089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 113679, 115127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 113679, 115127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReadOnlySpanFromArray(BoundReadOnlySpanFromArray node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 115139, 115312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115249, 115275);

                f_10877_115249_115274(this, f_10877_115261_115273(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115289, 115301);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 115139, 115312);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_115261_115273(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115261, 115273);
                    return return_v;
                }


                int
                f_10877_115249_115274(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 115249, 115274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 115139, 115312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 115139, 115312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFunctionPointerInvocation(BoundFunctionPointerInvocation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 115324, 115612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115442, 115472);

                f_10877_115442_115471(this, f_10877_115448_115470(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115486, 115575);

                f_10877_115486_115574(this, f_10877_115501_115515(node), f_10877_115517_115541(node), f_10877_115543_115573(f_10877_115543_115563(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115589, 115601);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 115324, 115612);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_115448_115470(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.InvokedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115448, 115470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_115442_115471(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 115442, 115471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10877_115501_115515(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115501, 115515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10877_115517_115541(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115517, 115541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10877_115543_115563(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerInvocation
                this_param)
                {
                    var return_v = this_param.FunctionPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115543, 115563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10877_115543_115573(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115543, 115573);
                    return return_v;
                }


                int
                f_10877_115486_115574(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                refKindsOpt, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                method)
                {
                    this_param.VisitArguments(arguments, refKindsOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 115486, 115574);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 115324, 115612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 115324, 115612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUnconvertedAddressOfOperator(BoundUnconvertedAddressOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 115624, 116006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115949, 115969);

                f_10877_115949_115968(this, f_10877_115955_115967(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 115983, 115995);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 115624, 116006);

                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10877_115955_115967(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 115955, 115967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_115949_115968(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 115949, 115968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 115624, 116006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 115624, 116006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void VisitAssignmentOfNullCoalescingAssignment(
                    BoundNullCoalescingAssignmentOperator node,
                    BoundPropertyAccess propertyAccessOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 116184, 116718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116383, 116414);

                f_10877_116383_116413(this, f_10877_116395_116412(node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116428, 116707) || true) && (propertyAccessOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 116428, 116707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116491, 116537);

                    var
                    symbol = f_10877_116504_116536(propertyAccessOpt)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116555, 116609);

                    var
                    writeMethod = f_10877_116573_116608(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116627, 116692);

                    f_10877_116627_116691(this, node, f_10877_116648_116677(propertyAccessOpt), writeMethod);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 116428, 116707);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 116184, 116718);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10877_116395_116412(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 116395, 116412);
                    return return_v;
                }


                int
                f_10877_116383_116413(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    this_param.VisitRvalue(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 116383, 116413);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10877_116504_116536(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 116504, 116536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10877_116573_116608(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 116573, 116608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10877_116648_116677(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 116648, 116677);
                    return return_v;
                }


                int
                f_10877_116627_116691(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                setter)
                {
                    this_param.PropertySetter((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, receiver, setter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 116627, 116691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 116184, 116718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 116184, 116718);
            }
        }

        public override BoundNode VisitSavePreviousSequencePoint(BoundSavePreviousSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 116730, 116871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 116848, 116860);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 116730, 116871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 116730, 116871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 116730, 116871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRestorePreviousSequencePoint(BoundRestorePreviousSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 116883, 117030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117007, 117019);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 116883, 117030);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 116883, 117030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 116883, 117030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitStepThroughSequencePoint(BoundStepThroughSequencePoint node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 117042, 117181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117158, 117170);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 117042, 117181);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 117042, 117181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 117042, 117181);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void AdjustStateForNullCoalescingAssignmentNonNullCase(BoundNullCoalescingAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 117399, 117537);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 117399, 117537);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 117399, 117537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 117399, 117537);
            }
        }

        private void VisitMethodBodies(BoundBlock blockBody, BoundBlock expressionBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10877, 117549, 118923);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117653, 117906) || true) && (blockBody == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 117653, 117906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117708, 117730);

                    f_10877_117708_117729(this, expressionBody);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117748, 117755);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 117653, 117906);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 117653, 117906);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117789, 117906) || true) && (expressionBody == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10877, 117789, 117906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117849, 117866);

                        f_10877_117849_117865(this, blockBody);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 117884, 117891);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 117789, 117906);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10877, 117653, 117906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118659, 118705);

                TLocalState
                initialState = f_10877_118686_118704(this.State)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118719, 118736);

                f_10877_118719_118735(this, blockBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118750, 118786);

                TLocalState
                afterBlock = this.State
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118800, 118823);

                f_10877_118800_118822(this, initialState);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118837, 118859);

                f_10877_118837_118858(this, expressionBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10877, 118875, 118912);

                f_10877_118875_118911(this, ref this.State, ref afterBlock);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10877, 117549, 118923);

                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_117708_117729(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 117708, 117729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_117849_117865(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 117849, 117865);
                    return return_v;
                }


                TLocalState
                f_10877_118686_118704(TLocalState
                this_param)
                {
                    var return_v = this_param.Clone();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 118686, 118704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_118719_118735(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 118719, 118735);
                    return return_v;
                }


                int
                f_10877_118800_118822(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, TLocalState
                newState)
                {
                    this_param.SetState(newState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 118800, 118822);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10877_118837_118858(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 118837, 118858);
                    return return_v;
                }


                bool
                f_10877_118875_118911(Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>
                this_param, ref TLocalState
                self, ref TLocalState
                other)
                {
                    var return_v = this_param.Join(ref self, ref other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 118875, 118911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10877, 117549, 118923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 117549, 118923);
            }
        }

        static AbstractFlowPass()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10877, 1679, 118959);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10877, 1679, 118959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10877, 1679, 118959);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10877, 1679, 118959);

        int
        f_10877_9035_9061(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9035, 9061);
            return 0;
        }


        int
        f_10877_9262_9297(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9262, 9297);
            return 0;
        }


        int
        f_10877_9316_9350(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9316, 9350);
            return 0;
        }


        int
        f_10877_9389_9419(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SpanStart;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10877, 9389, 9419);
            return return_v;
        }


        int
        f_10877_9562_9614(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9562, 9614);
            return 0;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_10877_9651_9686(int
        start, int
        length)
        {
            var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9651, 9686);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<TLocalState, TLocalFunctionState>.PendingBranch>
        f_10877_9736_9777()
        {
            var return_v = ArrayBuilder<PendingBranch>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9736, 9777);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundStatement>
        f_10877_9806_9849()
        {
            var return_v = PooledHashSet<BoundStatement>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9806, 9849);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, TLocalState>
        f_10877_9874_9930()
        {
            var return_v = PooledDictionary<LabelSymbol, TLocalState>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9874, 9930);
            return return_v;
        }


        Microsoft.CodeAnalysis.DiagnosticBag
        f_10877_9964_9991()
        {
            var return_v = DiagnosticBag.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 9964, 9991);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundLoopStatement, TLocalState>
        f_10877_10273_10356(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundLoopStatement, TLocalState>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.BoundLoopStatement>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10877, 10273, 10356);
            return return_v;
        }

    }

    /// <summary>
    /// The possible places that we are processing when there is a region.
    /// </summary>
    /// <remarks>
    /// This should be nested inside <see cref="AbstractFlowPass{TLocalState, TLocalFunctionState}"/> but is not due to https://github.com/dotnet/roslyn/issues/36992 .
    /// </remarks>
    internal enum RegionPlace { Before, Inside, After };
}

