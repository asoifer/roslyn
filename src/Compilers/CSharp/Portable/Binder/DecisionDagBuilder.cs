// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class DecisionDagBuilder
    {
        private readonly CSharpCompilation _compilation;

        private readonly Conversions _conversions;

        private readonly DiagnosticBag _diagnostics;

        private readonly LabelSymbol _defaultLabel;

        private DecisionDagBuilder(CSharpCompilation compilation, LabelSymbol defaultLabel, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 3964, 4284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 3780, 3792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 3832, 3844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 3886, 3898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 3938, 3951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4099, 4131);

                this._compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4145, 4189);

                this._conversions = f_10330_4165_4188(compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4203, 4230);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4244, 4273);

                _defaultLabel = defaultLabel;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 3964, 4284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 3964, 4284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 3964, 4284);
            }
        }

        public static BoundDecisionDag CreateDecisionDagForSwitchStatement(
                    CSharpCompilation compilation,
                    SyntaxNode syntax,
                    BoundExpression switchGoverningExpression,
                    ImmutableArray<BoundSwitchSection> switchSections,
                    LabelSymbol defaultLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 4402, 4973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4769, 4846);

                var
                builder = f_10330_4783_4845(compilation, defaultLabel, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 4860, 4962);

                return f_10330_4867_4961(builder, syntax, switchGoverningExpression, switchSections);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 4402, 4973);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                f_10330_4783_4845(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder(compilation, defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 4783, 4845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_4867_4961(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                switchGoverningExpression, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                switchSections)
                {
                    var return_v = this_param.CreateDecisionDagForSwitchStatement(syntax, switchGoverningExpression, switchSections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 4867, 4961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 4402, 4973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 4402, 4973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundDecisionDag CreateDecisionDagForSwitchExpression(
                    CSharpCompilation compilation,
                    SyntaxNode syntax,
                    BoundExpression switchExpressionInput,
                    ImmutableArray<BoundSwitchExpressionArm> switchArms,
                    LabelSymbol defaultLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 5092, 5655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 5458, 5535);

                var
                builder = f_10330_5472_5534(compilation, defaultLabel, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 5549, 5644);

                return f_10330_5556_5643(builder, syntax, switchExpressionInput, switchArms);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 5092, 5655);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                f_10330_5472_5534(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder(compilation, defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 5472, 5534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_5556_5643(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                switchExpressionInput, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                switchArms)
                {
                    var return_v = this_param.CreateDecisionDagForSwitchExpression(syntax, switchExpressionInput, switchArms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 5556, 5643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 5092, 5655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 5092, 5655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundDecisionDag CreateDecisionDagForIsPattern(
                    CSharpCompilation compilation,
                    SyntaxNode syntax,
                    BoundExpression inputExpression,
                    BoundPattern pattern,
                    LabelSymbol whenTrueLabel,
                    LabelSymbol whenFalseLabel,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 5778, 6354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 6142, 6235);

                var
                builder = f_10330_6156_6234(compilation, defaultLabel: whenFalseLabel, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 6249, 6343);

                return f_10330_6256_6342(builder, syntax, inputExpression, pattern, whenTrueLabel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 5778, 6354);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                f_10330_6156_6234(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                defaultLabel, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder(compilation, defaultLabel: defaultLabel, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6156, 6234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_6256_6342(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                inputExpression, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                whenTrueLabel)
                {
                    var return_v = this_param.CreateDecisionDagForIsPattern(syntax, inputExpression, pattern, whenTrueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6256, 6342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 5778, 6354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 5778, 6354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDecisionDag CreateDecisionDagForIsPattern(
                    SyntaxNode syntax,
                    BoundExpression inputExpression,
                    BoundPattern pattern,
                    LabelSymbol whenTrueLabel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 6366, 6856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 6599, 6667);

                var
                rootIdentifier = f_10330_6620_6666(inputExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 6681, 6845);

                return f_10330_6688_6844(this, syntax, f_10330_6717_6843(f_10330_6739_6842(this, index: 1, pattern.Syntax, rootIdentifier, pattern, whenClause: null, whenTrueLabel)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 6366, 6856);

                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_6620_6666(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = BoundDagTemp.ForOriginalInput(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6620, 6666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_6739_6842(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, int
                index, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.MakeTestsForPattern(index: index, syntax, input, pattern, whenClause: whenClause, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6739, 6842);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_6717_6843(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6717, 6843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_6688_6844(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases)
                {
                    var return_v = this_param.MakeBoundDecisionDag(syntax, cases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 6688, 6844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 6366, 6856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 6366, 6856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDecisionDag CreateDecisionDagForSwitchStatement(
                    SyntaxNode syntax,
                    BoundExpression switchGoverningExpression,
                    ImmutableArray<BoundSwitchSection> switchSections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 6868, 7866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7106, 7184);

                var
                rootIdentifier = f_10330_7127_7183(switchGoverningExpression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7198, 7208);

                int
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7222, 7298);

                var
                builder = f_10330_7236_7297(switchSections.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7312, 7773);
                    foreach (BoundSwitchSection section in f_10330_7351_7365_I(switchSections))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 7312, 7773);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7399, 7758);
                            foreach (BoundSwitchLabel label in f_10330_7434_7454_I(f_10330_7434_7454(section)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 7399, 7758);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7496, 7739) || true) && (f_10330_7500_7519(label.Syntax) != SyntaxKind.DefaultSwitchLabel)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 7496, 7739);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7602, 7716);

                                    f_10330_7602_7715(builder, f_10330_7614_7714(this, ++i, label.Syntax, rootIdentifier, f_10330_7669_7682(label), f_10330_7684_7700(label), f_10330_7702_7713(label)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 7496, 7739);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 7399, 7758);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 360);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 360);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 7312, 7773);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 462);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 7789, 7855);

                return f_10330_7796_7854(this, syntax, f_10330_7825_7853(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 6868, 7866);

                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_7127_7183(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = BoundDagTemp.ForOriginalInput(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7127, 7183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_7236_7297(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7236, 7297);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10330_7434_7454(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                this_param)
                {
                    var return_v = this_param.SwitchLabels;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 7434, 7454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10330_7500_7519(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7500, 7519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_7669_7682(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 7669, 7682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10330_7684_7700(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 7684, 7700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10330_7702_7713(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 7702, 7713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_7614_7714(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, int
                index, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.MakeTestsForPattern(index, syntax, input, pattern, whenClause, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7614, 7714);
                    return return_v;
                }


                int
                f_10330_7602_7715(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7602, 7715);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                f_10330_7434_7454_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7434, 7454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                f_10330_7351_7365_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7351, 7365);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_7825_7853(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7825, 7853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_7796_7854(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases)
                {
                    var return_v = this_param.MakeBoundDecisionDag(syntax, cases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 7796, 7854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 6868, 7866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 6868, 7866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDecisionDag CreateDecisionDagForSwitchExpression(
                    SyntaxNode syntax,
                    BoundExpression switchExpressionInput,
                    ImmutableArray<BoundSwitchExpressionArm> switchArms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 7993, 8697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8230, 8304);

                var
                rootIdentifier = f_10330_8251_8303(switchExpressionInput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8318, 8328);

                int
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8342, 8414);

                var
                builder = f_10330_8356_8413(switchArms.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8428, 8604);
                    foreach (BoundSwitchExpressionArm arm in f_10330_8469_8479_I(switchArms))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 8428, 8604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8498, 8604);

                        f_10330_8498_8603(builder, f_10330_8510_8602(this, ++i, arm.Syntax, rootIdentifier, f_10330_8563_8574(arm), f_10330_8576_8590(arm), f_10330_8592_8601(arm)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 8428, 8604);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 8620, 8686);

                return f_10330_8627_8685(this, syntax, f_10330_8656_8684(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 7993, 8697);

                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_8251_8303(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = BoundDagTemp.ForOriginalInput(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8251, 8303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_8356_8413(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8356, 8413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_8563_8574(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 8563, 8574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10330_8576_8590(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.WhenClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 8576, 8590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                f_10330_8592_8601(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 8592, 8601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_8510_8602(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, int
                index, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.MakeTestsForPattern(index, syntax, input, pattern, whenClause, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8510, 8602);
                    return return_v;
                }


                int
                f_10330_8498_8603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8498, 8603);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10330_8469_8479_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8469, 8479);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_8656_8684(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8656, 8684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_8627_8685(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases)
                {
                    var return_v = this_param.MakeBoundDecisionDag(syntax, cases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 8627, 8685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 7993, 8697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 7993, 8697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StateForCase MakeTestsForPattern(
                    int index,
                    SyntaxNode syntax,
                    BoundDagTemp input,
                    BoundPattern pattern,
                    BoundExpression? whenClause,
                    LabelSymbol label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 8819, 9295);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding> bindings = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9083, 9195);

                Tests
                tests = f_10330_9097_9194(this, input, pattern, out bindings)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9209, 9284);

                return f_10330_9216_9283(index, syntax, tests, bindings, whenClause, label);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 8819, 9295);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_9097_9194(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeAndSimplifyTestsAndBindings(input, pattern, out bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9097, 9194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_9216_9283(int
                Index, Microsoft.CodeAnalysis.SyntaxNode
                Syntax, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                RemainingTests, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                Bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                WhenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                CaseLabel)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase(Index, Syntax, RemainingTests, Bindings, WhenClause, CaseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9216, 9283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 8819, 9295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 8819, 9295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeAndSimplifyTestsAndBindings(
                    BoundDagTemp input,
                    BoundPattern pattern,
                    out ImmutableArray<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 9307, 9832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9509, 9579);

                var
                bindingsBuilder = f_10330_9531_9578()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9593, 9661);

                Tests
                tests = f_10330_9607_9660(this, input, pattern, bindingsBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9675, 9732);

                tests = f_10330_9683_9731(tests, bindingsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9746, 9794);

                bindings = f_10330_9757_9793(bindingsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 9808, 9821);

                return tests;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 9307, 9832);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                f_10330_9531_9578()
                {
                    var return_v = ArrayBuilder<BoundPatternBinding>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9531, 9578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_9607_9660(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9607, 9660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_9683_9731(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                tests, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindingsBuilder)
                {
                    var return_v = SimplifyTestsAndBindings(tests, bindingsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9683, 9731);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                f_10330_9757_9793(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 9757, 9793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 9307, 9832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 9307, 9832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Tests SimplifyTestsAndBindings(
                    Tests tests,
                    ArrayBuilder<BoundPatternBinding> bindingsBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 9844, 12487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10265, 10330);

                var
                usedValues = f_10330_10282_10329()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10344, 10625);
                    foreach (BoundPatternBinding binding in f_10330_10384_10399_I(bindingsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10344, 10625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10433, 10481);

                        BoundDagTemp
                        temp = binding.TempContainingValue
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10499, 10610) || true) && (f_10330_10503_10514(temp) is { })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10499, 10610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10563, 10591);

                            f_10330_10563_10590(usedValues, f_10330_10578_10589(temp));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10499, 10610);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10344, 10625);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10641, 10677);

                var
                result = f_10330_10654_10676(tests)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10691, 10709);

                f_10330_10691_10708(usedValues);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10723, 10737);

                return result;

                Tests scanAndSimplify(Tests tests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 10753, 12476);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10820, 12461);

                        switch (tests)
                        {

                            case Tests.SequenceTests seq:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10930, 10968);

                                var
                                testSequence = seq.RemainingTests
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 10994, 11027);

                                var
                                length = testSequence.Length
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11053, 11111);

                                var
                                newSequence = f_10330_11071_11110(length)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11137, 11172);

                                f_10330_11137_11171(newSequence, testSequence);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11207, 11221);
                                    for (int
            i = length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11198, 11368) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11231, 11234)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 11198, 11368))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 11198, 11368);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11292, 11341);

                                        newSequence[i] = f_10330_11309_11340(f_10330_11325_11339(newSequence, i));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 171);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 171);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11394, 11425);

                                return f_10330_11401_11424(seq, newSequence);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);

                            case Tests.True _:
                            case Tests.False _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11532, 11545);

                                return tests;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);

                            case Tests.One(BoundDagEvaluation e):
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11630, 12016) || true) && (f_10330_11634_11656(usedValues, e))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 11630, 12016);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11714, 11805) || true) && (f_10330_11718_11732(f_10330_11718_11725(e)) is { })
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 11714, 11805);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11774, 11805);

                                        f_10330_11774_11804(usedValues, f_10330_11789_11803(f_10330_11789_11796(e)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 11714, 11805);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11835, 11848);

                                    return tests;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 11630, 12016);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 11630, 12016);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 11962, 11989);

                                    return Tests.True.Instance;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 11630, 12016);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);

                            case Tests.One(BoundDagTest d):
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12095, 12182) || true) && (f_10330_12099_12113(f_10330_12099_12106(d)) is { })
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 12095, 12182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12151, 12182);

                                    f_10330_12151_12181(usedValues, f_10330_12166_12180(f_10330_12166_12173(d)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 12095, 12182);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12208, 12221);

                                return tests;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);

                            case Tests.Not n:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12286, 12338);

                                return f_10330_12293_12337(f_10330_12310_12336(n.Negated));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 10820, 12461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12394, 12442);

                                throw f_10330_12400_12441(tests);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 10820, 12461);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 10753, 12476);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_11071_11110(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11071, 11110);
                            return return_v;
                        }


                        int
                        f_10330_11137_11171(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        items)
                        {
                            this_param.AddRange(items);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11137, 11171);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_11325_11339(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 11325, 11339);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_11309_11340(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        tests)
                        {
                            var return_v = scanAndSimplify(tests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11309, 11340);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_11401_11424(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = this_param.Update(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11401, 11424);
                            return return_v;
                        }


                        bool
                        f_10330_11634_11656(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11634, 11656);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_11718_11725(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 11718, 11725);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                        f_10330_11718_11732(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 11718, 11732);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_11789_11796(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 11789, 11796);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        f_10330_11789_11803(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 11789, 11803);
                            return return_v;
                        }


                        bool
                        f_10330_11774_11804(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 11774, 11804);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_12099_12106(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 12099, 12106);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                        f_10330_12099_12113(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 12099, 12113);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_12166_12173(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 12166, 12173);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        f_10330_12166_12180(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Source;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 12166, 12180);
                            return return_v;
                        }


                        bool
                        f_10330_12151_12181(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 12151, 12181);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_12310_12336(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        tests)
                        {
                            var return_v = scanAndSimplify(tests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 12310, 12336);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_12293_12337(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        negated)
                        {
                            var return_v = Tests.Not.Create(negated);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 12293, 12337);
                            return return_v;
                        }


                        System.Exception
                        f_10330_12400_12441(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        o)
                        {
                            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 12400, 12441);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 10753, 12476);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 10753, 12476);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 9844, 12487);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                f_10330_10282_10329()
                {
                    var return_v = PooledHashSet<BoundDagEvaluation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 10282, 10329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                f_10330_10503_10514(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 10503, 10514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                f_10330_10578_10589(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 10578, 10589);
                    return return_v;
                }


                bool
                f_10330_10563_10590(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 10563, 10590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                f_10330_10384_10399_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 10384, 10399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_10654_10676(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                tests)
                {
                    var return_v = scanAndSimplify(tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 10654, 10676);
                    return return_v;
                }


                int
                f_10330_10691_10708(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 10691, 10708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 9844, 12487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 9844, 12487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindings(
                    BoundDagTemp input,
                    BoundPattern pattern,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 12499, 12756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 12684, 12745);

                return f_10330_12691_12744(this, input, pattern, out _, bindings);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 12499, 12756);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_12691_12744(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 12691, 12744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 12499, 12756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 12499, 12756);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindings(
                    BoundDagTemp input,
                    BoundPattern pattern,
                    out BoundDagTemp output,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 13148, 15030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13371, 13512);

                f_10330_13371_13511(f_10330_13384_13401(pattern) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 13384, 13475) || f_10330_13405_13475(f_10330_13405_13422(pattern), f_10330_13430_13440(input), TypeCompareKind.AllIgnoreOptions)) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 13384, 13510) || f_10330_13479_13510(f_10330_13479_13496(pattern))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13526, 15019);

                switch (pattern)
                {

                    case BoundDeclarationPattern declaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13638, 13729);

                        return f_10330_13645_13728(this, input, declaration, out output, bindings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundConstantPattern constant:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13804, 13868);

                        return f_10330_13811_13867(this, input, constant, out output);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundDiscardPattern _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13935, 13950);

                        output = input;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 13972, 13999);

                        return Tests.True.Instance;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundRecursivePattern recursive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14076, 14163);

                        return f_10330_14083_14162(this, input, recursive, out output, bindings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundITuplePattern iTuple:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14234, 14315);

                        return f_10330_14241_14314(this, input, iTuple, out output, bindings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundTypePattern type:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14382, 14438);

                        return f_10330_14389_14437(this, input, type, out output);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundRelationalPattern rel:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14510, 14582);

                        return f_10330_14517_14581(this, input, rel, out output);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundNegatedPattern neg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14651, 14666);

                        output = input;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14688, 14755);

                        return f_10330_14695_14754(this, input, neg, bindings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    case BoundBinaryPattern bin:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14823, 14901);

                        return f_10330_14830_14900(this, input, bin, out output, bindings);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 13526, 15019);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 14949, 15004);

                        throw f_10330_14955_15003(f_10330_14990_15002(pattern));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 13526, 15019);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 13148, 15030);

                bool
                f_10330_13384_13401(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 13384, 13401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_13405_13422(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 13405, 13422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_13430_13440(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 13430, 13440);
                    return return_v;
                }


                bool
                f_10330_13405_13475(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 13405, 13475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_13479_13496(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 13479, 13496);
                    return return_v;
                }


                bool
                f_10330_13479_13510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 13479, 13510);
                    return return_v;
                }


                int
                f_10330_13371_13511(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 13371, 13511);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_13645_13728(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                declaration, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindingsForDeclarationPattern(input, declaration, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 13645, 13728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_13811_13867(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                constant, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output)
                {
                    var return_v = this_param.MakeTestsForConstantPattern(input, constant, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 13811, 13867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14083_14162(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                recursive, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindingsForRecursivePattern(input, recursive, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14083, 14162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14241_14314(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                pattern, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindingsForITuplePattern(input, pattern, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14241, 14314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14389_14437(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                typePattern, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output)
                {
                    var return_v = this_param.MakeTestsForTypePattern(input, typePattern, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14389, 14437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14517_14581(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                rel, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output)
                {
                    var return_v = this_param.MakeTestsAndBindingsForRelationalPattern(input, rel, out output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14517, 14581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14695_14754(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                neg, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindingsForNegatedPattern(input, neg, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14695, 14754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_14830_14900(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                bin, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindingsForBinaryPattern(input, bin, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14830, 14900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10330_14990_15002(Microsoft.CodeAnalysis.CSharp.BoundPattern
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 14990, 15002);
                    return return_v;
                }


                System.Exception
                f_10330_14955_15003(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 14955, 15003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 13148, 15030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 13148, 15030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForITuplePattern(
                    BoundDagTemp input,
                    BoundITuplePattern pattern,
                    out BoundDagTemp output,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 15042, 17405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15287, 15315);

                var
                syntax = pattern.Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15329, 15376);

                var
                patternLength = pattern.Subpatterns.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15390, 15467);

                var
                objectType = f_10330_15407_15466(this._compilation, SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15481, 15562);

                var
                getLengthProperty = (PropertySymbol)f_10330_15521_15561(f_10330_15521_15544(pattern))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15576, 15659);

                f_10330_15576_15658(f_10330_15595_15629(f_10330_15595_15617(getLengthProperty)) == SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15673, 15750);

                var
                getItemProperty = (PropertySymbol)f_10330_15711_15749(f_10330_15711_15732(pattern))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15764, 15814);

                var
                iTupleType = f_10330_15781_15813(getLengthProperty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15828, 15876);

                f_10330_15828_15875(f_10330_15847_15862(iTupleType) == "ITuple");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15890, 15957);

                var
                tests = f_10330_15902_15956(4 + patternLength * 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 15973, 16047);

                f_10330_15973_16046(
                            tests, f_10330_15983_16045(f_10330_15997_16044(syntax, iTupleType, input)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16061, 16145);

                var
                valueAsITupleEvaluation = f_10330_16091_16144(syntax, iTupleType, input)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16159, 16209);

                f_10330_16159_16208(tests, f_10330_16169_16207(valueAsITupleEvaluation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16223, 16305);

                var
                valueAsITuple = f_10330_16243_16304(syntax, iTupleType, valueAsITupleEvaluation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16319, 16342);

                output = valueAsITuple;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16358, 16488);

                var
                lengthEvaluation = f_10330_16381_16487(syntax, getLengthProperty, f_10330_16439_16486(this, valueAsITuple, getLengthProperty))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16502, 16545);

                f_10330_16502_16544(tests, f_10330_16512_16543(lengthEvaluation));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16559, 16679);

                var
                lengthTemp = f_10330_16576_16678(syntax, f_10330_16601_16659(this._compilation, SpecialType.System_Int32), lengthEvaluation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16693, 16798);

                f_10330_16693_16797(tests, f_10330_16703_16796(f_10330_16717_16795(syntax, f_10330_16747_16782(patternLength), lengthTemp)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16814, 16887);

                var
                getItemPropertyInput = f_10330_16841_16886(this, valueAsITuple, getItemProperty)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16910, 16915);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16901, 17339) || true) && (i < patternLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16936, 16939)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 16901, 17339))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 16901, 17339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 16973, 17073);

                        var
                        indexEvaluation = f_10330_16995_17072(syntax, getItemProperty, i, getItemPropertyInput)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 17091, 17133);

                        f_10330_17091_17132(tests, f_10330_17101_17131(indexEvaluation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 17151, 17221);

                        var
                        indexTemp = f_10330_17167_17220(syntax, objectType, indexEvaluation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 17239, 17324);

                        f_10330_17239_17323(tests, f_10330_17249_17322(this, indexTemp, f_10330_17281_17311(f_10330_17281_17300(pattern)[i]), bindings));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 439);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 17355, 17394);

                return f_10330_17362_17393(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 15042, 17405);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10330_15407_15466(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15407, 15466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10330_15521_15544(Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                this_param)
                {
                    var return_v = this_param.GetLengthMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15521, 15544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10330_15521_15561(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15521, 15561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_15595_15617(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15595, 15617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10330_15595_15629(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15595, 15629);
                    return return_v;
                }


                int
                f_10330_15576_15658(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15576, 15658);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10330_15711_15732(Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                this_param)
                {
                    var return_v = this_param.GetItemMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15711, 15732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10330_15711_15749(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15711, 15749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10330_15781_15813(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15781, 15813);
                    return return_v;
                }


                string
                f_10330_15847_15862(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 15847, 15862);
                    return return_v;
                }


                int
                f_10330_15828_15875(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15828, 15875);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_15902_15956(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15902, 15956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                f_10330_15997_16044(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15997, 16044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_15983_16045(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15983, 16045);
                    return return_v;
                }


                int
                f_10330_15973_16046(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 15973, 16046);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                f_10330_16091_16144(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16091, 16144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_16169_16207(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16169, 16207);
                    return return_v;
                }


                int
                f_10330_16159_16208(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16159, 16208);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_16243_16304(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16243, 16304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_16439_16486(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16439, 16486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                f_10330_16381_16487(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation(syntax, property, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16381, 16487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_16512_16543(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16512, 16543);
                    return return_v;
                }


                int
                f_10330_16502_16544(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16502, 16544);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10330_16601_16659(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16601, 16659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_16576_16678(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16576, 16678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_16747_16782(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16747, 16782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                f_10330_16717_16795(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagValueTest(syntax, value, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16717, 16795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_16703_16796(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16703, 16796);
                    return return_v;
                }


                int
                f_10330_16693_16797(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16693, 16797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_16841_16886(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16841, 16886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                f_10330_16995_17072(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, int
                index, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation(syntax, property, index, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 16995, 17072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_17101_17131(Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17101, 17131);
                    return return_v;
                }


                int
                f_10330_17091_17132(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17091, 17132);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_17167_17220(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagIndexEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17167, 17220);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10330_17281_17300(Microsoft.CodeAnalysis.CSharp.BoundITuplePattern
                this_param)
                {
                    var return_v = this_param.Subpatterns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17281, 17300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_17281_17311(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17281, 17311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_17249_17322(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17249, 17322);
                    return return_v;
                }


                int
                f_10330_17239_17323(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17239, 17323);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_17362_17393(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17362, 17393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 15042, 17405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 15042, 17405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDagTemp OriginalInput(BoundDagTemp input, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 17807, 18122);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 17901, 18082) || true) && (f_10330_17908_17920(input) is BoundDagTypeEvaluation source && (DynAbs.Tracing.TraceSender.Expression_True(10330, 17908, 18012) && f_10330_17957_18012(this, f_10330_17971_17988(f_10330_17971_17983(source)), f_10330_17990_18011(symbol))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 17901, 18082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18046, 18067);

                        input = f_10330_18054_18066(source);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 17901, 18082);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 17901, 18082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 17901, 18082);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18098, 18111);

                return input;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 17807, 18122);

                Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                f_10330_17908_17920(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17908, 17920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_17971_17983(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17971, 17983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_17971_17988(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17971, 17988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10330_17990_18011(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 17990, 18011);
                    return return_v;
                }


                bool
                f_10330_17957_18012(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                possibleDerived, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                possibleBase)
                {
                    var return_v = this_param.IsDerivedType(possibleDerived, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)possibleBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 17957, 18012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_18054_18066(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 18054, 18066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 17807, 18122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 17807, 18122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IsDerivedType(TypeSymbol possibleDerived, TypeSymbol possibleBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 18134, 18427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18230, 18281);

                HashSet<DiagnosticInfo>?
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18295, 18416);

                return f_10330_18302_18415(this._conversions, possibleDerived, possibleBase, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 18134, 18427);

                bool
                f_10330_18302_18415(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 18302, 18415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 18134, 18427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 18134, 18427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForDeclarationPattern(
                    BoundDagTemp input,
                    BoundDeclarationPattern declaration,
                    out BoundDagTemp output,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 18439, 19587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18698, 18748);

                TypeSymbol?
                type = f_10330_18717_18747_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10330_18717_18741(declaration), 10330, 18717, 18747)?.Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18762, 18809);

                var
                tests = f_10330_18774_18808(1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18877, 19008) || true) && (f_10330_18881_18899_M(!declaration.IsVar))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 18877, 19008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 18918, 19008);

                    input = f_10330_18926_19007(this, input, declaration.Syntax, type!, isExplicitTest: false, tests);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 18877, 19008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19024, 19085);

                BoundExpression?
                variableAccess = f_10330_19058_19084(declaration)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19099, 19492) || true) && (variableAccess is { })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 19099, 19492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19158, 19283);

                    f_10330_19158_19282(f_10330_19171_19244(variableAccess.Type!, f_10330_19199_19209(input), TypeCompareKind.AllIgnoreOptions) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 19171, 19281) || f_10330_19248_19281(f_10330_19248_19267(variableAccess))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19301, 19362);

                    f_10330_19301_19361(bindings, f_10330_19314_19360(variableAccess, input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 19099, 19492);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 19099, 19492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19428, 19477);

                    f_10330_19428_19476(f_10330_19447_19467(declaration) == null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 19099, 19492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19508, 19523);

                output = input;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19537, 19576);

                return f_10330_19544_19575(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 18439, 19587);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10330_18717_18741(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 18717, 18741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10330_18717_18747_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 18717, 18747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_18774_18808(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 18774, 18808);
                    return return_v;
                }


                bool
                f_10330_18881_18899_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 18881, 18899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_18926_19007(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input, syntax, type, isExplicitTest: isExplicitTest, tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 18926, 19007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10330_19058_19084(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19058, 19084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_19199_19209(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19199, 19209);
                    return return_v;
                }


                bool
                f_10330_19171_19244(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19171, 19244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_19248_19267(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19248, 19267);
                    return return_v;
                }


                bool
                f_10330_19248_19281(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19248, 19281);
                    return return_v;
                }


                int
                f_10330_19158_19282(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19158, 19282);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPatternBinding
                f_10330_19314_19360(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variableAccess, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                tempContainingValue)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPatternBinding(variableAccess, tempContainingValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19314, 19360);
                    return return_v;
                }


                int
                f_10330_19301_19361(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPatternBinding
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19301, 19361);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10330_19447_19467(Microsoft.CodeAnalysis.CSharp.BoundDeclarationPattern
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19447, 19467);
                    return return_v;
                }


                int
                f_10330_19428_19476(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19428, 19476);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_19544_19575(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19544, 19575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 18439, 19587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 18439, 19587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsForTypePattern(
                    BoundDagTemp input,
                    BoundTypePattern typePattern,
                    out BoundDagTemp output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 19599, 20109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19776, 19824);

                TypeSymbol
                type = f_10330_19794_19823(f_10330_19794_19818(typePattern))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19838, 19885);

                var
                tests = f_10330_19850_19884(4)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 19899, 20045);

                output = f_10330_19908_20044(this, input: input, syntax: typePattern.Syntax, type: type, isExplicitTest: f_10330_19996_20029(typePattern), tests: tests);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 20059, 20098);

                return f_10330_20066_20097(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 19599, 20109);

                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10330_19794_19818(Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19794, 19818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_19794_19823(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19794, 19823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_19850_19884(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19850, 19884);
                    return return_v;
                }


                bool
                f_10330_19996_20029(Microsoft.CodeAnalysis.CSharp.BoundTypePattern
                this_param)
                {
                    var return_v = this_param.IsExplicitNotNullTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 19996, 20029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_19908_20044(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input: input, syntax: syntax, type: type, isExplicitTest: isExplicitTest, tests: tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 19908, 20044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_20066_20097(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20066, 20097);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 19599, 20109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 19599, 20109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void MakeCheckNotNull(
                    BoundDagTemp input,
                    SyntaxNode syntax,
                    bool isExplicitTest,
                    ArrayBuilder<Tests> tests)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 20121, 20506);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 20364, 20495) || true) && (f_10330_20368_20395(f_10330_20368_20378(input)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 20364, 20495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 20414, 20495);

                    f_10330_20414_20494(tests, f_10330_20424_20493(f_10330_20438_20492(syntax, isExplicitTest, input)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 20364, 20495);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 20121, 20506);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_20368_20378(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 20368, 20378);
                    return return_v;
                }


                bool
                f_10330_20368_20395(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanContainNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20368, 20395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                f_10330_20438_20492(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isExplicitTest, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest(syntax, isExplicitTest, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20438, 20492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_20424_20493(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20424, 20493);
                    return return_v;
                }


                int
                f_10330_20414_20494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20414, 20494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 20121, 20506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 20121, 20506);
            }
        }

        private BoundDagTemp MakeConvertToType(
                    BoundDagTemp input,
                    SyntaxNode syntax,
                    TypeSymbol type,
                    bool isExplicitTest,
                    ArrayBuilder<Tests> tests)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 20622, 22056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 20855, 20910);

                f_10330_20855_20909(input, syntax, isExplicitTest, tests);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 20924, 22016) || true) && (!f_10330_20929_20986(f_10330_20929_20939(input), type, TypeCompareKind.AllIgnoreOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 20924, 22016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21020, 21069);

                    TypeSymbol
                    inputType = f_10330_21043_21068(f_10330_21043_21053(input))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21131, 21182);

                    HashSet<DiagnosticInfo>?
                    useSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21200, 21304);

                    Conversion
                    conversion = f_10330_21224_21303(_conversions, inputType, type, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21322, 21367);

                    f_10330_21322_21366(_diagnostics, syntax, useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21385, 21792) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 21389, 21411) || ((f_10330_21389_21411(f_10330_21389_21399(input)) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 21414, 21459)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 21462, 21483))) ? f_10330_21414_21430(type) == SpecialType.System_Object : conversion.IsImplicit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 21385, 21792);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 21385, 21792);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 21385, 21792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21705, 21773);

                        f_10330_21705_21772(                    // both type test and cast needed
                                            tests, f_10330_21715_21771(f_10330_21729_21770(syntax, type, input)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 21385, 21792);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21812, 21877);

                    var
                    evaluation = f_10330_21829_21876(syntax, type, input)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21895, 21946);

                    input = f_10330_21903_21945(syntax, type, evaluation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 21964, 22001);

                    f_10330_21964_22000(tests, f_10330_21974_21999(evaluation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 20924, 22016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22032, 22045);

                return input;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 20622, 22056);

                int
                f_10330_20855_20909(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    MakeCheckNotNull(input, syntax, isExplicitTest, tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20855, 20909);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_20929_20939(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 20929, 20939);
                    return return_v;
                }


                bool
                f_10330_20929_20986(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 20929, 20986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_21043_21053(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 21043, 21053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_21043_21068(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21043, 21068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10330_21224_21303(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyBuiltInConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21224, 21303);
                    return return_v;
                }


                bool
                f_10330_21322_21366(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21322, 21366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_21389_21399(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 21389, 21399);
                    return return_v;
                }


                bool
                f_10330_21389_21411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21389, 21411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10330_21414_21430(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 21414, 21430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                f_10330_21729_21770(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest(syntax, type, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21729, 21770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_21715_21771(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21715, 21771);
                    return return_v;
                }


                int
                f_10330_21705_21772(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21705, 21772);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                f_10330_21829_21876(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation(syntax, type, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21829, 21876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_21903_21945(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21903, 21945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_21974_21999(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21974, 21999);
                    return return_v;
                }


                int
                f_10330_21964_22000(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 21964, 22000);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 20622, 22056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 20622, 22056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsForConstantPattern(
                    BoundDagTemp input,
                    BoundConstantPattern constant,
                    out BoundDagTemp output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 22068, 22934);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22250, 22923) || true) && (f_10330_22254_22276(constant) == f_10330_22280_22298())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 22250, 22923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22332, 22347);

                    output = input;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22365, 22440);

                    return f_10330_22372_22439(f_10330_22386_22438(constant.Syntax, input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 22250, 22923);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 22250, 22923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22506, 22553);

                    var
                    tests = f_10330_22518_22552(2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22571, 22686);

                    var
                    convertedInput = f_10330_22592_22685(this, input, constant.Syntax, f_10330_22634_22648(constant).Type!, isExplicitTest: false, tests)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22704, 22728);

                    output = convertedInput;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22746, 22851);

                    f_10330_22746_22850(tests, f_10330_22756_22849(f_10330_22770_22848(constant.Syntax, f_10330_22809_22831(constant), convertedInput)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 22869, 22908);

                    return f_10330_22876_22907(tests);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 22250, 22923);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 22068, 22934);

                Microsoft.CodeAnalysis.ConstantValue
                f_10330_22254_22276(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 22254, 22276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_22280_22298()
                {
                    var return_v = ConstantValue.Null;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 22280, 22298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagExplicitNullTest
                f_10330_22386_22438(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagExplicitNullTest(syntax, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22386, 22438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_22372_22439(Microsoft.CodeAnalysis.CSharp.BoundDagExplicitNullTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22372, 22439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_22518_22552(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22518, 22552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10330_22634_22648(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 22634, 22648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_22592_22685(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input, syntax, type, isExplicitTest: isExplicitTest, tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22592, 22685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_22809_22831(Microsoft.CodeAnalysis.CSharp.BoundConstantPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 22809, 22831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                f_10330_22770_22848(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagValueTest(syntax, value, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22770, 22848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_22756_22849(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22756, 22849);
                    return return_v;
                }


                int
                f_10330_22746_22850(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22746, 22850);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_22876_22907(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 22876, 22907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 22068, 22934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 22068, 22934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForRecursivePattern(
                    BoundDagTemp input,
                    BoundRecursivePattern recursive,
                    out BoundDagTemp output,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 22946, 28822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23199, 23380);

                f_10330_23199_23379(f_10330_23218_23242(f_10330_23218_23228(input)) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 23218, 23265) || f_10330_23246_23265(recursive)) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 23218, 23302) || f_10330_23269_23302(f_10330_23269_23288(recursive))) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 23218, 23378) || f_10330_23306_23378(f_10330_23306_23316(input), f_10330_23324_23343(recursive), TypeCompareKind.AllIgnoreOptions)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23394, 23468);

                var
                inputType = f_10330_23410_23438_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10330_23410_23432(recursive), 10330, 23410, 23438)?.Type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10330, 23410, 23467) ?? f_10330_23442_23467(f_10330_23442_23452(input)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23482, 23529);

                var
                tests = f_10330_23494_23528(5)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23543, 23670);

                output = input = f_10330_23560_23669(this, input, recursive.Syntax, inputType, isExplicitTest: f_10330_23630_23661(recursive), tests);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23686, 27007) || true) && (f_10330_23690_23725_M(!recursive.Deconstruction.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 23686, 27007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23895, 26992) || true) && (f_10330_23899_23926(recursive) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 23895, 26992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 23976, 24026);

                        MethodSymbol
                        method = f_10330_23998_24025(recursive)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24048, 24155);

                        var
                        evaluation = f_10330_24065_24154(recursive.Syntax, method, f_10330_24125_24153(this, input, method))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24177, 24214);

                        f_10330_24177_24213(tests, f_10330_24187_24212(evaluation));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24236, 24281);

                        int
                        extensionExtra = (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 24257, 24272) || ((f_10330_24257_24272(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 24275, 24276)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 24279, 24280))) ? 1 : 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24303, 24397);

                        int
                        count = f_10330_24315_24396(f_10330_24324_24345(method) - extensionExtra, recursive.Deconstruction.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24428, 24433);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24419, 24852) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24446, 24449)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 24419, 24852))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 24419, 24852);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24499, 24558);

                                BoundPattern
                                pattern = f_10330_24522_24557(f_10330_24522_24546(recursive)[i])
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24584, 24619);

                                SyntaxNode
                                syntax = pattern.Syntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24645, 24743);

                                var
                                element = f_10330_24659_24742(syntax, f_10330_24684_24726(f_10330_24684_24701(method)[i + extensionExtra]), evaluation, i)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24769, 24829);

                                f_10330_24769_24828(tests, f_10330_24779_24827(this, element, pattern, bindings));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 434);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 434);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 23895, 26992);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 23895, 26992);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 24894, 26992) || true) && (f_10330_24898_24938(inputType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 24894, 26992);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 24894, 26992);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 24894, 26992);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25502, 26992) || true) && (f_10330_25506_25527(inputType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 25502, 26992);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25569, 25632);

                                ImmutableArray<FieldSymbol>
                                elements = f_10330_25608_25631(inputType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25654, 25748);

                                ImmutableArray<TypeWithAnnotations>
                                elementTypes = f_10330_25705_25747(inputType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25770, 25845);

                                int
                                count = f_10330_25782_25844(elementTypes.Length, recursive.Deconstruction.Length)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25876, 25881);
                                    for (int
                i = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25867, 26526) || true) && (i < count)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25894, 25897)
                , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 25867, 26526))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 25867, 26526);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 25947, 26006);

                                        BoundPattern
                                        pattern = f_10330_25970_26005(f_10330_25970_25994(recursive)[i])
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26032, 26067);

                                        SyntaxNode
                                        syntax = pattern.Syntax
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26093, 26125);

                                        FieldSymbol
                                        field = elements[i]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26151, 26240);

                                        var
                                        evaluation = f_10330_26168_26239(syntax, field, f_10330_26211_26238(this, input, field))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26291, 26328);

                                        f_10330_26291_26327(tests, f_10330_26301_26326(evaluation));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26354, 26417);

                                        var
                                        element = f_10330_26368_26416(syntax, f_10330_26393_26403(field), evaluation)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26443, 26503);

                                        f_10330_26443_26502(tests, f_10330_26453_26501(this, element, pattern, bindings));
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 660);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 660);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 25502, 26992);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 25502, 26992);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26660, 26703);

                                f_10330_26660_26702(f_10330_26679_26701(recursive));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 26871, 26973);

                                f_10330_26871_26972(                    // To prevent this pattern from subsuming other patterns and triggering a cascaded diagnostic, we add a test that will fail.
                                                    tests, f_10330_26881_26971(f_10330_26895_26970(recursive.Syntax, f_10330_26934_26945(this), input, hasErrors: true)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 25502, 26992);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 24894, 26992);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 23895, 26992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 23686, 27007);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27023, 28531) || true) && (f_10330_27027_27058_M(!recursive.Properties.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 27023, 28531);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27147, 27152);
                        // we have a "property" form
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27138, 28516) || true) && (i < recursive.Properties.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27187, 27190)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 27138, 28516))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 27138, 28516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27232, 27273);

                            var
                            subPattern = f_10330_27249_27269(recursive)[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27295, 27330);

                            Symbol?
                            symbol = f_10330_27312_27329(subPattern)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27352, 27394);

                            BoundPattern
                            pattern = f_10330_27375_27393(subPattern)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27416, 27446);

                            BoundDagEvaluation
                            evaluation
                            = default(BoundDagEvaluation);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27468, 28238);

                            switch (symbol)
                            {

                                case PropertySymbol property:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 27468, 28238);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27591, 27693);

                                    evaluation = f_10330_27604_27692(pattern.Syntax, property, f_10330_27661_27691(this, input, property));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 27723, 27729);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 27468, 28238);

                                case FieldSymbol field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 27468, 28238);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 27808, 27901);

                                    evaluation = f_10330_27821_27900(pattern.Syntax, field, f_10330_27872_27899(this, input, field));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 27931, 27937);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 27468, 28238);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 27468, 28238);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28001, 28044);

                                    f_10330_28001_28043(f_10330_28020_28042(recursive));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28074, 28176);

                                    f_10330_28074_28175(tests, f_10330_28084_28174(f_10330_28098_28173(recursive.Syntax, f_10330_28137_28148(this), input, hasErrors: true)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28206, 28215);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 27468, 28238);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28262, 28299);

                            f_10330_28262_28298(
                                                tests, f_10330_28272_28297(evaluation));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28321, 28415);

                            var
                            element = f_10330_28335_28414(pattern.Syntax, f_10330_28368_28396(symbol).Type, evaluation)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28437, 28497);

                            f_10330_28437_28496(tests, f_10330_28447_28495(this, element, pattern, bindings));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 1379);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 1379);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 27023, 28531);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28547, 28756) || true) && (f_10330_28551_28575(recursive) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 28547, 28756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28670, 28741);

                    f_10330_28670_28740(                // we have a "variable" declaration
                                    bindings, f_10330_28683_28739(f_10330_28707_28731(recursive), input));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 28547, 28756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28772, 28811);

                return f_10330_28779_28810(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 22946, 28822);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23218_23228(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23218, 23228);
                    return return_v;
                }


                bool
                f_10330_23218_23242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23218, 23242);
                    return return_v;
                }


                bool
                f_10330_23246_23265(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23246, 23265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23269_23288(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23269, 23288);
                    return return_v;
                }


                bool
                f_10330_23269_23302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23269, 23302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23306_23316(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23306, 23316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23324_23343(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23324, 23343);
                    return return_v;
                }


                bool
                f_10330_23306_23378(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23306, 23378);
                    return return_v;
                }


                int
                f_10330_23199_23379(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23199, 23379);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?
                f_10330_23410_23432(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.DeclaredType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23410, 23432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10330_23410_23438_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23410, 23438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23442_23452(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23442, 23452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_23442_23467(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23442, 23467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_23494_23528(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23494, 23528);
                    return return_v;
                }


                bool
                f_10330_23630_23661(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.IsExplicitNotNullTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23630, 23661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_23560_23669(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input, syntax, type, isExplicitTest: isExplicitTest, tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 23560, 23669);
                    return return_v;
                }


                bool
                f_10330_23690_23725_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23690, 23725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10330_23899_23926(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.DeconstructMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23899, 23926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10330_23998_24025(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.DeconstructMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 23998, 24025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_24125_24153(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24125, 24153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                f_10330_24065_24154(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                deconstructMethod, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation(syntax, deconstructMethod, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24065, 24154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_24187_24212(Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24187, 24212);
                    return return_v;
                }


                int
                f_10330_24177_24213(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24177, 24213);
                    return 0;
                }


                bool
                f_10330_24257_24272(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24257, 24272);
                    return return_v;
                }


                int
                f_10330_24324_24345(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24324, 24345);
                    return return_v;
                }


                int
                f_10330_24315_24396(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24315, 24396);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10330_24522_24546(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Deconstruction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24522, 24546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_24522_24557(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24522, 24557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10330_24684_24701(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24684, 24701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_24684_24726(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 24684, 24726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_24659_24742(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagDeconstructEvaluation
                source, int
                index)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24659, 24742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_24779_24827(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24779, 24827);
                    return return_v;
                }


                int
                f_10330_24769_24828(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24769, 24828);
                    return 0;
                }


                bool
                f_10330_24898_24938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = Binder.IsZeroElementTupleType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 24898, 24938);
                    return return_v;
                }


                bool
                f_10330_25506_25527(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 25506, 25527);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10330_25608_25631(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 25608, 25631);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10330_25705_25747(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 25705, 25747);
                    return return_v;
                }


                int
                f_10330_25782_25844(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 25782, 25844);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10330_25970_25994(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Deconstruction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 25970, 25994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_25970_26005(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 25970, 26005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_26211_26238(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26211, 26238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                f_10330_26168_26239(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation(syntax, field, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26168, 26239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_26301_26326(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26301, 26326);
                    return return_v;
                }


                int
                f_10330_26291_26327(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26291, 26327);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_26393_26403(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 26393, 26403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_26368_26416(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, (Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26368, 26416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_26453_26501(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26453, 26501);
                    return return_v;
                }


                int
                f_10330_26443_26502(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26443, 26502);
                    return 0;
                }


                bool
                f_10330_26679_26701(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 26679, 26701);
                    return return_v;
                }


                int
                f_10330_26660_26702(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26660, 26702);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_26934_26945(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param)
                {
                    var return_v = this_param.ErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26934, 26945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                f_10330_26895_26970(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest(syntax, type, input, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26895, 26970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_26881_26971(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26881, 26971);
                    return return_v;
                }


                int
                f_10330_26871_26972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 26871, 26972);
                    return 0;
                }


                bool
                f_10330_27027_27058_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 27027, 27058);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSubpattern>
                f_10330_27249_27269(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 27249, 27269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10330_27312_27329(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 27312, 27329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_27375_27393(Microsoft.CodeAnalysis.CSharp.BoundSubpattern
                this_param)
                {
                    var return_v = this_param.Pattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 27375, 27393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_27661_27691(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 27661, 27691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                f_10330_27604_27692(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation(syntax, property, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 27604, 27692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_27872_27899(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.OriginalInput(input, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 27872, 27899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                f_10330_27821_27900(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation(syntax, field, input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 27821, 27900);
                    return return_v;
                }


                bool
                f_10330_28020_28042(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 28020, 28042);
                    return return_v;
                }


                int
                f_10330_28001_28043(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28001, 28043);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_28137_28148(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param)
                {
                    var return_v = this_param.ErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28137, 28148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                f_10330_28098_28173(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest(syntax, type, input, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28098, 28173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_28084_28174(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28084, 28174);
                    return return_v;
                }


                int
                f_10330_28074_28175(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28074, 28175);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_28272_28297(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28272, 28297);
                    return return_v;
                }


                int
                f_10330_28262_28298(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28262, 28298);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10330_28368_28396(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetTypeOrReturnType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28368, 28396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_28335_28414(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                source)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagTemp(syntax, type, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28335, 28414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_28447_28495(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28447, 28495);
                    return return_v;
                }


                int
                f_10330_28437_28496(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28437, 28496);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10330_28551_28575(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 28551, 28575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10330_28707_28731(Microsoft.CodeAnalysis.CSharp.BoundRecursivePattern
                this_param)
                {
                    var return_v = this_param.VariableAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 28707, 28731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPatternBinding
                f_10330_28683_28739(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variableAccess, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                tempContainingValue)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundPatternBinding(variableAccess, tempContainingValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28683, 28739);
                    return return_v;
                }


                int
                f_10330_28670_28740(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundPatternBinding
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28670, 28740);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_28779_28810(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 28779, 28810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 22946, 28822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 22946, 28822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForNegatedPattern(BoundDagTemp input, BoundNegatedPattern neg, ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 28834, 29118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 28999, 29062);

                var
                tests = f_10330_29011_29061(this, input, f_10330_29039_29050(neg), bindings)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29076, 29107);

                return f_10330_29083_29106(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 28834, 29118);

                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_29039_29050(Microsoft.CodeAnalysis.CSharp.BoundNegatedPattern
                this_param)
                {
                    var return_v = this_param.Negated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29039, 29050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_29011_29061(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29011, 29061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_29083_29106(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                negated)
                {
                    var return_v = Tests.Not.Create(negated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29083, 29106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 28834, 29118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 28834, 29118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForBinaryPattern(
                    BoundDagTemp input,
                    BoundBinaryPattern bin,
                    out BoundDagTemp output,
                    ArrayBuilder<BoundPatternBinding> bindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 29130, 30739);
                Microsoft.CodeAnalysis.CSharp.BoundDagTemp leftOutput = default(Microsoft.CodeAnalysis.CSharp.BoundDagTemp);
                Microsoft.CodeAnalysis.CSharp.BoundDagTemp rightOutput = default(Microsoft.CodeAnalysis.CSharp.BoundDagTemp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29371, 29420);

                var
                builder = f_10330_29385_29419(2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29434, 30728) || true) && (f_10330_29438_29453(bin))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 29434, 30728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29487, 29548);

                    f_10330_29487_29547(builder, f_10330_29499_29546(this, input, f_10330_29527_29535(bin), bindings));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29566, 29628);

                    f_10330_29566_29627(builder, f_10330_29578_29626(this, input, f_10330_29606_29615(bin), bindings));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29646, 29692);

                    var
                    result = f_10330_29659_29691(builder)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29710, 30242) || true) && (f_10330_29714_29752(f_10330_29714_29727(bin), f_10330_29735_29751(bin)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 29710, 30242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29794, 29809);

                        output = input;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29831, 29845);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 29710, 30242);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 29710, 30242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29927, 29972);

                        builder = f_10330_29937_29971(2);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 29994, 30014);

                        f_10330_29994_30013(builder, result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30036, 30160);

                        output = f_10330_30045_30159(this, input: input, syntax: bin.Syntax, type: f_10330_30103_30119(bin), isExplicitTest: false, tests: builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30182, 30223);

                        return f_10330_30189_30222(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 29710, 30242);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 29434, 30728);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 29434, 30728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30308, 30389);

                    f_10330_30308_30388(builder, f_10330_30320_30387(this, input, f_10330_30348_30356(bin), out leftOutput, bindings));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30407, 30495);

                    f_10330_30407_30494(builder, f_10330_30419_30493(this, leftOutput, f_10330_30452_30461(bin), out rightOutput, bindings));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30513, 30534);

                    output = rightOutput;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30552, 30654);

                    f_10330_30552_30653(f_10330_30565_30578(bin) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 30565, 30652) || f_10330_30582_30652(f_10330_30582_30593(output), f_10330_30601_30617(bin), TypeCompareKind.AllIgnoreOptions)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 30672, 30713);

                    return f_10330_30679_30712(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 29434, 30728);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 29130, 30739);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_29385_29419(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29385, 29419);
                    return return_v;
                }


                bool
                f_10330_29438_29453(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Disjunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29438, 29453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_29527_29535(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29527, 29535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_29499_29546(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29499, 29546);
                    return return_v;
                }


                int
                f_10330_29487_29547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29487, 29547);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_29606_29615(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29606, 29615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_29578_29626(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29578, 29626);
                    return return_v;
                }


                int
                f_10330_29566_29627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29566, 29627);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_29659_29691(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.OrSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29659, 29691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_29714_29727(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.InputType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29714, 29727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_29735_29751(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 29735, 29751);
                    return return_v;
                }


                bool
                f_10330_29714_29752(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29714, 29752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_29937_29971(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29937, 29971);
                    return return_v;
                }


                int
                f_10330_29994_30013(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 29994, 30013);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_30103_30119(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30103, 30119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_30045_30159(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input: input, syntax: syntax, type: type, isExplicitTest: isExplicitTest, tests: tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30045, 30159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_30189_30222(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30189, 30222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_30348_30356(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30348, 30356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_30320_30387(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30320, 30387);
                    return return_v;
                }


                int
                f_10330_30308_30388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30308, 30388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPattern
                f_10330_30452_30461(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30452, 30461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_30419_30493(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.CSharp.BoundPattern
                pattern, out Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                output, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings)
                {
                    var return_v = this_param.MakeTestsAndBindings(input, pattern, out output, bindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30419, 30493);
                    return return_v;
                }


                int
                f_10330_30407_30494(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30407, 30494);
                    return 0;
                }


                bool
                f_10330_30565_30578(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30565, 30578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_30582_30593(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30582, 30593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_30601_30617(Microsoft.CodeAnalysis.CSharp.BoundBinaryPattern
                this_param)
                {
                    var return_v = this_param.NarrowedType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 30601, 30617);
                    return return_v;
                }


                bool
                f_10330_30582_30652(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30582, 30652);
                    return return_v;
                }


                int
                f_10330_30552_30653(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30552, 30653);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_30679_30712(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 30679, 30712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 29130, 30739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 29130, 30739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tests MakeTestsAndBindingsForRelationalPattern(
                    BoundDagTemp input,
                    BoundRelationalPattern rel,
                    out BoundDagTemp output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 30751, 31772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31008, 31055);

                var
                tests = f_10330_31020_31054(2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31069, 31162);

                output = f_10330_31078_31161(this, input, rel.Syntax, f_10330_31115_31124(rel).Type!, isExplicitTest: false, tests);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31176, 31222);

                var
                fac = f_10330_31186_31221(f_10330_31210_31220(input))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31236, 31306);

                var
                values = f_10330_31249_31305_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(fac, 10330, 31249, 31305)?.Related(f_10330_31262_31285(f_10330_31262_31274(rel)), f_10330_31287_31304(rel)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31320, 31706) || true) && (f_10330_31324_31339_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(values, 10330, 31324, 31339)?.IsEmpty) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 31320, 31706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31381, 31413);

                    f_10330_31381_31412(tests, Tests.False.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 31320, 31706);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 31320, 31706);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31470, 31706) || true) && (((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 31475, 31489) || ((values != null && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 31492, 31519)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 31522, 31527))) ? f_10330_31492_31519(f_10330_31492_31511(values)) : false) != true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 31470, 31706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31570, 31691);

                        f_10330_31570_31690(tests, f_10330_31580_31689(f_10330_31594_31688(rel.Syntax, f_10330_31633_31645(rel), f_10330_31647_31664(rel), output, f_10330_31674_31687(rel))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 31470, 31706);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 31320, 31706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31722, 31761);

                return f_10330_31729_31760(tests);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 30751, 31772);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_31020_31054(int
                capacity)
                {
                    var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31020, 31054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10330_31115_31124(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31115, 31124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_31078_31161(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isExplicitTest, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                tests)
                {
                    var return_v = this_param.MakeConvertToType(input, syntax, type, isExplicitTest: isExplicitTest, tests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31078, 31161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_31210_31220(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31210, 31220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                f_10330_31186_31221(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ValueSetFactory.ForType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31186, 31221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10330_31262_31274(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31262, 31274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10330_31262_31285(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31262, 31285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_31287_31304(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31287, 31304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.IValueSet?
                f_10330_31249_31305_I(Microsoft.CodeAnalysis.CSharp.IValueSet?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31249, 31305);
                    return return_v;
                }


                bool?
                f_10330_31324_31339_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31324, 31339);
                    return return_v;
                }


                int
                f_10330_31381_31412(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.False
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31381, 31412);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.IValueSet
                f_10330_31492_31511(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param)
                {
                    var return_v = this_param.Complement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31492, 31511);
                    return return_v;
                }


                bool
                f_10330_31492_31519(Microsoft.CodeAnalysis.CSharp.IValueSet
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31492, 31519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10330_31633_31645(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31633, 31645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_31647_31664(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31647, 31664);
                    return return_v;
                }


                bool
                f_10330_31674_31687(Microsoft.CodeAnalysis.CSharp.BoundRelationalPattern
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 31674, 31687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                f_10330_31594_31688(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.ConstantValue
                value, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest(syntax, operatorKind, value, input, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31594, 31688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                f_10330_31580_31689(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                test)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One((Microsoft.CodeAnalysis.CSharp.BoundDagTest)test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31580, 31689);
                    return return_v;
                }


                int
                f_10330_31570_31690(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31570, 31690);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_31729_31760(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                remainingTests)
                {
                    var return_v = Tests.AndSequence.Create(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31729, 31760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 30751, 31772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 30751, 31772);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol ErrorType(string name = "")
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 31784, 31972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 31855, 31961);

                return f_10330_31862_31960(this._compilation, name, arity: 0, errorInfo: null, unreported: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 31784, 31972);

                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10330_31862_31960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity: arity, errorInfo: errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 31862, 31960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 31784, 31972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 31784, 31972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDecisionDag MakeBoundDecisionDag(SyntaxNode syntax, ImmutableArray<StateForCase> cases)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 32339, 33278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 32532, 32581);

                DecisionDag
                decisionDag = f_10330_32558_32580(this, cases)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 32751, 32752);

                // Note: It is useful for debugging the dag state table construction to set a breakpoint
                // here and view `decisionDag.Dump()`.
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 32900, 32974);

                var
                defaultDecision = f_10330_32922_32973(syntax, _defaultLabel)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 32988, 33047);

                f_10330_32988_33046(this, decisionDag, defaultDecision);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 33063, 33114);

                var
                rootDecisionDagNode = decisionDag.RootNode.Dag
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 33128, 33176);

                f_10330_33128_33175(rootDecisionDagNode != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 33190, 33267);

                return f_10330_33197_33266(rootDecisionDagNode.Syntax, rootDecisionDagNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 32339, 33278);

                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag
                f_10330_32558_32580(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                casesForRootNode)
                {
                    var return_v = this_param.MakeDecisionDag(casesForRootNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 32558, 32580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                f_10330_32922_32973(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode(syntax, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 32922, 32973);
                    return return_v;
                }


                int
                f_10330_32988_33046(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag
                decisionDag, Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                defaultDecision)
                {
                    this_param.ComputeBoundDecisionDagNodes(decisionDag, defaultDecision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 32988, 33046);
                    return 0;
                }


                int
                f_10330_33128_33175(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 33128, 33175);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                f_10330_33197_33266(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                rootNode)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDecisionDag(syntax, rootNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 33197, 33266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 32339, 33278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 32339, 33278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DecisionDag MakeDecisionDag(ImmutableArray<StateForCase> casesForRootNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 33501, 41429);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase> whenTrueDecisions = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase> whenFalseDecisions = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>);
                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenTrueValues = default(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>);
                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenFalseValues = default(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 33686, 33738);

                var
                workList = f_10330_33701_33737()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 33849, 33932);

                var
                uniqueState = f_10330_33867_33931(DagStateEquivalence.Instance)
                ;

                DagState uniqifyState(ImmutableArray<StateForCase> cases, ImmutableDictionary<BoundDagTemp, IValueSet> remainingValues)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 34570, 36794);
                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState existingState = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState);
                        Microsoft.CodeAnalysis.CSharp.IValueSet existingValuesForTemp = default(Microsoft.CodeAnalysis.CSharp.IValueSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 34722, 34771);

                        var
                        state = f_10330_34734_34770(cases, remainingValues)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 34789, 36779) || true) && (f_10330_34793_34852(uniqueState, state, out existingState))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 34789, 36779);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 35096, 35182);

                            var
                            newRemainingValues = f_10330_35121_35181()
                            ;
                            foreach (var (dagTemp, valuesForTemp) in remainingValues)
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 35495, 35827) || true) && (f_10330_35499_35580(f_10330_35499_35528(existingState), dagTemp, out existingValuesForTemp))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 35495, 35827);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 35638, 35712);

                                    var
                                    newExistingValuesForTemp = f_10330_35669_35711(existingValuesForTemp, valuesForTemp)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 35742, 35800);

                                    f_10330_35742_35799(newRemainingValues, dagTemp, newExistingValuesForTemp);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 35495, 35827);
                                }
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 35874, 36366) || true) && (f_10330_35878_35913(f_10330_35878_35907(existingState)) != f_10330_35917_35941(newRemainingValues) || (DynAbs.Tracing.TraceSender.Expression_False(10330, 35878, 36100) || !f_10330_35971_36100(f_10330_35971_36000(existingState), kv => newRemainingValues.TryGetValue(kv.Key, out IValueSet? values) && kv.Value.Equals(values))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 35874, 36366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36150, 36220);

                                f_10330_36150_36219(existingState, f_10330_36186_36218(newRemainingValues));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36246, 36343) || true) && (!f_10330_36251_36283(workList, existingState))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 36246, 36343);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36314, 36343);

                                    f_10330_36314_36342(workList, existingState);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 36246, 36343);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 35874, 36366);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36390, 36411);

                            return existingState;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 34789, 36779);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 34789, 36779);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36652, 36682);

                            f_10330_36652_36681(                    // When we add a new unique state, we add it to a work list so that we
                                                                    // will process it to compute its successors.
                                                uniqueState, state, state);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36704, 36725);

                            f_10330_36704_36724(workList, state);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36747, 36760);

                            return state;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 34789, 36779);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 34570, 36794);

                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        f_10330_34734_34770(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                        cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        remainingValues)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState(cases, remainingValues);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 34734, 34770);
                            return return_v;
                        }


                        bool
                        f_10330_34793_34852(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        key, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 34793, 34852);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>.Builder
                        f_10330_35121_35181()
                        {
                            var return_v = ImmutableDictionary.CreateBuilder<BoundDagTemp, IValueSet>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 35121, 35181);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_35499_35528(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        this_param)
                        {
                            var return_v = this_param.RemainingValues;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 35499, 35528);
                            return return_v;
                        }


                        bool
                        f_10330_35499_35580(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, out Microsoft.CodeAnalysis.CSharp.IValueSet
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 35499, 35580);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10330_35669_35711(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param, Microsoft.CodeAnalysis.CSharp.IValueSet
                        other)
                        {
                            var return_v = this_param.Union(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 35669, 35711);
                            return return_v;
                        }


                        int
                        f_10330_35742_35799(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>.Builder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, Microsoft.CodeAnalysis.CSharp.IValueSet
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 35742, 35799);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_35878_35907(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        this_param)
                        {
                            var return_v = this_param.RemainingValues;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 35878, 35907);
                            return return_v;
                        }


                        int
                        f_10330_35878_35913(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 35878, 35913);
                            return return_v;
                        }


                        int
                        f_10330_35917_35941(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>.Builder
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 35917, 35941);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_35971_36000(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        this_param)
                        {
                            var return_v = this_param.RemainingValues;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 35971, 36000);
                            return return_v;
                        }


                        bool
                        f_10330_35971_36100(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>, bool>
                        predicate)
                        {
                            var return_v = source.All<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>>(predicate);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 35971, 36100);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_36186_36218(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>.Builder
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36186, 36218);
                            return return_v;
                        }


                        int
                        f_10330_36150_36219(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        this_param, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        newRemainingValues)
                        {
                            this_param.UpdateRemainingValues(newRemainingValues);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36150, 36219);
                            return 0;
                        }


                        bool
                        f_10330_36251_36283(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36251, 36283);
                            return return_v;
                        }


                        int
                        f_10330_36314_36342(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                        builder, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        e)
                        {
                            builder.Push<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36314, 36342);
                            return 0;
                        }


                        int
                        f_10330_36652_36681(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        key, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36652, 36681);
                            return 0;
                        }


                        int
                        f_10330_36704_36724(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                        builder, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                        e)
                        {
                            builder.Push<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36704, 36724);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 34570, 36794);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 34570, 36794);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36898, 36983);

                var
                rewrittenCases = f_10330_36919_36982(casesForRootNode.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 36997, 37253);
                    foreach (var state in f_10330_37019_37035_I(casesForRootNode))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 36997, 37253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37069, 37123) || true) && (f_10330_37073_37091(state))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 37069, 37123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37114, 37123);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 37069, 37123);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37141, 37167);

                        f_10330_37141_37166(rewrittenCases, state);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37185, 37238) || true) && (f_10330_37189_37209(state))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 37185, 37238);
                            DynAbs.Tracing.TraceSender.TraceBreak(10330, 37232, 37238);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 37185, 37238);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 36997, 37253);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37269, 37390);

                var
                initialState = f_10330_37288_37389(f_10330_37301_37336(rewrittenCases), ImmutableDictionary<BoundDagTemp, IValueSet>.Empty)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37533, 41335) || true) && (f_10330_37540_37554(workList) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 37533, 41335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37593, 37625);

                        DagState
                        state = f_10330_37610_37624(workList)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37643, 37690);

                        f_10330_37643_37689(state.SelectedTest == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37708, 37753);

                        f_10330_37708_37752(state.TrueBranch == null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37771, 37817);

                        f_10330_37771_37816(state.FalseBranch == null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 37835, 38221) || true) && (state.Cases.IsDefaultOrEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 37835, 38221);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 38193, 38202);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 37835, 38221);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 38241, 38277);

                        StateForCase
                        first = state.Cases[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 38297, 38331);

                        f_10330_38297_38330(f_10330_38310_38329_M(!first.IsImpossible));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 38349, 41320) || true) && (f_10330_38353_38377(first))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 38349, 41320);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 38419, 39308) || true) && (f_10330_38423_38443(first))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 38419, 39308);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 38419, 39308);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 38419, 39308);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 39142, 39187);

                                var
                                stateWhenFails = state.Cases.RemoveAt(0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 39213, 39285);

                                state.FalseBranch = f_10330_39233_39284(stateWhenFails, f_10330_39262_39283(state));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 38419, 39308);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 38349, 41320);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 38349, 41320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 39485, 41301);

                            switch (state.SelectedTest = f_10330_39514_39541(state))
                            {

                                case BoundDagEvaluation e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 39485, 41301);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 39647, 39736);

                                    state.TrueBranch = f_10330_39666_39735(f_10330_39679_39711(state.Cases, e), f_10330_39713_39734(state));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 39873, 39879);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 39485, 41301);

                                case BoundDagTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 39485, 41301);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 39955, 39990);

                                    bool
                                    foundExplicitNullTest = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 40020, 40532);

                                    f_10330_40020_40531(this, state.Cases, f_10330_40078_40099(state), d, out whenTrueDecisions, out whenFalseDecisions, out whenTrueValues, out whenFalseValues, ref foundExplicitNullTest);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 40562, 40629);

                                    state.TrueBranch = f_10330_40581_40628(whenTrueDecisions, whenTrueValues);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 40659, 40729);

                                    state.FalseBranch = f_10330_40679_40728(whenFalseDecisions, whenFalseValues);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 40759, 41126) || true) && (foundExplicitNullTest && (DynAbs.Tracing.TraceSender.Expression_True(10330, 40763, 40840) && d is BoundDagNonNullTest { IsExplicitTest: false } t))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 40759, 41126);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 40996, 41095);

                                        state.SelectedTest = f_10330_41017_41094(t.Syntax, isExplicitTest: true, f_10330_41073_41080(t), f_10330_41082_41093(t));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 40759, 41126);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 41156, 41162);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 39485, 41301);

                                case var n:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 39485, 41301);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 41229, 41278);

                                    throw f_10330_41235_41277(f_10330_41270_41276(n));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 39485, 41301);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 38349, 41320);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 37533, 41335);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 37533, 41335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 37533, 41335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 41351, 41367);

                f_10330_41351_41366(
                            workList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 41381, 41418);

                return f_10330_41388_41417(initialState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 33501, 41429);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                f_10330_33701_33737()
                {
                    var return_v = ArrayBuilder<DagState>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 33701, 33737);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                f_10330_33867_33931(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagStateEquivalence
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 33867, 33931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_36919_36982(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 36919, 36982);
                    return return_v;
                }


                bool
                f_10330_37073_37091(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsImpossible;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 37073, 37091);
                    return return_v;
                }


                int
                f_10330_37141_37166(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37141, 37166);
                    return 0;
                }


                bool
                f_10330_37189_37209(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsFullyMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 37189, 37209);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_37019_37035_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37019, 37035);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_37301_37336(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37301, 37336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_37288_37389(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                remainingValues)
                {
                    var return_v = uniqifyState(cases, remainingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37288, 37389);
                    return return_v;
                }


                int
                f_10330_37540_37554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 37540, 37554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_37610_37624(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                builder)
                {
                    var return_v = builder.Pop<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37610, 37624);
                    return return_v;
                }


                int
                f_10330_37643_37689(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37643, 37689);
                    return 0;
                }


                int
                f_10330_37708_37752(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37708, 37752);
                    return 0;
                }


                int
                f_10330_37771_37816(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 37771, 37816);
                    return 0;
                }


                bool
                f_10330_38310_38329_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 38310, 38329);
                    return return_v;
                }


                int
                f_10330_38297_38330(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 38297, 38330);
                    return 0;
                }


                bool
                f_10330_38353_38377(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.PatternIsSatisfied;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 38353, 38377);
                    return return_v;
                }


                bool
                f_10330_38423_38443(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsFullyMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 38423, 38443);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                f_10330_39262_39283(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                this_param)
                {
                    var return_v = this_param.RemainingValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 39262, 39283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_39233_39284(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                remainingValues)
                {
                    var return_v = uniqifyState(cases, remainingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 39233, 39284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTest
                f_10330_39514_39541(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                this_param)
                {
                    var return_v = this_param.ComputeSelectedTest();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 39514, 39541);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_39679_39711(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                e)
                {
                    var return_v = RemoveEvaluation(cases, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 39679, 39711);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                f_10330_39713_39734(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                this_param)
                {
                    var return_v = this_param.RemainingValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 39713, 39734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_39666_39735(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                remainingValues)
                {
                    var return_v = uniqifyState(cases, remainingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 39666, 39735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                f_10330_40078_40099(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                this_param)
                {
                    var return_v = this_param.RemainingValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 40078, 40099);
                    return return_v;
                }


                int
                f_10330_40020_40531(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                statesForCases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                values, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                whenTrue, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                whenFalse, out System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                whenTrueValues, out System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                whenFalseValues, ref bool
                foundExplicitNullTest)
                {
                    this_param.SplitCases(statesForCases, values, test, out whenTrue, out whenFalse, out whenTrueValues, out whenFalseValues, ref foundExplicitNullTest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 40020, 40531);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_40581_40628(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                remainingValues)
                {
                    var return_v = uniqifyState(cases, remainingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 40581, 40628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                f_10330_40679_40728(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                cases, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                remainingValues)
                {
                    var return_v = uniqifyState(cases, remainingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 40679, 40728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_41073_41080(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 41073, 41080);
                    return return_v;
                }


                bool
                f_10330_41082_41093(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 41082, 41093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                f_10330_41017_41094(Microsoft.CodeAnalysis.SyntaxNode
                syntax, bool
                isExplicitTest, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                input, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest(syntax, isExplicitTest: isExplicitTest, input, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41017, 41094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10330_41270_41276(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 41270, 41276);
                    return return_v;
                }


                System.Exception
                f_10330_41235_41277(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41235, 41277);
                    return return_v;
                }


                int
                f_10330_41351_41366(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41351, 41366);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag
                f_10330_41388_41417(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                rootNode)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag(rootNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41388, 41417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 33501, 41429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 33501, 41429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ComputeBoundDecisionDagNodes(DecisionDag decisionDag, BoundLeafDecisionDagNode defaultDecision)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 41685, 46881);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState> sortedStates = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 41818, 41854);

                f_10330_41818_41853(_defaultLabel != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 41868, 41906);

                f_10330_41868_41905(defaultDecision != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 42041, 42155);

                bool
                wasAcyclic = f_10330_42059_42154(decisionDag, out sortedStates)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 42169, 42890) || true) && (!wasAcyclic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 42169, 42890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 42644, 42669);

                    f_10330_42644_42668(wasAcyclic);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 42807, 42850);

                    decisionDag.RootNode.Dag = defaultDecision;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 42868, 42875);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 42169, 42890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43209, 43302);

                var
                uniqueNodes = f_10330_43227_43301()
                ;

                BoundDecisionDagNode uniqifyDagNode(BoundDecisionDagNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 43379, 43414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43382, 43414);
                        return f_10330_43382_43414(uniqueNodes, node, node); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 43379, 43414);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 43379, 43414);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 43379, 43414);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43431, 43467);

                _ = f_10330_43435_43466(defaultDecision);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43492, 43519);

                    for (int
        i = sortedStates.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43483, 46835) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43529, 43532)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43483, 46835))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43483, 46835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43566, 43594);

                        var
                        state = sortedStates[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43612, 43764) || true) && (state.Cases.IsDefaultOrEmpty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43612, 43764);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43686, 43714);

                            state.Dag = defaultDecision;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43736, 43745);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43612, 43764);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43784, 43820);

                        StateForCase
                        first = state.Cases[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43838, 43897);

                        f_10330_43838_43896(!(first.RemainingTests is Tests.False));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43915, 46820) || true) && (f_10330_43919_43943(first))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43915, 46820);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 43985, 44991) || true) && (f_10330_43989_44009(first))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43985, 44991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44131, 44201);

                                state.Dag = f_10330_44143_44200(first.Syntax, first.CaseLabel, first.Bindings);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43985, 44991);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43985, 44991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44299, 44344);

                                f_10330_44299_44343(state.TrueBranch == null);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44370, 44415);

                                f_10330_44370_44414(state.FalseBranch is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44588, 44671);

                                BoundDecisionDagNode
                                whenTrue = f_10330_44620_44670(first.Syntax, first.CaseLabel, default)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44697, 44753);

                                BoundDecisionDagNode?
                                whenFalse = state.FalseBranch.Dag
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44779, 44816);

                                f_10330_44779_44815(whenFalse is { });
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 44842, 44968);

                                state.Dag = f_10330_44854_44967(f_10330_44869_44966(first.Syntax, first.Bindings, first.WhenClause, whenTrue, whenFalse));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43985, 44991);
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10330_44620_44670(Microsoft.CodeAnalysis.SyntaxNode
                            syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                            label, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                            bindings)
                            {
                                var return_v = finalState(syntax, label, bindings);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44620, 44670);
                                return return_v;
                            }

                            Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                            f_10330_44143_44200(Microsoft.CodeAnalysis.SyntaxNode
                            syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                            label, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                            bindings)
                            {
                                var return_v = finalState(syntax, label, bindings);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44143, 44200);
                                return return_v;
                            }

                            BoundDecisionDagNode finalState(SyntaxNode syntax, LabelSymbol label, ImmutableArray<BoundPatternBinding> bindings)
                            {
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 45015, 45442);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45179, 45268);

                                    BoundDecisionDagNode
                                    final = f_10330_45208_45267(f_10330_45223_45266(syntax, label))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45294, 45419);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 45301, 45326) || ((bindings.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 45329, 45334)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 45337, 45418))) ? final : f_10330_45337_45418(f_10330_45352_45417(syntax, bindings, null, final, null));
                                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 45015, 45442);

                                    Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                                    f_10330_45223_45266(Microsoft.CodeAnalysis.SyntaxNode
                                    syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                                    label)
                                    {
                                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode(syntax, label);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45223, 45266);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                                    f_10330_45208_45267(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                                    node)
                                    {
                                        var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45208, 45267);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                                    f_10330_45352_45417(Microsoft.CodeAnalysis.SyntaxNode
                                    syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                                    bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                                    whenExpression, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                                    whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode?
                                    whenFalse)
                                    {
                                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode(syntax, bindings, whenExpression, whenTrue, whenFalse);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45352, 45417);
                                        return return_v;
                                    }


                                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                                    f_10330_45337_45418(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                                    node)
                                    {
                                        var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45337, 45418);
                                        return return_v;
                                    }

                                }
                                catch
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 45015, 45442);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 45015, 45442);
                                }
                                throw new System.Exception("Slicer error: unreachable code");
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43915, 46820);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 43915, 46820);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45524, 46801);

                            switch (state.SelectedTest)
                            {

                                case BoundDagEvaluation e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 45524, 46801);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45691, 45742);

                                        BoundDecisionDagNode?
                                        next = state.TrueBranch!.Dag
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45776, 45808);

                                        f_10330_45776_45807(next is { });
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45842, 45888);

                                        f_10330_45842_45887(state.FalseBranch == null);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 45922, 46004);

                                        state.Dag = f_10330_45934_46003(f_10330_45949_46002(e.Syntax, e, next));
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 46065, 46071);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 45524, 46801);

                                case BoundDagTest d:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 45524, 46801);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46182, 46237);

                                        BoundDecisionDagNode?
                                        whenTrue = state.TrueBranch!.Dag
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46271, 46328);

                                        BoundDecisionDagNode?
                                        whenFalse = state.FalseBranch!.Dag
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46362, 46398);

                                        f_10330_46362_46397(whenTrue is { });
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46432, 46469);

                                        f_10330_46432_46468(whenFalse is { });
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46503, 46594);

                                        state.Dag = f_10330_46515_46593(f_10330_46530_46592(d.Syntax, d, whenTrue, whenFalse));
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10330, 46655, 46661);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 45524, 46801);

                                case var n:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 45524, 46801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46728, 46778);

                                    throw f_10330_46734_46777(f_10330_46769_46776_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(n, 10330, 46769, 46776)?.Kind));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 45524, 46801);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 43915, 46820);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 3353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 3353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 46851, 46870);

                f_10330_46851_46869(
                            uniqueNodes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 41685, 46881);

                int
                f_10330_41818_41853(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41818, 41853);
                    return 0;
                }


                int
                f_10330_41868_41905(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 41868, 41905);
                    return 0;
                }


                bool
                f_10330_42059_42154(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag
                this_param, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                result)
                {
                    var return_v = this_param.TryGetTopologicallySortedReachableStates(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 42059, 42154);
                    return return_v;
                }


                int
                f_10330_42644_42668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 42644, 42668);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                f_10330_43227_43301()
                {
                    var return_v = PooledDictionary<BoundDecisionDagNode, BoundDecisionDagNode>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 43227, 43301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10330_43382_43414(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                dictionary, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                key, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                value)
                {
                    var return_v = dictionary.GetOrAdd<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 43382, 43414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10330_43435_43466(Microsoft.CodeAnalysis.CSharp.BoundLeafDecisionDagNode
                node)
                {
                    var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 43435, 43466);
                    return return_v;
                }


                int
                f_10330_43838_43896(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 43838, 43896);
                    return 0;
                }


                bool
                f_10330_43919_43943(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.PatternIsSatisfied;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 43919, 43943);
                    return return_v;
                }


                bool
                f_10330_43989_44009(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsFullyMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 43989, 44009);
                    return return_v;
                }


                int
                f_10330_44299_44343(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44299, 44343);
                    return 0;
                }


                int
                f_10330_44370_44414(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44370, 44414);
                    return 0;
                }


                int
                f_10330_44779_44815(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44779, 44815);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                f_10330_44869_44966(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenExpression, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenFalse)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode(syntax, bindings, whenExpression, whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44869, 44966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10330_44854_44967(Microsoft.CodeAnalysis.CSharp.BoundWhenDecisionDagNode
                node)
                {
                    var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 44854, 44967);
                    return return_v;
                }


                int
                f_10330_45776_45807(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45776, 45807);
                    return 0;
                }


                int
                f_10330_45842_45887(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45842, 45887);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                f_10330_45949_46002(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                evaluation, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode(syntax, evaluation, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45949, 46002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10330_45934_46003(Microsoft.CodeAnalysis.CSharp.BoundEvaluationDecisionDagNode
                node)
                {
                    var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 45934, 46003);
                    return return_v;
                }


                int
                f_10330_46362_46397(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46362, 46397);
                    return 0;
                }


                int
                f_10330_46432_46468(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46432, 46468);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                f_10330_46530_46592(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenTrue, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                whenFalse)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode(syntax, test, whenTrue, whenFalse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46530, 46592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode
                f_10330_46515_46593(Microsoft.CodeAnalysis.CSharp.BoundTestDecisionDagNode
                node)
                {
                    var return_v = uniqifyDagNode((Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46515, 46593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10330_46769_46776_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 46769, 46776);
                    return return_v;
                }


                System.Exception
                f_10330_46734_46777(Microsoft.CodeAnalysis.CSharp.BoundKind?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object?)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46734, 46777);
                    return return_v;
                }


                int
                f_10330_46851_46869(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode, Microsoft.CodeAnalysis.CSharp.BoundDecisionDagNode>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 46851, 46869);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 41685, 46881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 41685, 46881);
            }
        }

        private void SplitCase(
                    StateForCase stateForCase,
                    BoundDagTest test,
                    IValueSet? whenTrueValues,
                    IValueSet? whenFalseValues,
                    out StateForCase whenTrue,
                    out StateForCase whenFalse,
                    ref bool foundExplicitNullTest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 46893, 47931);
                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests whenTrueTests = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests whenFalseTests = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 47220, 47378);

                f_10330_47220_47377(stateForCase.RemainingTests, this, test, whenTrueValues, whenFalseValues, out whenTrueTests, out whenFalseTests, ref foundExplicitNullTest);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 47392, 47427);

                whenTrue = f_10330_47403_47426(whenTrueTests);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 47441, 47478);

                whenFalse = f_10330_47453_47477(whenFalseTests);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 47492, 47499);

                return;

                StateForCase makeNext(Tests remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 47515, 47920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 47591, 47905);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 47598, 47648) || ((f_10330_47598_47648(remainingTests, stateForCase.RemainingTests) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 47672, 47684)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 47708, 47904))) ? stateForCase
                        : f_10330_47708_47904(stateForCase.Index, stateForCase.Syntax, remainingTests, stateForCase.Bindings, stateForCase.WhenClause, stateForCase.CaseLabel);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 47515, 47920);

                        bool
                        f_10330_47598_47648(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        obj)
                        {
                            var return_v = this_param.Equals((object)obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 47598, 47648);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                        f_10330_47708_47904(int
                        Index, Microsoft.CodeAnalysis.SyntaxNode
                        Syntax, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        RemainingTests, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                        Bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        WhenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        CaseLabel)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase(Index, Syntax, RemainingTests, Bindings, WhenClause, CaseLabel);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 47708, 47904);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 47515, 47920);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 47515, 47920);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 46893, 47931);

                int
                f_10330_47220_47377(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                builder, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test, Microsoft.CodeAnalysis.CSharp.IValueSet?
                whenTrueValues, Microsoft.CodeAnalysis.CSharp.IValueSet?
                whenFalseValues, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                whenTrue, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                whenFalse, ref bool
                foundExplicitNullTest)
                {
                    this_param.Filter(builder, test, whenTrueValues, whenFalseValues, out whenTrue, out whenFalse, ref foundExplicitNullTest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 47220, 47377);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_47403_47426(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                remainingTests)
                {
                    var return_v = makeNext(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 47403, 47426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_47453_47477(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                remainingTests)
                {
                    var return_v = makeNext(remainingTests);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 47453, 47477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 46893, 47931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 46893, 47931);
            }
        }

        private void SplitCases(
                    ImmutableArray<StateForCase> statesForCases,
                    ImmutableDictionary<BoundDagTemp, IValueSet> values,
                    BoundDagTest test,
                    out ImmutableArray<StateForCase> whenTrue,
                    out ImmutableArray<StateForCase> whenFalse,
                    out ImmutableDictionary<BoundDagTemp, IValueSet> whenTrueValues,
                    out ImmutableDictionary<BoundDagTemp, IValueSet> whenFalseValues,
                    ref bool foundExplicitNullTest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 47943, 50702);
                Microsoft.CodeAnalysis.CSharp.IValueSet v1 = default(Microsoft.CodeAnalysis.CSharp.IValueSet);
                Microsoft.CodeAnalysis.CSharp.IValueSet v2 = default(Microsoft.CodeAnalysis.CSharp.IValueSet);
                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase whenTrueState = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase);
                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase whenFalseState = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 48463, 48547);

                var
                whenTrueBuilder = f_10330_48485_48546(statesForCases.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 48561, 48646);

                var
                whenFalseBuilder = f_10330_48584_48645(statesForCases.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 48660, 48701);

                bool
                whenTruePossible
                = default(bool),
                whenFalsePossible
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 48715, 48814);

                (whenTrueValues, whenFalseValues, whenTruePossible, whenFalsePossible) = f_10330_48788_48813(values, test);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 49367, 50563);
                    foreach (var state in f_10330_49389_49403_I(statesForCases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 49367, 50563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 49437, 49748);

                        f_10330_49437_49747(this, state, test, (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 49503, 49553) || ((f_10330_49503_49553(whenTrueValues, f_10330_49530_49540(test), out v1) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 49556, 49558)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 49561, 49565))) ? v1 : null, (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 49588, 49639) || ((f_10330_49588_49639(whenFalseValues, f_10330_49616_49626(test), out v2) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 49642, 49644)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 49647, 49651))) ? v2 : null, out whenTrueState, out whenFalseState, ref foundExplicitNullTest);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50111, 50289) || true) && (whenTruePossible && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50115, 50162) && f_10330_50135_50162_M(!whenTrueState.IsImpossible)) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50115, 50231) && !(f_10330_50168_50189(whenTrueBuilder) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50168, 50230) && f_10330_50193_50230(f_10330_50193_50215(whenTrueBuilder))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 50111, 50289);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50254, 50289);

                            f_10330_50254_50288(whenTrueBuilder, whenTrueState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 50111, 50289);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50364, 50548) || true) && (whenFalsePossible && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50368, 50417) && f_10330_50389_50417_M(!whenFalseState.IsImpossible)) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50368, 50488) && !(f_10330_50423_50445(whenFalseBuilder) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 50423, 50487) && f_10330_50449_50487(f_10330_50449_50472(whenFalseBuilder))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 50364, 50548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50511, 50548);

                            f_10330_50511_50547(whenFalseBuilder, whenFalseState);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 50364, 50548);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 49367, 50563);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 1197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 1197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50579, 50627);

                whenTrue = f_10330_50590_50626(whenTrueBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 50641, 50691);

                whenFalse = f_10330_50653_50690(whenFalseBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 47943, 50702);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_48485_48546(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 48485, 48546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_48584_48645(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 48584, 48645);
                    return return_v;
                }


                (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenTrueValues, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenFalseValues, bool truePossible, bool falsePossible)
                f_10330_48788_48813(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                values, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test)
                {
                    var return_v = SplitValues(values, test);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 48788, 48813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_49530_49540(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 49530, 49540);
                    return return_v;
                }


                bool
                f_10330_49503_49553(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, out Microsoft.CodeAnalysis.CSharp.IValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 49503, 49553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_49616_49626(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 49616, 49626);
                    return return_v;
                }


                bool
                f_10330_49588_49639(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                key, out Microsoft.CodeAnalysis.CSharp.IValueSet
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 49588, 49639);
                    return return_v;
                }


                int
                f_10330_49437_49747(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                stateForCase, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                test, Microsoft.CodeAnalysis.CSharp.IValueSet?
                whenTrueValues, Microsoft.CodeAnalysis.CSharp.IValueSet?
                whenFalseValues, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                whenTrue, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                whenFalse, ref bool
                foundExplicitNullTest)
                {
                    this_param.SplitCase(stateForCase, test, whenTrueValues, whenFalseValues, out whenTrue, out whenFalse, ref foundExplicitNullTest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 49437, 49747);
                    return 0;
                }


                bool
                f_10330_50135_50162_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 50135, 50162);
                    return return_v;
                }


                bool
                f_10330_50168_50189(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50168, 50189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_50193_50215(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50193, 50215);
                    return return_v;
                }


                bool
                f_10330_50193_50230(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsFullyMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 50193, 50230);
                    return return_v;
                }


                int
                f_10330_50254_50288(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50254, 50288);
                    return 0;
                }


                bool
                f_10330_50389_50417_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 50389, 50417);
                    return return_v;
                }


                bool
                f_10330_50423_50445(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50423, 50445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_50449_50472(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50449, 50472);
                    return return_v;
                }


                bool
                f_10330_50449_50487(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                this_param)
                {
                    var return_v = this_param.IsFullyMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 50449, 50487);
                    return return_v;
                }


                int
                f_10330_50511_50547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50511, 50547);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_49389_49403_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 49389, 49403);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_50590_50626(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50590, 50626);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_50653_50690(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 50653, 50690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 47943, 50702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 47943, 50702);
            }
        }

        private static (
                    ImmutableDictionary<BoundDagTemp, IValueSet> whenTrueValues,
                    ImmutableDictionary<BoundDagTemp, IValueSet> whenFalseValues,
                    bool truePossible,
                    bool falsePossible)
                    SplitValues(
                    ImmutableDictionary<BoundDagTemp, IValueSet> values,
                    BoundDagTest test)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 50714, 53167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 51093, 51711);

                switch (test)
                {

                    case BoundDagEvaluation _:
                    case BoundDagExplicitNullTest _:
                    case BoundDagNonNullTest _:
                    case BoundDagTypeTest _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 51093, 51711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 51324, 51360);

                        return (values, values, true, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 51093, 51711);

                    case BoundDagValueTest t:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 51093, 51711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 51425, 51485);

                        return f_10330_51432_51484(BinaryOperatorKind.Equal, f_10330_51476_51483(t));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 51093, 51711);

                    case BoundDagRelationalTest t:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 51093, 51711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 51555, 51601);

                        return f_10330_51562_51600(f_10330_51580_51590(t), f_10330_51592_51599(t));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 51093, 51711);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 51093, 51711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 51649, 51696);

                        throw f_10330_51655_51695(test);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 51093, 51711);
                }

                (
                            ImmutableDictionary<BoundDagTemp, IValueSet> whenTrueValues,
                            ImmutableDictionary<BoundDagTemp, IValueSet> whenFalseValues,
                            bool truePossible,
                            bool falsePossible)
                            resultForRelation(BinaryOperatorKind relation, ConstantValue value)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 51727, 53156);
                        Microsoft.CodeAnalysis.CSharp.IValueSet tempValuesBeforeTest = default(Microsoft.CodeAnalysis.CSharp.IValueSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52056, 52079);

                        var
                        input = f_10330_52068_52078(test)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52097, 52162);

                        IValueSetFactory?
                        valueFac = f_10330_52126_52161(f_10330_52150_52160(input))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52180, 52403) || true) && (valueFac == null || (DynAbs.Tracing.TraceSender.Expression_False(10330, 52184, 52215) || f_10330_52204_52215(value)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 52180, 52403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52348, 52384);

                            return (values, values, true, true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 52180, 52403);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52421, 52494);

                        IValueSet
                        fromTestPassing = f_10330_52449_52493(valueFac, f_10330_52466_52485(relation), value)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52512, 52569);

                        IValueSet
                        fromTestFailing = f_10330_52540_52568(fromTestPassing)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52587, 52873) || true) && (f_10330_52591_52658(values, f_10330_52610_52620(test), out tempValuesBeforeTest))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 52587, 52873);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52700, 52766);

                            fromTestPassing = f_10330_52718_52765(fromTestPassing, tempValuesBeforeTest);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52788, 52854);

                            fromTestFailing = f_10330_52806_52853(fromTestFailing, tempValuesBeforeTest);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 52587, 52873);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52891, 52951);

                        var
                        whenTrueValues = f_10330_52912_52950(values, input, fromTestPassing)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 52969, 53030);

                        var
                        whenFalseValues = f_10330_52991_53029(values, input, fromTestFailing)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53048, 53141);

                        return (whenTrueValues, whenFalseValues, f_10330_53089_53113_M(!fromTestPassing.IsEmpty), f_10330_53115_53139_M(!fromTestFailing.IsEmpty));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 51727, 53156);

                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_52068_52078(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 52068, 52078);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10330_52150_52160(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 52150, 52160);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSetFactory?
                        f_10330_52126_52161(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = ValueSetFactory.ForType(type);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52126, 52161);
                            return return_v;
                        }


                        bool
                        f_10330_52204_52215(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.IsBad;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 52204, 52215);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        f_10330_52466_52485(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        kind)
                        {
                            var return_v = kind.Operator();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52466, 52485);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10330_52449_52493(Microsoft.CodeAnalysis.CSharp.IValueSetFactory
                        this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        relation, Microsoft.CodeAnalysis.ConstantValue
                        value)
                        {
                            var return_v = this_param.Related(relation, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52449, 52493);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10330_52540_52568(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param)
                        {
                            var return_v = this_param.Complement();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52540, 52568);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_52610_52620(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 52610, 52620);
                            return return_v;
                        }


                        bool
                        f_10330_52591_52658(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, out Microsoft.CodeAnalysis.CSharp.IValueSet?
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52591, 52658);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10330_52718_52765(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param, Microsoft.CodeAnalysis.CSharp.IValueSet
                        other)
                        {
                            var return_v = this_param.Intersect(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52718, 52765);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.IValueSet
                        f_10330_52806_52853(Microsoft.CodeAnalysis.CSharp.IValueSet
                        this_param, Microsoft.CodeAnalysis.CSharp.IValueSet
                        other)
                        {
                            var return_v = this_param.Intersect(other);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52806, 52853);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_52912_52950(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, Microsoft.CodeAnalysis.CSharp.IValueSet
                        value)
                        {
                            var return_v = this_param.SetItem(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52912, 52950);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        f_10330_52991_53029(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        key, Microsoft.CodeAnalysis.CSharp.IValueSet
                        value)
                        {
                            var return_v = this_param.SetItem(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 52991, 53029);
                            return return_v;
                        }


                        bool
                        f_10330_53089_53113_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 53089, 53113);
                            return return_v;
                        }


                        bool
                        f_10330_53115_53139_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 53115, 53139);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 51727, 53156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 51727, 53156);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 50714, 53167);

                Microsoft.CodeAnalysis.ConstantValue
                f_10330_51476_51483(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 51476, 51483);
                    return return_v;
                }


                (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenTrueValues, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenFalseValues, bool truePossible, bool falsePossible)
                f_10330_51432_51484(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = resultForRelation(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 51432, 51484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10330_51580_51590(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 51580, 51590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_51592_51599(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 51592, 51599);
                    return return_v;
                }


                (System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenTrueValues, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet> whenFalseValues, bool truePossible, bool falsePossible)
                f_10330_51562_51600(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                relation, Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = resultForRelation(relation, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 51562, 51600);
                    return return_v;
                }


                System.Exception
                f_10330_51655_51695(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 51655, 51695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 50714, 53167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 50714, 53167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<StateForCase> RemoveEvaluation(ImmutableArray<StateForCase> cases, BoundDagEvaluation e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 53179, 54247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53322, 53389);

                var
                builder = f_10330_53336_53388(cases.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53403, 54184);
                    foreach (var stateForCase in f_10330_53432_53437_I(cases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 53403, 54184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53471, 53540);

                        var
                        remainingTests = f_10330_53492_53539(stateForCase.RemainingTests, e)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53558, 54169) || true) && (remainingTests is Tests.False)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 53558, 54169);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 53558, 54169);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 53558, 54169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 53851, 54150);

                            f_10330_53851_54149(builder, f_10330_53863_54148(Index: stateForCase.Index, Syntax: stateForCase.Syntax, RemainingTests: remainingTests, Bindings: stateForCase.Bindings, WhenClause: stateForCase.WhenClause, CaseLabel: stateForCase.CaseLabel));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 53558, 54169);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 53403, 54184);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 54200, 54236);

                return f_10330_54207_54235(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 53179, 54247);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_53336_53388(int
                capacity)
                {
                    var return_v = ArrayBuilder<StateForCase>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 53336, 53388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                f_10330_53492_53539(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                e)
                {
                    var return_v = this_param.RemoveEvaluation(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 53492, 53539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                f_10330_53863_54148(int
                Index, Microsoft.CodeAnalysis.SyntaxNode
                Syntax, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                RemainingTests, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundPatternBinding>
                Bindings, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                WhenClause, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                CaseLabel)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase(Index: Index, Syntax: Syntax, RemainingTests: RemainingTests, Bindings: Bindings, WhenClause: WhenClause, CaseLabel: CaseLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 53863, 54148);
                    return return_v;
                }


                int
                f_10330_53851_54149(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 53851, 54149);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_53432_53437_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 53432, 53437);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                f_10330_54207_54235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 54207, 54235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 53179, 54247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 53179, 54247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckConsistentDecision(
                    BoundDagTest test,
                    BoundDagTest other,
                    IValueSet? whenTrueValues,
                    IValueSet? whenFalseValues,
                    SyntaxNode syntax,
                    out bool trueTestPermitsTrueOther,
                    out bool falseTestPermitsTrueOther,
                    out bool trueTestImpliesTrueOther,
                    out bool falseTestImpliesTrueOther,
                    ref bool foundExplicitNullTest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 55463, 64513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 55987, 56019);

                trueTestPermitsTrueOther = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56033, 56066);

                falseTestPermitsTrueOther = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56080, 56113);

                trueTestImpliesTrueOther = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56127, 56161);

                falseTestImpliesTrueOther = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56278, 56339) || true) && (!f_10330_56283_56313(f_10330_56283_56293(test), f_10330_56301_56312(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56278, 56339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56332, 56339);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56278, 56339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56355, 64502);

                switch (test)
                {

                    case BoundDagNonNullTest _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56355, 64502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56450, 57759);

                        switch (other)
                        {

                            case BoundDagValueTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56450, 57759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56627, 56661);

                                falseTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 56691, 56697);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56450, 57759);

                            case BoundDagExplicitNullTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56450, 57759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56785, 56814);

                                foundExplicitNullTest = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 56903, 56936);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57025, 57058);

                                falseTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 57088, 57094);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56450, 57759);

                            case BoundDagNonNullTest n2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56450, 57759);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57178, 57263) || true) && (f_10330_57182_57199(n2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57178, 57263);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57234, 57263);

                                    foundExplicitNullTest = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57178, 57263);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57349, 57381);

                                trueTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57473, 57507);

                                falseTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 57537, 57543);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56450, 57759);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56450, 57759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57666, 57700);

                                falseTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 57730, 57736);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56450, 57759);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 57781, 57787);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56355, 64502);

                    case BoundDagTypeTest t1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56355, 64502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57852, 60258);

                        switch (other)
                        {

                            case BoundDagNonNullTest n2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57852, 60258);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 57973, 58058) || true) && (f_10330_57977_57994(n2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57973, 58058);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58029, 58058);

                                    foundExplicitNullTest = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57973, 58058);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58141, 58173);

                                trueTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 58203, 58209);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57852, 60258);

                            case BoundDagTypeTest t2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57852, 60258);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58325, 58376);

                                    HashSet<DiagnosticInfo>?
                                    useSiteDiagnostics = null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58410, 58536);

                                    bool?
                                    matches = f_10330_58426_58535(this, f_10330_58494_58501(t1), f_10330_58503_58510(t2), ref useSiteDiagnostics)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58570, 59168) || true) && (matches == false)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 58570, 59168);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58791, 58824);

                                        trueTestPermitsTrueOther = false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 58570, 59168);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 58570, 59168);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 58898, 59168) || true) && (matches == true)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 58898, 59168);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 59101, 59133);

                                            trueTestImpliesTrueOther = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 58898, 59168);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 58570, 59168);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 59303, 59418);

                                    matches = f_10330_59313_59417(_conversions, f_10330_59369_59376(t2), f_10330_59378_59385(t1), ref useSiteDiagnostics, out _);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 59452, 59497);

                                    f_10330_59452_59496(_diagnostics, syntax, useSiteDiagnostics);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 59531, 59809) || true) && (matches == true)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 59531, 59809);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 59740, 59774);

                                        falseTestPermitsTrueOther = false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 59531, 59809);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 59870, 59876);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57852, 60258);

                            case BoundDagValueTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57852, 60258);
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 59957, 59963);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57852, 60258);

                            case BoundDagExplicitNullTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 57852, 60258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60051, 60080);

                                foundExplicitNullTest = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60166, 60199);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 60229, 60235);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 57852, 60258);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 60280, 60286);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56355, 64502);

                    case BoundDagValueTest _:
                    case BoundDagRelationalTest _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56355, 64502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60399, 62991);

                        switch (other)
                        {

                            case BoundDagNonNullTest n2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60399, 62991);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60520, 60605) || true) && (f_10330_60524_60541(n2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60520, 60605);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60576, 60605);

                                    foundExplicitNullTest = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60520, 60605);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60688, 60720);

                                trueTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 60750, 60756);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60399, 62991);

                            case BoundDagTypeTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60399, 62991);
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 60836, 60842);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60399, 62991);

                            case BoundDagExplicitNullTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60399, 62991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 60930, 60959);

                                foundExplicitNullTest = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 61045, 61078);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 61108, 61114);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60399, 62991);

                            case BoundDagRelationalTest r2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60399, 62991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 61201, 61403);

                                f_10330_61201_61402(f_10330_61225_61236(r2), f_10330_61238_61246(r2), out trueTestPermitsTrueOther, out falseTestPermitsTrueOther, out trueTestImpliesTrueOther, out falseTestImpliesTrueOther);
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 61433, 61439);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60399, 62991);

                            case BoundDagValueTest v2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 60399, 62991);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 61521, 61736);

                                f_10330_61521_61735(BinaryOperatorKind.Equal, f_10330_61571_61579(v2), out trueTestPermitsTrueOther, out falseTestPermitsTrueOther, out trueTestImpliesTrueOther, out falseTestImpliesTrueOther);
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 61766, 61772);

                                break;

                                int
                                f_10330_61521_61735(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                relation, Microsoft.CodeAnalysis.ConstantValue
                                value, out bool
                                trueTestPermitsTrueOther, out bool
                                falseTestPermitsTrueOther, out bool
                                trueTestImpliesTrueOther, out bool
                                falseTestImpliesTrueOther)
                                {
                                    handleRelationWithValue(relation, value, out trueTestPermitsTrueOther, out falseTestPermitsTrueOther, out trueTestImpliesTrueOther, out falseTestImpliesTrueOther);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 61521, 61735);
                                    return 0;
                                }

                                int
                                f_10330_61201_61402(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                                relation, Microsoft.CodeAnalysis.ConstantValue
                                value, out bool
                                trueTestPermitsTrueOther, out bool
                                falseTestPermitsTrueOther, out bool
                                trueTestImpliesTrueOther, out bool
                                falseTestImpliesTrueOther)
                                {
                                    handleRelationWithValue(relation, value, out trueTestPermitsTrueOther, out falseTestPermitsTrueOther, out trueTestImpliesTrueOther, out falseTestImpliesTrueOther);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 61201, 61402);
                                    return 0;
                                }

                                void handleRelationWithValue(
                                                                BinaryOperatorKind relation,
                                                                ConstantValue value,
                                                                out bool trueTestPermitsTrueOther,
                                                                out bool falseTestPermitsTrueOther,
                                                                out bool trueTestImpliesTrueOther,
                                                                out bool falseTestImpliesTrueOther)
                                {
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 61804, 62968);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 62384, 62419);

                                        bool
                                        sameTest = f_10330_62400_62418(test, other)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 62453, 62525);

                                        trueTestPermitsTrueOther = f_10330_62480_62516_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(whenTrueValues, 10330, 62480, 62516)?.Any(relation, value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10330, 62480, 62524) ?? true);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 62559, 62674);

                                        trueTestImpliesTrueOther = sameTest || (DynAbs.Tracing.TraceSender.Expression_False(10330, 62586, 62673) || trueTestPermitsTrueOther && (DynAbs.Tracing.TraceSender.Expression_True(10330, 62598, 62673) && (f_10330_62627_62663_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(whenTrueValues, 10330, 62627, 62663)?.All(relation, value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10330, 62627, 62672) ?? false))));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 62708, 62797);

                                        falseTestPermitsTrueOther = !sameTest && (DynAbs.Tracing.TraceSender.Expression_True(10330, 62736, 62796) && (f_10330_62750_62787_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(whenFalseValues, 10330, 62750, 62787)?.Any(relation, value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10330, 62750, 62795) ?? true)));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 62831, 62937);

                                        falseTestImpliesTrueOther = falseTestPermitsTrueOther && (DynAbs.Tracing.TraceSender.Expression_True(10330, 62859, 62936) && (f_10330_62889_62926_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(whenFalseValues, 10330, 62889, 62926)?.All(relation, value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10330, 62889, 62935) ?? false)));
                                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 61804, 62968);

                                        bool
                                        f_10330_62400_62418(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                                        obj)
                                        {
                                            var return_v = this_param.Equals((object)obj);
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 62400, 62418);
                                            return return_v;
                                        }


                                        bool?
                                        f_10330_62480_62516_I(bool?
                                        i)
                                        {
                                            var return_v = i;
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 62480, 62516);
                                            return return_v;
                                        }


                                        bool?
                                        f_10330_62627_62663_I(bool?
                                        i)
                                        {
                                            var return_v = i;
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 62627, 62663);
                                            return return_v;
                                        }


                                        bool?
                                        f_10330_62750_62787_I(bool?
                                        i)
                                        {
                                            var return_v = i;
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 62750, 62787);
                                            return return_v;
                                        }


                                        bool?
                                        f_10330_62889_62926_I(bool?
                                        i)
                                        {
                                            var return_v = i;
                                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 62889, 62926);
                                            return return_v;
                                        }

                                    }
                                    catch
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 61804, 62968);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 61804, 62968);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 60399, 62991);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 63013, 63019);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56355, 64502);

                    case BoundDagExplicitNullTest _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 56355, 64502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63091, 63120);

                        foundExplicitNullTest = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63142, 64459);

                        switch (other)
                        {

                            case BoundDagNonNullTest n2:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 63142, 64459);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63263, 63348) || true) && (f_10330_63267_63284(n2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 63263, 63348);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63319, 63348);

                                    foundExplicitNullTest = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 63263, 63348);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63437, 63470);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63559, 63592);

                                falseTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 63622, 63628);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 63142, 64459);

                            case BoundDagTypeTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 63142, 64459);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63764, 63797);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 63827, 63833);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 63142, 64459);

                            case BoundDagExplicitNullTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 63142, 64459);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 63921, 63950);

                                foundExplicitNullTest = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 64036, 64068);

                                trueTestImpliesTrueOther = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 64160, 64194);

                                falseTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 64224, 64230);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 63142, 64459);

                            case BoundDagValueTest _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 63142, 64459);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 64367, 64400);

                                trueTestPermitsTrueOther = false;
                                DynAbs.Tracing.TraceSender.TraceBreak(10330, 64430, 64436);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 63142, 64459);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 64481, 64487);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 56355, 64502);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 55463, 64513);

                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_56283_56293(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 56283, 56293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                f_10330_56301_56312(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                this_param)
                {
                    var return_v = this_param.Input;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 56301, 56312);
                    return return_v;
                }


                bool
                f_10330_56283_56313(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 56283, 56313);
                    return return_v;
                }


                bool
                f_10330_57182_57199(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 57182, 57199);
                    return return_v;
                }


                bool
                f_10330_57977_57994(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 57977, 57994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_58494_58501(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 58494, 58501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_58503_58510(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 58503, 58510);
                    return return_v;
                }


                bool?
                f_10330_58426_58535(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ExpressionOfTypeMatchesPatternTypeForLearningFromSuccessfulTypeTest(expressionType, patternType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 58426, 58535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_59369_59376(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 59369, 59376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10330_59378_59385(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 59378, 59385);
                    return return_v;
                }


                bool?
                f_10330_59313_59417(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = Binder.ExpressionOfTypeMatchesPatternType(conversions, expressionType, patternType, ref useSiteDiagnostics, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 59313, 59417);
                    return return_v;
                }


                bool
                f_10330_59452_59496(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 59452, 59496);
                    return return_v;
                }


                bool
                f_10330_60524_60541(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 60524, 60541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10330_61225_61236(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Relation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 61225, 61236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_61238_61246(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 61238, 61246);
                    return return_v;
                }


                


                Microsoft.CodeAnalysis.ConstantValue
                f_10330_61571_61579(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 61571, 61579);
                    return return_v;
                }


                bool
                f_10330_63267_63284(Microsoft.CodeAnalysis.CSharp.BoundDagNonNullTest
                this_param)
                {
                    var return_v = this_param.IsExplicitTest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 63267, 63284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 55463, 64513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 55463, 64513);
            }
        }

        private bool? ExpressionOfTypeMatchesPatternTypeForLearningFromSuccessfulTypeTest(
                    TypeSymbol expressionType,
                    TypeSymbol patternType,
                    ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 65776, 70330);
                Microsoft.CodeAnalysis.CSharp.Conversion conversion = default(Microsoft.CodeAnalysis.CSharp.Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66022, 66173);

                bool?
                result = f_10330_66037_66172(_conversions, expressionType, patternType, ref useSiteDiagnostics, out conversion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66187, 66400);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 66194, 66263) || (((f_10330_66195_66213_M(!conversion.Exists) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 66195, 66262) && f_10330_66217_66262(expressionType, patternType)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 66283, 66287)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 66393, 66399))) ? null // runtime and compile-time test behavior differ. Pretend we don't know what happens.
                : result;

                static bool isRuntimeSimilar(TypeSymbol expressionType, TypeSymbol patternType)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 66416, 70319);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66528, 70271) || true) && (expressionType is ArrayTypeSymbol { ElementType: var e1, IsSZArray: var sz1, Rank: var r1 } && (DynAbs.Tracing.TraceSender.Expression_True(10330, 66535, 66742) && patternType is ArrayTypeSymbol { ElementType: var e2, IsSZArray: var sz2, Rank: var r2 }) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 66535, 66780) && sz1 == sz2) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 66535, 66792) && r1 == r2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 66528, 70271);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66834, 66869);

                                e1 = f_10330_66839_66868(e1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66891, 66926);

                                e2 = f_10330_66896_66925(e2);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 66948, 70252);

                                switch (f_10330_66956_66970(e1), f_10330_66972_66986(e2))
                                {

                                    case var (s1, s2) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 67316, 67329) || true) && (s1 == s2) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 67316, 67329) || true)
                                :
                                    case (SpecialType.System_SByte, SpecialType.System_Byte):
                                    case (SpecialType.System_Byte, SpecialType.System_SByte):
                                    case (SpecialType.System_Int16, SpecialType.System_UInt16):
                                    case (SpecialType.System_UInt16, SpecialType.System_Int16):
                                    case (SpecialType.System_Int32, SpecialType.System_UInt32):
                                    case (SpecialType.System_UInt32, SpecialType.System_Int32):
                                    case (SpecialType.System_Int64, SpecialType.System_UInt64):
                                    case (SpecialType.System_UInt64, SpecialType.System_Int64):
                                    case (SpecialType.System_IntPtr, SpecialType.System_UIntPtr):
                                    case (SpecialType.System_UIntPtr, SpecialType.System_IntPtr):

                                    // The following support behavior of the CLR that violates the CLI
                                    // and C# specifications, but we implement them because that is the
                                    // behavior on 32-bit runtimes.
                                    case (SpecialType.System_Int32, SpecialType.System_IntPtr):
                                    case (SpecialType.System_Int32, SpecialType.System_UIntPtr):
                                    case (SpecialType.System_UInt32, SpecialType.System_IntPtr):
                                    case (SpecialType.System_UInt32, SpecialType.System_UIntPtr):
                                    case (SpecialType.System_IntPtr, SpecialType.System_Int32):
                                    case (SpecialType.System_IntPtr, SpecialType.System_UInt32):
                                    case (SpecialType.System_UIntPtr, SpecialType.System_Int32):
                                    case (SpecialType.System_UIntPtr, SpecialType.System_UInt32):

                                    // The following support behavior of the CLR that violates the CLI
                                    // and C# specifications, but we implement them because that is the
                                    // behavior on 64-bit runtimes.
                                    case (SpecialType.System_Int64, SpecialType.System_IntPtr):
                                    case (SpecialType.System_Int64, SpecialType.System_UIntPtr):
                                    case (SpecialType.System_UInt64, SpecialType.System_IntPtr):
                                    case (SpecialType.System_UInt64, SpecialType.System_UIntPtr):
                                    case (SpecialType.System_IntPtr, SpecialType.System_Int64):
                                    case (SpecialType.System_IntPtr, SpecialType.System_UInt64):
                                    case (SpecialType.System_UIntPtr, SpecialType.System_Int64):
                                    case (SpecialType.System_UIntPtr, SpecialType.System_UInt64):
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 66948, 70252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 70074, 70086);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 66948, 70252);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 66948, 70252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 70152, 70193);

                                        (expressionType, patternType) = (e1, e2);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 70223, 70229);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 66948, 70252);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 66528, 70271);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 66528, 70271);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 66528, 70271);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 70291, 70304);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 66416, 70319);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10330_66839_66868(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.EnumUnderlyingTypeOrSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 66839, 66868);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10330_66896_66925(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.EnumUnderlyingTypeOrSelf();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 66896, 66925);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10330_66956_66970(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 66956, 66970);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10330_66972_66986(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 66972, 66986);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 66416, 70319);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 66416, 70319);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 65776, 70330);

                bool?
                f_10330_66037_66172(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = Binder.ExpressionOfTypeMatchesPatternType(conversions, expressionType, patternType, ref useSiteDiagnostics, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 66037, 66172);
                    return return_v;
                }


                bool
                f_10330_66195_66213_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 66195, 66213);
                    return return_v;
                }


                bool
                f_10330_66217_66262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                patternType)
                {
                    var return_v = isRuntimeSimilar(expressionType, patternType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 66217, 66262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 65776, 70330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 65776, 70330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class DecisionDag
        {
            public readonly DagState RootNode;

            public DecisionDag(DagState rootNode)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 70699, 70809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 70676, 70684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 70769, 70794);

                    this.RootNode = rootNode;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 70699, 70809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 70699, 70809);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 70699, 70809);
                }
            }

            private static ImmutableArray<DagState> Successor(DagState state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 70963, 71702);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71063, 71687) || true) && (state.TrueBranch != null && (DynAbs.Tracing.TraceSender.Expression_True(10330, 71067, 71120) && state.FalseBranch != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71063, 71687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71162, 71228);

                        return f_10330_71169_71227(state.FalseBranch, state.TrueBranch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71063, 71687);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71063, 71687);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71270, 71687) || true) && (state.TrueBranch != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71270, 71687);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71340, 71387);

                            return f_10330_71347_71386(state.TrueBranch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71270, 71687);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71270, 71687);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71429, 71687) || true) && (state.FalseBranch != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71429, 71687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71500, 71548);

                                return f_10330_71507_71547(state.FalseBranch);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71429, 71687);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 71429, 71687);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 71630, 71668);

                                return ImmutableArray<DagState>.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71429, 71687);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71270, 71687);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 71063, 71687);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 70963, 71702);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    f_10330_71169_71227(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    item1, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    item2)
                    {
                        var return_v = ImmutableArray.Create(item1, item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 71169, 71227);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    f_10330_71347_71386(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 71347, 71386);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    f_10330_71507_71547(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 71507, 71547);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 70963, 71702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 70963, 71702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetTopologicallySortedReachableStates(out ImmutableArray<DagState> result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 71995, 72274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72117, 72259);

                    return f_10330_72124_72258(f_10330_72167_72234(this.RootNode), Successor, out result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 71995, 72274);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    f_10330_72167_72234(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    value)
                    {
                        var return_v = SpecializedCollections.SingletonEnumerable<DagState>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 72167, 72234);
                        return return_v;
                    }


                    bool
                    f_10330_72124_72258(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    nodes, System.Func<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>>
                    successors, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    result)
                    {
                        var return_v = TopologicalSort.TryIterativeSort<DagState>(nodes, successors, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 72124, 72258);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 71995, 72274);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 71995, 72274);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal string Dump()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 72553, 78339);
                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState> allStates = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72608, 72775) || true) && (!f_10330_72613_72677(this, out allStates))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 72608, 72775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72719, 72756);

                        return "(the dag contains a cycle!)";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 72608, 72775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72795, 72866);

                    var
                    stateIdentifierMap = f_10330_72820_72865()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72893, 72898);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72884, 73026) || true) && (i < allStates.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72922, 72925)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 72884, 73026))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 72884, 73026);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 72967, 73007);

                            f_10330_72967_73006(stateIdentifierMap, allStates[i], i);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 143);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 143);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73275, 73298);

                    int
                    nextTempNumber = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73316, 73434);

                    PooledDictionary<BoundDagEvaluation, int>
                    tempIdentifierMap = f_10330_73378_73433()
                    ;

                    int tempIdentifier(BoundDagEvaluation? e)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 73452, 73676);
                            int value = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73534, 73657);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 73541, 73552) || (((e == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 73555, 73556)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 73559, 73656))) ? 0 : (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 73559, 73606) || ((f_10330_73559_73606(tempIdentifierMap, e, out value) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 73609, 73614)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 73617, 73656))) ? value : tempIdentifierMap[e] = ++nextTempNumber;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 73452, 73676);

                            bool
                            f_10330_73559_73606(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            key, out int
                            value)
                            {
                                var return_v = this_param.TryGetValue(key, out value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 73559, 73606);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 73452, 73676);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 73452, 73676);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    string tempName(BoundDagTemp t)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 73696, 73825);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73768, 73806);

                            return $"t{f_10330_73779_73803(f_10330_73794_73802(t))}";
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 73696, 73825);

                            Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                            f_10330_73794_73802(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            this_param)
                            {
                                var return_v = this_param.Source;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 73794, 73802);
                                return return_v;
                            }


                            int
                            f_10330_73779_73803(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation?
                            e)
                            {
                                var return_v = tempIdentifier(e);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 73779, 73803);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 73696, 73825);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 73696, 73825);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73845, 73899);

                    var
                    resultBuilder = f_10330_73865_73898()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73917, 73952);

                    var
                    result = resultBuilder.Builder
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 73972, 75340);
                        foreach (DagState state in f_10330_73999_74008_I(allStates))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 73972, 75340);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74050, 74084);

                            bool
                            isFail = state.Cases.IsEmpty
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74106, 74170);

                            bool
                            starred = isFail || (DynAbs.Tracing.TraceSender.Expression_False(10330, 74121, 74169) || f_10330_74131_74169(state.Cases.First()))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74192, 74293);

                            f_10330_74192_74292(result, $"{((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 74210, 74217) || ((starred && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 74220, 74223)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 74226, 74228))) ? "*" : "")}State " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_10330_74240_74265(stateIdentifierMap, state)).ToString(), 10330, 74240, 74265) + ((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 74269, 74275) || ((isFail && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 74278, 74285)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 74288, 74290))) ? " FAIL" : ""));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74315, 74409);

                            var
                            remainingValues = f_10330_74337_74408(f_10330_74337_74358(state), kvp => $"{tempName(kvp.Key)}:{kvp.Value}")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74431, 74536);

                            f_10330_74431_74535(result, $"{((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 74453, 74474) || ((f_10330_74453_74474(remainingValues) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 74477, 74526)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 74529, 74531))) ? " REMAINING " + f_10330_74493_74526(" ", remainingValues) : "")}");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74560, 74721);
                                foreach (StateForCase cd in f_10330_74588_74599_I(state.Cases))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 74560, 74721);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74649, 74698);

                                    f_10330_74649_74697(result, $"    {f_10330_74674_74694(cd)}");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 74560, 74721);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 162);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 162);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74745, 74914) || true) && (state.SelectedTest != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 74745, 74914);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74825, 74891);

                                f_10330_74825_74890(result, $"    Test: {f_10330_74856_74887(state.SelectedTest)}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 74745, 74914);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 74938, 75116) || true) && (state.TrueBranch != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 74938, 75116);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75016, 75093);

                                f_10330_75016_75092(result, $"    TrueBranch: {f_10330_75053_75089(stateIdentifierMap, state.TrueBranch)}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 74938, 75116);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75140, 75321) || true) && (state.FalseBranch != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 75140, 75321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75219, 75298);

                                f_10330_75219_75297(result, $"    FalseBranch: {f_10330_75257_75294(stateIdentifierMap, state.FalseBranch)}");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 75140, 75321);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 73972, 75340);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 1369);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 1369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75360, 75386);

                    f_10330_75360_75385(
                                    stateIdentifierMap);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75404, 75429);

                    f_10330_75404_75428(tempIdentifierMap);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75447, 75486);

                    return f_10330_75454_75485(resultBuilder);

                    string dumpStateForCase(StateForCase cd)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 75506, 76514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75587, 75636);

                            var
                            instance = f_10330_75602_75635()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75658, 75699);

                            StringBuilder
                            builder = instance.Builder
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75721, 75840);

                            f_10330_75721_75839(builder, $"{cd.Index}. [{cd.Syntax}] {((DynAbs.Tracing.TraceSender.Conditional_F1(10330, 75766, 75787) || ((f_10330_75766_75787(cd) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 75790, 75797)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 75800, 75835))) ? "MATCH" : f_10330_75800_75835(cd.RemainingTests, dumpDagTest))}");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 75862, 76013);

                            var
                            bindings = cd.Bindings.Select(bpb => $"{(bpb.VariableAccess is BoundLocal l ? l.LocalSymbol.Name : "<var>")}={tempName(bpb.TempContainingValue)}")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76035, 76267) || true) && (f_10330_76039_76053(bindings))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76035, 76267);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76103, 76128);

                                f_10330_76103_76127(builder, " BIND[");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76154, 76198);

                                f_10330_76154_76197(builder, f_10330_76169_76196("; ", bindings));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76224, 76244);

                                f_10330_76224_76243(builder, "]");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76035, 76267);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76291, 76437) || true) && (cd.WhenClause is { })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76291, 76437);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76365, 76414);

                                f_10330_76365_76413(builder, $" WHEN[{cd.WhenClause.Syntax}]");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76291, 76437);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76461, 76495);

                            return f_10330_76468_76494(instance);
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 75506, 76514);

                            Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                            f_10330_75602_75635()
                            {
                                var return_v = PooledStringBuilder.GetInstance();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75602, 75635);
                                return return_v;
                            }


                            bool
                            f_10330_75766_75787(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                            this_param)
                            {
                                var return_v = this_param.PatternIsSatisfied;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 75766, 75787);
                                return return_v;
                            }


                            string
                            f_10330_75800_75835(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                            this_param, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDagTest, string>
                            dump)
                            {
                                var return_v = this_param.Dump(dump);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75800, 75835);
                                return return_v;
                            }


                            System.Text.StringBuilder
                            f_10330_75721_75839(System.Text.StringBuilder
                            this_param, string
                            value)
                            {
                                var return_v = this_param.Append(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75721, 75839);
                                return return_v;
                            }


                            bool
                            f_10330_76039_76053(System.Collections.Generic.IEnumerable<string>
                            source)
                            {
                                var return_v = source.Any<string>();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76039, 76053);
                                return return_v;
                            }


                            System.Text.StringBuilder
                            f_10330_76103_76127(System.Text.StringBuilder
                            this_param, string
                            value)
                            {
                                var return_v = this_param.Append(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76103, 76127);
                                return return_v;
                            }


                            string
                            f_10330_76169_76196(string
                            separator, System.Collections.Generic.IEnumerable<string>
                            values)
                            {
                                var return_v = string.Join(separator, values);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76169, 76196);
                                return return_v;
                            }


                            System.Text.StringBuilder
                            f_10330_76154_76197(System.Text.StringBuilder
                            this_param, string
                            value)
                            {
                                var return_v = this_param.Append(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76154, 76197);
                                return return_v;
                            }


                            System.Text.StringBuilder
                            f_10330_76224_76243(System.Text.StringBuilder
                            this_param, string
                            value)
                            {
                                var return_v = this_param.Append(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76224, 76243);
                                return return_v;
                            }


                            System.Text.StringBuilder
                            f_10330_76365_76413(System.Text.StringBuilder
                            this_param, string
                            value)
                            {
                                var return_v = this_param.Append(value);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76365, 76413);
                                return return_v;
                            }


                            string
                            f_10330_76468_76494(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                            this_param)
                            {
                                var return_v = this_param.ToStringAndFree();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76468, 76494);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 75506, 76514);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 75506, 76514);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }

                    string dumpDagTest(BoundDagTest d)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 76534, 78324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76609, 78305);

                            switch (d)
                            {

                                case BoundDagTypeEvaluation a:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76728, 76801);

                                    return $"t{f_10330_76739_76756(a)}={f_10330_76759_76765(a)}({f_10330_76768_76785(f_10330_76777_76784(a))} as {f_10330_76791_76797(a)})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagFieldEvaluation e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 76888, 76964);

                                    return $"t{f_10330_76899_76916(e)}={f_10330_76919_76925(e)}({f_10330_76928_76945(f_10330_76937_76944(e))}.{f_10330_76948_76960(f_10330_76948_76955(e))})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagPropertyEvaluation e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77054, 77133);

                                    return $"t{f_10330_77065_77082(e)}={f_10330_77085_77091(e)}({f_10330_77094_77111(f_10330_77103_77110(e))}.{f_10330_77114_77129(f_10330_77114_77124(e))})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagEvaluation e:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77215, 77276);

                                    return $"t{f_10330_77226_77243(e)}={f_10330_77246_77252(e)}({f_10330_77255_77272(f_10330_77264_77271(e))})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagTypeTest b:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77356, 77409);

                                    return $"?{f_10330_77367_77373(d)}({f_10330_77376_77393(f_10330_77385_77392(d))} is {f_10330_77399_77405(b)})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagValueTest v:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77490, 77544);

                                    return $"?{f_10330_77501_77507(d)}({f_10330_77510_77527(f_10330_77519_77526(d))} == {f_10330_77533_77540(v)})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                case BoundDagRelationalTest r:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77630, 78081);

                                    var
                                    operatorName = f_10330_77649_77670(f_10330_77649_77659(r)) switch
                                    {
                                        BinaryOperatorKind.LessThan when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77742, 77776) && DynAbs.Tracing.TraceSender.Expression_True(10330, 77742, 77776))
