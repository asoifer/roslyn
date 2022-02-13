// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class BoundNode
    {
        internal string DumpSource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 546, 17546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 599, 618);

                int
                indentSize = 4
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 632, 666);

                var
                builder = f_10566_646_665()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 680, 772);

                f_10566_680_771(this, indent: 0, tempIdentifiers: f_10566_731_770());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 786, 812);

                return f_10566_793_811(builder);

                void appendSourceCore(BoundNode node, int indent, Dictionary<SynthesizedLocal, int> tempIdentifiers)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 828, 17535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 961, 15052);

                        switch (node)
                        {

                            case BoundTryStatement tryStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1108, 1126);

                                    f_10566_1108_1125("try");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1156, 1192);

                                    f_10566_1156_1191(f_10566_1169_1190(tryStatement));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1224, 1267);

                                    var
                                    catchBlocks = f_10566_1242_1266(tryStatement)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1297, 2079) || true) && (catchBlocks != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 1297, 2079);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1386, 2048);
                                            foreach (var catchBlock in f_10566_1413_1424_I(catchBlocks))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 1386, 2048);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1498, 1516);

                                                f_10566_1498_1515("catch (");
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1554, 1596);

                                                f_10566_1554_1595(f_10566_1561_1594_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10566_1561_1588(catchBlock), 10566, 1561, 1594)?.Name));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1634, 1647);

                                                f_10566_1634_1646(") ");

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1685, 1890) || true) && (f_10566_1689_1718(catchBlock) != null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 1685, 1890);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1808, 1851);

                                                    f_10566_1808_1850("... exception filter omitted ...");
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 1685, 1890);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1928, 1943);

                                                f_10566_1928_1942("");
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 1983, 2013);

                                                f_10566_1983_2012(f_10566_1996_2011(catchBlock));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 1386, 2048);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 663);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 663);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 1297, 2079);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2111, 2159);

                                    var
                                    finallyBlock = f_10566_2130_2158(tryStatement)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2189, 2393) || true) && (finallyBlock != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 2189, 2393);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2279, 2301);

                                        f_10566_2279_2300("finally");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2335, 2362);

                                        f_10566_2335_2361(finallyBlock);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 2189, 2393);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 2423, 2429);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundThrowStatement throwStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2575, 2592);

                                    f_10566_2575_2591("throw ");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2622, 2802) || true) && (f_10566_2626_2654(throwStatement) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 2622, 2802);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2728, 2771);

                                        f_10566_2728_2770(f_10566_2741_2769(throwStatement));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 2622, 2802);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 2832, 2848);

                                    f_10566_2832_2847(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 2878, 2884);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundBlock block:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3012, 3046);

                                    var
                                    statements = f_10566_3029_3045(block)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3076, 3291) || true) && (statements.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10566, 3080, 3126) && block.Locals.IsEmpty))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 3076, 3291);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3192, 3220);

                                        f_10566_3192_3219(statements[0]);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10566, 3254, 3260);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 3076, 3291);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3323, 3339);

                                    f_10566_3323_3338("{");
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3369, 3925);
                                        foreach (var local in f_10566_3391_3403_I(f_10566_3391_3403(block)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 3369, 3925);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3469, 3894) || true) && (local is SynthesizedLocal synthesized)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 3469, 3894);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3584, 3666);

                                                f_10566_3584_3665($"{local.TypeWithAnnotations.ToDisplayString()} {f_10566_3644_3661(synthesized)};");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 3469, 3894);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 3469, 3894);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3812, 3859);

                                                f_10566_3812_3858($"({f_10566_3827_3853(local)});");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 3469, 3894);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 3369, 3925);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 557);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 557);
                                    }
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 3955, 4112);
                                        foreach (var statement in f_10566_3981_3991_I(statements))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 3955, 4112);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4057, 4081);

                                            f_10566_4057_4080(statement);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 3955, 4112);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 158);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 158);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4142, 4158);

                                    f_10566_4142_4157("}");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 4188, 4194);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundStateMachineScope stateMachineScope:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4346, 4388);

                                    f_10566_4346_4387(f_10566_4359_4386(stateMachineScope));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 4418, 4424);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSequencePoint seqPoint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4563, 4601);

                                    var
                                    statement = f_10566_4579_4600(seqPoint)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4631, 4773) || true) && (statement != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 4631, 4773);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4718, 4742);

                                        f_10566_4718_4741(statement);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 4631, 4773);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 4803, 4809);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSequencePointExpression seqPoint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 4958, 4995);

                                    var
                                    expression = f_10566_4975_4994(seqPoint)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5025, 5050);

                                    f_10566_5025_5049(expression);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 5080, 5086);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSequencePointWithSpan seqPoint:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5233, 5271);

                                    var
                                    statement = f_10566_5249_5270(seqPoint)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5301, 5443) || true) && (statement != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 5301, 5443);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5388, 5412);

                                        f_10566_5388_5411(statement);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 5301, 5443);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 5473, 5479);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundYieldReturnStatement yieldStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5631, 5655);

                                    f_10566_5631_5654("yield return ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5685, 5725);

                                    f_10566_5685_5724(f_10566_5698_5723(yieldStatement));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5755, 5771);

                                    f_10566_5755_5770(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 5801, 5807);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundReturnStatement returnStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 5955, 5972);

                                    f_10566_5955_5971("return");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6002, 6044);

                                    var
                                    value = f_10566_6014_6043(returnStatement)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6074, 6254) || true) && (value != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 6074, 6254);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6157, 6169);

                                        f_10566_6157_6168(" ");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6203, 6223);

                                        f_10566_6203_6222(value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 6074, 6254);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6284, 6300);

                                    f_10566_6284_6299(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 6330, 6336);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundGotoStatement gotoStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6480, 6496);

                                    f_10566_6480_6495("goto ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6526, 6565);

                                    f_10566_6526_6564(f_10566_6533_6563(f_10566_6533_6552(gotoStatement)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6595, 6611);

                                    f_10566_6595_6610(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 6641, 6647);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundConditionalGoto gotoStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6793, 6808);

                                    f_10566_6793_6807("if (");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6838, 6882);

                                    f_10566_6838_6881((DynAbs.Tracing.TraceSender.Conditional_F1(10566, 6845, 6869) || ((f_10566_6845_6869(gotoStatement) && DynAbs.Tracing.TraceSender.Conditional_F2(10566, 6872, 6874)) || DynAbs.Tracing.TraceSender.Conditional_F3(10566, 6877, 6880))) ? "" : "!");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6912, 6950);

                                    f_10566_6912_6949(f_10566_6925_6948(gotoStatement));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 6980, 6993);

                                    f_10566_6980_6992(") ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7025, 7041);

                                    f_10566_7025_7040("goto ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7071, 7110);

                                    f_10566_7071_7109(f_10566_7078_7108(f_10566_7078_7097(gotoStatement)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7140, 7156);

                                    f_10566_7140_7155(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 7186, 7192);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundLabelStatement label:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7329, 7360);

                                    f_10566_7329_7359(f_10566_7336_7358(f_10566_7336_7347(label)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7390, 7408);

                                    f_10566_7390_7407(": ;");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 7438, 7444);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundTypeExpression type:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7580, 7603);

                                    f_10566_7580_7602(f_10566_7587_7601(f_10566_7587_7596(type)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 7633, 7639);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundLocal local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7767, 7798);

                                    var
                                    symbol = f_10566_7780_7797(local)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 7828, 7848);

                                    f_10566_7828_7847(symbol);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 7878, 7884);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundNoOpStatement noop:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 8019, 8025);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundExpressionStatement expressionStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8181, 8226);

                                    f_10566_8181_8225(f_10566_8194_8224(expressionStatement));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8256, 8272);

                                    f_10566_8256_8271(";");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 8302, 8308);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundAwaitExpression awaitExpression:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8456, 8473);

                                    f_10566_8456_8472("await ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8503, 8544);

                                    f_10566_8503_8543(f_10566_8516_8542(awaitExpression));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 8574, 8580);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundCall call:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8706, 8738);

                                    var
                                    receiver = f_10566_8721_8737(call)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8768, 8954) || true) && (receiver != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 8768, 8954);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8854, 8877);

                                        f_10566_8854_8876(receiver);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8911, 8923);

                                        f_10566_8911_8922(".");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 8768, 8954);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 8986, 9011);

                                    f_10566_8986_9010(f_10566_8993_9009(f_10566_8993_9004(call)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9041, 9053);

                                    f_10566_9041_9052("(");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9083, 9101);

                                    bool
                                    first = true
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9131, 9504);
                                        foreach (var argument in f_10566_9156_9170_I(f_10566_9156_9170(call)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 9131, 9504);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9236, 9368) || true) && (!first)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 9236, 9368);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9320, 9333);

                                                f_10566_9320_9332(", ");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 9236, 9368);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9402, 9416);

                                            first = false;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9450, 9473);

                                            f_10566_9450_9472(argument);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 9131, 9504);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 374);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 374);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9534, 9546);

                                    f_10566_9534_9545(")");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 9576, 9582);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundLiteral literal:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9753, 9783);

                                    var
                                    a = f_10566_9761_9782(literal)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9813, 9852);

                                    object?
                                    b = (DynAbs.Tracing.TraceSender.Conditional_F1(10566, 9825, 9834) || ((a != null && DynAbs.Tracing.TraceSender.Conditional_F2(10566, 9837, 9844)) || DynAbs.Tracing.TraceSender.Conditional_F3(10566, 9847, 9851))) ? f_10566_9837_9844(a) : null
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9883, 9935);

                                    var
                                    value = (DynAbs.Tracing.TraceSender.Conditional_F1(10566, 9895, 9904) || ((b != null && DynAbs.Tracing.TraceSender.Conditional_F2(10566, 9907, 9919)) || DynAbs.Tracing.TraceSender.Conditional_F3(10566, 9922, 9934))) ? f_10566_9907_9919(b) : (string)null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 9965, 10134) || true) && (value is null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 9965, 10134);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10048, 10063);

                                        f_10566_10048_10062("null");
                                        DynAbs.Tracing.TraceSender.TraceBreak(10566, 10097, 10103);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 9965, 10134);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10164, 10592);

                                    switch (f_10566_10172_10208_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10566_10172_10193(literal), 10566, 10172, 10208)?.Discriminator))
                                    {

                                        case ConstantValueTypeDiscriminator.String:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 10164, 10592);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10355, 10379);

                                            f_10566_10355_10378($@"""{value}""");
                                            DynAbs.Tracing.TraceSender.TraceBreak(10566, 10417, 10423);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 10164, 10592);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 10164, 10592);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10503, 10517);

                                            f_10566_10503_10516(value);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10566, 10555, 10561);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 10164, 10592);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 10622, 10628);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundAssignmentOperator assignment:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10774, 10804);

                                    f_10566_10774_10803(f_10566_10787_10802(assignment));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10834, 10848);

                                    f_10566_10834_10847(" = ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 10878, 10909);

                                    f_10566_10878_10908(f_10566_10891_10907(assignment));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 10939, 10945);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundThisReference thisReference:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11089, 11104);

                                    f_10566_11089_11103("this");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 11134, 11140);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundFieldAccess fieldAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11280, 11319);

                                    var
                                    receiver = f_10566_11295_11318(fieldAccess)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11349, 11535) || true) && (receiver != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 11349, 11535);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11435, 11458);

                                        f_10566_11435_11457(receiver);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11492, 11504);

                                        f_10566_11492_11503(".");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 11349, 11535);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11567, 11604);

                                    f_10566_11567_11603(f_10566_11574_11602(f_10566_11574_11597(fieldAccess)));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 11634, 11640);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSwitchStatement switchStatement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11788, 11807);

                                    f_10566_11788_11806("switch (");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11837, 11878);

                                    f_10566_11837_11877(f_10566_11850_11876(switchStatement));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11908, 11924);

                                    f_10566_11908_11923(")");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 11954, 11970);

                                    f_10566_11954_11969("{");
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12002, 12825);
                                        foreach (BoundSwitchSection section in f_10566_12041_12071_I(f_10566_12041_12071(switchStatement)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 12002, 12825);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12137, 12416);
                                                foreach (var label in f_10566_12159_12179_I(f_10566_12159_12179(section)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 12137, 12416);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12253, 12269);

                                                    f_10566_12253_12268("case ");
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12307, 12327);

                                                    f_10566_12307_12326(label);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12365, 12381);

                                                    f_10566_12365_12380(":");
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 12137, 12416);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 280);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 280);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12452, 12470);

                                            f_10566_12452_12469();
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12506, 12683);
                                                foreach (var statement in f_10566_12532_12550_I(f_10566_12532_12550(section)))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 12506, 12683);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12624, 12648);

                                                    f_10566_12624_12647(statement);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 12506, 12683);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 178);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 178);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12719, 12740);

                                            f_10566_12719_12739("break;");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12776, 12794);

                                            f_10566_12776_12793();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 12002, 12825);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 824);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 824);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 12855, 12871);

                                    f_10566_12855_12870("}");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 12901, 12907);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSwitchLabel label:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13041, 13069);

                                    f_10566_13041_13068(f_10566_13054_13067(label));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 13099, 13105);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundUnaryOperator unary:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13241, 13286);

                                    f_10566_13241_13285($" {f_10566_13252_13281(f_10566_13252_13270(unary))} ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13316, 13344);

                                    f_10566_13316_13343(f_10566_13329_13342(unary));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 13374, 13380);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundStatementList list:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13515, 13677);
                                        foreach (var statement in f_10566_13541_13556_I(f_10566_13541_13556(list)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 13515, 13677);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13622, 13646);

                                            f_10566_13622_13645(statement);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 13515, 13677);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 163);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 163);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 13707, 13713);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundSequence sequence:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13847, 13860);

                                    f_10566_13847_13859("{ ");
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13890, 14098);
                                        foreach (var effect in f_10566_13913_13933_I(f_10566_13913_13933(sequence)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 13890, 14098);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 13999, 14020);

                                            f_10566_13999_14019(effect);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14054, 14067);

                                            f_10566_14054_14066("; ");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 13890, 14098);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10566, 1, 209);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10566, 1, 209);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14128, 14157);

                                    f_10566_14128_14156(f_10566_14141_14155(sequence));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14187, 14200);

                                    f_10566_14187_14199(" }");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 14230, 14236);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundDefaultLiteral _:
                            case BoundDefaultExpression _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14421, 14439);

                                    f_10566_14421_14438("default");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 14469, 14475);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            case BoundBinaryOperator binary:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14613, 14639);

                                    f_10566_14613_14638(f_10566_14626_14637(binary));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14669, 14681);

                                    f_10566_14669_14680(" ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14711, 14750);

                                    f_10566_14711_14749(f_10566_14718_14748(f_10566_14718_14737(binary)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14780, 14792);

                                    f_10566_14780_14791(" ");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14822, 14849);

                                    f_10566_14822_14848(f_10566_14835_14847(binary));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10566, 14879, 14885);

                                    break;
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 961, 15052);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 14968, 15001);

                                f_10566_14968_15000(f_10566_14979_14999(f_10566_14979_14988(node)));
                                DynAbs.Tracing.TraceSender.TraceBreak(10566, 15027, 15033);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 961, 15052);
                        }

                        void appendSource(BoundNode? n)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 15072, 15407);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15144, 15388) || true) && (n is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 15144, 15388);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15207, 15222);

                                    f_10566_15207_15221("NULL");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 15144, 15388);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 15144, 15388);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15320, 15365);

                                    f_10566_15320_15364(n, indent, tempIdentifiers);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 15144, 15388);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 15072, 15407);

                                int
                                f_10566_15207_15221(string
                                s)
                                {
                                    append(s);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 15207, 15221);
                                    return 0;
                                }


                                int
                                f_10566_15320_15364(Microsoft.CodeAnalysis.CSharp.BoundNode
                                node, int
                                indent, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                                tempIdentifiers)
                                {
                                    appendSourceCore(node, indent, tempIdentifiers);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 15320, 15364);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 15072, 15407);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 15072, 15407);
                            }
                        }

                        void append(string? s)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 15427, 15527);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15490, 15508);

                                f_10566_15490_15507(builder, s);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 15427, 15527);

                                System.Text.StringBuilder
                                f_10566_15490_15507(System.Text.StringBuilder
                                this_param, string?
                                value)
                                {
                                    var return_v = this_param.Append(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 15490, 15507);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 15427, 15527);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 15427, 15527);
                            }
                        }

                        void incrementIndent()
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 15547, 15704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15610, 15631);

                                indent += indentSize;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15653, 15685);

                                f_10566_15653_15684(builder, ' ', indentSize);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 15547, 15704);

                                System.Text.StringBuilder
                                f_10566_15653_15684(System.Text.StringBuilder
                                this_param, char
                                value, int
                                repeatCount)
                                {
                                    var return_v = this_param.Append(value, repeatCount);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 15653, 15684);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 15547, 15704);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 15547, 15704);
                            }
                        }

                        void decrementIndent()
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 15724, 15905);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15787, 15808);

                                indent -= indentSize;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15830, 15886);

                                f_10566_15830_15885(builder, f_10566_15845_15859(builder) - indentSize, indentSize);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 15724, 15905);

                                int
                                f_10566_15845_15859(System.Text.StringBuilder
                                this_param)
                                {
                                    var return_v = this_param.Length;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 15845, 15859);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_15830_15885(System.Text.StringBuilder
                                this_param, int
                                startIndex, int
                                length)
                                {
                                    var return_v = this_param.Remove(startIndex, length);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 15830, 15885);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 15724, 15905);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 15724, 15905);
                            }
                        }

                        void appendLine(string s)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 15925, 16709);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 15991, 16690) || true) && (s == "{")
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 15991, 16690);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16053, 16074);

                                    indent += indentSize;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16100, 16122);

                                    f_10566_16100_16121(builder, s);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16148, 16176);

                                    f_10566_16148_16175(builder, ' ', indent);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 15991, 16690);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 15991, 16690);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16226, 16690) || true) && (s == "}")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 16226, 16690);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16288, 16344);

                                        f_10566_16288_16343(builder, f_10566_16303_16317(builder) - indentSize, indentSize);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16370, 16392);

                                        f_10566_16370_16391(builder, s);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16418, 16439);

                                        indent -= indentSize;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16465, 16493);

                                        f_10566_16465_16492(builder, ' ', indent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 16226, 16690);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 16226, 16690);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16591, 16613);

                                        f_10566_16591_16612(builder, s);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16639, 16667);

                                        f_10566_16639_16666(builder, ' ', indent);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 16226, 16690);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 15991, 16690);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 15925, 16709);

                                System.Text.StringBuilder
                                f_10566_16100_16121(System.Text.StringBuilder
                                this_param, string
                                value)
                                {
                                    var return_v = this_param.AppendLine(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16100, 16121);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16148_16175(System.Text.StringBuilder
                                this_param, char
                                value, int
                                repeatCount)
                                {
                                    var return_v = this_param.Append(value, repeatCount);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16148, 16175);
                                    return return_v;
                                }


                                int
                                f_10566_16303_16317(System.Text.StringBuilder
                                this_param)
                                {
                                    var return_v = this_param.Length;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 16303, 16317);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16288_16343(System.Text.StringBuilder
                                this_param, int
                                startIndex, int
                                length)
                                {
                                    var return_v = this_param.Remove(startIndex, length);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16288, 16343);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16370_16391(System.Text.StringBuilder
                                this_param, string
                                value)
                                {
                                    var return_v = this_param.AppendLine(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16370, 16391);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16465_16492(System.Text.StringBuilder
                                this_param, char
                                value, int
                                repeatCount)
                                {
                                    var return_v = this_param.Append(value, repeatCount);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16465, 16492);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16591_16612(System.Text.StringBuilder
                                this_param, string
                                value)
                                {
                                    var return_v = this_param.AppendLine(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16591, 16612);
                                    return return_v;
                                }


                                System.Text.StringBuilder
                                f_10566_16639_16666(System.Text.StringBuilder
                                this_param, char
                                value, int
                                repeatCount)
                                {
                                    var return_v = this_param.Append(value, repeatCount);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16639, 16666);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 15925, 16709);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 15925, 16709);
                            }
                        }

                        string name(SynthesizedLocal local)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 16729, 17122);
                                int identifier = default(int);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16805, 17041) || true) && (!f_10566_16810_16864(tempIdentifiers, local, out identifier))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 16805, 17041);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16914, 16953);

                                    identifier = f_10566_16927_16948(tempIdentifiers) + 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 16979, 17018);

                                    f_10566_16979_17017(tempIdentifiers, local, identifier);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 16805, 17041);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 17065, 17103);

                                return "temp" + f_10566_17081_17102(identifier);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 16729, 17122);

                                bool
                                f_10566_16810_16864(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                                key, out int
                                value)
                                {
                                    var return_v = this_param.TryGetValue(key, out value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16810, 16864);
                                    return return_v;
                                }


                                int
                                f_10566_16927_16948(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                                this_param)
                                {
                                    var return_v = this_param.Count;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 16927, 16948);
                                    return return_v;
                                }


                                int
                                f_10566_16979_17017(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                                key, int
                                value)
                                {
                                    this_param.Add(key, value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 16979, 17017);
                                    return 0;
                                }


                                string
                                f_10566_17081_17102(int
                                this_param)
                                {
                                    var return_v = this_param.ToString();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 17081, 17102);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 16729, 17122);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 16729, 17122);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }

                        void appendLocal(LocalSymbol symbol)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10566, 17142, 17520);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 17219, 17501) || true) && (symbol is SynthesizedLocal synthesized)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 17219, 17501);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 17311, 17337);

                                    f_10566_17311_17336(f_10566_17318_17335(synthesized));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 17219, 17501);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10566, 17219, 17501);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10566, 17435, 17478);

                                    f_10566_17435_17477($"({f_10566_17446_17473(symbol)})");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10566, 17219, 17501);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 17142, 17520);

                                string
                                f_10566_17318_17335(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                                local)
                                {
                                    var return_v = name(local);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 17318, 17335);
                                    return return_v;
                                }


                                int
                                f_10566_17311_17336(string
                                s)
                                {
                                    append(s);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 17311, 17336);
                                    return 0;
                                }


                                string
                                f_10566_17446_17473(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                                this_param)
                                {
                                    var return_v = this_param.GetDebuggerDisplay();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 17446, 17473);
                                    return return_v;
                                }


                                int
                                f_10566_17435_17477(string
                                s)
                                {
                                    append(s);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 17435, 17477);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 17142, 17520);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 17142, 17520);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 828, 17535);

                        int
                        f_10566_1108_1125(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1108, 1125);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundBlock
                        f_10566_1169_1190(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                        this_param)
                        {
                            var return_v = this_param.TryBlock;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1169, 1190);
                            return return_v;
                        }


                        int
                        f_10566_1156_1191(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1156, 1191);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                        f_10566_1242_1266(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                        this_param)
                        {
                            var return_v = this_param.CatchBlocks;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1242, 1266);
                            return return_v;
                        }


                        int
                        f_10566_1498_1515(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1498, 1515);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10566_1561_1588(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                        this_param)
                        {
                            var return_v = this_param.ExceptionTypeOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1561, 1588);
                            return return_v;
                        }


                        string?
                        f_10566_1561_1594_M(string?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1561, 1594);
                            return return_v;
                        }


                        int
                        f_10566_1554_1595(string?
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1554, 1595);
                            return 0;
                        }


                        int
                        f_10566_1634_1646(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1634, 1646);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10566_1689_1718(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                        this_param)
                        {
                            var return_v = this_param.ExceptionFilterOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1689, 1718);
                            return return_v;
                        }


                        int
                        f_10566_1808_1850(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1808, 1850);
                            return 0;
                        }


                        int
                        f_10566_1928_1942(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1928, 1942);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundBlock
                        f_10566_1996_2011(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                        this_param)
                        {
                            var return_v = this_param.Body;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 1996, 2011);
                            return return_v;
                        }


                        int
                        f_10566_1983_2012(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1983, 2012);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                        f_10566_1413_1424_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundCatchBlock>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 1413, 1424);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundBlock?
                        f_10566_2130_2158(Microsoft.CodeAnalysis.CSharp.BoundTryStatement
                        this_param)
                        {
                            var return_v = this_param.FinallyBlockOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 2130, 2158);
                            return return_v;
                        }


                        int
                        f_10566_2279_2300(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 2279, 2300);
                            return 0;
                        }


                        int
                        f_10566_2335_2361(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 2335, 2361);
                            return 0;
                        }


                        int
                        f_10566_2575_2591(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 2575, 2591);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10566_2626_2654(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                        this_param)
                        {
                            var return_v = this_param.ExpressionOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 2626, 2654);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_2741_2769(Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                        this_param)
                        {
                            var return_v = this_param.ExpressionOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 2741, 2769);
                            return return_v;
                        }


                        int
                        f_10566_2728_2770(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 2728, 2770);
                            return 0;
                        }


                        int
                        f_10566_2832_2847(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 2832, 2847);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_3029_3045(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        this_param)
                        {
                            var return_v = this_param.Statements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 3029, 3045);
                            return return_v;
                        }


                        int
                        f_10566_3192_3219(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3192, 3219);
                            return 0;
                        }


                        int
                        f_10566_3323_3338(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3323, 3338);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10566_3391_3403(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 3391, 3403);
                            return return_v;
                        }


                        string
                        f_10566_3644_3661(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                        local)
                        {
                            var return_v = name(local);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3644, 3661);
                            return return_v;
                        }


                        int
                        f_10566_3584_3665(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3584, 3665);
                            return 0;
                        }


                        string
                        f_10566_3827_3853(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        this_param)
                        {
                            var return_v = this_param.GetDebuggerDisplay();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3827, 3853);
                            return return_v;
                        }


                        int
                        f_10566_3812_3858(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3812, 3858);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10566_3391_3403_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3391, 3403);
                            return return_v;
                        }


                        int
                        f_10566_4057_4080(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 4057, 4080);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_3981_3991_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 3981, 3991);
                            return return_v;
                        }


                        int
                        f_10566_4142_4157(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 4142, 4157);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundStatement
                        f_10566_4359_4386(Microsoft.CodeAnalysis.CSharp.BoundStateMachineScope
                        this_param)
                        {
                            var return_v = this_param.Statement;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 4359, 4386);
                            return return_v;
                        }


                        int
                        f_10566_4346_4387(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 4346, 4387);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundStatement?
                        f_10566_4579_4600(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                        this_param)
                        {
                            var return_v = this_param.StatementOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 4579, 4600);
                            return return_v;
                        }


                        int
                        f_10566_4718_4741(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 4718, 4741);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_4975_4994(Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 4975, 4994);
                            return return_v;
                        }


                        int
                        f_10566_5025_5049(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5025, 5049);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundStatement?
                        f_10566_5249_5270(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                        this_param)
                        {
                            var return_v = this_param.StatementOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 5249, 5270);
                            return return_v;
                        }


                        int
                        f_10566_5388_5411(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5388, 5411);
                            return 0;
                        }


                        int
                        f_10566_5631_5654(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5631, 5654);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_5698_5723(Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 5698, 5723);
                            return return_v;
                        }


                        int
                        f_10566_5685_5724(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5685, 5724);
                            return 0;
                        }


                        int
                        f_10566_5755_5770(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5755, 5770);
                            return 0;
                        }


                        int
                        f_10566_5955_5971(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 5955, 5971);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10566_6014_6043(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                        this_param)
                        {
                            var return_v = this_param.ExpressionOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 6014, 6043);
                            return return_v;
                        }


                        int
                        f_10566_6157_6168(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6157, 6168);
                            return 0;
                        }


                        int
                        f_10566_6203_6222(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6203, 6222);
                            return 0;
                        }


                        int
                        f_10566_6284_6299(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6284, 6299);
                            return 0;
                        }


                        int
                        f_10566_6480_6495(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6480, 6495);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10566_6533_6552(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 6533, 6552);
                            return return_v;
                        }


                        string
                        f_10566_6533_6563(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6533, 6563);
                            return return_v;
                        }


                        int
                        f_10566_6526_6564(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6526, 6564);
                            return 0;
                        }


                        int
                        f_10566_6595_6610(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6595, 6610);
                            return 0;
                        }


                        int
                        f_10566_6793_6807(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6793, 6807);
                            return 0;
                        }


                        bool
                        f_10566_6845_6869(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                        this_param)
                        {
                            var return_v = this_param.JumpIfTrue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 6845, 6869);
                            return return_v;
                        }


                        int
                        f_10566_6838_6881(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6838, 6881);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_6925_6948(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                        this_param)
                        {
                            var return_v = this_param.Condition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 6925, 6948);
                            return return_v;
                        }


                        int
                        f_10566_6912_6949(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6912, 6949);
                            return 0;
                        }


                        int
                        f_10566_6980_6992(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 6980, 6992);
                            return 0;
                        }


                        int
                        f_10566_7025_7040(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7025, 7040);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10566_7078_7097(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 7078, 7097);
                            return return_v;
                        }


                        string
                        f_10566_7078_7108(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7078, 7108);
                            return return_v;
                        }


                        int
                        f_10566_7071_7109(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7071, 7109);
                            return 0;
                        }


                        int
                        f_10566_7140_7155(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7140, 7155);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10566_7336_7347(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 7336, 7347);
                            return return_v;
                        }


                        string
                        f_10566_7336_7358(Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7336, 7358);
                            return return_v;
                        }


                        int
                        f_10566_7329_7359(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7329, 7359);
                            return 0;
                        }


                        int
                        f_10566_7390_7407(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7390, 7407);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10566_7587_7596(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 7587, 7596);
                            return return_v;
                        }


                        string
                        f_10566_7587_7601(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 7587, 7601);
                            return return_v;
                        }


                        int
                        f_10566_7580_7602(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7580, 7602);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        f_10566_7780_7797(Microsoft.CodeAnalysis.CSharp.BoundLocal
                        this_param)
                        {
                            var return_v = this_param.LocalSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 7780, 7797);
                            return return_v;
                        }


                        int
                        f_10566_7828_7847(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        symbol)
                        {
                            appendLocal(symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 7828, 7847);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_8194_8224(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 8194, 8224);
                            return return_v;
                        }


                        int
                        f_10566_8181_8225(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8181, 8225);
                            return 0;
                        }


                        int
                        f_10566_8256_8271(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8256, 8271);
                            return 0;
                        }


                        int
                        f_10566_8456_8472(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8456, 8472);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_8516_8542(Microsoft.CodeAnalysis.CSharp.BoundAwaitExpression
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 8516, 8542);
                            return return_v;
                        }


                        int
                        f_10566_8503_8543(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8503, 8543);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10566_8721_8737(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 8721, 8737);
                            return return_v;
                        }


                        int
                        f_10566_8854_8876(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8854, 8876);
                            return 0;
                        }


                        int
                        f_10566_8911_8922(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8911, 8922);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10566_8993_9004(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 8993, 9004);
                            return return_v;
                        }


                        string
                        f_10566_8993_9009(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 8993, 9009);
                            return return_v;
                        }


                        int
                        f_10566_8986_9010(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 8986, 9010);
                            return 0;
                        }


                        int
                        f_10566_9041_9052(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9041, 9052);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10566_9156_9170(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Arguments;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 9156, 9170);
                            return return_v;
                        }


                        int
                        f_10566_9320_9332(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9320, 9332);
                            return 0;
                        }


                        int
                        f_10566_9450_9472(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9450, 9472);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10566_9156_9170_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9156, 9170);
                            return return_v;
                        }


                        int
                        f_10566_9534_9545(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9534, 9545);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ConstantValue?
                        f_10566_9761_9782(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        this_param)
                        {
                            var return_v = this_param.ConstantValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 9761, 9782);
                            return return_v;
                        }


                        object?
                        f_10566_9837_9844(Microsoft.CodeAnalysis.ConstantValue
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 9837, 9844);
                            return return_v;
                        }


                        string?
                        f_10566_9907_9919(object
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 9907, 9919);
                            return return_v;
                        }


                        int
                        f_10566_10048_10062(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10048, 10062);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.ConstantValue?
                        f_10566_10172_10193(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                        this_param)
                        {
                            var return_v = this_param.ConstantValue;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 10172, 10193);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator?
                        f_10566_10172_10208_M(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 10172, 10208);
                            return return_v;
                        }


                        int
                        f_10566_10355_10378(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10355, 10378);
                            return 0;
                        }


                        int
                        f_10566_10503_10516(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10503, 10516);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_10787_10802(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 10787, 10802);
                            return return_v;
                        }


                        int
                        f_10566_10774_10803(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10774, 10803);
                            return 0;
                        }


                        int
                        f_10566_10834_10847(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10834, 10847);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_10891_10907(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 10891, 10907);
                            return return_v;
                        }


                        int
                        f_10566_10878_10908(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 10878, 10908);
                            return 0;
                        }


                        int
                        f_10566_11089_11103(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11089, 11103);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression?
                        f_10566_11295_11318(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.ReceiverOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 11295, 11318);
                            return return_v;
                        }


                        int
                        f_10566_11435_11457(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11435, 11457);
                            return 0;
                        }


                        int
                        f_10566_11492_11503(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11492, 11503);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        f_10566_11574_11597(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                        this_param)
                        {
                            var return_v = this_param.FieldSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 11574, 11597);
                            return return_v;
                        }


                        string
                        f_10566_11574_11602(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 11574, 11602);
                            return return_v;
                        }


                        int
                        f_10566_11567_11603(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11567, 11603);
                            return 0;
                        }


                        int
                        f_10566_11788_11806(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11788, 11806);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_11850_11876(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 11850, 11876);
                            return return_v;
                        }


                        int
                        f_10566_11837_11877(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11837, 11877);
                            return 0;
                        }


                        int
                        f_10566_11908_11923(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11908, 11923);
                            return 0;
                        }


                        int
                        f_10566_11954_11969(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 11954, 11969);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                        f_10566_12041_12071(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                        this_param)
                        {
                            var return_v = this_param.SwitchSections;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 12041, 12071);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                        f_10566_12159_12179(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                        this_param)
                        {
                            var return_v = this_param.SwitchLabels;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 12159, 12179);
                            return return_v;
                        }


                        int
                        f_10566_12253_12268(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12253, 12268);
                            return 0;
                        }


                        int
                        f_10566_12307_12326(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12307, 12326);
                            return 0;
                        }


                        int
                        f_10566_12365_12380(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12365, 12380);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                        f_10566_12159_12179_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12159, 12179);
                            return return_v;
                        }


                        int
                        f_10566_12452_12469()
                        {
                            incrementIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12452, 12469);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_12532_12550(Microsoft.CodeAnalysis.CSharp.BoundSwitchSection
                        this_param)
                        {
                            var return_v = this_param.Statements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 12532, 12550);
                            return return_v;
                        }


                        int
                        f_10566_12624_12647(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12624, 12647);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_12532_12550_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12532, 12550);
                            return return_v;
                        }


                        int
                        f_10566_12719_12739(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12719, 12739);
                            return 0;
                        }


                        int
                        f_10566_12776_12793()
                        {
                            decrementIndent();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12776, 12793);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                        f_10566_12041_12071_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchSection>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12041, 12071);
                            return return_v;
                        }


                        int
                        f_10566_12855_12870(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 12855, 12870);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundPattern
                        f_10566_13054_13067(Microsoft.CodeAnalysis.CSharp.BoundSwitchLabel
                        this_param)
                        {
                            var return_v = this_param.Pattern;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 13054, 13067);
                            return return_v;
                        }


                        int
                        f_10566_13041_13068(Microsoft.CodeAnalysis.CSharp.BoundPattern
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13041, 13068);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                        f_10566_13252_13270(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 13252, 13270);
                            return return_v;
                        }


                        string
                        f_10566_13252_13281(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13252, 13281);
                            return return_v;
                        }


                        int
                        f_10566_13241_13285(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13241, 13285);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_13329_13342(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                        this_param)
                        {
                            var return_v = this_param.Operand;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 13329, 13342);
                            return return_v;
                        }


                        int
                        f_10566_13316_13343(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13316, 13343);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_13541_13556(Microsoft.CodeAnalysis.CSharp.BoundStatementList
                        this_param)
                        {
                            var return_v = this_param.Statements;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 13541, 13556);
                            return return_v;
                        }


                        int
                        f_10566_13622_13645(Microsoft.CodeAnalysis.CSharp.BoundStatement
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13622, 13645);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        f_10566_13541_13556_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13541, 13556);
                            return return_v;
                        }


                        int
                        f_10566_13847_13859(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13847, 13859);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10566_13913_13933(Microsoft.CodeAnalysis.CSharp.BoundSequence
                        this_param)
                        {
                            var return_v = this_param.SideEffects;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 13913, 13933);
                            return return_v;
                        }


                        int
                        f_10566_13999_14019(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13999, 14019);
                            return 0;
                        }


                        int
                        f_10566_14054_14066(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14054, 14066);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        f_10566_13913_13933_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 13913, 13933);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_14141_14155(Microsoft.CodeAnalysis.CSharp.BoundSequence
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 14141, 14155);
                            return return_v;
                        }


                        int
                        f_10566_14128_14156(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14128, 14156);
                            return 0;
                        }


                        int
                        f_10566_14187_14199(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14187, 14199);
                            return 0;
                        }


                        int
                        f_10566_14421_14438(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14421, 14438);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_14626_14637(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                        this_param)
                        {
                            var return_v = this_param.Left;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 14626, 14637);
                            return return_v;
                        }


                        int
                        f_10566_14613_14638(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14613, 14638);
                            return 0;
                        }


                        int
                        f_10566_14669_14680(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14669, 14680);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        f_10566_14718_14737(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                        this_param)
                        {
                            var return_v = this_param.OperatorKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 14718, 14737);
                            return return_v;
                        }


                        string
                        f_10566_14718_14748(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14718, 14748);
                            return return_v;
                        }


                        int
                        f_10566_14711_14749(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14711, 14749);
                            return 0;
                        }


                        int
                        f_10566_14780_14791(string
                        s)
                        {
                            append(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14780, 14791);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundExpression
                        f_10566_14835_14847(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                        this_param)
                        {
                            var return_v = this_param.Right;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 14835, 14847);
                            return return_v;
                        }


                        int
                        f_10566_14822_14848(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        n)
                        {
                            appendSource((Microsoft.CodeAnalysis.CSharp.BoundNode)n);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14822, 14848);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundKind
                        f_10566_14979_14988(Microsoft.CodeAnalysis.CSharp.BoundNode
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10566, 14979, 14988);
                            return return_v;
                        }


                        string
                        f_10566_14979_14999(Microsoft.CodeAnalysis.CSharp.BoundKind
                        this_param)
                        {
                            var return_v = this_param.ToString();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14979, 14999);
                            return return_v;
                        }


                        int
                        f_10566_14968_15000(string
                        s)
                        {
                            appendLine(s);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 14968, 15000);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 828, 17535);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 828, 17535);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10566, 546, 17546);

                System.Text.StringBuilder
                f_10566_646_665()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 646, 665);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                f_10566_731_770()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 731, 770);
                    return return_v;
                }


                int
                f_10566_680_771(Microsoft.CodeAnalysis.CSharp.BoundNode
                node, int
                indent, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal, int>
                tempIdentifiers)
                {
                    appendSourceCore(node, indent: indent, tempIdentifiers: tempIdentifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 680, 771);
                    return 0;
                }


                string
                f_10566_793_811(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10566, 793, 811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10566, 546, 17546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10566, 546, 17546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
