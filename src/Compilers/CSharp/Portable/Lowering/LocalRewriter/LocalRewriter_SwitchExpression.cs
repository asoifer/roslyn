// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class LocalRewriter
    {
        public override BoundNode VisitConvertedSwitchExpression(BoundConvertedSwitchExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10527, 582, 1172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1063, 1090);

                this._needsSpilling = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1104, 1161);

                return f_10527_1111_1160(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10527, 582, 1172);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10527_1111_1160(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                localRewriter, Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                node)
                {
                    var return_v = SwitchExpressionLocalRewriter.Rewrite(localRewriter, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 1111, 1160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10527, 582, 1172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 582, 1172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SwitchExpressionLocalRewriter : BaseSwitchLocalRewriter
        {
            private SwitchExpressionLocalRewriter(BoundConvertedSwitchExpression node, LocalRewriter localRewriter)
            : base(f_10527_1413_1424_C(node.Syntax), localRewriter, node.SwitchArms.SelectAsArray(arm => arm.Syntax), generateInstrumentation: f_10527_1539_1565_M(!node.WasCompilerGenerated) && (DynAbs.Tracing.TraceSender.Expression_True(10527, 1539, 1593) && f_10527_1569_1593(localRewriter)))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10527, 1285, 1624);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10527, 1285, 1624);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10527, 1285, 1624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 1285, 1624);
                }
            }

            public static BoundExpression Rewrite(LocalRewriter localRewriter, BoundConvertedSwitchExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10527, 1640, 2007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1776, 1846);

                    var
                    rewriter = f_10527_1791_1845(node, localRewriter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1864, 1926);

                    BoundExpression
                    result = f_10527_1889_1925(rewriter, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1944, 1960);

                    f_10527_1944_1959(rewriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 1978, 1992);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10527, 1640, 2007);

                    Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter
                    f_10527_1791_1845(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    node, Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    localRewriter)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter(node, localRewriter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 1791, 1845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_1889_1925(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    node)
                    {
                        var return_v = this_param.LowerSwitchExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 1889, 1925);
                        return return_v;
                    }


                    int
                    f_10527_1944_1959(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 1944, 1959);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10527, 1640, 2007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 1640, 2007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private BoundExpression LowerSwitchExpression(BoundConvertedSwitchExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10527, 2023, 9258);
                    Microsoft.CodeAnalysis.CSharp.BoundExpression savedInputExpression = default(Microsoft.CodeAnalysis.CSharp.BoundExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2244, 2411);

                    var
                    produceDetailedSequencePoints =
                    f_10527_2301_2324() && (DynAbs.Tracing.TraceSender.Expression_True(10527, 2301, 2410) && f_10527_2328_2381(f_10527_2328_2363(_localRewriter._compilation)) != OptimizationLevel.Release)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2429, 2459);

                    _factory.Syntax = node.Syntax;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2477, 2533);

                    var
                    result = f_10527_2490_2532()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2551, 2612);

                    var
                    outerVariables = f_10527_2572_2611()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2630, 2717);

                    var
                    loweredSwitchGoverningExpression = f_10527_2669_2716(_localRewriter, f_10527_2700_2715(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2735, 2927);

                    BoundDecisionDag
                    decisionDag = f_10527_2766_2926(this, f_10527_2825_2841(node), loweredSwitchGoverningExpression, result, out savedInputExpression)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 2945, 2988);

                    f_10527_2945_2987(savedInputExpression != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3008, 3064);

                    object
                    restorePointForEnclosingStatement = f_10527_3051_3063()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3082, 3130);

                    object
                    restorePointForSwitchBody = f_10527_3117_3129()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3194, 3371);

                    (ImmutableArray<BoundStatement> loweredDag, ImmutableDictionary<SyntaxNode, ImmutableArray<BoundStatement>> switchSections) =
                    f_10527_3341_3370(this, decisionDag);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3391, 4167) || true) && (produceDetailedSequencePoints)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 3391, 4167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3466, 3515);

                        var
                        syntax = (SwitchExpressionSyntax)node.Syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3537, 3627);

                        f_10527_3537_3626(result, f_10527_3548_3625(syntax, restorePointForEnclosingStatement));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3747, 3795);

                        var
                        spanStart = syntax.SwitchKeyword.Span.Start
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3817, 3847);

                        var
                        spanEnd = syntax.Span.End
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3869, 3938);

                        var
                        spanForSwitchBody = f_10527_3893_3937(spanStart, spanEnd - spanStart)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 3960, 4044);

                        f_10527_3960_4043(result, f_10527_3971_4042(node.Syntax, span: spanForSwitchBody));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4066, 4148);

                        f_10527_4066_4147(result, f_10527_4077_4146(syntax, restorePointForSwitchBody));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 3391, 4167);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4266, 4305);

                    f_10527_4266_4304(
                                    // add the rest of the lowered dag that references that input
                                    result, f_10527_4277_4303(_factory, loweredDag));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4562, 4678);

                    LocalSymbol
                    resultTemp = f_10527_4587_4677(_factory, f_10527_4613_4622(node), node.Syntax, kind: SynthesizedLocalKind.LoweringTemp)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4696, 4780);

                    LabelSymbol
                    afterSwitchExpression = f_10527_4732_4779(_factory, "afterSwitchExpression")
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4798, 6473);
                        foreach (BoundSwitchExpressionArm arm in f_10527_4839_4854_I(f_10527_4839_4854(node)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 4798, 6473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4896, 4925);

                            _factory.Syntax = arm.Syntax;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 4947, 5011);

                            var
                            sectionBuilder = f_10527_4968_5010()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5033, 5085);

                            f_10527_5033_5084(sectionBuilder, f_10527_5057_5083(switchSections, arm.Syntax));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5107, 5153);

                            f_10527_5107_5152(sectionBuilder, f_10527_5126_5151(_factory, f_10527_5141_5150(arm)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5175, 5236);

                            var
                            loweredValue = f_10527_5194_5235(_localRewriter, f_10527_5225_5234(arm))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5258, 5436) || true) && (f_10527_5262_5285())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 5258, 5436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5312, 5436);

                                loweredValue = f_10527_5327_5435(this._localRewriter._instrumenter, f_10527_5401_5410(arm), loweredValue, _factory);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 5258, 5436);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5460, 5542);

                            f_10527_5460_5541(
                                                sectionBuilder, f_10527_5479_5540(_factory, f_10527_5499_5525(_factory, resultTemp), loweredValue));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5564, 5621);

                            f_10527_5564_5620(sectionBuilder, f_10527_5583_5619(_factory, afterSwitchExpression));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5643, 5696);

                            var
                            statements = f_10527_5660_5695(sectionBuilder)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5718, 6454) || true) && (arm.Locals.IsEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 5718, 6454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 5790, 5837);

                                f_10527_5790_5836(result, f_10527_5801_5835(_factory, statements));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 5718, 6454);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 5718, 6454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6117, 6153);

                                f_10527_6117_6152(                        // Lifetime of these locals is expanded to the entire switch body, as it is possible to
                                                                          // share them as temps in the decision dag.
                                                        outerVariables, f_10527_6141_6151(arm));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6368, 6431);

                                f_10527_6368_6430(
                                                        // Note the language scope of the locals, even though they are included for the purposes of
                                                        // lifetime analysis in the enclosing scope.
                                                        result, f_10527_6379_6429(arm.Syntax, f_10527_6406_6416(arm), statements));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 5718, 6454);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 4798, 6473);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10527, 1, 1676);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10527, 1, 1676);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6493, 6523);

                    _factory.Syntax = node.Syntax;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6541, 8247) || true) && (f_10527_6545_6562(node) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 6541, 8247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6612, 6658);

                        f_10527_6612_6657(result, f_10527_6623_6656(_factory, f_10527_6638_6655(node)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6680, 6830) || true) && (produceDetailedSequencePoints)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 6680, 6830);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6740, 6830);

                            f_10527_6740_6829(result, f_10527_6751_6828(node.Syntax, restorePointForSwitchBody));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 6680, 6830);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6852, 6917);

                        var
                        objectType = f_10527_6869_6916(_factory, SpecialType.System_Object)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 6970, 7029);

                        var
                        thrownExpression = (BoundObjectCreationExpression)null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7051, 7122);

                        var
                        temp1 = f_10527_7063_7121(savedInputExpression, objectType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7144, 7286);

                        var
                        temp3 = f_10527_7156_7285(_factory, WellKnownMember.System_Runtime_CompilerServices_SwitchExpressionException__ctorObject, isOptional: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7308, 7351);

                        var
                        temp2 = temp1 && (DynAbs.Tracing.TraceSender.Expression_True(10527, 7320, 7350) && temp3 is MethodSymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7373, 8158) || true) && (temp2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 7373, 8158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7432, 7537);

                            thrownExpression = f_10527_7451_7536(_factory, temp3, f_10527_7485_7535(_factory, objectType, savedInputExpression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 7373, 8158);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 7373, 8158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7636, 7772);

                            var
                            temp4 = f_10527_7648_7771(_factory, WellKnownMember.System_Runtime_CompilerServices_SwitchExpressionException__ctor, isOptional: true)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7798, 8135) || true) && (temp4 is MethodSymbol)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 7798, 8135);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7854, 7907);

                                thrownExpression = f_10527_7873_7906(_factory, temp4);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 7798, 8135);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 7798, 8135);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 7994, 8108);

                                thrownExpression = f_10527_8013_8107(_factory, f_10527_8026_8106(_factory, WellKnownMember.System_InvalidOperationException__ctor));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 7798, 8135);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 7373, 8158);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8183, 8228);

                        f_10527_8183_8227(result, f_10527_8194_8226(_factory, thrownExpression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 6541, 8247);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8267, 8360) || true) && (f_10527_8271_8294())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 8267, 8360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8317, 8360);

                        f_10527_8317_8359(result, f_10527_8328_8358(_factory));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 8267, 8360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8378, 8428);

                    f_10527_8378_8427(result, f_10527_8389_8426(_factory, afterSwitchExpression));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8446, 8600) || true) && (produceDetailedSequencePoints)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10527, 8446, 8600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8502, 8600);

                        f_10527_8502_8599(result, f_10527_8513_8598(node.Syntax, restorePointForEnclosingStatement));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10527, 8446, 8600);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8620, 8651);

                    f_10527_8620_8650(
                                    outerVariables, resultTemp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8669, 8720);

                    f_10527_8669_8719(outerVariables, f_10527_8693_8718(_tempAllocator));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8738, 8862);

                    return f_10527_8745_8861(_factory, f_10527_8768_8803(outerVariables), f_10527_8805_8832(result), f_10527_8834_8860(_factory, resultTemp));

                    bool implicitConversionExists(BoundExpression expression, TypeSymbol type)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10527, 8882, 9243);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 8997, 9039);

                            HashSet<DiagnosticInfo>?
                            discarded = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 9061, 9182);

                            Conversion
                            c = f_10527_9076_9181(f_10527_9076_9115(_localRewriter._compilation), expression, type, ref discarded)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10527, 9204, 9224);

                            return c.IsImplicit;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10527, 8882, 9243);

                            Microsoft.CodeAnalysis.CSharp.Conversions
                            f_10527_9076_9115(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                            this_param)
                            {
                                var return_v = this_param.Conversions;
                                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 9076, 9115);
                                return return_v;
                            }


                            Microsoft.CodeAnalysis.CSharp.Conversion
                            f_10527_9076_9181(Microsoft.CodeAnalysis.CSharp.Conversions
                            this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                            sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                            destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                            useSiteDiagnostics)
                            {
                                var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 9076, 9181);
                                return return_v;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10527, 8882, 9243);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 8882, 9243);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10527, 2023, 9258);

                    bool
                    f_10527_2301_2324()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 2301, 2324);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10527_2328_2363(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 2328, 2363);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OptimizationLevel
                    f_10527_2328_2381(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OptimizationLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 2328, 2381);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10527_2490_2532()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 2490, 2532);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10527_2572_2611()
                    {
                        var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 2572, 2611);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_2700_2715(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.Expression;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 2700, 2715);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10527_2669_2716(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 2669, 2716);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10527_2825_2841(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.DecisionDag;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 2825, 2841);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    f_10527_2766_2926(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    loweredSwitchGoverningExpression, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    result, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    savedInputExpression)
                    {
                        var return_v = this_param.ShareTempsIfPossibleAndEvaluateInput(decisionDag, loweredSwitchGoverningExpression, result, out savedInputExpression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 2766, 2926);
                        return return_v;
                    }


                    int
                    f_10527_2945_2987(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 2945, 2987);
                        return 0;
                    }


                    object
                    f_10527_3051_3063()
                    {
                        var return_v = new object();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3051, 3063);
                        return return_v;
                    }


                    object
                    f_10527_3117_3129()
                    {
                        var return_v = new object();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3117, 3129);
                        return return_v;
                    }


                    (System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement> loweredDag, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>> switchSections)
                    f_10527_3341_3370(Microsoft.CodeAnalysis.CSharp.LocalRewriter.SwitchExpressionLocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundDecisionDag
                    decisionDag)
                    {
                        var return_v = this_param.LowerDecisionDag(decisionDag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3341, 3370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint
                    f_10527_3548_3625(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                    syntax, object
                    identifier)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint((Microsoft.CodeAnalysis.SyntaxNode)syntax, identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3548, 3625);
                        return return_v;
                    }


                    int
                    f_10527_3537_3626(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3537, 3626);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Text.TextSpan
                    f_10527_3893_3937(int
                    start, int
                    length)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3893, 3937);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStepThroughSequencePoint
                    f_10527_3971_4042(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.Text.TextSpan
                    span)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundStepThroughSequencePoint(syntax, span: span);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3971, 4042);
                        return return_v;
                    }


                    int
                    f_10527_3960_4043(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStepThroughSequencePoint
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 3960, 4043);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint
                    f_10527_4077_4146(Microsoft.CodeAnalysis.CSharp.Syntax.SwitchExpressionSyntax
                    syntax, object
                    identifier)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint((Microsoft.CodeAnalysis.SyntaxNode)syntax, identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4077, 4146);
                        return return_v;
                    }


                    int
                    f_10527_4066_4147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundSavePreviousSequencePoint
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4066, 4147);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10527_4277_4303(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4277, 4303);
                        return return_v;
                    }


                    int
                    f_10527_4266_4304(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4266, 4304);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10527_4613_4622(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 4613, 4622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10527_4587_4677(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = this_param.SynthesizedLocal(type, syntax, kind: kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4587, 4677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                    f_10527_4732_4779(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, string
                    prefix)
                    {
                        var return_v = this_param.GenerateLabel(prefix);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4732, 4779);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                    f_10527_4839_4854(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.SwitchArms;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 4839, 4854);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10527_4968_5010()
                    {
                        var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4968, 5010);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10527_5057_5083(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.SyntaxNode, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>>
                    this_param, Microsoft.CodeAnalysis.SyntaxNode
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 5057, 5083);
                        return return_v;
                    }


                    int
                    f_10527_5033_5084(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5033, 5084);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10527_5141_5150(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Label;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 5141, 5150);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10527_5126_5151(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5126, 5151);
                        return return_v;
                    }


                    int
                    f_10527_5107_5152(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5107, 5152);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_5225_5234(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 5225, 5234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10527_5194_5235(Microsoft.CodeAnalysis.CSharp.LocalRewriter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    node)
                    {
                        var return_v = this_param.VisitExpression(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5194, 5235);
                        return return_v;
                    }


                    bool
                    f_10527_5262_5285()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 5262, 5285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_5401_5410(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 5401, 5410);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_5327_5435(Microsoft.CodeAnalysis.CSharp.Instrumenter
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    original, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    rewrittenExpression, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    factory)
                    {
                        var return_v = this_param.InstrumentSwitchExpressionArmExpression(original, rewrittenExpression, factory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5327, 5435);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10527_5499_5525(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5499, 5525);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10527_5479_5540(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5479, 5540);
                        return return_v;
                    }


                    int
                    f_10527_5460_5541(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5460, 5541);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    f_10527_5583_5619(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Goto(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5583, 5619);
                        return return_v;
                    }


                    int
                    f_10527_5564_5620(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5564, 5620);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10527_5660_5695(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5660, 5695);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatementList
                    f_10527_5801_5835(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = this_param.StatementList(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5801, 5835);
                        return return_v;
                    }


                    int
                    f_10527_5790_5836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 5790, 5836);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10527_6141_6151(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 6141, 6151);
                        return return_v;
                    }


                    int
                    f_10527_6117_6152(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6117, 6152);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10527_6406_6416(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                    this_param)
                    {
                        var return_v = this_param.Locals;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 6406, 6416);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundScope
                    f_10527_6379_6429(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundScope(syntax, locals, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6379, 6429);
                        return return_v;
                    }


                    int
                    f_10527_6368_6430(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundScope
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6368, 6430);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                    f_10527_4839_4854_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 4839, 4854);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol?
                    f_10527_6545_6562(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.DefaultLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 6545, 6562);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    f_10527_6638_6655(Microsoft.CodeAnalysis.CSharp.BoundConvertedSwitchExpression
                    this_param)
                    {
                        var return_v = this_param.DefaultLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 6638, 6655);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10527_6623_6656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6623, 6656);
                        return return_v;
                    }


                    int
                    f_10527_6612_6657(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6612, 6657);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint
                    f_10527_6751_6828(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, object
                    identifier)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint(syntax, identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6751, 6828);
                        return return_v;
                    }


                    int
                    f_10527_6740_6829(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6740, 6829);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10527_6869_6916(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    st)
                    {
                        var return_v = this_param.SpecialType(st);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 6869, 6916);
                        return return_v;
                    }


                    bool
                    f_10527_7063_7121(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = implicitConversionExists(expression, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7063, 7121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10527_7156_7285(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm, bool
                    isOptional)
                    {
                        var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7156, 7285);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10527_7485_7535(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7485, 7535);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10527_7451_7536(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7451, 7536);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10527_7648_7771(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm, bool
                    isOptional)
                    {
                        var return_v = this_param.WellKnownMember(wm, isOptional: isOptional);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7648, 7771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10527_7873_7906(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 7873, 7906);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10527_8026_8106(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    wm)
                    {
                        var return_v = this_param.WellKnownMethod(wm);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8026, 8106);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    f_10527_8013_8107(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.New(ctor, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8013, 8107);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                    f_10527_8194_8226(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                    e)
                    {
                        var return_v = this_param.Throw((Microsoft.CodeAnalysis.CSharp.BoundExpression)e);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8194, 8226);
                        return return_v;
                    }


                    int
                    f_10527_8183_8227(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8183, 8227);
                        return 0;
                    }


                    bool
                    f_10527_8271_8294()
                    {
                        var return_v = GenerateInstrumentation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 8271, 8294);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundStatement
                    f_10527_8328_8358(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.HiddenSequencePoint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8328, 8358);
                        return return_v;
                    }


                    int
                    f_10527_8317_8359(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8317, 8359);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    f_10527_8389_8426(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                    label)
                    {
                        var return_v = this_param.Label(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8389, 8426);
                        return return_v;
                    }


                    int
                    f_10527_8378_8427(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8378, 8427);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint
                    f_10527_8513_8598(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, object
                    identifier)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint(syntax, identifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8513, 8598);
                        return return_v;
                    }


                    int
                    f_10527_8502_8599(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundRestorePreviousSequencePoint
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8502, 8599);
                        return 0;
                    }


                    int
                    f_10527_8620_8650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8620, 8650);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10527_8693_8718(Microsoft.CodeAnalysis.CSharp.LocalRewriter.PatternLocalRewriter.DagTempAllocator
                    this_param)
                    {
                        var return_v = this_param.AllTemps();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8693, 8718);
                        return return_v;
                    }


                    int
                    f_10527_8669_8719(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8669, 8719);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10527_8768_8803(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8768, 8803);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10527_8805_8832(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8805, 8832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10527_8834_8860(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    local)
                    {
                        var return_v = this_param.Local(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8834, 8860);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundSpillSequence
                    f_10527_8745_8861(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    sideEffects, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    result)
                    {
                        var return_v = this_param.SpillSequence(locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10527, 8745, 8861);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10527, 2023, 9258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 2023, 9258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SwitchExpressionLocalRewriter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10527, 1184, 9269);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10527, 1184, 9269);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10527, 1184, 9269);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10527, 1184, 9269);

            static bool
            f_10527_1539_1565_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 1539, 1565);
                return return_v;
            }


            static bool
            f_10527_1569_1593(Microsoft.CodeAnalysis.CSharp.LocalRewriter
            this_param)
            {
                var return_v = this_param.Instrument;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10527, 1569, 1593);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxNode
            f_10527_1413_1424_C(Microsoft.CodeAnalysis.SyntaxNode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10527, 1285, 1624);
                return return_v;
            }

        }
    }
}