=> "<",
                                        BinaryOperatorKind.LessThanOrEqual when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77811, 77853) && DynAbs.Tracing.TraceSender.Expression_True(10330, 77811, 77853))
=> "<=",
                                        BinaryOperatorKind.GreaterThan when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77888, 77925) && DynAbs.Tracing.TraceSender.Expression_True(10330, 77888, 77925))
=> ">",
                                        BinaryOperatorKind.GreaterThanOrEqual when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 77960, 78005) && DynAbs.Tracing.TraceSender.Expression_True(10330, 77960, 78005))
=> ">=",
                                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 78040, 78049) && DynAbs.Tracing.TraceSender.Expression_True(10330, 78040, 78049))
=> "??"
                                    }
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 78111, 78177);

                                    return $"?{f_10330_78122_78128(d)}({f_10330_78131_78148(f_10330_78140_78147(d))} {operatorName} {f_10330_78166_78173(r)})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 76609, 78305);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 78241, 78282);

                                    return $"?{f_10330_78252_78258(d)}({f_10330_78261_78278(f_10330_78270_78277(d))})";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 76609, 78305);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 76534, 78324);

                            int
                            f_10330_76739_76756(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                            e)
                            {
                                var return_v = tempIdentifier((Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)e);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76739, 76756);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_76759_76765(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76759, 76765);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_76777_76784(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76777, 76784);
                                return return_v;
                            }


                            string
                            f_10330_76768_76785(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76768, 76785);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10330_76791_76797(Microsoft.CodeAnalysis.CSharp.BoundDagTypeEvaluation
                            this_param)
                            {
                                var return_v = this_param.Type;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76791, 76797);
                                return return_v;
                            }


                            int
                            f_10330_76899_76916(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            e)
                            {
                                var return_v = tempIdentifier((Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)e);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76899, 76916);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_76919_76925(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76919, 76925);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_76937_76944(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76937, 76944);
                                return return_v;
                            }


                            string
                            f_10330_76928_76945(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 76928, 76945);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            f_10330_76948_76955(Microsoft.CodeAnalysis.CSharp.BoundDagFieldEvaluation
                            this_param)
                            {
                                var return_v = this_param.Field;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76948, 76955);
                                return return_v;
                            }


                            string
                            f_10330_76948_76960(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 76948, 76960);
                                return return_v;
                            }


                            int
                            f_10330_77065_77082(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                            e)
                            {
                                var return_v = tempIdentifier((Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation)e);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77065, 77082);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_77085_77091(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77085, 77091);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_77103_77110(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77103, 77110);
                                return return_v;
                            }


                            string
                            f_10330_77094_77111(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77094, 77111);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                            f_10330_77114_77124(Microsoft.CodeAnalysis.CSharp.BoundDagPropertyEvaluation
                            this_param)
                            {
                                var return_v = this_param.Property;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77114, 77124);
                                return return_v;
                            }


                            string
                            f_10330_77114_77129(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                            this_param)
                            {
                                var return_v = this_param.Name;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77114, 77129);
                                return return_v;
                            }


                            int
                            f_10330_77226_77243(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            e)
                            {
                                var return_v = tempIdentifier(e);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77226, 77243);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_77246_77252(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77246, 77252);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_77264_77271(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77264, 77271);
                                return return_v;
                            }


                            string
                            f_10330_77255_77272(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77255, 77272);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_77367_77373(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77367, 77373);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_77385_77392(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77385, 77392);
                                return return_v;
                            }


                            string
                            f_10330_77376_77393(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77376, 77393);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            f_10330_77399_77405(Microsoft.CodeAnalysis.CSharp.BoundDagTypeTest
                            this_param)
                            {
                                var return_v = this_param.Type;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77399, 77405);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_77501_77507(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77501, 77507);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_77519_77526(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77519, 77526);
                                return return_v;
                            }


                            string
                            f_10330_77510_77527(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77510, 77527);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ConstantValue
                            f_10330_77533_77540(Microsoft.CodeAnalysis.CSharp.BoundDagValueTest
                            this_param)
                            {
                                var return_v = this_param.Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77533, 77540);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            f_10330_77649_77659(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                            this_param)
                            {
                                var return_v = this_param.Relation;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 77649, 77659);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            f_10330_77649_77670(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                            kind)
                            {
                                var return_v = kind.Operator();
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 77649, 77670);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_78122_78128(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 78122, 78128);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_78140_78147(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 78140, 78147);
                                return return_v;
                            }


                            string
                            f_10330_78131_78148(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 78131, 78148);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.ConstantValue
                            f_10330_78166_78173(Microsoft.CodeAnalysis.CSharp.BoundDagRelationalTest
                            this_param)
                            {
                                var return_v = this_param.Value;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 78166, 78173);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundKind
                            f_10330_78252_78258(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Kind;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 78252, 78258);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            f_10330_78270_78277(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                            this_param)
                            {
                                var return_v = this_param.Input;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 78270, 78277);
                                return return_v;
                            }


                            string
                            f_10330_78261_78278(Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                            t)
                            {
                                var return_v = tempName(t);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 78261, 78278);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 76534, 78324);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 76534, 78324);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 72553, 78339);

                    bool
                    f_10330_72613_72677(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DecisionDag
                    this_param, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    result)
                    {
                        var return_v = this_param.TryGetTopologicallySortedReachableStates(out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 72613, 72677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    f_10330_72820_72865()
                    {
                        var return_v = PooledDictionary<DagState, int>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 72820, 72865);
                        return return_v;
                    }


                    int
                    f_10330_72967_73006(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    key, int
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 72967, 73006);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>
                    f_10330_73378_73433()
                    {
                        var return_v = PooledDictionary<BoundDagEvaluation, int>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 73378, 73433);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10330_73865_73898()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 73865, 73898);
                        return return_v;
                    }


                    bool
                    f_10330_74131_74169(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                    this_param)
                    {
                        var return_v = this_param.PatternIsSatisfied;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 74131, 74169);
                        return return_v;
                    }


                    int
                    f_10330_74240_74265(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 74240, 74265);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_74192_74292(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74192, 74292);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                    f_10330_74337_74358(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    this_param)
                    {
                        var return_v = this_param.RemainingValues;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 74337, 74358);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<string>
                    f_10330_74337_74408(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>
                    source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>, string>
                    selector)
                    {
                        var return_v = source.Select<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.CSharp.BoundDagTemp, Microsoft.CodeAnalysis.CSharp.IValueSet>, string>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74337, 74408);
                        return return_v;
                    }


                    bool
                    f_10330_74453_74474(System.Collections.Generic.IEnumerable<string>
                    source)
                    {
                        var return_v = source.Any<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74453, 74474);
                        return return_v;
                    }


                    string
                    f_10330_74493_74526(string
                    separator, System.Collections.Generic.IEnumerable<string>
                    values)
                    {
                        var return_v = string.Join(separator, values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74493, 74526);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_74431_74535(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74431, 74535);
                        return return_v;
                    }


                    string
                    f_10330_74674_74694(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase
                    cd)
                    {
                        var return_v = dumpStateForCase(cd);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74674, 74694);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_74649_74697(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74649, 74697);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                    f_10330_74588_74599_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74588, 74599);
                        return return_v;
                    }


                    string
                    f_10330_74856_74887(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    d)
                    {
                        var return_v = dumpDagTest(d);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74856, 74887);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_74825_74890(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 74825, 74890);
                        return return_v;
                    }


                    int
                    f_10330_75053_75089(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 75053, 75089);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_75016_75092(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75016, 75092);
                        return return_v;
                    }


                    int
                    f_10330_75257_75294(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 75257, 75294);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10330_75219_75297(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75219, 75297);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    f_10330_73999_74008_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 73999, 74008);
                        return return_v;
                    }


                    int
                    f_10330_75360_75385(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagState, int>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75360, 75385);
                        return 0;
                    }


                    int
                    f_10330_75404_75428(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation, int>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75404, 75428);
                        return 0;
                    }


                    string
                    f_10330_75454_75485(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 75454, 75485);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 72553, 78339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 72553, 78339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DecisionDag()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 70470, 78358);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 70470, 78358);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 70470, 78358);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 70470, 78358);
        }
        private sealed class DagState
        {
            public ImmutableDictionary<BoundDagTemp, IValueSet> RemainingValues { get; private set; }

            public readonly ImmutableArray<StateForCase> Cases;

            public DagState(ImmutableArray<StateForCase> cases, ImmutableDictionary<BoundDagTemp, IValueSet> remainingValues)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 79992, 80229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 79645, 79734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 80403, 80415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 80834, 80844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 80846, 80857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81012, 81015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 80138, 80157);

                    this.Cases = cases;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 80175, 80214);

                    this.RemainingValues = remainingValues;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 79992, 80229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 79992, 80229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 79992, 80229);
                }
            }

            public BoundDagTest? SelectedTest;

            public DagState? TrueBranch, FalseBranch;

            public BoundDecisionDagNode? Dag;

            internal BoundDagTest ComputeSelectedTest()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 81391, 81535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81467, 81520);

                    return f_10330_81474_81519(Cases[0].RemainingTests);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 81391, 81535);

                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10330_81474_81519(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param)
                    {
                        var return_v = this_param.ComputeSelectedTest();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 81474, 81519);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 81391, 81535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 81391, 81535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void UpdateRemainingValues(ImmutableDictionary<BoundDagTemp, IValueSet> newRemainingValues)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 81551, 81867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81684, 81726);

                    this.RemainingValues = newRemainingValues;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81744, 81769);

                    this.SelectedTest = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81787, 81810);

                    this.TrueBranch = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 81828, 81852);

                    this.FalseBranch = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 81551, 81867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 81551, 81867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 81551, 81867);
                }
            }

            static DagState()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 78897, 81878);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 78897, 81878);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 78897, 81878);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 78897, 81878);
        }
        private sealed class DagStateEquivalence : IEqualityComparer<DagState>
        {
            public static readonly DagStateEquivalence Instance;

            private DagStateEquivalence()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 82379, 82412);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 82379, 82412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 82379, 82412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 82379, 82412);
                }
            }

            public bool Equals(DagState? x, DagState? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 82428, 82685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 82505, 82534);

                    f_10330_82505_82533(x is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 82552, 82581);

                    f_10330_82552_82580(y is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 82599, 82670);

                    return x == y || (DynAbs.Tracing.TraceSender.Expression_False(10330, 82606, 82669) || x.Cases.SequenceEqual(y.Cases, (a, b) => a.Equals(b)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 82428, 82685);

                    int
                    f_10330_82505_82533(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 82505, 82533);
                        return 0;
                    }


                    int
                    f_10330_82552_82580(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 82552, 82580);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 82428, 82685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 82428, 82685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int GetHashCode(DagState x)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 82701, 82848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 82768, 82833);

                    return f_10330_82775_82832(f_10330_82788_82815(x.Cases), x.Cases.Length);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 82701, 82848);

                    int
                    f_10330_82788_82815(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.StateForCase>
                    values)
                    {
                        var return_v = Hash.CombineValues(values);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 82788, 82815);
                        return return_v;
                    }


                    int
                    f_10330_82775_82832(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 82775, 82832);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 82701, 82848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 82701, 82848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DagStateEquivalence()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 82188, 82859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 82326, 82362);
                Instance = f_10330_82337_82362(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 82188, 82859);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 82188, 82859);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 82188, 82859);

            static Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagStateEquivalence
            f_10330_82337_82362()
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.DagStateEquivalence();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 82337, 82362);
                return return_v;
            }

        }
        private sealed class StateForCase
        {
            public readonly int Index;

            public readonly SyntaxNode Syntax;

            public readonly Tests RemainingTests;

            public readonly ImmutableArray<BoundPatternBinding> Bindings;

            public readonly BoundExpression? WhenClause;

            public readonly LabelSymbol CaseLabel;

            public StateForCase(
                            int Index,
                            SyntaxNode Syntax,
                            Tests RemainingTests,
                            ImmutableArray<BoundPatternBinding> Bindings,
                            BoundExpression? WhenClause,
                            LabelSymbol CaseLabel)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 83770, 84338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 83466, 83471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 83513, 83519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 83556, 83570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 83693, 83703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 83746, 83755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84075, 84094);

                    this.Index = Index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84112, 84133);

                    this.Syntax = Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84151, 84188);

                    this.RemainingTests = RemainingTests;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84206, 84231);

                    this.Bindings = Bindings;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84249, 84278);

                    this.WhenClause = WhenClause;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84296, 84323);

                    this.CaseLabel = CaseLabel;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 83770, 84338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 83770, 84338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 83770, 84338);
                }
            }

            public bool IsFullyMatched
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 84537, 84642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84540, 84642);
                        return RemainingTests is Tests.True && (DynAbs.Tracing.TraceSender.Expression_True(10330, 84540, 84642) && (WhenClause is null || (DynAbs.Tracing.TraceSender.Expression_False(10330, 84573, 84641) || f_10330_84595_84619(WhenClause) == f_10330_84623_84641()))); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 84537, 84642);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 84537, 84642);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 84537, 84642);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool PatternIsSatisfied
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 84847, 84878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 84850, 84878);
                        return RemainingTests is Tests.True; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 84847, 84878);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 84847, 84878);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 84847, 84878);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool IsImpossible
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 85265, 85297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 85268, 85297);
                        return RemainingTests is Tests.False; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 85265, 85297);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 85265, 85297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 85265, 85297);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool Equals(object? obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 85314, 85439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 85387, 85424);

                    throw f_10330_85393_85423();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 85314, 85439);

                    System.Exception
                    f_10330_85393_85423()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 85393, 85423);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 85314, 85439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 85314, 85439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool Equals(StateForCase other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 85455, 85889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 85692, 85874);

                    return this == other || (DynAbs.Tracing.TraceSender.Expression_False(10330, 85699, 85873) || other != null && (DynAbs.Tracing.TraceSender.Expression_True(10330, 85737, 85800) && this.Index == other.Index) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 85737, 85873) && f_10330_85825_85873(this.RemainingTests, other.RemainingTests)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 85455, 85889);

                    bool
                    f_10330_85825_85873(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 85825, 85873);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 85455, 85889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 85455, 85889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 85905, 86043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 85971, 86028);

                    return f_10330_85978_86027(f_10330_85991_86019(RemainingTests), Index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 85905, 86043);

                    int
                    f_10330_85991_86019(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 85991, 86019);
                        return return_v;
                    }


                    int
                    f_10330_85978_86027(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 85978, 86027);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 85905, 86043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 85905, 86043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static StateForCase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 83069, 86054);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 83069, 86054);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 83069, 86054);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 83069, 86054);

            Microsoft.CodeAnalysis.ConstantValue?
            f_10330_84595_84619(Microsoft.CodeAnalysis.CSharp.BoundExpression
            this_param)
            {
                var return_v = this_param.ConstantValue;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 84595, 84619);
                return return_v;
            }


            Microsoft.CodeAnalysis.ConstantValue
            f_10330_84623_84641()
            {
                var return_v = ConstantValue.True;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 84623, 84641);
                return return_v;
            }

        }
        private abstract class Tests
        {
            private Tests()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 86292, 86311);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 86292, 86311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 86292, 86311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 86292, 86311);
                }
            }

            public abstract void Filter(
                            DecisionDagBuilder builder,
                            BoundDagTest test,
                            IValueSet? whenTrueValues,
                            IValueSet? whenFalseValues,
                            out Tests whenTrue,
                            out Tests whenFalse,
                            ref bool foundExplicitNullTest);

            public virtual BoundDagTest ComputeSelectedTest()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 86908, 86947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 86911, 86947);
                    throw f_10330_86917_86947(); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 86908, 86947);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 86908, 86947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 86908, 86947);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10330_86917_86947()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 86917, 86947);
                    return return_v;
                }

            }

            public virtual Tests RemoveEvaluation(BoundDagEvaluation e)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 87022, 87029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 87025, 87029);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 87022, 87029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 87022, 87029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 87022, 87029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public abstract string Dump(Func<BoundDagTest, string> dump);
            public sealed class True : Tests
            {
                public static readonly True Instance;

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 87443, 87452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 87446, 87452);
                        return "TRUE"; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 87443, 87452);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 87443, 87452);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 87443, 87452);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override void Filter(
                                    DecisionDagBuilder builder,
                                    BoundDagTest test,
                                    IValueSet? whenTrueValues,
                                    IValueSet? whenFalseValues,
                                    out Tests whenTrue,
                                    out Tests whenFalse,
                                    ref bool foundExplicitNullTest)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 87471, 87909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 87862, 87890);

                        whenTrue = whenFalse = this;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 87471, 87909);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 87471, 87909);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 87471, 87909);
                    }
                }

                public True()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 87249, 87924);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 87249, 87924);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 87249, 87924);
                }


                static True()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 87249, 87924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 87342, 87363);
                    Instance = f_10330_87353_87363(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 87249, 87924);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 87249, 87924);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 87249, 87924);

                static Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.True
                f_10330_87353_87363()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 87353, 87363);
                    return return_v;
                }

            }
            public sealed class False : Tests
            {
                public static readonly False Instance;

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 88266, 88276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 88269, 88276);
                        return "FALSE"; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 88266, 88276);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 88266, 88276);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 88266, 88276);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override void Filter(
                                    DecisionDagBuilder builder,
                                    BoundDagTest test,
                                    IValueSet? whenTrueValues,
                                    IValueSet? whenFalseValues,
                                    out Tests whenTrue,
                                    out Tests whenFalse,
                                    ref bool foundExplicitNullTest)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 88295, 88733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 88686, 88714);

                        whenTrue = whenFalse = this;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 88295, 88733);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 88295, 88733);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 88295, 88733);
                    }
                }

                public False()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 88069, 88748);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 88069, 88748);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 88069, 88748);
                }


                static False()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 88069, 88748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 88164, 88186);
                    Instance = f_10330_88175_88186(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 88069, 88748);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 88069, 88748);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 88069, 88748);

                static Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.False
                f_10330_88175_88186()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 88175, 88186);
                    return return_v;
                }

            }
            public sealed class One : Tests
            {
                public readonly BoundDagTest Test;

                public One(BoundDagTest test)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 89192, 89242);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 89169, 89173);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 89225, 89241);
                        this.Test = test; DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 89192, 89242);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 89192, 89242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 89192, 89242);
                    }
                }

                public void Deconstruct(out BoundDagTest Test)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 89307, 89326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 89310, 89326);
                        Test = this.Test; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 89307, 89326);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 89307, 89326);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 89307, 89326);
                    }
                }

                public override void Filter(
                                    DecisionDagBuilder builder,
                                    BoundDagTest test,
                                    IValueSet? whenTrueValues,
                                    IValueSet? whenFalseValues,
                                    out Tests whenTrue,
                                    out Tests whenFalse,
                                    ref bool foundExplicitNullTest)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 89345, 90771);
                        bool trueDecisionPermitsTrueOther = default(bool);
                        bool falseDecisionPermitsTrueOther = default(bool);
                        bool trueDecisionImpliesTrueOther = default(bool);
                        bool falseDecisionImpliesTrueOther = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 89736, 90445);

                        f_10330_89736_90444(builder, test: test, other: Test, whenTrueValues: whenTrueValues, whenFalseValues: whenFalseValues, syntax: test.Syntax, trueTestPermitsTrueOther: out trueDecisionPermitsTrueOther, falseTestPermitsTrueOther: out falseDecisionPermitsTrueOther, trueTestImpliesTrueOther: out trueDecisionImpliesTrueOther, falseTestImpliesTrueOther: out falseDecisionImpliesTrueOther, foundExplicitNullTest: ref foundExplicitNullTest);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 90467, 90597);

                        whenTrue = (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 90478, 90506) || ((trueDecisionImpliesTrueOther && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 90509, 90528)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 90531, 90596))) ? Tests.True.Instance : (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 90531, 90559) || ((trueDecisionPermitsTrueOther && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 90562, 90566)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 90569, 90596))) ? this : (Tests)Tests.False.Instance;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 90619, 90752);

                        whenFalse = (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 90631, 90660) || ((falseDecisionImpliesTrueOther && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 90663, 90682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 90685, 90751))) ? Tests.True.Instance : (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 90685, 90714) || ((falseDecisionPermitsTrueOther && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 90717, 90721)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 90724, 90751))) ? this : (Tests)Tests.False.Instance;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 89345, 90771);

                        int
                        f_10330_89736_90444(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        test, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        other, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenTrueValues, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenFalseValues, Microsoft.CodeAnalysis.SyntaxNode
                        syntax, out bool
                        trueTestPermitsTrueOther, out bool
                        falseTestPermitsTrueOther, out bool
                        trueTestImpliesTrueOther, out bool
                        falseTestImpliesTrueOther, ref bool
                        foundExplicitNullTest)
                        {
                            this_param.CheckConsistentDecision(test: test, other: other, whenTrueValues: whenTrueValues, whenFalseValues: whenFalseValues, syntax: syntax, out trueTestPermitsTrueOther, out falseTestPermitsTrueOther, out trueTestImpliesTrueOther, out falseTestImpliesTrueOther, foundExplicitNullTest: ref foundExplicitNullTest);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 89736, 90444);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 89345, 90771);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 89345, 90771);
                    }
                }

                public override BoundDagTest ComputeSelectedTest()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 90840, 90852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 90843, 90852);
                        return this.Test; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 90840, 90852);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 90840, 90852);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 90840, 90852);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override Tests RemoveEvaluation(BoundDagEvaluation e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 90932, 90985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 90935, 90985);
                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 90935, 90949) || ((f_10330_90935_90949(e, Test) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 90952, 90971)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 90974, 90985))) ? Tests.True.Instance : (Tests)this; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 90932, 90985);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 90932, 90985);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 90932, 90985);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    bool
                    f_10330_90935_90949(Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 90935, 90949);
                        return return_v;
                    }

                }

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 91065, 91083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91068, 91083);
                        return f_10330_91068_91083(dump, this.Test); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 91065, 91083);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 91065, 91083);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91065, 91083);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    string
                    f_10330_91068_91083(System.Func<Microsoft.CodeAnalysis.CSharp.BoundDagTest, string>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91068, 91083);
                        return return_v;
                    }

                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 91143, 91209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91146, 91209);
                        return this == obj || (DynAbs.Tracing.TraceSender.Expression_False(10330, 91146, 91209) || obj is One other && (DynAbs.Tracing.TraceSender.Expression_True(10330, 91161, 91209) && f_10330_91181_91209(this.Test, other.Test))); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 91143, 91209);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 91143, 91209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91143, 91209);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    bool
                    f_10330_91181_91209(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91181, 91209);
                        return return_v;
                    }

                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 91262, 91288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91265, 91288);
                        return f_10330_91265_91288(this.Test); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 91262, 91288);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 91262, 91288);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91262, 91288);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    int
                    f_10330_91265_91288(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91265, 91288);
                        return return_v;
                    }

                }

                static One()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 89076, 91304);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 89076, 91304);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 89076, 91304);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 89076, 91304);
            }
            public sealed class Not : Tests
            {
                public readonly Tests Negated;

                private Not(Tests negated)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 91520, 91568);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91494, 91501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91550, 91567);
                        Negated = negated; DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 91520, 91568);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 91520, 91568);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91520, 91568);
                    }
                }

                public static Tests Create(Tests negated)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 91628, 92199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91631, 92199);
                        return negated switch
                        {
                            Tests.True _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91686, 91722) && DynAbs.Tracing.TraceSender.Expression_True(10330, 91686, 91722))
        => Tests.False.Instance,
                            Tests.False _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91745, 91781) && DynAbs.Tracing.TraceSender.Expression_True(10330, 91745, 91781))
        => Tests.True.Instance,
                            Tests.Not n when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91804, 91828) && DynAbs.Tracing.TraceSender.Expression_True(10330, 91804, 91828))
        => n.Negated, // double negative
                            Tests.AndSequence a when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91870, 91903) && DynAbs.Tracing.TraceSender.Expression_True(10330, 91870, 91903))
        => f_10330_91893_91903(a),
                            Tests.OrSequence a when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 91926, 92014) && DynAbs.Tracing.TraceSender.Expression_True(10330, 91926, 92014))
        => f_10330_91948_92014(f_10330_91973_92013(a.RemainingTests)), // use demorgan to prefer and sequences
                            Tests.One o when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92077, 92102) && DynAbs.Tracing.TraceSender.Expression_True(10330, 92077, 92102))
        => f_10330_92092_92102(o),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92125, 92179) && DynAbs.Tracing.TraceSender.Expression_True(10330, 92125, 92179))
        => throw f_10330_92136_92179(negated),
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 91628, 92199);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 91628, 92199);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91628, 92199);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.Not
                    f_10330_91893_91903(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.AndSequence
                    negated)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.Not((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)negated);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91893, 91903);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                    f_10330_91973_92013(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                    seq)
                    {
                        var return_v = NegateSequenceElements(seq);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91973, 92013);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    f_10330_91948_92014(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                    remainingTests)
                    {
                        var return_v = Tests.AndSequence.Create(remainingTests);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 91948, 92014);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.Not
                    f_10330_92092_92102(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.One
                    negated)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.Not((Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests)negated);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92092, 92102);
                        return return_v;
                    }


                    System.Exception
                    f_10330_92136_92179(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92136, 92179);
                        return return_v;
                    }

                }

                private static ArrayBuilder<Tests> NegateSequenceElements(ImmutableArray<Tests> seq)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 92218, 92556);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92343, 92401);

                        var
                        builder = f_10330_92357_92400(seq.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92423, 92498);
                            foreach (var t in f_10330_92441_92444_I(seq))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 92423, 92498);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92471, 92498);

                                f_10330_92471_92497(builder, f_10330_92483_92496(t));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 92423, 92498);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 76);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 76);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92522, 92537);

                        return builder;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 92218, 92556);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_92357_92400(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92357, 92400);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_92483_92496(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        negated)
                        {
                            var return_v = Not.Create(negated);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92483, 92496);
                            return return_v;
                        }


                        int
                        f_10330_92471_92497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92471, 92497);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_92441_92444_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92441, 92444);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 92218, 92556);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 92218, 92556);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override Tests RemoveEvaluation(BoundDagEvaluation e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 92635, 92673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92638, 92673);
                        return f_10330_92638_92673(f_10330_92645_92672(Negated, e)); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 92635, 92673);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 92635, 92673);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 92635, 92673);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    f_10330_92645_92672(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                    e)
                    {
                        var return_v = this_param.RemoveEvaluation(e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92645, 92672);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    f_10330_92638_92673(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    negated)
                    {
                        var return_v = Create(negated);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92638, 92673);
                        return return_v;
                    }

                }

                public override BoundDagTest ComputeSelectedTest()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 92743, 92775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92746, 92775);
                        return f_10330_92746_92775(Negated); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 92743, 92775);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 92743, 92775);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 92743, 92775);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10330_92746_92775(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param)
                    {
                        var return_v = this_param.ComputeSelectedTest();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92746, 92775);
                        return return_v;
                    }

                }

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 92855, 92887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 92858, 92887);
                        return $"Not ({f_10330_92866_92884(Negated, dump)})"; DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 92855, 92887);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 92855, 92887);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 92855, 92887);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    string
                    f_10330_92866_92884(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param, System.Func<Microsoft.CodeAnalysis.CSharp.BoundDagTest, string>
                    dump)
                    {
                        var return_v = this_param.Dump(dump);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 92866, 92884);
                        return return_v;
                    }

                }

                public override void Filter(
                                    DecisionDagBuilder builder,
                                    BoundDagTest test,
                                    IValueSet? whenTrueValues,
                                    IValueSet? whenFalseValues,
                                    out Tests whenTrue,
                                    out Tests whenFalse,
                                    ref bool foundExplicitNullTest)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 92906, 93569);
                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests whenTestTrue = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests whenTestFalse = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 93297, 93432);

                        f_10330_93297_93431(Negated, builder, test, whenTrueValues, whenFalseValues, out whenTestTrue, out whenTestFalse, ref foundExplicitNullTest);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 93454, 93490);

                        whenTrue = f_10330_93465_93489(whenTestTrue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 93512, 93550);

                        whenFalse = f_10330_93524_93549(whenTestFalse);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 92906, 93569);

                        int
                        f_10330_93297_93431(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        test, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenTrueValues, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenFalseValues, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        whenTrue, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        whenFalse, ref bool
                        foundExplicitNullTest)
                        {
                            this_param.Filter(builder, test, whenTrueValues, whenFalseValues, out whenTrue, out whenFalse, ref foundExplicitNullTest);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93297, 93431);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_93465_93489(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        negated)
                        {
                            var return_v = Not.Create(negated);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93465, 93489);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_93524_93549(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        negated)
                        {
                            var return_v = Not.Create(negated);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93524, 93549);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 92906, 93569);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 92906, 93569);
                    }
                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 93628, 93687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 93631, 93687);
                        return this == obj || (DynAbs.Tracing.TraceSender.Expression_False(10330, 93631, 93687) || obj is Not n && (DynAbs.Tracing.TraceSender.Expression_True(10330, 93646, 93687) && f_10330_93662_93687(Negated, n.Negated))); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 93628, 93687);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 93628, 93687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 93628, 93687);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    bool
                    f_10330_93662_93687(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93662, 93687);
                        return return_v;
                    }

                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 93740, 93805);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 93743, 93805);
                        return f_10330_93743_93805(f_10330_93756_93777(Negated), f_10330_93779_93804(typeof(Not))); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 93740, 93805);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 93740, 93805);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 93740, 93805);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    int
                    f_10330_93756_93777(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93756, 93777);
                        return return_v;
                    }


                    int
                    f_10330_93779_93804(System.Type
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93779, 93804);
                        return return_v;
                    }


                    int
                    f_10330_93743_93805(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 93743, 93805);
                        return return_v;
                    }

                }

                static Not()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 91320, 93821);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 91320, 93821);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 91320, 93821);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 91320, 93821);
            }
            public abstract class SequenceTests : Tests
            {
                public readonly ImmutableArray<Tests> RemainingTests;

                protected SequenceTests(ImmutableArray<Tests> remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 93984, 94204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94086, 94126);

                        f_10330_94086_94125(remainingTests.Length > 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94148, 94185);

                        this.RemainingTests = remainingTests;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 93984, 94204);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 93984, 94204);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 93984, 94204);
                    }
                }

                public abstract Tests Update(ArrayBuilder<Tests> remainingTests);

                public override void Filter(
                                    DecisionDagBuilder builder,
                                    BoundDagTest test,
                                    IValueSet? whenTrueValues,
                                    IValueSet? whenFalseValues,
                                    out Tests whenTrue,
                                    out Tests whenFalse,
                                    ref bool foundExplicitNullTest)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 94305, 95356);
                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests oneTrue = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests oneFalse = default(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94696, 94769);

                        var
                        trueBuilder = f_10330_94714_94768(RemainingTests.Length)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94791, 94865);

                        var
                        falseBuilder = f_10330_94810_94864(RemainingTests.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94887, 95227);
                            foreach (var other in f_10330_94909_94923_I(RemainingTests))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 94887, 95227);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 94973, 95100);

                                f_10330_94973_95099(other, builder, test, whenTrueValues, whenFalseValues, out oneTrue, out oneFalse, ref foundExplicitNullTest);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95126, 95151);

                                f_10330_95126_95150(trueBuilder, oneTrue);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95177, 95204);

                                f_10330_95177_95203(falseBuilder, oneFalse);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 94887, 95227);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95251, 95282);

                        whenTrue = f_10330_95262_95281(this, trueBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95304, 95337);

                        whenFalse = f_10330_95316_95336(this, falseBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 94305, 95356);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_94714_94768(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 94714, 94768);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_94810_94864(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 94810, 94864);
                            return return_v;
                        }


                        int
                        f_10330_94973_95099(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder
                        builder, Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        test, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenTrueValues, Microsoft.CodeAnalysis.CSharp.IValueSet?
                        whenFalseValues, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        whenTrue, out Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        whenFalse, ref bool
                        foundExplicitNullTest)
                        {
                            this_param.Filter(builder, test, whenTrueValues, whenFalseValues, out whenTrue, out whenFalse, ref foundExplicitNullTest);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 94973, 95099);
                            return 0;
                        }


                        int
                        f_10330_95126_95150(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95126, 95150);
                            return 0;
                        }


                        int
                        f_10330_95177_95203(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95177, 95203);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_94909_94923_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 94909, 94923);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_95262_95281(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = this_param.Update(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95262, 95281);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_95316_95336(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = this_param.Update(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95316, 95336);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 94305, 95356);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 94305, 95356);
                    }
                }

                public override Tests RemoveEvaluation(BoundDagEvaluation e)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 95374, 95732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95475, 95544);

                        var
                        builder = f_10330_95489_95543(RemainingTests.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95566, 95666);
                            foreach (var test in f_10330_95587_95601_I(RemainingTests))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 95566, 95666);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95628, 95666);

                                f_10330_95628_95665(builder, f_10330_95640_95664(test, e));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 95566, 95666);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 101);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 101);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95690, 95713);

                        return f_10330_95697_95712(this, builder);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 95374, 95732);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_95489_95543(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<Tests>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95489, 95543);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_95640_95664(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundDagEvaluation
                        e)
                        {
                            var return_v = this_param.RemoveEvaluation(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95640, 95664);
                            return return_v;
                        }


                        int
                        f_10330_95628_95665(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95628, 95665);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_95587_95601_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95587, 95601);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_95697_95712(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                        this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = this_param.Update(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95697, 95712);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 95374, 95732);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 95374, 95732);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 95791, 95947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 95815, 95947);
                        return this == obj || (DynAbs.Tracing.TraceSender.Expression_False(10330, 95815, 95947) || obj is SequenceTests other && (DynAbs.Tracing.TraceSender.Expression_True(10330, 95830, 95893) && f_10330_95860_95874(this) == f_10330_95878_95893(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10330, 95830, 95947) && RemainingTests.SequenceEqual(other.RemainingTests))); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 95791, 95947);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 95791, 95947);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 95791, 95947);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    System.Type
                    f_10330_95860_95874(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95860, 95874);
                        return return_v;
                    }


                    System.Type
                    f_10330_95878_95893(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 95878, 95893);
                        return return_v;
                    }

                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 95966, 96310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96040, 96080);

                        int
                        length = this.RemainingTests.Length
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96102, 96165);

                        int
                        value = f_10330_96114_96164(length, f_10330_96135_96163(f_10330_96135_96149(this)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96187, 96256);

                        value = f_10330_96195_96255(f_10330_96208_96247(this.RemainingTests), value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96278, 96291);

                        return value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 95966, 96310);

                        System.Type
                        f_10330_96135_96149(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.SequenceTests
                        this_param)
                        {
                            var return_v = this_param.GetType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96135, 96149);
                            return return_v;
                        }


                        int
                        f_10330_96135_96163(System.Type
                        this_param)
                        {
                            var return_v = this_param.GetHashCode();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96135, 96163);
                            return return_v;
                        }


                        int
                        f_10330_96114_96164(int
                        newKey, int
                        currentKey)
                        {
                            var return_v = Hash.Combine(newKey, currentKey);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96114, 96164);
                            return return_v;
                        }


                        int
                        f_10330_96208_96247(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        values)
                        {
                            var return_v = Hash.CombineValues(values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96208, 96247);
                            return return_v;
                        }


                        int
                        f_10330_96195_96255(int
                        newKey, int
                        currentKey)
                        {
                            var return_v = Hash.Combine(newKey, currentKey);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96195, 96255);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 95966, 96310);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 95966, 96310);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static SequenceTests()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 93837, 96325);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 93837, 96325);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 93837, 96325);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 93837, 96325);

                int
                f_10330_94086_94125(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 94086, 94125);
                    return 0;
                }

            }
            public sealed class AndSequence : SequenceTests
            {
                private AndSequence(ImmutableArray<Tests> remainingTests) : base(f_10330_96702_96716_C(remainingTests))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 96637, 96721);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 96637, 96721);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 96637, 96721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 96637, 96721);
                    }
                }

                public override Tests Update(ArrayBuilder<Tests> remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 96804, 96829);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96807, 96829);
                        return f_10330_96807_96829(remainingTests); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 96804, 96829);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 96804, 96829);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 96804, 96829);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    f_10330_96807_96829(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                    remainingTests)
                    {
                        var return_v = Create(remainingTests);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 96807, 96829);
                        return return_v;
                    }

                }

                public static Tests Create(ArrayBuilder<Tests> remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 96848, 98215);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96960, 96988);
                            for (int
        i = f_10330_96964_96984(remainingTests) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96951, 97836) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 96998, 97001)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 96951, 97836))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 96951, 97836);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97051, 97813);

                                switch (f_10330_97059_97076(remainingTests, i))
                                {

                                    case True _:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 97051, 97813);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97180, 97207);

                                        f_10330_97180_97206(remainingTests, i);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 97241, 97247);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 97051, 97813);

                                    case False f:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 97051, 97813);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97324, 97346);

                                        f_10330_97324_97345(remainingTests);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97380, 97389);

                                        return f;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 97051, 97813);

                                    case AndSequence seq:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 97051, 97813);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97474, 97513);

                                        var
                                        testsToInsert = seq.RemainingTests
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97547, 97574);

                                        f_10330_97547_97573(remainingTests, i);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97617, 97622);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97624, 97648);
                                            for (int
            j = 0
            ,
            n = testsToInsert.Length
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97608, 97746) || true) && (j < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97657, 97660)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 97608, 97746))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 97608, 97746);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97699, 97746);

                                                f_10330_97699_97745(remainingTests, i + j, testsToInsert[j]);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 139);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 139);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 97780, 97786);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 97051, 97813);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 886);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 886);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97858, 98116);

                        var
                        result = f_10330_97871_97891(remainingTests) switch
                        {
                            0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97947, 97965) && DynAbs.Tracing.TraceSender.Expression_True(10330, 97947, 97965))
