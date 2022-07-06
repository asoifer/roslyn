// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.Metadata.Tools;
using Roslyn.Utilities;
using Cci = Microsoft.Cci;
using Microsoft.CodeAnalysis.Symbols;
using System.Diagnostics;

namespace Roslyn.Test.Utilities
{
    internal sealed class ILBuilderVisualizer : ILVisualizer
    {
        private readonly ITokenDeferral _tokenDeferral;

        public ILBuilderVisualizer(ITokenDeferral tokenDeferral)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25105, 843, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 816, 830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 924, 955);

                _tokenDeferral = tokenDeferral;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25105, 843, 966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 843, 966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 843, 966);
            }
        }

        public override string VisualizeUserString(uint token)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25105, 978, 1333);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1154, 1244) || true) && (token == 0x80000000)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 1154, 1244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1211, 1229);

                    return "##MVID##";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 1154, 1244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1260, 1322);

                return "\"" + f_25105_1274_1314(_tokenDeferral, token) + "\"";
                DynAbs.Tracing.TraceSender.TraceExitMethod(25105, 978, 1333);

                string
                f_25105_1274_1314(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param, uint
                token)
                {
                    var return_v = this_param.GetStringFromToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 1274, 1314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 978, 1333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 978, 1333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string VisualizeSymbol(uint token, OperandType operandType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25105, 1345, 2848);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1445, 2232) || true) && (operandType == OperandType.InlineTok)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 1445, 2232);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1602, 1733) || true) && ((token & 0xff000000) == 0x40000000)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 1602, 1733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1682, 1714);

                        return "Max Method Token Index";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 1602, 1733);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1823, 1982) || true) && ((token & 0xff000000) == 0x20000000)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 1823, 1982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 1903, 1963);

                        return "Source Document " + f_25105_1931_1962((token & 0x00ffffff));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 1823, 1982);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2084, 2217) || true) && ((token & 0x80000000) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(25105, 2088, 2136) && token != 0xffffffff))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 2084, 2217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2178, 2198);

                        token &= 0x7fffffff;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 2084, 2217);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 1445, 2232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2248, 2311);

                object
                reference = f_25105_2267_2310(_tokenDeferral, token)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2482, 2616);

                var
                temp = (reference as ISymbolInternal) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Symbols.ISymbolInternal?>(25105, 2493, 2615) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(25105, 2528, 2557) || (((reference is Cci.IReference) && DynAbs.Tracing.TraceSender.Conditional_F2(25105, 2560, 2607)) || DynAbs.Tracing.TraceSender.Conditional_F3(25105, 2610, 2614))) ? f_25105_2560_2607(((Cci.IReference)reference)) : null))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2630, 2687);

                ISymbol
                symbol = (DynAbs.Tracing.TraceSender.Conditional_F1(25105, 2647, 2659) || ((temp != null && DynAbs.Tracing.TraceSender.Conditional_F2(25105, 2662, 2679)) || DynAbs.Tracing.TraceSender.Conditional_F3(25105, 2682, 2686))) ? f_25105_2662_2679(temp) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 2701, 2837);

                return f_25105_2708_2836("\"{0}\"", (DynAbs.Tracing.TraceSender.Conditional_F1(25105, 2733, 2747) || ((symbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(25105, 2750, 2767)) || DynAbs.Tracing.TraceSender.Conditional_F3(25105, 2770, 2835))) ? (object)reference : f_25105_2770_2835(symbol, SymbolDisplayFormat.ILVisualizationFormat));
                DynAbs.Tracing.TraceSender.TraceExitMethod(25105, 1345, 2848);

                string
                f_25105_1931_1962(uint
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 1931, 1962);
                    return return_v;
                }


                object
                f_25105_2267_2310(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param, uint
                token)
                {
                    var return_v = this_param.GetReferenceFromToken(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 2267, 2310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_25105_2560_2607(Microsoft.Cci.IReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 2560, 2607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25105_2662_2679(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 2662, 2679);
                    return return_v;
                }


                string
                f_25105_2770_2835(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 2770, 2835);
                    return return_v;
                }


                string
                f_25105_2708_2836(string
                format, object
                arg0)
                {
                    var return_v = string.Format(format, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 2708, 2836);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 1345, 2848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 1345, 2848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string VisualizeLocalType(object type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25105, 2860, 3484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3189, 3310);

                var
                temp = ((type as ISymbolInternal) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Symbols.ISymbolInternal?>(25105, 3201, 3308) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(25105, 3231, 3255) || (((type is Cci.IReference) && DynAbs.Tracing.TraceSender.Conditional_F2(25105, 3258, 3300)) || DynAbs.Tracing.TraceSender.Conditional_F3(25105, 3303, 3307))) ? f_25105_3258_3300(((Cci.IReference)type)) : null)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3324, 3473);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(25105, 3331, 3356) || (((temp is ISymbolInternal) && DynAbs.Tracing.TraceSender.Conditional_F2(25105, 3359, 3454)) || DynAbs.Tracing.TraceSender.Conditional_F3(25105, 3457, 3472))) ? f_25105_3359_3454(f_25105_3359_3395(((ISymbolInternal)temp)), SymbolDisplayFormat.ILVisualizationFormat) : f_25105_3457_3472(type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25105, 2860, 3484);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_25105_3258_3300(Microsoft.Cci.IReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 3258, 3300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_25105_3359_3395(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 3359, 3395);
                    return return_v;
                }


                string
                f_25105_3359_3454(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 3359, 3454);
                    return return_v;
                }


                string?
                f_25105_3457_3472(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 3457, 3472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 2860, 3484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 2860, 3484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<HandlerSpan> GetHandlerSpans(ImmutableArray<Cci.ExceptionHandlerRegion> regions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 3663, 5905);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3788, 3872) || true) && (regions.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 3788, 3872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3845, 3857);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 3788, 3872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3888, 3924);

                var
                spans = f_25105_3900_3923()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 3979, 4357);
                    foreach (Cci.ExceptionHandlerRegion region in f_25105_4025_4032_I(regions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 3979, 4357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4066, 4160);

                        var
                        span = f_25105_4077_4159(HandlerKind.Try, null, f_25105_4116_4137(region), f_25105_4139_4158(region))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4180, 4200);

                        int
                        n = f_25105_4188_4199(spans)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4218, 4342) || true) && (n == 0 || (DynAbs.Tracing.TraceSender.Expression_False(25105, 4222, 4265) || span.CompareTo(f_25105_4247_4259(spans, n - 1)) != 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4218, 4342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4307, 4323);

                            f_25105_4307_4322(spans, span);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4218, 4342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 3979, 4357);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25105, 1, 379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25105, 1, 379);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4413, 5838);
                    foreach (Cci.ExceptionHandlerRegion region in f_25105_4459_4466_I(regions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4413, 5838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4500, 4517);

                        HandlerSpan
                        span
                        = default(HandlerSpan);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4537, 5789) || true) && (f_25105_4541_4559(region) == System.Reflection.Metadata.ExceptionRegionKind.Filter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4537, 5789);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4658, 4793);

                            span = f_25105_4665_4792(HandlerKind.Filter, null, f_25105_4707_4739(region), f_25105_4741_4764(region), f_25105_4766_4791(region));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4537, 5789);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4537, 5789);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4875, 4892);

                            HandlerKind
                            kind
                            = default(HandlerKind);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 4916, 5643);

                            switch (f_25105_4924_4942(region))
                            {

                                case System.Reflection.Metadata.ExceptionRegionKind.Catch:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4916, 5643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5080, 5105);

                                    kind = HandlerKind.Catch;
                                    DynAbs.Tracing.TraceSender.TraceBreak(25105, 5135, 5141);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4916, 5643);

                                case System.Reflection.Metadata.ExceptionRegionKind.Fault:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4916, 5643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5255, 5280);

                                    kind = HandlerKind.Fault;
                                    DynAbs.Tracing.TraceSender.TraceBreak(25105, 5310, 5316);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4916, 5643);

                                case System.Reflection.Metadata.ExceptionRegionKind.Filter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4916, 5643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5431, 5457);

                                    kind = HandlerKind.Filter;
                                    DynAbs.Tracing.TraceSender.TraceBreak(25105, 5487, 5493);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4916, 5643);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 4916, 5643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5557, 5584);

                                    kind = HandlerKind.Finally;
                                    DynAbs.Tracing.TraceSender.TraceBreak(25105, 5614, 5620);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4916, 5643);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5667, 5770);

                            span = f_25105_5674_5769(kind, f_25105_5696_5716(region), f_25105_5718_5743(region), f_25105_5745_5768(region));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4537, 5789);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5807, 5823);

                        f_25105_5807_5822(spans, span);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 4413, 5838);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25105, 1, 1426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25105, 1, 1426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5854, 5867);

                f_25105_5854_5866(
                            spans);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 5881, 5894);

                return spans;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 3663, 5905);

                System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                f_25105_3900_3923()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 3900, 3923);
                    return return_v;
                }


                int
                f_25105_4116_4137(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.TryStartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4116, 4137);
                    return return_v;
                }


                int
                f_25105_4139_4158(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.TryEndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4139, 4158);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                f_25105_4077_4159(Microsoft.Metadata.Tools.ILVisualizer.HandlerKind
                kind, object
                exceptionType, int
                startOffset, int
                endOffset)
                {
                    var return_v = new Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan(kind, exceptionType, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 4077, 4159);
                    return return_v;
                }


                int
                f_25105_4188_4199(System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4188, 4199);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                f_25105_4247_4259(System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4247, 4259);
                    return return_v;
                }


                int
                f_25105_4307_4322(System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                this_param, Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 4307, 4322);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                f_25105_4025_4032_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 4025, 4032);
                    return return_v;
                }


                System.Reflection.Metadata.ExceptionRegionKind
                f_25105_4541_4559(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4541, 4559);
                    return return_v;
                }


                int
                f_25105_4707_4739(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.FilterDecisionStartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4707, 4739);
                    return return_v;
                }


                int
                f_25105_4741_4764(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerEndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4741, 4764);
                    return return_v;
                }


                int
                f_25105_4766_4791(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerStartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4766, 4791);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                f_25105_4665_4792(Microsoft.Metadata.Tools.ILVisualizer.HandlerKind
                kind, object
                exceptionType, int
                startOffset, int
                endOffset, int
                filterHandlerStart)
                {
                    var return_v = new Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan(kind, exceptionType, startOffset, endOffset, filterHandlerStart);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 4665, 4792);
                    return return_v;
                }


                System.Reflection.Metadata.ExceptionRegionKind
                f_25105_4924_4942(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 4924, 4942);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference?
                f_25105_5696_5716(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.ExceptionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 5696, 5716);
                    return return_v;
                }


                int
                f_25105_5718_5743(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerStartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 5718, 5743);
                    return return_v;
                }


                int
                f_25105_5745_5768(Microsoft.Cci.ExceptionHandlerRegion
                this_param)
                {
                    var return_v = this_param.HandlerEndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 5745, 5768);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                f_25105_5674_5769(Microsoft.Metadata.Tools.ILVisualizer.HandlerKind
                kind, Microsoft.Cci.ITypeReference?
                exceptionType, int
                startOffset, int
                endOffset)
                {
                    var return_v = new Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan(kind, (object?)exceptionType, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 5674, 5769);
                    return return_v;
                }


                int
                f_25105_5807_5822(System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                this_param, Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 5807, 5822);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                f_25105_4459_4466_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 4459, 4466);
                    return return_v;
                }


                int
                f_25105_5854_5866(System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                this_param)
                {
                    this_param.Sort();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 5854, 5866);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 3663, 5905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 3663, 5905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ILBuilderToString(
                    ILBuilder builder,
                    Func<Cci.ILocalDefinition, LocalInfo> mapLocal = null,
                    IReadOnlyDictionary<int, string> markers = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 6058, 7465);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6286, 6315);

                var
                sb = f_25105_6295_6314()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6331, 6365);

                var
                ilStream = builder.RealizedIL
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6379, 6541) || true) && (mapLocal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 6379, 6541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6433, 6526);

                    mapLocal = local => new LocalInfo(local.Name, local.Type, local.IsPinned, local.IsReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 6379, 6541);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6557, 6635);

                var
                locals = f_25105_6570_6610(builder.LocalSlotManager).SelectAsArray(mapLocal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6649, 6706);

                var
                visualizer = f_25105_6666_6705(builder.module)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6722, 7417) || true) && (f_25105_6726_6745_M(!ilStream.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 6722, 7417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6779, 6927);

                    f_25105_6779_6926(visualizer, sb, f_25105_6805_6821(builder), ilStream, locals, f_25105_6841_6891(builder.RealizedExceptionHandlers), markers, f_25105_6902_6925(builder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 6722, 7417);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 6722, 7417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 6993, 7012);

                    f_25105_6993_7011(sb, "{");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7032, 7092);

                    f_25105_7032_7091(
                                    visualizer, sb, 0, f_25105_7066_7082(builder), locals);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7153, 7187);

                    var
                    current = builder.leaderBlock
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7205, 7363) || true) && (current != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 7205, 7363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7269, 7294);

                            f_25105_7269_7293(current, sb);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7316, 7344);

                            current = current.NextBlock;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 7205, 7363);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(25105, 7205, 7363);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(25105, 7205, 7363);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7383, 7402);

                    f_25105_7383_7401(
                                    sb, "}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 6722, 7417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7433, 7454);

                return f_25105_7440_7453(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 6058, 7465);

                System.Text.StringBuilder
                f_25105_6295_6314()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6295, 6314);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_25105_6570_6610(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param)
                {
                    var return_v = this_param.LocalsInOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6570, 6610);
                    return return_v;
                }


                Roslyn.Test.Utilities.ILBuilderVisualizer
                f_25105_6666_6705(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                tokenDeferral)
                {
                    var return_v = new Roslyn.Test.Utilities.ILBuilderVisualizer(tokenDeferral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6666, 6705);
                    return return_v;
                }


                bool
                f_25105_6726_6745_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 6726, 6745);
                    return return_v;
                }


                ushort
                f_25105_6805_6821(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 6805, 6821);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                f_25105_6841_6891(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                regions)
                {
                    var return_v = GetHandlerSpans(regions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6841, 6891);
                    return return_v;
                }


                bool
                f_25105_6902_6925(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.AreLocalsZeroed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 6902, 6925);
                    return return_v;
                }


                int
                f_25105_6779_6926(Roslyn.Test.Utilities.ILBuilderVisualizer
                this_param, System.Text.StringBuilder
                sb, ushort
                maxStack, System.Collections.Immutable.ImmutableArray<byte>
                ilBytes, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                locals, System.Collections.Generic.List<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>
                exceptionHandlers, System.Collections.Generic.IReadOnlyDictionary<int, string>?
                markers, bool
                localsAreZeroed)
                {
                    this_param.DumpMethod(sb, (int)maxStack, ilBytes, locals, (System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>)exceptionHandlers, markers, localsAreZeroed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6779, 6926);
                    return 0;
                }


                System.Text.StringBuilder
                f_25105_6993_7011(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 6993, 7011);
                    return return_v;
                }


                ushort
                f_25105_7066_7082(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.MaxStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 7066, 7082);
                    return return_v;
                }


                int
                f_25105_7032_7091(Roslyn.Test.Utilities.ILBuilderVisualizer
                this_param, System.Text.StringBuilder
                sb, int
                codeSize, ushort
                maxStack, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                locals)
                {
                    this_param.VisualizeHeader(sb, codeSize, (int)maxStack, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7032, 7091);
                    return 0;
                }


                int
                f_25105_7269_7293(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block, System.Text.StringBuilder
                sb)
                {
                    DumpBlockIL(block, sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7269, 7293);
                    return 0;
                }


                System.Text.StringBuilder
                f_25105_7383_7401(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7383, 7401);
                    return return_v;
                }


                string
                f_25105_7440_7453(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7440, 7453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 6058, 7465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 6058, 7465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string LocalSignatureToString(
                    ILBuilder builder,
                    Func<Cci.ILocalDefinition, LocalInfo> mapLocal = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 7477, 8129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7648, 7677);

                var
                sb = f_25105_7657_7676()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7693, 7855) || true) && (mapLocal == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 7693, 7855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7747, 7840);

                    mapLocal = local => new LocalInfo(local.Name, local.Type, local.IsPinned, local.IsReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 7693, 7855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7871, 7949);

                var
                locals = f_25105_7884_7924(builder.LocalSlotManager).SelectAsArray(mapLocal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 7963, 8020);

                var
                visualizer = f_25105_7980_8019(builder.module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8036, 8083);

                f_25105_8036_8082(
                            visualizer, sb, -1, -1, locals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8097, 8118);

                return f_25105_8104_8117(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 7477, 8129);

                System.Text.StringBuilder
                f_25105_7657_7676()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7657, 7676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                f_25105_7884_7924(Microsoft.CodeAnalysis.CodeGen.LocalSlotManager
                this_param)
                {
                    var return_v = this_param.LocalsInOrder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7884, 7924);
                    return return_v;
                }


                Roslyn.Test.Utilities.ILBuilderVisualizer
                f_25105_7980_8019(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                tokenDeferral)
                {
                    var return_v = new Roslyn.Test.Utilities.ILBuilderVisualizer(tokenDeferral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 7980, 8019);
                    return return_v;
                }


                int
                f_25105_8036_8082(Roslyn.Test.Utilities.ILBuilderVisualizer
                this_param, System.Text.StringBuilder
                sb, int
                codeSize, int
                maxStack, System.Collections.Immutable.ImmutableArray<Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
                locals)
                {
                    this_param.VisualizeHeader(sb, codeSize, maxStack, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8036, 8082);
                    return 0;
                }


                string
                f_25105_8104_8117(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8104, 8117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 7477, 8129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 7477, 8129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string BasicBlockToString(ILBuilder.BasicBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 8141, 8356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8234, 8273);

                StringBuilder
                sb = f_25105_8253_8272()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8287, 8310);

                f_25105_8287_8309(block, sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8324, 8345);

                return f_25105_8331_8344(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 8141, 8356);

                System.Text.StringBuilder
                f_25105_8253_8272()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8253, 8272);
                    return return_v;
                }


                int
                f_25105_8287_8309(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block, System.Text.StringBuilder
                sb)
                {
                    DumpBlockIL(block, sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8287, 8309);
                    return 0;
                }


                string
                f_25105_8331_8344(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8331, 8344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 8141, 8356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 8141, 8356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void DumpBlockIL(ILBuilder.BasicBlock block, StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 8368, 8705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8470, 8694) || true) && (block is ILBuilder.SwitchBlock switchBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 8470, 8694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8550, 8585);

                    f_25105_8550_8584(switchBlock, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 8470, 8694);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 8470, 8694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8651, 8679);

                    f_25105_8651_8678(block, sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 8470, 8694);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 8368, 8705);

                int
                f_25105_8550_8584(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                block, System.Text.StringBuilder
                sb)
                {
                    DumpSwitchBlockIL(block, sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8550, 8584);
                    return 0;
                }


                int
                f_25105_8651_8678(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                block, System.Text.StringBuilder
                sb)
                {
                    DumpBasicBlockIL(block, sb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8651, 8678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 8368, 8705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 8368, 8705);
            }
        }

        private static void DumpBasicBlockIL(ILBuilder.BasicBlock block, StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 8717, 10005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8824, 8871);

                var
                instrCnt = f_25105_8839_8870(block)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8885, 9153) || true) && (instrCnt != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 8885, 9153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 8936, 8990);

                    var
                    il = f_25105_8945_8989(f_25105_8945_8970(block))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9008, 9138);

                    f_25105_9008_9137(f_25105_9008_9053(block.builder.module), il, instrCnt, sb, f_25105_9084_9123(), block.Start);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 8885, 9153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9169, 9994) || true) && (f_25105_9173_9189(block) != ILOpCode.Nop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 9169, 9994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9239, 9327);

                    f_25105_9239_9326(sb, f_25105_9249_9325("  IL_{0:x4}:", f_25105_9279_9310(block) + block.Start));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9345, 9421);

                    f_25105_9345_9420(sb, f_25105_9355_9419("  {0,-10}", f_25105_9382_9418(f_25105_9401_9417(block))));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9441, 9943) || true) && (f_25105_9445_9472(f_25105_9445_9461(block)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 9441, 9943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9514, 9550);

                        var
                        branchBlock = f_25105_9532_9549(block)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9572, 9924) || true) && (branchBlock == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 9572, 9924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9714, 9745);

                            f_25105_9714_9744(                        // this happens if label is not yet marked.
                                                    sb, " <unmarked label>");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 9572, 9924);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 9572, 9924);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9843, 9901);

                            f_25105_9843_9900(sb, f_25105_9853_9899(" IL_{0:x4}", branchBlock.Start));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 9572, 9924);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 9441, 9943);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 9963, 9979);

                    f_25105_9963_9978(
                                    sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 9169, 9994);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 8717, 10005);

                int
                f_25105_8839_8870(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 8839, 8870);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_25105_8945_8970(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 8945, 8970);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25105_8945_8989(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 8945, 8989);
                    return return_v;
                }


                Roslyn.Test.Utilities.ILBuilderVisualizer
                f_25105_9008_9053(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                tokenDeferral)
                {
                    var return_v = new Roslyn.Test.Utilities.ILBuilderVisualizer(tokenDeferral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9008, 9053);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan[]
                f_25105_9084_9123()
                {
                    var return_v = Array.Empty<ILVisualizer.HandlerSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9084, 9123);
                    return return_v;
                }


                int
                f_25105_9008_9137(Roslyn.Test.Utilities.ILBuilderVisualizer
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                ilBytes, int
                length, System.Text.StringBuilder
                sb, Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan[]
                spans, int
                blockOffset)
                {
                    this_param.DumpILBlock(ilBytes, length, sb, (System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>)spans, blockOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9008, 9137);
                    return 0;
                }


                System.Reflection.Metadata.ILOpCode
                f_25105_9173_9189(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 9173, 9189);
                    return return_v;
                }


                int
                f_25105_9279_9310(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 9279, 9310);
                    return return_v;
                }


                string
                f_25105_9249_9325(string
                format, int
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9249, 9325);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_9239_9326(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9239, 9326);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_25105_9401_9417(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 9401, 9417);
                    return return_v;
                }


                string
                f_25105_9382_9418(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = GetInstructionName(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9382, 9418);
                    return return_v;
                }


                string
                f_25105_9355_9419(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9355, 9419);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_9345_9420(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9345, 9420);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_25105_9445_9461(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 9445, 9461);
                    return return_v;
                }


                bool
                f_25105_9445_9472(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.IsBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9445, 9472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_25105_9532_9549(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.BranchBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 9532, 9549);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_9714_9744(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9714, 9744);
                    return return_v;
                }


                string
                f_25105_9853_9899(string
                format, int
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9853, 9899);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_9843_9900(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9843, 9900);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_9963_9978(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 9963, 9978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 8717, 10005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 8717, 10005);
            }
        }

        private static void DumpSwitchBlockIL(ILBuilder.SwitchBlock block, StringBuilder sb)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 10017, 11345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10126, 10180);

                var
                il = f_25105_10135_10179(f_25105_10135_10160(block))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10194, 10312);

                f_25105_10194_10311(f_25105_10194_10239(block.builder.module), il, il.Length, sb, f_25105_10271_10297(), block.Start);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10453, 10541);

                f_25105_10453_10540(
                            // switch (N, t1, t2... tN)
                            //  IL ==> ILOpCode.Switch < unsigned int32 > < int32 >... < int32 >

                            sb, f_25105_10463_10539("  IL_{0:x4}:", f_25105_10493_10524(block) + block.Start));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10555, 10631);

                f_25105_10555_10630(sb, f_25105_10565_10629("  {0,-10}", f_25105_10592_10628(f_25105_10611_10627(block))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10645, 10707);

                f_25105_10645_10706(sb, f_25105_10655_10705("  IL_{0:x4}:", f_25105_10685_10704(block)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10723, 10791);

                var
                blockBuilder = f_25105_10742_10790()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10805, 10841);

                f_25105_10805_10840(block, blockBuilder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10857, 11266);
                    foreach (var branchBlock in f_25105_10885_10897_I(blockBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 10857, 11266);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 10931, 11251) || true) && (branchBlock == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 10931, 11251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11061, 11092);

                            f_25105_11061_11091(                    // this happens if label is not yet marked.
                                                sb, " <unmarked label>");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 10931, 11251);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 10931, 11251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11174, 11232);

                            f_25105_11174_11231(sb, f_25105_11184_11230(" IL_{0:x4}", branchBlock.Start));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 10931, 11251);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 10857, 11266);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(25105, 1, 410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(25105, 1, 410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11282, 11302);

                f_25105_11282_11301(
                            blockBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11318, 11334);

                f_25105_11318_11333(
                            sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 10017, 11345);

                System.Reflection.Metadata.BlobBuilder
                f_25105_10135_10160(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 10135, 10160);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_25105_10135_10179(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10135, 10179);
                    return return_v;
                }


                Roslyn.Test.Utilities.ILBuilderVisualizer
                f_25105_10194_10239(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                tokenDeferral)
                {
                    var return_v = new Roslyn.Test.Utilities.ILBuilderVisualizer(tokenDeferral);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10194, 10239);
                    return return_v;
                }


                Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan[]
                f_25105_10271_10297()
                {
                    var return_v = Array.Empty<HandlerSpan>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10271, 10297);
                    return return_v;
                }


                int
                f_25105_10194_10311(Roslyn.Test.Utilities.ILBuilderVisualizer
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                ilBytes, int
                length, System.Text.StringBuilder
                sb, Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan[]
                spans, int
                blockOffset)
                {
                    this_param.DumpILBlock(ilBytes, length, sb, (System.Collections.Generic.IReadOnlyList<Microsoft.Metadata.Tools.ILVisualizer.HandlerSpan>)spans, blockOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10194, 10311);
                    return 0;
                }


                int
                f_25105_10493_10524(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.RegularInstructionsLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 10493, 10524);
                    return return_v;
                }


                string
                f_25105_10463_10539(string
                format, int
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10463, 10539);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_10453_10540(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10453, 10540);
                    return return_v;
                }


                System.Reflection.Metadata.ILOpCode
                f_25105_10611_10627(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.BranchCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 10611, 10627);
                    return return_v;
                }


                string
                f_25105_10592_10628(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = GetInstructionName(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10592, 10628);
                    return return_v;
                }


                string
                f_25105_10565_10629(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10565, 10629);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_10555_10630(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10555, 10630);
                    return return_v;
                }


                uint
                f_25105_10685_10704(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param)
                {
                    var return_v = this_param.BranchesCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25105, 10685, 10704);
                    return return_v;
                }


                string
                f_25105_10655_10705(string
                format, uint
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10655, 10705);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_10645_10706(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10645, 10706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_25105_10742_10790()
                {
                    var return_v = ArrayBuilder<ILBuilder.BasicBlock>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10742, 10790);
                    return return_v;
                }


                int
                f_25105_10805_10840(Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                branchBlocksBuilder)
                {
                    this_param.GetBranchBlocks(branchBlocksBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10805, 10840);
                    return 0;
                }


                System.Text.StringBuilder
                f_25105_11061_11091(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 11061, 11091);
                    return return_v;
                }


                string
                f_25105_11184_11230(string
                format, int
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 11184, 11230);
                    return return_v;
                }


                System.Text.StringBuilder
                f_25105_11174_11231(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 11174, 11231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                f_25105_10885_10897_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 10885, 10897);
                    return return_v;
                }


                int
                f_25105_11282_11301(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 11282, 11301);
                    return 0;
                }


                System.Text.StringBuilder
                f_25105_11318_11333(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 11318, 11333);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 10017, 11345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 10017, 11345);
            }
        }

        private static string GetInstructionName(ILOpCode opcode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25105, 11357, 24267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11439, 24191);

                switch (opcode)
                {

                    case ILOpCode.Nop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11506, 11519);

                        return "nop";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Break:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11558, 11573);

                        return "break";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg_0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11614, 11631);

                        return "ldarg.0";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg_1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11672, 11689);

                        return "ldarg.1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg_2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11730, 11747);

                        return "ldarg.2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11788, 11805);

                        return "ldarg.3";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc_0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11846, 11863);

                        return "ldloc.0";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc_1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11904, 11921);

                        return "ldloc.1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc_2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 11962, 11979);

                        return "ldloc.2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12020, 12037);

                        return "ldloc.3";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc_0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12078, 12095);

                        return "stloc.0";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc_1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12136, 12153);

                        return "stloc.1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc_2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12194, 12211);

                        return "stloc.2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12252, 12269);

                        return "stloc.3";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12310, 12327);

                        return "ldarg.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarga_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12369, 12387);

                        return "ldarga.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Starg_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12428, 12445);

                        return "starg.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12486, 12503);

                        return "ldloc.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloca_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12545, 12563);

                        return "ldloca.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12604, 12621);

                        return "stloc.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldnull:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12661, 12677);

                        return "ldnull";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_m1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12720, 12739);

                        return "ldc.i4.m1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12781, 12799);

                        return "ldc.i4.0";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12841, 12859);

                        return "ldc.i4.1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12901, 12919);

                        return "ldc.i4.2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 12961, 12979);

                        return "ldc.i4.3";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13021, 13039);

                        return "ldc.i4.4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13081, 13099);

                        return "ldc.i4.5";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13141, 13159);

                        return "ldc.i4.6";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13201, 13219);

                        return "ldc.i4.7";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13261, 13279);

                        return "ldc.i4.8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13321, 13339);

                        return "ldc.i4.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13379, 13395);

                        return "ldc.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13435, 13451);

                        return "ldc.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13491, 13507);

                        return "ldc.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldc_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13547, 13563);

                        return "ldc.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Dup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13600, 13613);

                        return "dup";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Pop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13650, 13663);

                        return "pop";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Jmp:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13700, 13713);

                        return "jmp";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13751, 13765);

                        return "call";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Calli:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13804, 13819);

                        return "calli";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ret:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13856, 13869);

                        return "ret";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Br_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13907, 13921);

                        return "br.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Brfalse_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 13964, 13983);

                        return "brfalse.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Brtrue_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14025, 14043);

                        return "brtrue.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Beq_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14082, 14097);

                        return "beq.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bge_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14136, 14151);

                        return "bge.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bgt_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14190, 14205);

                        return "bgt.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ble_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14244, 14259);

                        return "ble.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Blt_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14298, 14313);

                        return "blt.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bne_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14355, 14373);

                        return "bne.un.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bge_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14415, 14433);

                        return "bge.un.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bgt_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14475, 14493);

                        return "bgt.un.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ble_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14535, 14553);

                        return "ble.un.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Blt_un_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14595, 14613);

                        return "blt.un.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Br:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14649, 14661);

                        return "br";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Brfalse:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14702, 14719);

                        return "brfalse";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Brtrue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14759, 14775);

                        return "brtrue";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Beq:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14812, 14825);

                        return "beq";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bge:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14862, 14875);

                        return "bge";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bgt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14912, 14925);

                        return "bgt";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ble:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 14962, 14975);

                        return "ble";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Blt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15012, 15025);

                        return "blt";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bne_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15065, 15081);

                        return "bne.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bge_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15121, 15137);

                        return "bge.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Bgt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15177, 15193);

                        return "bgt.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ble_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15233, 15249);

                        return "ble.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Blt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15289, 15305);

                        return "blt.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Switch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15345, 15361);

                        return "switch";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15403, 15421);

                        return "ldind.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_u1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15463, 15481);

                        return "ldind.u1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15523, 15541);

                        return "ldind.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_u2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15583, 15601);

                        return "ldind.u2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15643, 15661);

                        return "ldind.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_u4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15703, 15721);

                        return "ldind.u4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15763, 15781);

                        return "ldind.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15822, 15839);

                        return "ldind.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15881, 15899);

                        return "ldind.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 15941, 15959);

                        return "ldind.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldind_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16002, 16021);

                        return "ldind.ref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16064, 16083);

                        return "stind.ref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16125, 16143);

                        return "stind.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16185, 16203);

                        return "stind.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16245, 16263);

                        return "stind.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16305, 16323);

                        return "stind.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16365, 16383);

                        return "stind.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16425, 16443);

                        return "stind.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Add:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16480, 16493);

                        return "add";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Sub:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16530, 16543);

                        return "sub";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Mul:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16580, 16593);

                        return "mul";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Div:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16630, 16643);

                        return "div";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Div_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16683, 16699);

                        return "div.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Rem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16736, 16749);

                        return "rem";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Rem_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16789, 16805);

                        return "rem.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16842, 16855);

                        return "and";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Or:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16891, 16903);

                        return "or";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16940, 16953);

                        return "xor";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Shl:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 16990, 17003);

                        return "shl";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Shr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17040, 17053);

                        return "shr";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Shr_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17093, 17109);

                        return "shr.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Neg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17146, 17159);

                        return "neg";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Not:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17196, 17209);

                        return "not";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17250, 17267);

                        return "conv.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17308, 17325);

                        return "conv.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17366, 17383);

                        return "conv.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17424, 17441);

                        return "conv.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17482, 17499);

                        return "conv.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17540, 17557);

                        return "conv.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_u4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17598, 17615);

                        return "conv.u4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_u8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17656, 17673);

                        return "conv.u8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Callvirt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17715, 17733);

                        return "callvirt";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Cpobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17772, 17787);

                        return "cpobj";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17826, 17841);

                        return "ldobj";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldstr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17880, 17895);

                        return "ldstr";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Newobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17935, 17951);

                        return "newobj";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Castclass:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 17994, 18013);

                        return "castclass";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Isinst:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18053, 18069);

                        return "isinst";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_r_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18112, 18131);

                        return "conv.r.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Unbox:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18170, 18185);

                        return "unbox";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Throw:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18224, 18239);

                        return "throw";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18278, 18293);

                        return "ldfld";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18333, 18349);

                        return "ldflda";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18388, 18403);

                        return "stfld";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldsfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18443, 18459);

                        return "ldsfld";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldsflda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18500, 18517);

                        return "ldsflda";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stsfld:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18557, 18573);

                        return "stsfld";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18612, 18627);

                        return "stobj";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i1_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18675, 18699);

                        return "conv.ovf.i1.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i2_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18747, 18771);

                        return "conv.ovf.i2.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i4_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18819, 18843);

                        return "conv.ovf.i4.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i8_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18891, 18915);

                        return "conv.ovf.i8.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u1_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 18963, 18987);

                        return "conv.ovf.u1.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u2_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19035, 19059);

                        return "conv.ovf.u2.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u4_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19107, 19131);

                        return "conv.ovf.u4.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u8_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19179, 19203);

                        return "conv.ovf.u8.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19250, 19273);

                        return "conv.ovf.i.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19320, 19343);

                        return "conv.ovf.u.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Box:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19380, 19393);

                        return "box";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Newarr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19433, 19449);

                        return "newarr";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldlen:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19488, 19503);

                        return "ldlen";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelema:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19544, 19561);

                        return "ldelema";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19604, 19623);

                        return "ldelem.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_u1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19666, 19685);

                        return "ldelem.u1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19728, 19747);

                        return "ldelem.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_u2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19790, 19809);

                        return "ldelem.u2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19852, 19871);

                        return "ldelem.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_u4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19914, 19933);

                        return "ldelem.u4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 19976, 19995);

                        return "ldelem.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20037, 20055);

                        return "ldelem.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20098, 20117);

                        return "ldelem.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20160, 20179);

                        return "ldelem.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20223, 20243);

                        return "ldelem.ref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20285, 20303);

                        return "stelem.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20346, 20365);

                        return "stelem.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20408, 20427);

                        return "stelem.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20470, 20489);

                        return "stelem.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20532, 20551);

                        return "stelem.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_r4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20594, 20613);

                        return "stelem.r4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_r8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20656, 20675);

                        return "stelem.r8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem_ref:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20719, 20739);

                        return "stelem.ref";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20779, 20795);

                        return "ldelem";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stelem:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20835, 20851);

                        return "stelem";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Unbox_any:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20894, 20913);

                        return "unbox.any";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 20958, 20979);

                        return "conv.ovf.i1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21024, 21045);

                        return "conv.ovf.u1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21090, 21111);

                        return "conv.ovf.i2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21156, 21177);

                        return "conv.ovf.u2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21222, 21243);

                        return "conv.ovf.i4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21288, 21309);

                        return "conv.ovf.u4";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21354, 21375);

                        return "conv.ovf.i8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21420, 21441);

                        return "conv.ovf.u8";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Refanyval:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21484, 21503);

                        return "refanyval";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ckfinite:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21545, 21563);

                        return "ckfinite";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Mkrefany:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21605, 21623);

                        return "mkrefany";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldtoken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21664, 21681);

                        return "ldtoken";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_u2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21722, 21739);

                        return "conv.u2";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_u1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21780, 21797);

                        return "conv.u1";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21837, 21853);

                        return "conv.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21897, 21917);

                        return "conv.ovf.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_ovf_u:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 21961, 21981);

                        return "conv.ovf.u";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Add_ovf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22022, 22039);

                        return "add.ovf";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Add_ovf_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22083, 22103);

                        return "add.ovf.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Mul_ovf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22144, 22161);

                        return "mul.ovf";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Mul_ovf_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22205, 22225);

                        return "mul.ovf.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Sub_ovf:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22266, 22283);

                        return "sub.ovf";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Sub_ovf_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22327, 22347);

                        return "sub.ovf.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Endfinally:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22391, 22411);

                        return "endfinally";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Leave:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22450, 22465);

                        return "leave";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Leave_s:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22506, 22523);

                        return "leave.s";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stind_i:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22564, 22581);

                        return "stind.i";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Conv_u:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22621, 22637);

                        return "conv.u";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Arglist:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22678, 22695);

                        return "arglist";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ceq:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22732, 22745);

                        return "ceq";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Cgt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22782, 22795);

                        return "cgt";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Cgt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22835, 22851);

                        return "cgt.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Clt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22888, 22901);

                        return "clt";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Clt_un:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22941, 22957);

                        return "clt.un";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldftn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 22996, 23011);

                        return "ldftn";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldvirtftn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23054, 23073);

                        return "ldvirtftn";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23112, 23127);

                        return "ldarg";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldarga:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23167, 23183);

                        return "ldarga";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Starg:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23222, 23237);

                        return "starg";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23276, 23291);

                        return "ldloc";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Ldloca:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23331, 23347);

                        return "ldloca";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Stloc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23386, 23401);

                        return "stloc";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Localloc:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23443, 23461);

                        return "localloc";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Endfilter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23504, 23523);

                        return "endfilter";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Unaligned:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23566, 23586);

                        return "unaligned.";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Volatile:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23628, 23647);

                        return "volatile.";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Tail:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23685, 23700);

                        return "tail.";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Initobj:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23741, 23758);

                        return "initobj";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Constrained:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23803, 23825);

                        return "constrained.";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Cpblk:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23864, 23879);

                        return "cpblk";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Initblk:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23920, 23937);

                        return "initblk";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Rethrow:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 23978, 23995);

                        return "rethrow";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Sizeof:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 24035, 24051);

                        return "sizeof";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Refanytype:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 24095, 24115);

                        return "refanytype";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);

                    case ILOpCode.Readonly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(25105, 11439, 24191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 24157, 24176);

                        return "readonly.";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(25105, 11439, 24191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25105, 24207, 24256);

                throw f_25105_24213_24255(opcode);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25105, 11357, 24267);

                System.Exception
                f_25105_24213_24255(System.Reflection.Metadata.ILOpCode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25105, 24213, 24255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25105, 11357, 24267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 11357, 24267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ILBuilderVisualizer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25105, 711, 24274);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25105, 711, 24274);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25105, 711, 24274);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25105, 711, 24274);
    }
}
