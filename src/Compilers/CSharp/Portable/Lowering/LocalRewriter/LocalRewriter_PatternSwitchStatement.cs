// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalRewriter
    {
        public override BoundNode VisitSwitchStatement(BoundSwitchStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10517, 489, 654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 587, 643);

                return f_10517_594_642(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10517, 489, 654);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10517_594_642(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                localRewriter, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                node)
                {
                    var return_v = SwitchStatementLocalRewriter.Rewrite(localRewriter, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 594, 642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10517, 489, 654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 489, 654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SwitchStatementLocalRewriter : BaseSwitchLocalRewriter
        {
            private readonly Dictionary<SyntaxNode, LabelSymbol> _sectionLabels;

            public static BoundStatement Rewrite(LocalRewriter localRewriter, BoundSwitchStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10517, 1042, 1395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1167, 1236);

                    var
                    rewriter = f_10517_1182_1235(node, localRewriter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1254, 1314);

                    BoundStatement
                    result = f_10517_1278_1313(rewriter, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1332, 1348);

                    f_10517_1332_1347(rewriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1366, 1380);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10517, 1042, 1395);

                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter
                    f_10517_1182_1235(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    node, Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    localRewriter)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter(node, localRewriter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 1182, 1235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10517_1278_1313(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    node)
                    {
                        var return_v = this_param.LowerSwitchStatement(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 1278, 1313);
                        return return_v;
                    }


                    int
                    f_10517_1332_1347(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 1332, 1347);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10517, 1042, 1395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 1042, 1395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override LabelSymbol GetDagNodeLabel(BoundDecisionDagNode dag)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10517, 1668, 2757);
                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol replacementLabel = default(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1773, 1812);

                    var
                    result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetDagNodeLabel(dag), 10517, 1786, 1811)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1830, 2708) || true) && (dag is BoundLeafDecisionDagNode d)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 1830, 2708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 1909, 1947);

                        SyntaxNode?
                        section = f_10517_1931_1946(d.Syntax)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 2322, 2689) || true) && (f_10517_2334_2341(section) == SyntaxKind.SwitchSection)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 2322, 2689);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 2419, 2602) || true) && (f_10517_2423_2493(_sectionLabels, section, out replacementLabel))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 2419, 2602);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 2551, 2575);

                                return replacementLabel;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 2419, 2602);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 2630, 2666);

                            f_10517_2630_2665(
                                                    _sectionLabels, section, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 2322, 2689);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 1830, 2708);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 2728, 2742);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10517, 1668, 2757);

                    Microsoft.CodeAnalysis.SyntaxNode?
                    f_10517_1931_1946(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Parent;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 1931, 1946);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                    f_10517_2334_2341(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node?.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 2334, 2341);
                        return return_v;
                    }


                    bool
                    f_10517_2423_2493(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 2423, 2493);
                        return return_v;
                    }


                    int
                    f_10517_2630_2665(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 2630, 2665);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10517, 1668, 2757);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 1668, 2757);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private SwitchStatementLocalRewriter(BoundSwitchStatement node, LocalRewriter localRewriter)
            : base(f_10517_2890_2901_C(node.Syntax), localRewriter, node.SwitchSections.SelectAsArray(section => section.Syntax),                      // Only add instrumentation (such as sequence points) if the node is not compiler-generated.
                                  generateInstrumentation: f_10517_3144_3168(localRewriter) && (DynAbs.Tracing.TraceSender.Expression_True(10517, 3144, 3198) && f_10517_3172_3198_M(!node.WasCompilerGenerated)))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10517, 2773, 3229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 953, 1025);
                    this._sectionLabels = f_10517_970_1025(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10517, 2773, 3229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10517, 2773, 3229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 2773, 3229);
                }
            }

            private BoundStatement LowerSwitchStatement(BoundSwitchStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10517, 3245, 9396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3348, 3378);

                    _factory.Syntax = node.Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3396, 3452);

                    var
                    result = f_10517_3409_3451()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3470, 3531);

                    var
                    outerVariables = f_10517_3491_3530()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3549, 3636);

                    var
                    loweredSwitchGoverningExpression = f_10517_3588_3635(_localRewriter, f_10517_3619_3634(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3654, 4761) || true) && (f_10517_3658_3684_M(!node.WasCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10517, 3658, 3713) && f_10517_3688_3713(_localRewriter)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 3654, 4761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 3979, 4123);

                        var
                        instrumentedExpression = f_10517_4008_4122(_localRewriter._instrumenter, node, loweredSwitchGoverningExpression, _factory)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 4145, 4742) || true) && (f_10517_4149_4195(loweredSwitchGoverningExpression) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 4145, 4742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 4253, 4311);

                            loweredSwitchGoverningExpression = instrumentedExpression;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 4145, 4742);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 4145, 4742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 4654, 4719);

                            f_10517_4654_4718(                        // If the expression is a constant, we leave it alone (the decision dag lowering code needs
                                                                      // to see that constant). But we add an additional leading statement with the instrumented expression.
                                                    result, f_10517_4665_4717(_factory, instrumentedExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 4145, 4742);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 3654, 4761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 4850, 4892);

                    f_10517_4850_4891(
                                    // The set of variables attached to the outer block
                                    outerVariables, f_10517_4874_4890(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5004, 5139);

                    BoundDecisionDag
                    decisionDag = f_10517_5035_5138(this, f_10517_5072_5088(node), loweredSwitchGoverningExpression, result, out _)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5493, 5888) || true) && (f_10517_5497_5520())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 5493, 5888);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5699, 5802) || true) && (f_10517_5703_5715(result) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 5699, 5802);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5747, 5802);

                            f_10517_5747_5801(result, f_10517_5758_5800(_factory, NoOpStatementFlavor.Default));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 5699, 5802);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5826, 5869);

                        f_10517_5826_5868(
                                            result, f_10517_5837_5867(_factory));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 5493, 5888);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 5952, 6129);

                    (ImmutableArray<BoundStatement> loweredDag, ImmutableDictionary<SyntaxNode, ImmutableArray<BoundStatement>> switchSections) =
                    f_10517_6099_6128(this, decisionDag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6233, 6272);

                    f_10517_6233_6271(
                                    // then add the rest of the lowered dag that references that input
                                    result, f_10517_6244_6270(_factory, loweredDag));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6526, 8359);
                        foreach (BoundSwitchSection section in f_10517_6565_6584_I(f_10517_6565_6584(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 6526, 8359);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6626, 6659);

                            _factory.Syntax = section.Syntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6681, 6745);

                            var
                            sectionBuilder = f_10517_6702_6744()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6767, 6823);

                            f_10517_6767_6822(sectionBuilder, f_10517_6791_6821(switchSections, section.Syntax));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6845, 7033);
                                foreach (BoundSwitchLabel switchLabel in f_10517_6886_6906_I(f_10517_6886_6906(section)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 6845, 7033);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 6956, 7010);

                                    f_10517_6956_7009(sectionBuilder, f_10517_6975_7008(_factory, f_10517_6990_7007(switchLabel)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 6845, 7033);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10517, 1, 189);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10517, 1, 189);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 7127, 7197);

                            f_10517_7127_7196(
                                                // Add the translated body of the switch section
                                                sectionBuilder, f_10517_7151_7195(_localRewriter, f_10517_7176_7194(section)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 7443, 7523);

                            ImmutableArray<BoundStatement>
                            statements = f_10517_7487_7522(sectionBuilder)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 7547, 8340) || true) && (section.Locals.IsEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 7547, 8340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 7623, 7670);

                                f_10517_7623_7669(result, f_10517_7634_7668(_factory, statements));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 7547, 8340);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 7547, 8340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 7991, 8031);

                                f_10517_7991_8030(                        // Lifetime of these locals is expanded to the entire switch body, as it is possible to capture
                                                                          // them in a different section by using a local function as an intermediary.
                                                        outerVariables, f_10517_8015_8029(section));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8246, 8317);

                                f_10517_8246_8316(
                                                        // Note the language scope of the locals, even though they are included for the purposes of
                                                        // lifetime analysis in the enclosing scope.
                                                        result, f_10517_8257_8315(section.Syntax, f_10517_8288_8302(section), statements));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 7547, 8340);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 6526, 8359);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10517, 1, 1834);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10517, 1, 1834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8734, 8785);

                    f_10517_8734_8784(
                                    // Dispatch temps are in scope throughout the switch statement, as they are used
                                    // both in the dispatch section to hold temporary values from the translation of
                                    // the decision dag, and in the branches where the temp values are assigned to the
                                    // pattern variables of matched patterns.
                                    outerVariables, f_10517_8758_8783(_tempAllocator));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8805, 8835);

                    _factory.Syntax = node.Syntax;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8853, 8946) || true) && (f_10517_8857_8880())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 8853, 8946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8903, 8946);

                        f_10517_8903_8945(result, f_10517_8914_8944(_factory));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 8853, 8946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 8966, 9010);

                    f_10517_8966_9009(
                                    result, f_10517_8977_9008(_factory, f_10517_8992_9007(node)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 9028, 9169);

                    BoundStatement
                    translatedSwitch = f_10517_9062_9168(_factory, f_10517_9077_9112(outerVariables), f_10517_9114_9138(node), f_10517_9140_9167(result))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 9189, 9337) || true) && (f_10517_9193_9216())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10517, 9189, 9337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 9239, 9337);

                        translatedSwitch = f_10517_9258_9336(_localRewriter._instrumenter, node, translatedSwitch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10517, 9189, 9337);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10517, 9357, 9381);

                    return translatedSwitch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10517, 3245, 9396);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_3409_3451()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 3409, 3451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_3491_3530()
                    {
                        var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 3491, 3530);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10517_3619_3634(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 3619, 3634);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10517_3588_3635(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 3588, 3635);
                        return return_v;
                    }


                    bool
                    f_10517_3658_3684_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 3658, 3684);
                        return return_v;
                    }


                    bool
                    f_10517_3688_3713(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param)
                    {
                        var return_v = this_param.Instrument;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 3688, 3713);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10517_4008_4122(Microsoft.CodeAnalysis.CSharp.Instrumenter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenExpression, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    factory)
                    {
                        var return_v = this_param.InstrumentSwitchStatementExpression((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewrittenExpression, factory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 4008, 4122);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10517_4149_4195(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.ConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 4149, 4195);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10517_4665_4717(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 4665, 4717);
                        return return_v;
                    }


                    int
                    f_10517_4654_4718(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 4654, 4718);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_4874_4890(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 4874, 4890);
                        return return_v;
                    }


                    int
                    f_10517_4850_4891(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 4850, 4891);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10517_5072_5088(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.DecisionDag;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 5072, 5088);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10517_5035_5138(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredSwitchGoverningExpression, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    result, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    savedInputExpression)
                    {
                        var return_v = this_param.ShareTempsIfPossibleAndEvaluateInput(decisionDag, loweredSwitchGoverningExpression, result, out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 5035, 5138);
                        return return_v;
                    }


                    bool
                    f_10517_5497_5520()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 5497, 5520);
                        return return_v;
                    }


                    int
                    f_10517_5703_5715(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 5703, 5715);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10517_5758_5800(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.NoOpStatementFlavor
                    noOpStatementFlavor)
                    {
                        var return_v = this_param.NoOp(noOpStatementFlavor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 5758, 5800);
                        return return_v;
                    }


                    int
                    f_10517_5747_5801(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 5747, 5801);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10517_5837_5867(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.HiddenSequencePoint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 5837, 5867);
                        return return_v;
                    }


                    int
                    f_10517_5826_5868(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 5826, 5868);
                        return 0;
                    }


                    (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement> loweredDag, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>> switchSections)
                    f_10517_6099_6128(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchStatementLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag)
                    {
                        var return_v = this_param.LowerDecisionDag(decisionDag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6099, 6128);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10517_6244_6270(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6244, 6270);
                        return return_v;
                    }


                    int
                    f_10517_6233_6271(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6233, 6271);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                    f_10517_6565_6584(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.SwitchSections;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 6565, 6584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_6702_6744()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6702, 6744);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_6791_6821(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 6791, 6821);
                        return return_v;
                    }


                    int
                    f_10517_6767_6822(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6767, 6822);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                    f_10517_6886_6906(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.SwitchLabels;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 6886, 6906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10517_6990_7007(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 6990, 7007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10517_6975_7008(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6975, 7008);
                        return return_v;
                    }


                    int
                    f_10517_6956_7009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6956, 7009);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                    f_10517_6886_6906_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6886, 6906);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_7176_7194(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.Statements;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 7176, 7194);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_7151_7195(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    list)
                    {
                        var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundStatement>(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7151, 7195);
                        return return_v;
                    }


                    int
                    f_10517_7127_7196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7127, 7196);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_7487_7522(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7487, 7522);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatementList
                    f_10517_7634_7668(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.StatementList(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7634, 7668);
                        return return_v;
                    }


                    int
                    f_10517_7623_7669(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7623, 7669);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_8015_8029(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 8015, 8029);
                        return return_v;
                    }


                    int
                    f_10517_7991_8030(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 7991, 8030);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_8288_8302(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 8288, 8302);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundScope
                    f_10517_8257_8315(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundScope(syntax, locals, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8257, 8315);
                        return return_v;
                    }


                    int
                    f_10517_8246_8316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundScope
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8246, 8316);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                    f_10517_6565_6584_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 6565, 6584);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_8758_8783(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param)
                    {
                        var return_v = this_param.AllTemps();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8758, 8783);
                        return return_v;
                    }


                    int
                    f_10517_8734_8784(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8734, 8784);
                        return 0;
                    }


                    bool
                    f_10517_8857_8880()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 8857, 8880);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10517_8914_8944(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.HiddenSequencePoint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8914, 8944);
                        return return_v;
                    }


                    int
                    f_10517_8903_8945(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8903, 8945);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10517_8992_9007(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.BreakLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 8992, 9007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10517_8977_9008(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    label)
                    {
                        var return_v = this_param.Label((Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol)label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8977, 9008);
                        return return_v;
                    }


                    int
                    f_10517_8966_9009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 8966, 9009);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10517_9077_9112(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 9077, 9112);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    f_10517_9114_9138(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    this_param)
                    {
                        var return_v = this_param.InnerLocalFunctions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 9114, 9138);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10517_9140_9167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 9140, 9167);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10517_9062_9168(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                    localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.Block(locals, localFunctions, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 9062, 9168);
                        return return_v;
                    }


                    bool
                    f_10517_9193_9216()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 9193, 9216);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10517_9258_9336(Microsoft.CodeAnalysis.CSharp.Instrumenter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                    original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    rewritten)
                    {
                        var return_v = this_param.InstrumentSwitchStatement(original, rewritten);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 9258, 9336);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10517, 3245, 9396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 3245, 9396);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SwitchStatementLocalRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10517, 666, 9407);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10517, 666, 9407);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10517, 666, 9407);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10517, 666, 9407);

            Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
            f_10517_970_1025()
            {
                var return_v = PooledDictionary<SyntaxNode, LabelSymbol>.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10517, 970, 1025);
                return return_v;
            }


            static bool
            f_10517_3144_3168(Microsoft.CodeAnalysis.CSharp.LocalRewriter
            this_param)
            {
                var return_v = this_param.Instrument;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 3144, 3168);
                return return_v;
            }


            static bool
            f_10517_3172_3198_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10517, 3172, 3198);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode
            f_10517_2890_2901_C(Microsoft.CodeAnalysis.SyntaxNode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10517, 2773, 3229);
                return return_v;
            }

        }
    }
}