=> True.Instance,
                            1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 97992, 98014) && DynAbs.Tracing.TraceSender.Expression_True(10330, 97992, 98014))
=> f_10330_97997_98014(remainingTests, 0),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 98041, 98091) && DynAbs.Tracing.TraceSender.Expression_True(10330, 98041, 98091))
=> f_10330_98046_98091(f_10330_98062_98090(remainingTests)),
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 98138, 98160);

                        f_10330_98138_98159(remainingTests);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 98182, 98196);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 96848, 98215);

                        int
                        f_10330_96964_96984(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 96964, 96984);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_97059_97076(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 97059, 97076);
                            return return_v;
                        }


                        int
                        f_10330_97180_97206(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index)
                        {
                            this_param.RemoveAt(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 97180, 97206);
                            return 0;
                        }


                        int
                        f_10330_97324_97345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 97324, 97345);
                            return 0;
                        }


                        int
                        f_10330_97547_97573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index)
                        {
                            this_param.RemoveAt(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 97547, 97573);
                            return 0;
                        }


                        int
                        f_10330_97699_97745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Insert(index, item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 97699, 97745);
                            return 0;
                        }


                        int
                        f_10330_97871_97891(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 97871, 97891);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_97997_98014(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 97997, 98014);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_98062_98090(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 98062, 98090);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.AndSequence
                        f_10330_98046_98091(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.AndSequence(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 98046, 98091);
                            return return_v;
                        }


                        int
                        f_10330_98138_98159(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 98138, 98159);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 96848, 98215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 96848, 98215);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundDagTest ComputeSelectedTest()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 98233, 99865);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 98481, 99775) || true) && (RemainingTests[0] is One { Test: { Kind: BoundKind.DagNonNullTest } planA })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 98481, 99775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 98610, 99752);

                            switch (RemainingTests[1])
                            {

                                case One { Test: { Kind: BoundKind.DagTypeTest } planB1 }:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 98610, 99752);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 99090, 99144);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 99097, 99126) || (((f_10330_99098_99109(planA) == f_10330_99113_99125(planB1)) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 99129, 99135)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 99138, 99143))) ? planB1 : planA;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 98610, 99752);

                                case One { Test: { Kind: BoundKind.DagValueTest } planB2 }:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 98610, 99752);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 99671, 99725);

                                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10330, 99678, 99707) || (((f_10330_99679_99690(planA) == f_10330_99694_99706(planB2)) && DynAbs.Tracing.TraceSender.Conditional_F2(10330, 99710, 99716)) || DynAbs.Tracing.TraceSender.Conditional_F3(10330, 99719, 99724))) ? planB2 : planA;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 98610, 99752);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 98481, 99775);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 99799, 99846);

                        return f_10330_99806_99845(RemainingTests[0]);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 98233, 99865);

                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_99098_99109(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 99098, 99109);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_99113_99125(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 99113, 99125);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_99679_99690(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 99679, 99690);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTemp
                        f_10330_99694_99706(Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        this_param)
                        {
                            var return_v = this_param.Input;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 99694, 99706);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundDagTest
                        f_10330_99806_99845(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        this_param)
                        {
                            var return_v = this_param.ComputeSelectedTest();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 99806, 99845);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 98233, 99865);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 98233, 99865);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 99883, 100080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 99984, 100061);

                        return $"AND({f_10330_99998_100057(", ", RemainingTests.Select(t => t.Dump(dump)))})";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 99883, 100080);

                        string
                        f_10330_99998_100057(string
                        separator, System.Collections.Generic.IEnumerable<string>
                        values)
                        {
                            var return_v = string.Join(separator, values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 99998, 100057);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 99883, 100080);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 99883, 100080);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static AndSequence()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 96557, 100095);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 96557, 100095);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 96557, 100095);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 96557, 100095);

                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_96702_96716_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(10330, 96637, 96721);
                    return return_v;
                }

            }
            public sealed class OrSequence : SequenceTests
            {
                private OrSequence(ImmutableArray<Tests> remainingTests) : base(f_10330_100474_100488_C(remainingTests))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10330, 100410, 100493);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10330, 100410, 100493);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 100410, 100493);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 100410, 100493);
                    }
                }

                public override BoundDagTest ComputeSelectedTest()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 100562, 100609);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100565, 100609);
                        return f_10330_100565_100609(this.RemainingTests[0]); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 100562, 100609);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 100562, 100609);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 100562, 100609);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.BoundDagTest
                    f_10330_100565_100609(Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    this_param)
                    {
                        var return_v = this_param.ComputeSelectedTest();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 100565, 100609);
                        return return_v;
                    }

                }

                public override Tests Update(ArrayBuilder<Tests> remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 100693, 100718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100696, 100718);
                        return f_10330_100696_100718(remainingTests); DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 100693, 100718);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 100693, 100718);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 100693, 100718);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                    f_10330_100696_100718(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                    remainingTests)
                    {
                        var return_v = Create(remainingTests);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 100696, 100718);
                        return return_v;
                    }

                }

                public static Tests Create(ArrayBuilder<Tests> remainingTests)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10330, 100737, 102103);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100849, 100877);
                            for (int
        i = f_10330_100853_100873(remainingTests) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100840, 101724) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100887, 100890)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 100840, 101724))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 100840, 101724);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 100940, 101701);

                                switch (f_10330_100948_100965(remainingTests, i))
                                {

                                    case False _:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 100940, 101701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101070, 101097);

                                        f_10330_101070_101096(remainingTests, i);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 101131, 101137);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 100940, 101701);

                                    case True t:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 100940, 101701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101213, 101235);

                                        f_10330_101213_101234(remainingTests);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101269, 101278);

                                        return t;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 100940, 101701);

                                    case OrSequence seq:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 100940, 101701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101362, 101389);

                                        f_10330_101362_101388(remainingTests, i);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101423, 101462);

                                        var
                                        testsToInsert = seq.RemainingTests
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101505, 101510);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101512, 101536);
                                            for (int
            j = 0
            ,
            n = testsToInsert.Length
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101496, 101634) || true) && (j < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101545, 101548)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 101496, 101634))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10330, 101496, 101634);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101587, 101634);

                                                f_10330_101587_101633(remainingTests, i + j, testsToInsert[j]);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 139);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 139);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10330, 101668, 101674);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10330, 100940, 101701);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10330, 1, 885);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10330, 1, 885);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101746, 102004);

                        var
                        result = f_10330_101759_101779(remainingTests) switch
                        {
                            0 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101835, 101854) && DynAbs.Tracing.TraceSender.Expression_True(10330, 101835, 101854))
