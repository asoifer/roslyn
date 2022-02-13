// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class SwitchExpressionBinder : Binder
    {
        private readonly SwitchExpressionSyntax SwitchExpressionSyntax;

        private BoundExpression _inputExpression;

        private DiagnosticBag _inputExpressionDiagnostics;

        internal SwitchExpressionBinder(SwitchExpressionSyntax switchExpressionSyntax, Binder next)
        : base(f_10372_978_982_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10372, 866, 1067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 718, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 777, 793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 826, 853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1008, 1056);

                SwitchExpressionSyntax = switchExpressionSyntax;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10372, 866, 1067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 866, 1067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 866, 1067);
            }
        }

        internal override BoundExpression BindSwitchExpressionCore(SwitchExpressionSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 1079, 2424);
                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag decisionDag = default(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag);
                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol defaultLabel = default(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1241, 1286);

                f_10372_1241_1285(node == SwitchExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1376, 1419);

                var
                boundInputExpression = f_10372_1403_1418()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1433, 1482);

                f_10372_1433_1481(diagnostics, f_10372_1454_1480());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1496, 1610);

                ImmutableArray<BoundSwitchExpressionArm>
                switchArms = f_10372_1550_1609(this, node, originalBinder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1624, 1690);

                TypeSymbol
                naturalType = f_10372_1649_1689(this, switchArms, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 1704, 1882);

                bool
                reportedNotExhaustive = f_10372_1733_1881(this, node, boundInputExpression, switchArms, out decisionDag, out defaultLabel, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 2089, 2172);

                decisionDag = f_10372_2103_2171(decisionDag, boundInputExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 2188, 2413);

                return f_10372_2195_2412(node, boundInputExpression, switchArms, decisionDag, defaultLabel: defaultLabel, reportedNotExhaustive: reportedNotExhaustive, type: naturalType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 1079, 2424);

                int
                f_10372_1241_1285(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 1241, 1285);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_1403_1418()
                {
                    var return_v = InputExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 1403, 1418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10372_1454_1480()
                {
                    var return_v = InputExpressionDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 1454, 1480);
                    return return_v;
                }


                int
                f_10372_1433_1481(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 1433, 1481);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_1550_1609(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchExpressionArms(node, originalBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 1550, 1609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10372_1649_1689(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchCases, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.InferResultType(switchCases, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 1649, 1689);
                    return return_v;
                }


                bool
                f_10372_1733_1881(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundInputExpression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchArms, out Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, out Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckSwitchExpressionExhaustive(node, boundInputExpression, switchArms, out decisionDag, out defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 1733, 1881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10372_2103_2171(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                input)
                {
                    var return_v = this_param.SimplifyDecisionDagIfConstantInput(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 2103, 2171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                f_10372_2195_2412(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchArms, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, bool
                reportedNotExhaustive, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, expression, switchArms, decisionDag, defaultLabel: defaultLabel, reportedNotExhaustive: reportedNotExhaustive, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 2195, 2412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 1079, 2424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 1079, 2424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckSwitchExpressionExhaustive(
                    SwitchExpressionSyntax node,
                    BoundExpression boundInputExpression,
                    ImmutableArray<BoundSwitchExpressionArm> switchArms,
                    out BoundDecisionDag decisionDag,
                    out LabelSymbol defaultLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 2946, 6779);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode> nodes = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>);
                bool requiresFalseWhenClause = default(bool);
                bool unnamedEnumValue = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3305, 3356);

                defaultLabel = f_10372_3320_3355("default");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3370, 3525);

                decisionDag = f_10372_3384_3524(f_10372_3440_3456(this), node, boundInputExpression, switchArms, defaultLabel, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3539, 3589);

                var
                reachableLabels = f_10372_3561_3588(decisionDag)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3603, 3626);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3640, 3978);
                    foreach (BoundSwitchExpressionArm arm in f_10372_3681_3691_I(switchArms))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 3640, 3978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3725, 3752);

                        hasErrors |= f_10372_3738_3751(arm);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3770, 3963) || true) && (!hasErrors && (DynAbs.Tracing.TraceSender.Expression_True(10372, 3774, 3824) && !f_10372_3789_3824(reachableLabels, f_10372_3814_3823(arm))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 3770, 3963);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3866, 3944);

                            f_10372_3866_3943(diagnostics, ErrorCode.ERR_SwitchArmSubsumed, f_10372_3915_3942(f_10372_3915_3926(arm).Syntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 3770, 3963);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 3640, 3978);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10372, 1, 339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10372, 1, 339);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 3994, 4215) || true) && (!f_10372_3999_4037(reachableLabels, defaultLabel))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 3994, 4215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4149, 4169);

                    defaultLabel = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4187, 4200);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 3994, 4215);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4231, 4275) || true) && (hasErrors)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 4231, 4275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4263, 4275);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 4231, 4275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4568, 4707);

                bool
                wasAcyclic = f_10372_4586_4706(new[] { f_10372_4649_4669(decisionDag) }, nonNullSuccessors, out nodes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4841, 4866);

                f_10372_4841_4865(wasAcyclic);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4880, 5856);
                    foreach (var n in f_10372_4898_4903_I(nodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 4880, 5856);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 4937, 5841) || true) && (n is BoundLeafDecisionDagNode leaf && (DynAbs.Tracing.TraceSender.Expression_True(10372, 4941, 5005) && f_10372_4979_4989(leaf) == defaultLabel))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 4937, 5841);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 5047, 5282);

                            var
                            samplePattern = f_10372_5067_5281(f_10372_5140_5191(boundInputExpression), nodes, n, nullPaths: false, out requiresFalseWhenClause, out unnamedEnumValue)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 5304, 5612);

                            ErrorCode
                            warningCode =
                            (DynAbs.Tracing.TraceSender.Conditional_F1(10372, 5353, 5376) || ((requiresFalseWhenClause && DynAbs.Tracing.TraceSender.Conditional_F2(10372, 5379, 5430)) || DynAbs.Tracing.TraceSender.Conditional_F3(10372, 5458, 5611))) ? ErrorCode.WRN_SwitchExpressionNotExhaustiveWithWhen : (DynAbs.Tracing.TraceSender.Conditional_F1(10372, 5458, 5474) || ((unnamedEnumValue && DynAbs.Tracing.TraceSender.Conditional_F2(10372, 5477, 5540)) || DynAbs.Tracing.TraceSender.Conditional_F3(10372, 5568, 5611))) ? ErrorCode.WRN_SwitchExpressionNotExhaustiveWithUnnamedEnumValue : ErrorCode.WRN_SwitchExpressionNotExhaustive
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 5634, 5788);

                            f_10372_5634_5787(diagnostics, warningCode, node.SwitchKeyword.GetLocation(), samplePattern);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 5810, 5822);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 4937, 5841);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 4880, 5856);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10372, 1, 977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10372, 1, 977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 5872, 5885);

                return false;

                ImmutableArray<BoundDecisionDagNode> nonNullSuccessors(BoundDecisionDagNode n)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 5901, 6768);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6012, 6753);

                        switch (n)
                        {

                            case BoundTestDecisionDagNode p:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 6012, 6753);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6121, 6640);

                                switch (f_10372_6129_6135(p))
                                {

                                    case BoundDagNonNullTest t: // checks that the input is not null
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 6121, 6640);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6291, 6332);

                                        return f_10372_6298_6331(f_10372_6320_6330(p));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 6121, 6640);

                                    case BoundDagExplicitNullTest t: // checks that the input is null
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 6121, 6640);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6461, 6503);

                                        return f_10372_6468_6502(f_10372_6490_6501(p));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 6121, 6640);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 6121, 6640);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6575, 6613);

                                        return f_10372_6582_6612(n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 6121, 6640);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 6012, 6753);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 6012, 6753);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 6696, 6734);

                                return f_10372_6703_6733(n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 6012, 6753);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 5901, 6768);

                        Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        f_10372_6129_6135(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                        this_param)
                        {
                            var return_v = this_param.Test;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 6129, 6135);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        f_10372_6320_6330(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                        this_param)
                        {
                            var return_v = this_param.WhenTrue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 6320, 6330);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                        f_10372_6298_6331(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 6298, 6331);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        f_10372_6490_6501(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                        this_param)
                        {
                            var return_v = this_param.WhenFalse;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 6490, 6501);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                        f_10372_6468_6502(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        item)
                        {
                            var return_v = ImmutableArray.Create(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 6468, 6502);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                        f_10372_6582_6612(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        node)
                        {
                            var return_v = BoundDecisionDag.Successors(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 6582, 6612);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                        f_10372_6703_6733(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                        node)
                        {
                            var return_v = BoundDecisionDag.Successors(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 6703, 6733);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 5901, 6768);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 5901, 6768);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 2946, 6779);

                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10372_3320_3355(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3320, 3355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10372_3440_3456(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3440, 3456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10372_3384_3524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                switchExpressionInput, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchArms, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecisionDagBuilder.CreateDecisionDagForSwitchExpression(compilation, (Microsoft.CodeAnalysis.SyntaxNode)syntax, switchExpressionInput, switchArms, defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3384, 3524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10372_3561_3588(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3561, 3588);
                    return return_v;
                }


                bool
                f_10372_3738_3751(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3738, 3751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10372_3814_3823(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3814, 3823);
                    return return_v;
                }


                bool
                f_10372_3789_3824(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3789, 3824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10372_3915_3926(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3915, 3926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10372_3915_3942(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 3915, 3942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10372_3866_3943(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3866, 3943);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_3681_3691_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3681, 3691);
                    return return_v;
                }


                bool
                f_10372_3999_4037(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 3999, 4037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10372_4649_4669(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.RootNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 4649, 4669);
                    return return_v;
                }


                bool
                f_10372_4586_4706(Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode[]
                nodes, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>>
                successors, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                result)
                {
                    var return_v = TopologicalSort.TryIterativeSort<BoundDecisionDagNode>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>)nodes, successors, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 4586, 4706);
                    return return_v;
                }


                int
                f_10372_4841_4865(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 4841, 4865);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10372_4979_4989(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 4979, 4989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10372_5140_5191(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = BoundDagTemp.ForOriginalInput(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 5140, 5191);
                    return return_v;
                }


                string
                f_10372_5067_5281(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                rootIdentifier, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                nodes, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                targetNode, bool
                nullPaths, out bool
                requiresFalseWhenClause, out bool
                unnamedEnumValue)
                {
                    var return_v = PatternExplainer.SamplePatternForPathToDagNode(rootIdentifier, nodes, targetNode, nullPaths: nullPaths, out requiresFalseWhenClause, out unnamedEnumValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 5067, 5281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10372_5634_5787(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 5634, 5787);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10372_4898_4903_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 4898, 4903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 2946, 6779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 2946, 6779);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol InferResultType(ImmutableArray<BoundSwitchExpressionArm> switchCases, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 6990, 8554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7130, 7228);

                var
                seenTypes = f_10372_7146_7227()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7242, 7300);

                var
                typesInOrder = f_10372_7261_7299()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7314, 7567);
                    foreach (var @case in f_10372_7336_7347_I(switchCases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 7314, 7567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7381, 7409);

                        var
                        type = f_10372_7392_7408(f_10372_7392_7403(@case))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7427, 7552) || true) && (type is object && (DynAbs.Tracing.TraceSender.Expression_True(10372, 7431, 7468) && f_10372_7449_7468(seenTypes, type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 7427, 7552);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7510, 7533);

                            f_10372_7510_7532(typesInOrder, type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 7427, 7552);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 7314, 7567);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10372, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10372, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7583, 7600);

                f_10372_7583_7599(
                            seenTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7614, 7664);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7678, 7775);

                var
                commonType = f_10372_7695_7774(typesInOrder, f_10372_7738_7749(), ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 7789, 7809);

                f_10372_7789_7808(typesInOrder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8027, 8435) || true) && (commonType is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 8027, 8435);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8085, 8420);
                        foreach (var @case in f_10372_8107_8118_I(switchCases))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 8085, 8420);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8160, 8401) || true) && (f_10372_8164_8278_M(!f_10372_8165_8271(f_10372_8165_8181(this), f_10372_8223_8234(@case), commonType, ref useSiteDiagnostics).Exists))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 8160, 8401);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8328, 8346);

                                commonType = null;
                                DynAbs.Tracing.TraceSender.TraceBreak(10372, 8372, 8378);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 8160, 8401);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 8085, 8420);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10372, 1, 336);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10372, 1, 336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 8027, 8435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8451, 8511);

                f_10372_8451_8510(
                            diagnostics, SwitchExpressionSyntax, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8525, 8543);

                return commonType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 6990, 8554);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10372_7146_7227()
                {
                    var return_v = Symbols.SpecializedSymbolCollections.GetPooledSymbolHashSetInstance<TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7146, 7227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10372_7261_7299()
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7261, 7299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_7392_7403(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 7392, 7403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10372_7392_7408(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 7392, 7408);
                    return return_v;
                }


                bool
                f_10372_7449_7468(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7449, 7468);
                    return return_v;
                }


                int
                f_10372_7510_7532(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7510, 7532);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_7336_7347_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7336, 7347);
                    return return_v;
                }


                int
                f_10372_7583_7599(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7583, 7599);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10372_7738_7749()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 7738, 7749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10372_7695_7774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                types, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = BestTypeInferrer.GetBestType(types, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7695, 7774);
                    return return_v;
                }


                int
                f_10372_7789_7808(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 7789, 7808);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10372_8165_8181(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8165, 8181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_8223_8234(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8223, 8234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10372_8165_8271(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8165, 8271);
                    return return_v;
                }


                bool
                f_10372_8164_8278_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8164, 8278);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_8107_8118_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8107, 8118);
                    return return_v;
                }


                bool
                f_10372_8451_8510(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add((Microsoft.CodeAnalysis.SyntaxNode)node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8451, 8510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 6990, 8554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 6990, 8554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<BoundSwitchExpressionArm> BindSwitchExpressionArms(SwitchExpressionSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 8566, 9193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8743, 8786);

                bool
                hasErrors = f_10372_8760_8785(f_10372_8760_8775())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8800, 8867);

                var
                builder = f_10372_8814_8866()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8881, 9130);
                    foreach (var arm in f_10372_8901_8910_I(f_10372_8901_8910(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 8881, 9130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 8944, 8990);

                        var
                        armBinder = f_10372_8960_8989(originalBinder, arm)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9008, 9075);

                        var
                        boundArm = f_10372_9023_9074(armBinder, arm, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9093, 9115);

                        f_10372_9093_9114(builder, boundArm);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 8881, 9130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10372, 1, 250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10372, 1, 250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9146, 9182);

                return f_10372_9153_9181(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 8566, 9193);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_8760_8775()
                {
                    var return_v = InputExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8760, 8775);
                    return return_v;
                }


                bool
                f_10372_8760_8785(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8760, 8785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_8814_8866()
                {
                    var return_v = ArrayBuilder<BoundSwitchExpressionArm>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8814, 8866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                f_10372_8901_8910(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 8901, 8910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10372_8960_8989(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8960, 8989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                f_10372_9023_9074(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchExpressionArm(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9023, 9074);
                    return return_v;
                }


                int
                f_10372_9093_9114(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9093, 9114);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                f_10372_8901_8910_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionArmSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 8901, 8910);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10372_9153_9181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9153, 9181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 8566, 9193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 8566, 9193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression InputExpression
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 9270, 9473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9306, 9359);

                    f_10372_9306_9358(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9377, 9416);

                    f_10372_9377_9415(_inputExpression != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9434, 9458);

                    return _inputExpression;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 9270, 9473);

                    int
                    f_10372_9306_9358(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                    this_param)
                    {
                        this_param.EnsureSwitchGoverningExpressionAndDiagnosticsBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9306, 9358);
                        return 0;
                    }


                    int
                    f_10372_9377_9415(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9377, 9415);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 9205, 9484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 9205, 9484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeSymbol SwitchGoverningType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 9536, 9559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9539, 9559);
                    return f_10372_9539_9559(f_10372_9539_9554()); DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 9536, 9559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 9536, 9559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 9536, 9559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal uint SwitchGoverningValEscape
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 9611, 9660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9614, 9660);
                    return f_10372_9614_9660(f_10372_9627_9642(), f_10372_9644_9659()); DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 9611, 9660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 9611, 9660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 9611, 9660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected DiagnosticBag InputExpressionDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 9748, 9973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9784, 9837);

                    f_10372_9784_9836(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9855, 9905);

                    f_10372_9855_9904(_inputExpressionDiagnostics != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 9923, 9958);

                    return _inputExpressionDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 9748, 9973);

                    int
                    f_10372_9784_9836(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                    this_param)
                    {
                        this_param.EnsureSwitchGoverningExpressionAndDiagnosticsBound();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9784, 9836);
                        return 0;
                    }


                    int
                    f_10372_9855_9904(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9855, 9904);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 9673, 9984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 9673, 9984);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureSwitchGoverningExpressionAndDiagnosticsBound()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 9996, 10521);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10086, 10510) || true) && (_inputExpression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 10086, 10510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10148, 10201);

                    var
                    switchGoverningDiagnostics = f_10372_10181_10200()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10219, 10314);

                    var
                    boundSwitchGoverningExpression = f_10372_10256_10313(this, switchGoverningDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10332, 10389);

                    _inputExpressionDiagnostics = switchGoverningDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10407, 10495);

                    f_10372_10407_10494(ref _inputExpression, boundSwitchGoverningExpression, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 10086, 10510);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 9996, 10521);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10372_10181_10200()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10181, 10200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_10256_10313(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchGoverningExpression(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10256, 10313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10372_10407_10494(ref Microsoft.CodeAnalysis.CSharp.BoundExpression?
                location1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10407, 10494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 9996, 10521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 9996, 10521);
            }
        }

        private BoundExpression BindSwitchGoverningExpression(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10372, 10533, 11257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10638, 10755);

                var
                switchGoverningExpression = f_10372_10670_10754(this, f_10372_10698_10740(SwitchExpressionSyntax), diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10769, 11197) || true) && (f_10372_10773_10803(switchGoverningExpression) == (object)null || (DynAbs.Tracing.TraceSender.Expression_False(10372, 10773, 10866) || f_10372_10823_10866(f_10372_10823_10853(switchGoverningExpression))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10372, 10769, 11197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 10900, 11040);

                    f_10372_10900_11039(diagnostics, ErrorCode.ERR_BadPatternExpression, f_10372_10952_11003(f_10372_10952_10994(SwitchExpressionSyntax)), f_10372_11005_11038(switchGoverningExpression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 11058, 11182);

                    switchGoverningExpression = f_10372_11086_11181(this, f_10372_11123_11140(this), switchGoverningExpression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10372, 10769, 11197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10372, 11213, 11246);

                return switchGoverningExpression;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10372, 10533, 11257);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10372_10698_10740(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 10698, 10740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_10670_10754(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindRValueWithoutTargetType(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10670, 10754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10372_10773_10803(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 10773, 10803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10372_10823_10853(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 10823, 10853);
                    return return_v;
                }


                bool
                f_10372_10823_10866(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10823, 10866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10372_10952_10994(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                this_param)
                {
                    var return_v = this_param.GoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 10952, 10994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10372_10952_11003(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 10952, 11003);
                    return return_v;
                }


                object
                f_10372_11005_11038(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 11005, 11038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10372_10900_11039(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 10900, 11039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10372_11123_11140(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 11123, 11140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10372_11086_11181(Microsoft.CodeAnalysis.CSharp.SwitchExpressionBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 11086, 11181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10372, 10533, 11257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 10533, 11257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SwitchExpressionBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10372, 615, 11264);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10372, 615, 11264);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10372, 615, 11264);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10372, 615, 11264);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10372_978_982_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10372, 866, 1067);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10372_9539_9554()
        {
            var return_v = InputExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 9539, 9554);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
        f_10372_9539_9559(Microsoft.CodeAnalysis.CSharp.BoundExpression
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 9539, 9559);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundExpression
        f_10372_9627_9642()
        {
            var return_v = InputExpression;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 9627, 9642);
            return return_v;
        }


        uint
        f_10372_9644_9659()
        {
            var return_v = LocalScopeDepth;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10372, 9644, 9659);
            return return_v;
        }


        uint
        f_10372_9614_9660(Microsoft.CodeAnalysis.CSharp.BoundExpression
        expr, uint
        scopeOfTheContainingExpression)
        {
            var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10372, 9614, 9660);
            return return_v;
        }

    }
}
