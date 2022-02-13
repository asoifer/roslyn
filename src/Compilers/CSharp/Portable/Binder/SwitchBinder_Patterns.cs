// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SwitchBinder : LocalScopeBinder
    {
        internal static SwitchBinder Create(Binder next, SwitchStatementSyntax switchSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10370, 645, 809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 754, 798);

                return f_10370_761_797(next, switchSyntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10370, 645, 809);

                Microsoft.CodeAnalysis.CSharp.SwitchBinder
                f_10370_761_797(Microsoft.CodeAnalysis.CSharp.Binder
                next, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                switchSyntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SwitchBinder(next, switchSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 761, 797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 645, 809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 645, 809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundStatement BindSwitchStatementCore(SwitchStatementSyntax node, Binder originalBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 988, 3362);
                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel defaultLabel = default(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1147, 1187);

                f_10370_1147_1186(f_10370_1160_1185(SwitchSyntax, node));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1203, 1358) || true) && (node.Sections.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 1203, 1358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1265, 1343);

                    f_10370_1265_1342(diagnostics, ErrorCode.WRN_EmptySwitch, node.OpenBraceToken.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 1203, 1358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1448, 1523);

                BoundExpression
                boundSwitchGoverningExpression = f_10370_1497_1522()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1537, 1586);

                f_10370_1537_1585(diagnostics, f_10370_1558_1584());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1602, 1737);

                ImmutableArray<BoundSwitchSection>
                switchSections = f_10370_1654_1736(this, originalBinder, diagnostics, out defaultLabel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1751, 1820);

                ImmutableArray<LocalSymbol>
                locals = f_10370_1788_1819(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1834, 1922);

                ImmutableArray<LocalFunctionSymbol>
                functions = f_10370_1882_1921(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 1936, 2431);

                BoundDecisionDag
                decisionDag = f_10370_1967_2430(compilation: f_10370_2053_2069(this), syntax: node, switchGoverningExpression: boundSwitchGoverningExpression, switchSections: switchSections, defaultLabel: f_10370_2366_2385_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(defaultLabel, 10370, 2366, 2385)?.Label) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?>(10370, 2366, 2399) ?? f_10370_2389_2399()), diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 2538, 2640);

                f_10370_2538_2639(this, node, boundSwitchGoverningExpression, ref switchSections, decisionDag, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 2847, 2940);

                decisionDag = f_10370_2861_2939(decisionDag, boundSwitchGoverningExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 2956, 3351);

                return f_10370_2963_3350(syntax: node, expression: boundSwitchGoverningExpression, innerLocals: locals, innerLocalFunctions: functions, switchSections: switchSections, defaultLabel: defaultLabel, breakLabel: f_10370_3291_3306(this), decisionDag: decisionDag);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 988, 3362);

                bool
                f_10370_1160_1185(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1160, 1185);
                    return return_v;
                }


                int
                f_10370_1147_1186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1147, 1186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_1265_1342(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1265, 1342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10370_1497_1522()
                {
                    var return_v = SwitchGoverningExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 1497, 1522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10370_1558_1584()
                {
                    var return_v = SwitchGoverningDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 1558, 1584);
                    return return_v;
                }


                int
                f_10370_1537_1585(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1537, 1585);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_1654_1736(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                defaultLabel)
                {
                    var return_v = this_param.BindSwitchSections(originalBinder, diagnostics, out defaultLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1654, 1736);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10370_1788_1819(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1788, 1819);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10370_1882_1921(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalFunctionsForScope((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1882, 1921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10370_2053_2069(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 2053, 2069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                f_10370_2366_2385_M(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 2366, 2385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10370_2389_2399()
                {
                    var return_v = BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 2389, 2399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10370_1967_2430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                switchGoverningExpression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                switchSections, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = DecisionDagBuilder.CreateDecisionDagForSwitchStatement(compilation: compilation, syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, switchGoverningExpression: switchGoverningExpression, switchSections: switchSections, defaultLabel: defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 1967, 2430);
                    return return_v;
                }


                int
                f_10370_2538_2639(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundSwitchGoverningExpression, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                switchSections, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckSwitchErrors(node, boundSwitchGoverningExpression, ref switchSections, decisionDag, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 2538, 2639);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10370_2861_2939(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                input)
                {
                    var return_v = this_param.SimplifyDecisionDagIfConstantInput(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 2861, 2939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10370_3291_3306(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 3291, 3306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                f_10370_2963_3350(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                innerLocals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                innerLocalFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                switchSections, Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel?
                defaultLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                decisionDag)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, expression: expression, innerLocals: innerLocals, innerLocalFunctions: innerLocalFunctions, switchSections: switchSections, defaultLabel: defaultLabel, breakLabel: breakLabel, decisionDag: decisionDag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 2963, 3350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 988, 3362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 988, 3362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckSwitchErrors(
                    SwitchStatementSyntax node,
                    BoundExpression boundSwitchGoverningExpression,
                    ref ImmutableArray<BoundSwitchSection> switchSections,
                    BoundDecisionDag decisionDag,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 3374, 6800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 3683, 3733);

                var
                reachableLabels = f_10370_3705_3732(decisionDag)
                ;

                bool isSubsumed(BoundSwitchLabel switchLabel)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 3747, 3892);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 3825, 3877);

                        return !f_10370_3833_3876(reachableLabels, f_10370_3858_3875(switchLabel));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 3747, 3892);

                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10370_3858_3875(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 3858, 3875);
                            return return_v;
                        }


                        bool
                        f_10370_3833_3876(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 3833, 3876);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 3747, 3892);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 3747, 3892);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 3972, 4096) || true) && (!switchSections.Any(s => s.SwitchLabels.Any(l => isSubsumed(l))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 3972, 4096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4074, 4081);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 3972, 4096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4112, 4201);

                var
                sectionBuilder = f_10370_4133_4200(switchSections.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4215, 4246);

                bool
                anyPreviousErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4260, 6720);
                    foreach (var oldSection in f_10370_4287_4301_I(switchSections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4260, 6720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4335, 4429);

                        var
                        labelBuilder = f_10370_4354_4428(oldSection.SwitchLabels.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4447, 6570);
                            foreach (var label in f_10370_4469_4492_I(f_10370_4469_4492(oldSection)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4447, 6570);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4534, 4555);

                                var
                                newLabel = label
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4577, 6441) || true) && (f_10370_4581_4597_M(!label.HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10370, 4581, 4618) && f_10370_4601_4618(label)) && (DynAbs.Tracing.TraceSender.Expression_True(10370, 4581, 4674) && f_10370_4622_4641(label.Syntax) != SyntaxKind.DefaultSwitchLabel))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4577, 6441);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4724, 4750);

                                    var
                                    syntax = label.Syntax
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4776, 6177);

                                    switch (syntax)
                                    {

                                        case CasePatternSwitchLabelSyntax p:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4776, 6177);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 4918, 5143) || true) && (f_10370_4922_4942_M(!f_10370_4923_4932(p).HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10370, 4922, 4964) && !anyPreviousErrors))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4918, 5143);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 5038, 5108);

                                                f_10370_5038_5107(diagnostics, ErrorCode.ERR_SwitchCaseSubsumed, f_10370_5088_5106(f_10370_5088_5097(p)));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4918, 5143);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10370, 5177, 5183);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4776, 6177);

                                        case CaseSwitchLabelSyntax p:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4776, 6177);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 5276, 5982) || true) && (f_10370_5280_5293(label) is BoundConstantPattern cp && (DynAbs.Tracing.TraceSender.Expression_True(10370, 5280, 5347) && f_10370_5324_5347_M(!f_10370_5325_5341(cp).IsBad)) && (DynAbs.Tracing.TraceSender.Expression_True(10370, 5280, 5414) && f_10370_5351_5399(this, f_10370_5379_5395(cp), p) != f_10370_5403_5414(label)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 5276, 5982);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 5576, 5681);

                                                f_10370_5576_5680(                                    // We use the traditional diagnostic when possible
                                                                                    diagnostics, ErrorCode.ERR_DuplicateCaseLabel, f_10370_5626_5641(syntax), f_10370_5643_5679(f_10370_5643_5659(cp)));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 5276, 5982);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 5276, 5982);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 5755, 5982) || true) && (f_10370_5759_5783_M(!f_10370_5760_5773(label).HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10370, 5759, 5805) && !anyPreviousErrors))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 5755, 5982);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 5879, 5947);

                                                    f_10370_5879_5946(diagnostics, ErrorCode.ERR_SwitchCaseSubsumed, f_10370_5929_5945(f_10370_5929_5936(p)));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 5755, 5982);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 5276, 5982);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceBreak(10370, 6016, 6022);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4776, 6177);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 4776, 6177);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6094, 6150);

                                            throw f_10370_6100_6149(f_10370_6135_6148(syntax));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4776, 6177);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6309, 6418);

                                    newLabel = f_10370_6320_6417(label.Syntax, f_10370_6355_6366(label), f_10370_6368_6381(label), f_10370_6383_6399(label), hasErrors: true);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4577, 6441);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6465, 6502);

                                anyPreviousErrors |= f_10370_6486_6501(label);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6524, 6551);

                                f_10370_6524_6550(labelBuilder, newLabel);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4447, 6570);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10370, 1, 2124);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10370, 1, 2124);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6590, 6705);

                        f_10370_6590_6704(
                                        sectionBuilder, f_10370_6609_6703(oldSection, f_10370_6627_6644(oldSection), f_10370_6646_6679(labelBuilder), f_10370_6681_6702(oldSection)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 4260, 6720);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10370, 1, 2461);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10370, 1, 2461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 6736, 6789);

                switchSections = f_10370_6753_6788(sectionBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 3374, 6800);

                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10370_3705_3732(Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                this_param)
                {
                    var return_v = this_param.ReachableLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 3705, 3732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_4133_4200(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSwitchSection>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4133, 4200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_4354_4428(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSwitchLabel>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4354, 4428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_4469_4492(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 4469, 4492);
                    return return_v;
                }


                bool
                f_10370_4581_4597_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 4581, 4597);
                    return return_v;
                }


                bool
                f_10370_4601_4618(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                switchLabel)
                {
                    var return_v = isSubsumed(switchLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4601, 4618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10370_4622_4641(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4622, 4641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10370_4923_4932(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 4923, 4932);
                    return return_v;
                }


                bool
                f_10370_4922_4942_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 4922, 4942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10370_5088_5097(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5088, 5097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10370_5088_5106(Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5088, 5106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_5038_5107(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 5038, 5107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10370_5280_5293(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5280, 5293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10370_5325_5341(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5325, 5341);
                    return return_v;
                }


                bool
                f_10370_5324_5347_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5324, 5347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10370_5379_5395(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5379, 5395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLabelSymbol
                f_10370_5351_5399(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                labelSyntax)
                {
                    var return_v = this_param.FindMatchingSwitchCaseLabel(constantValue, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)labelSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 5351, 5399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10370_5403_5414(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5403, 5414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10370_5626_5641(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5626, 5641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10370_5643_5659(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5643, 5659);
                    return return_v;
                }


                string?
                f_10370_5643_5679(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.GetValueToDisplay();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 5643, 5679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_5576_5680(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 5576, 5680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10370_5760_5773(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5760, 5773);
                    return return_v;
                }


                bool
                f_10370_5759_5783_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5759, 5783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_5929_5936(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5929, 5936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10370_5929_5945(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 5929, 5945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_5879_5946(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 5879, 5946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10370_6135_6148(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6135, 6148);
                    return return_v;
                }


                System.Exception
                f_10370_6100_6149(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6100, 6149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10370_6355_6366(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6355, 6366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10370_6368_6381(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6368, 6381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10370_6383_6399(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6383, 6399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_6320_6417(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel(syntax, label, pattern, whenClause, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6320, 6417);
                    return return_v;
                }


                bool
                f_10370_6486_6501(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6486, 6501);
                    return return_v;
                }


                int
                f_10370_6524_6550(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6524, 6550);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_4469_4492_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4469, 4492);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10370_6627_6644(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6627, 6644);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_6646_6679(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6646, 6679);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10370_6681_6702(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 6681, 6702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                f_10370_6609_6703(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                switchLabels, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, switchLabels, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6609, 6703);
                    return return_v;
                }


                int
                f_10370_6590_6704(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6590, 6704);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_4287_4301_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 4287, 4301);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_6753_6788(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 6753, 6788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 3374, 6800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 3374, 6800);
            }
        }

        internal override void BindPatternSwitchLabelForInference(CasePatternSwitchLabelSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 6962, 7832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 7171, 7225);

                f_10370_7171_7224(this.SwitchSyntax == f_10370_7205_7223(f_10370_7205_7216(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 7525, 7562);

                BoundSwitchLabel
                defaultLabel = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 7576, 7821);

                f_10370_7576_7820(this, sectionBinder: f_10370_7632_7654(this, f_10370_7642_7653(node)), node: node, label: f_10370_7709_7727(f_10370_7709_7721(), node), defaultLabel: ref defaultLabel, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 6962, 7832);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10370_7205_7216(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 7205, 7216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10370_7205_7223(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 7205, 7223);
                    return return_v;
                }


                int
                f_10370_7171_7224(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 7171, 7224);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10370_7642_7653(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 7642, 7653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10370_7632_7654(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 7632, 7654);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10370_7709_7721()
                {
                    var return_v = LabelsByNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 7709, 7721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10370_7709_7727(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 7709, 7727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_7576_7820(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder?
                sectionBinder, Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, ref Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel?
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchSectionLabel(sectionBinder: sectionBinder, node: (Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax)node, label: label, defaultLabel: ref defaultLabel, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 7576, 7820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 6962, 7832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 6962, 7832);
            }
        }

        private ImmutableArray<BoundSwitchSection> BindSwitchSections(
                    Binder originalBinder,
                    DiagnosticBag diagnostics,
                    out BoundSwitchLabel defaultLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 7936, 8703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8183, 8290);

                var
                boundSwitchSectionsBuilder = f_10370_8216_8289(SwitchSyntax.Sections.Count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8304, 8324);

                defaultLabel = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8338, 8621);
                    foreach (SwitchSectionSyntax sectionSyntax in f_10370_8384_8405_I(f_10370_8384_8405(SwitchSyntax)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 8338, 8621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8439, 8548);

                        BoundSwitchSection
                        section = f_10370_8468_8547(this, sectionSyntax, originalBinder, ref defaultLabel, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8566, 8606);

                        f_10370_8566_8605(boundSwitchSectionsBuilder, section);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 8338, 8621);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10370, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10370, 1, 284);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 8637, 8692);

                return f_10370_8644_8691(boundSwitchSectionsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 7936, 8703);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_8216_8289(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSwitchSection>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 8216, 8289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10370_8384_8405(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchStatementSyntax
                this_param)
                {
                    var return_v = this_param.Sections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 8384, 8405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                f_10370_8468_8547(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, ref Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel?
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchSection(node, originalBinder, ref defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 8468, 8547);
                    return return_v;
                }


                int
                f_10370_8566_8605(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 8566, 8605);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                f_10370_8384_8405_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 8384, 8405);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10370_8644_8691(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 8644, 8691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 7936, 8703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 7936, 8703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundSwitchSection BindSwitchSection(
                    SwitchSectionSyntax node,
                    Binder originalBinder,
                    ref BoundSwitchLabel defaultLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 8808, 10574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9083, 9170);

                var
                boundLabelsBuilder = f_10370_9108_9169(node.Labels.Count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9184, 9238);

                Binder
                sectionBinder = f_10370_9207_9237(originalBinder, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9312, 9348);

                f_10370_9312_9347(sectionBinder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9362, 9426);

                Dictionary<SyntaxNode, LabelSymbol>
                labelsByNode = f_10370_9413_9425()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9442, 9780);
                    foreach (SwitchLabelSyntax labelSyntax in f_10370_9484_9495_I(f_10370_9484_9495(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 9442, 9780);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9529, 9575);

                        LabelSymbol
                        label = f_10370_9549_9574(labelsByNode, labelSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9593, 9712);

                        BoundSwitchLabel
                        boundLabel = f_10370_9623_9711(this, sectionBinder, labelSyntax, label, ref defaultLabel, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9730, 9765);

                        f_10370_9730_9764(boundLabelsBuilder, boundLabel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 9442, 9780);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10370, 1, 339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10370, 1, 339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9843, 9936);

                var
                boundStatementsBuilder = f_10370_9872_9935(node.Statements.Count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 9950, 10378);
                    foreach (StatementSyntax statement in f_10370_9988_10003_I(f_10370_9988_10003(node)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 9950, 10378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10037, 10110);

                        var
                        boundStatement = f_10370_10058_10109(sectionBinder, statement, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10128, 10302) || true) && (f_10370_10132_10169(boundStatement))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 10128, 10302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10211, 10283);

                            f_10370_10211_10282(diagnostics, ErrorCode.ERR_UsingVarInSwitchCase, f_10370_10263_10281(statement));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 10128, 10302);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10320, 10363);

                        f_10370_10320_10362(boundStatementsBuilder, boundStatement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 9950, 10378);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10370, 1, 429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10370, 1, 429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10394, 10563);

                return f_10370_10401_10562(node, f_10370_10430_10475(sectionBinder, node), f_10370_10477_10516(boundLabelsBuilder), f_10370_10518_10561(boundStatementsBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 8808, 10574);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_9108_9169(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundSwitchLabel>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9108, 9169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10370_9207_9237(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9207, 9237);
                    return return_v;
                }


                int
                f_10370_9312_9347(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9312, 9347);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10370_9413_9425()
                {
                    var return_v = LabelsByNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 9413, 9425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10370_9484_9495(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Labels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 9484, 9495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10370_9549_9574(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 9549, 9574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_9623_9711(Microsoft.CodeAnalysis.CSharp.SwitchBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                sectionBinder, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, ref Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindSwitchSectionLabel(sectionBinder, node, label, ref defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9623, 9711);
                    return return_v;
                }


                int
                f_10370_9730_9764(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9730, 9764);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                f_10370_9484_9495_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9484, 9495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10370_9872_9935(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9872, 9935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10370_9988_10003(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 9988, 10003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10370_10058_10109(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10058, 10109);
                    return return_v;
                }


                bool
                f_10370_10132_10169(Microsoft.CodeAnalysis.CSharp.BoundStatement
                boundStatement)
                {
                    var return_v = ContainsUsingVariable(boundStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10132, 10169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10370_10263_10281(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 10263, 10281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_10211_10282(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10211, 10282);
                    return return_v;
                }


                int
                f_10370_10320_10362(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10320, 10362);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                f_10370_9988_10003_I(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 9988, 10003);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10370_10430_10475(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                scopeDesignator)
                {
                    var return_v = this_param.GetDeclaredLocalsForScope((Microsoft.CodeAnalysis.SyntaxNode)scopeDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10430, 10475);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10370_10477_10516(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10477, 10516);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10370_10518_10561(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10518, 10561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                f_10370_10401_10562(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchSectionSyntax
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                switchLabels, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchSection((Microsoft.CodeAnalysis.SyntaxNode)syntax, locals, switchLabels, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 10401, 10562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 8808, 10574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 8808, 10574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsUsingVariable(BoundStatement boundStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10370, 10586, 11116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10684, 11078) || true) && (boundStatement is BoundLocalDeclaration boundLocal)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 10684, 11078);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10772, 10810);

                    return f_10370_10779_10809(f_10370_10779_10801(boundLocal));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 10684, 11078);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 10684, 11078);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 10844, 11078) || true) && (boundStatement is BoundMultipleLocalDeclarationsBase boundMultiple && (DynAbs.Tracing.TraceSender.Expression_True(10370, 10848, 10967) && f_10370_10918_10967_M(!boundMultiple.LocalDeclarations.IsDefaultOrEmpty)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 10844, 11078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11001, 11063);

                        return f_10370_11008_11062(f_10370_11008_11054(f_10370_11008_11039(boundMultiple)[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 10844, 11078);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 10684, 11078);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11092, 11105);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10370, 10586, 11116);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10370_10779_10801(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 10779, 10801);
                    return return_v;
                }


                bool
                f_10370_10779_10809(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsUsing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 10779, 10809);
                    return return_v;
                }


                bool
                f_10370_10918_10967_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 10918, 10967);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration>
                f_10370_11008_11039(Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarationsBase
                this_param)
                {
                    var return_v = this_param.LocalDeclarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11008, 11039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10370_11008_11054(Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11008, 11054);
                    return return_v;
                }


                bool
                f_10370_11008_11062(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.IsUsing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11008, 11062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 10586, 11116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 10586, 11116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundSwitchLabel BindSwitchSectionLabel(
                    Binder sectionBinder,
                    SwitchLabelSyntax node,
                    LabelSymbol label,
                    ref BoundSwitchLabel defaultLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 11130, 14577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11395, 14190);

                switch (f_10370_11403_11414(node))
                {

                    case SyntaxKind.CaseSwitchLabel:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 11395, 14190);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11529, 11579);

                            var
                            caseLabelSyntax = (CaseSwitchLabelSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11605, 11637);

                            bool
                            hasErrors = f_10370_11622_11636(node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11663, 11866);

                            BoundPattern
                            pattern = f_10370_11686_11865(sectionBinder, f_10370_11775_11796(caseLabelSyntax), f_10370_11798_11819(caseLabelSyntax), f_10370_11821_11840(), hasErrors, diagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11892, 11928);

                            pattern.WasCompilerGenerated = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 11993, 12057);

                            f_10370_11993_12056(pattern, f_10370_12034_12055(caseLabelSyntax));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12085, 12160);

                            return f_10370_12092_12159(node, label, pattern, null, f_10370_12141_12158(pattern));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 11395, 14190);

                    case SyntaxKind.DefaultSwitchLabel:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 11395, 14190);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12287, 12398);

                            var
                            pattern = f_10370_12301_12397(node, inputType: f_10370_12342_12361(), narrowedType: f_10370_12377_12396())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12424, 12459);

                            bool
                            hasErrors = f_10370_12441_12458(pattern)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12485, 13180) || true) && (defaultLabel != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 12485, 13180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12567, 12644);

                                f_10370_12567_12643(diagnostics, ErrorCode.ERR_DuplicateCaseLabel, f_10370_12617_12630(node), f_10370_12632_12642(label));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12674, 12691);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 12721, 12788);

                                return f_10370_12728_12787(node, label, pattern, null, hasErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 12485, 13180);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 12485, 13180);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13071, 13153);

                                return defaultLabel = f_10370_13093_13152(node, label, pattern, null, hasErrors);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 12485, 13180);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 11395, 14190);

                    case SyntaxKind.CasePatternSwitchLabel:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 11395, 14190);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13311, 13369);

                            var
                            matchLabelSyntax = (CasePatternSwitchLabelSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13395, 13602);

                            BoundPattern
                            pattern = f_10370_13418_13601(sectionBinder, f_10370_13474_13498(matchLabelSyntax), f_10370_13500_13519(), f_10370_13521_13545(), permitDesignations: true, f_10370_13573_13587(node), diagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13628, 13769) || true) && (f_10370_13632_13656(matchLabelSyntax) is ConstantPatternSyntax p)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 13628, 13769);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13714, 13769);

                                f_10370_13714_13768(pattern, f_10370_13755_13767(p));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 13628, 13769);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 13797, 14055);

                            return f_10370_13804_14054(node, label, pattern, (DynAbs.Tracing.TraceSender.Conditional_F1(10370, 13876, 13911) || ((f_10370_13876_13903(matchLabelSyntax) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10370, 13914, 14001)) || DynAbs.Tracing.TraceSender.Conditional_F3(10370, 14004, 14008))) ? f_10370_13914_14001(sectionBinder, f_10370_13950_13987(f_10370_13950_13977(matchLabelSyntax)), diagnostics) : null, f_10370_14039_14053(node));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 11395, 14190);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 11395, 14190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 14128, 14175);

                        throw f_10370_14134_14174(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 11395, 14190);
                }

                void reportIfConstantNamedUnderscore(BoundPattern pattern, ExpressionSyntax expression)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10370, 14206, 14566);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 14326, 14551) || true) && (pattern is BoundConstantPattern { HasErrors: false } && (DynAbs.Tracing.TraceSender.Expression_True(10370, 14330, 14410) && f_10370_14386_14410(expression)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10370, 14326, 14551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10370, 14452, 14532);

                            f_10370_14452_14531(diagnostics, ErrorCode.WRN_CaseConstantNamedUnderscore, f_10370_14511_14530(expression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10370, 14326, 14551);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 14206, 14566);

                        bool
                        f_10370_14386_14410(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        node)
                        {
                            var return_v = IsUnderscore(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 14386, 14410);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10370_14511_14530(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 14511, 14530);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10370_14452_14531(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 14452, 14531);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 14206, 14566);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 14206, 14566);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10370, 11130, 14577);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10370_11403_11414(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 11403, 11414);
                    return return_v;
                }


                bool
                f_10370_11622_11636(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11622, 11636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_11775_11796(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11775, 11796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_11798_11819(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11798, 11819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10370_11821_11840()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 11821, 11840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10370_11686_11865(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindConstantPatternWithFallbackToTypePattern((Microsoft.CodeAnalysis.SyntaxNode)node, expression, inputType, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 11686, 11865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_12034_12055(Microsoft.CodeAnalysis.CSharp.Syntax.CaseSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12034, 12055);
                    return return_v;
                }


                int
                f_10370_11993_12056(Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    reportIfConstantNamedUnderscore(pattern, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 11993, 12056);
                    return 0;
                }


                bool
                f_10370_12141_12158(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12141, 12158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_12092_12159(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel((Microsoft.CodeAnalysis.SyntaxNode)syntax, label, pattern, whenClause, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 12092, 12159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10370_12342_12361()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12342, 12361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10370_12377_12396()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12377, 12396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                f_10370_12301_12397(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                narrowedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern((Microsoft.CodeAnalysis.SyntaxNode)syntax, inputType: inputType, narrowedType: narrowedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 12301, 12397);
                    return return_v;
                }


                bool
                f_10370_12441_12458(Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12441, 12458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10370_12617_12630(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12617, 12630);
                    return return_v;
                }


                string
                f_10370_12632_12642(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 12632, 12642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10370_12567_12643(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 12567, 12643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_12728_12787(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel((Microsoft.CodeAnalysis.SyntaxNode)syntax, label, (Microsoft.CodeAnalysis.CSharp.BoundPattern)pattern, whenClause, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 12728, 12787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_13093_13152(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundDiscardPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel((Microsoft.CodeAnalysis.SyntaxNode)syntax, label, (Microsoft.CodeAnalysis.CSharp.BoundPattern)pattern, whenClause, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 13093, 13152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10370_13474_13498(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13474, 13498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10370_13500_13519()
                {
                    var return_v = SwitchGoverningType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13500, 13519);
                    return return_v;
                }


                uint
                f_10370_13521_13545()
                {
                    var return_v = SwitchGoverningValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13521, 13545);
                    return return_v;
                }


                bool
                f_10370_13573_13587(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13573, 13587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10370_13418_13601(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                inputType, uint
                inputValEscape, bool
                permitDesignations, bool
                hasErrors, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindPattern(node, inputType, inputValEscape, permitDesignations: permitDesignations, hasErrors, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 13418, 13601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                f_10370_13632_13656(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13632, 13656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_13755_13767(Microsoft.CodeAnalysis.CSharp.Syntax.ConstantPatternSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13755, 13767);
                    return return_v;
                }


                int
                f_10370_13714_13768(Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    reportIfConstantNamedUnderscore(pattern, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 13714, 13768);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10370_13876_13903(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13876, 13903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                f_10370_13950_13977(Microsoft.CodeAnalysis.CSharp.Syntax.CasePatternSwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13950, 13977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10370_13950_13987(Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 13950, 13987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10370_13914_14001(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindBooleanExpression(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 13914, 14001);
                    return return_v;
                }


                bool
                f_10370_14039_14053(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10370, 14039, 14053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                f_10370_13804_14054(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel((Microsoft.CodeAnalysis.SyntaxNode)syntax, label, pattern, whenClause, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 13804, 14054);
                    return return_v;
                }


                System.Exception
                f_10370_14134_14174(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10370, 14134, 14174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10370, 11130, 14577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10370, 11130, 14577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