=> False.Instance,
                            1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101881, 101903) && DynAbs.Tracing.TraceSender.Expression_True(10330, 101881, 101903))
=> f_10330_101886_101903(remainingTests, 0),
                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 101930, 101979) && DynAbs.Tracing.TraceSender.Expression_True(10330, 101930, 101979))
=> f_10330_101935_101979(f_10330_101950_101978(remainingTests)),
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 102026, 102048);

                        f_10330_102026_102047(remainingTests);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 102070, 102084);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10330, 100737, 102103);

                        int
                        f_10330_100853_100873(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 100853, 100873);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_100948_100965(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 100948, 100965);
                            return return_v;
                        }


                        int
                        f_10330_101070_101096(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index)
                        {
                            this_param.RemoveAt(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101070, 101096);
                            return 0;
                        }


                        int
                        f_10330_101213_101234(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101213, 101234);
                            return 0;
                        }


                        int
                        f_10330_101362_101388(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index)
                        {
                            this_param.RemoveAt(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101362, 101388);
                            return 0;
                        }


                        int
                        f_10330_101587_101633(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        index, Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        item)
                        {
                            this_param.Insert(index, item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101587, 101633);
                            return 0;
                        }


                        int
                        f_10330_101759_101779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 101759, 101779);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests
                        f_10330_101886_101903(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 101886, 101903);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        f_10330_101950_101978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            var return_v = this_param.ToImmutable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101950, 101978);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.OrSequence
                        f_10330_101935_101979(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        remainingTests)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests.OrSequence(remainingTests);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 101935, 101979);
                            return return_v;
                        }


                        int
                        f_10330_102026_102047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 102026, 102047);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 100737, 102103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 100737, 102103);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override string Dump(Func<BoundDagTest, string> dump)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10330, 102121, 102317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10330, 102222, 102298);

                        return $"OR({f_10330_102235_102294(", ", RemainingTests.Select(t => t.Dump(dump)))})";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10330, 102121, 102317);

                        string
                        f_10330_102235_102294(string
                        separator, System.Collections.Generic.IEnumerable<string>
                        values)
                        {
                            var return_v = string.Join(separator, values);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10330, 102235, 102294);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10330, 102121, 102317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 102121, 102317);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static OrSequence()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 100331, 102332);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 100331, 102332);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 100331, 102332);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 100331, 102332);

                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                f_10330_100474_100488_C(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.DecisionDagBuilder.Tests>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(10330, 100410, 100493);
                    return return_v;
                }

            }

            static Tests()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 86239, 102343);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 86239, 102343);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 86239, 102343);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 86239, 102343);
        }

        static DecisionDagBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10330, 3688, 102350);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10330, 3688, 102350);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10330, 3688, 102350);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10330, 3688, 102350);

        Microsoft.CodeAnalysis.CSharp.Conversions
        f_10330_4165_4188(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Conversions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10330, 4165, 4188);
            return return_v;
        }

    }
}
