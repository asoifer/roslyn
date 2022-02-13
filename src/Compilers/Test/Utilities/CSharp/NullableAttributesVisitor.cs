// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    internal sealed class NullableAttributesVisitor : CSharpSymbolVisitor
    {
        internal static string GetString(PEModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 690, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 770, 804);

                var
                builder = f_21015_784_803()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 818, 879);

                var
                visitor = f_21015_832_878(module, builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 893, 915);

                f_21015_893_914(visitor, module);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 929, 955);

                return f_21015_936_954(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 690, 966);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 690, 966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 690, 966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly PEModuleSymbol _module;

        private readonly StringBuilder _builder;

        private readonly HashSet<Symbol> _reported;

        private CSharpAttributeData _nullableContext;

        private NullableAttributesVisitor(PEModuleSymbol module, StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21015, 1188, 1401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1010, 1017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1059, 1067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1111, 1120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1159, 1175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1292, 1309);

                _module = module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1323, 1342);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1356, 1390);

                _reported = f_21015_1368_1389();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21015, 1188, 1401);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 1188, 1401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 1188, 1401);
            }
        }

        public override void DefaultVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 1413, 1518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1486, 1507);

                f_21015_1486_1506(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 1413, 1518);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 1413, 1518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 1413, 1518);
            }
        }

        public override void VisitModule(ModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 1530, 1649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1608, 1638);

                f_21015_1608_1637(this, f_21015_1614_1636(module));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 1530, 1649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 1530, 1649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 1530, 1649);
            }
        }

        public override void VisitNamespace(NamespaceSymbol @namespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 1661, 1795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1749, 1784);

                f_21015_1749_1783(this, f_21015_1759_1782(@namespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 1661, 1795);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 1661, 1795);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 1661, 1795);
            }
        }

        public override void VisitNamedType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 1807, 2425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1889, 1928);

                var
                previousContext = _nullableContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 1942, 2031);

                _nullableContext = f_21015_1961_2010(f_21015_1989_2009(type)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(21015, 1961, 2030) ?? _nullableContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2047, 2066);

                f_21015_2047_2065(this, type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2080, 2111);

                f_21015_2080_2110(this, f_21015_2090_2109(type));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2127, 2363);
                    foreach (var member in f_21015_2150_2167_I(f_21015_2150_2167(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 2127, 2363);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2282, 2316) || true) && (f_21015_2286_2305(member))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 2282, 2316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2307, 2316);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 2282, 2316);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2334, 2348);

                        f_21015_2334_2347(this, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 2127, 2363);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2379, 2414);

                _nullableContext = previousContext;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 1807, 2425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 1807, 2425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 1807, 2425);
            }
        }

        public override void VisitMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 2437, 2848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2515, 2554);

                var
                previousContext = _nullableContext
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2568, 2659);

                _nullableContext = f_21015_2587_2638(f_21015_2615_2637(method)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>(21015, 2587, 2658) ?? _nullableContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2675, 2696);

                f_21015_2675_2695(this, method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2710, 2743);

                f_21015_2710_2742(this, f_21015_2720_2741(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2757, 2786);

                f_21015_2757_2785(this, f_21015_2767_2784(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2802, 2837);

                _nullableContext = previousContext;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 2437, 2848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 2437, 2848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 2437, 2848);
            }
        }

        public override void VisitEvent(EventSymbol @event)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 2860, 3047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2936, 2957);

                f_21015_2936_2956(this, @event);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 2971, 2995);

                f_21015_2971_2994(this, f_21015_2977_2993(@event));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3009, 3036);

                f_21015_3009_3035(this, f_21015_3015_3034(@event));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 2860, 3047);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 2860, 3047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 2860, 3047);
            }
        }

        public override void VisitProperty(PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 3059, 3302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3143, 3166);

                f_21015_3143_3165(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3180, 3211);

                f_21015_3180_3210(this, f_21015_3190_3209(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3225, 3251);

                f_21015_3225_3250(this, f_21015_3231_3249(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3265, 3291);

                f_21015_3265_3290(this, f_21015_3271_3289(property));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 3059, 3302);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 3059, 3302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 3059, 3302);
            }
        }

        public override void VisitTypeParameter(TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 3314, 3452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3413, 3441);

                f_21015_3413_3440(this, typeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 3314, 3452);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 3314, 3452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 3314, 3452);
            }
        }

        private void VisitList<TSymbol>(ImmutableArray<TSymbol> symbols) where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 3464, 3680);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3576, 3669);
                    foreach (var symbol in f_21015_3599_3606_I<TSymbol>(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 3576, 3669);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 3640, 3654);

                        f_21015_3640_3653<TSymbol>(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 3576, 3669);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 1, 94);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 1, 94);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 3464, 3680);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 3464, 3680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 3464, 3680);
            }
        }

        private static Symbol GetContainingSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 3993, 4359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4074, 4193) || true) && (f_21015_4078_4097(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 4074, 4193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4131, 4178);

                    return f_21015_4138_4177(((MethodSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 4074, 4193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4207, 4254);

                var
                containingSymbol = f_21015_4230_4253(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4268, 4348);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(21015, 4275, 4321) || ((f_21015_4275_4297_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingSymbol, 21015, 4275, 4297)?.Kind) == SymbolKind.Namespace && DynAbs.Tracing.TraceSender.Conditional_F2(21015, 4324, 4328)) || DynAbs.Tracing.TraceSender.Conditional_F3(21015, 4331, 4347))) ? null : containingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 3993, 4359);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 3993, 4359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 3993, 4359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetIndentString(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 4371, 4761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4448, 4462);

                int
                level = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4476, 4702) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 4476, 4702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4521, 4558);

                        symbol = f_21015_4530_4557(symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4576, 4661) || true) && (symbol is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 4576, 4661);
                            DynAbs.Tracing.TraceSender.TraceBreak(21015, 4636, 4642);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 4576, 4661);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4679, 4687);

                        level++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 4476, 4702);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 4476, 4702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 4476, 4702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4716, 4750);

                return f_21015_4723_4749(' ', level * 4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 4371, 4761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 4371, 4761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 4371, 4761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly SymbolDisplayFormat _displayFormat;

        private void ReportContainingSymbols(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 5174, 5697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5250, 5287);

                symbol = f_21015_5259_5286(symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5301, 5375) || true) && (symbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 5301, 5375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5353, 5360);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 5301, 5375);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5389, 5475) || true) && (f_21015_5393_5419(_reported, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 5389, 5475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5453, 5460);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 5389, 5475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5489, 5521);

                f_21015_5489_5520(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5535, 5576);

                f_21015_5535_5575(_builder, f_21015_5551_5574(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5590, 5650);

                f_21015_5590_5649(_builder, f_21015_5610_5648(symbol, _displayFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5664, 5686);

                f_21015_5664_5685(_reported, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 5174, 5697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 5174, 5697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 5174, 5697);
            }
        }

        private void ReportSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 5709, 7107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5774, 5857);

                var
                nullableContextAttribute = f_21015_5805_5856(f_21015_5833_5855(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 5871, 6009);

                // LAFHIS f_21015_5950_5982((MethodSymbol)symbol) instead of method
                var
                nullableAttribute = f_21015_5895_6008((DynAbs.Tracing.TraceSender.Conditional_F1(21015, 5916, 5947) || (((symbol is MethodSymbol method) && DynAbs.Tracing.TraceSender.Conditional_F2(21015, 5950, 5982)) || DynAbs.Tracing.TraceSender.Conditional_F3(21015, 5985, 6007))) ? f_21015_5950_5982((MethodSymbol)symbol) : f_21015_5985_6007(symbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6025, 6563) || true) && (nullableContextAttribute == null && (DynAbs.Tracing.TraceSender.Expression_True(21015, 6029, 6090) && nullableAttribute == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 6025, 6563);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6124, 6292) || true) && (_nullableContext == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 6124, 6292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6266, 6273);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 6124, 6292);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6412, 6548) || true) && (!f_21015_6417_6480(_module, f_21015_6456_6479(symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 6412, 6548);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6522, 6529);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 6412, 6548);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 6025, 6563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6579, 6611);

                f_21015_6579_6610(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6625, 6666);

                f_21015_6625_6665(_builder, f_21015_6641_6664(symbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6682, 6832) || true) && (nullableContextAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 6682, 6832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6752, 6817);

                    f_21015_6752_6816(_builder, $"{f_21015_6771_6812(nullableContextAttribute)} ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 6682, 6832);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6848, 6984) || true) && (nullableAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 6848, 6984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 6911, 6969);

                    f_21015_6911_6968(_builder, $"{f_21015_6930_6964(nullableAttribute)} ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 6848, 6984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7000, 7060);

                f_21015_7000_7059(
                            _builder, f_21015_7020_7058(symbol, _displayFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7074, 7096);

                f_21015_7074_7095(_reported, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 5709, 7107);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 5709, 7107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 5709, 7107);
            }
        }

        private static Symbol GetAccessSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 7119, 7586);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7196, 7575) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 7196, 7575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7241, 7560);

                        switch (f_21015_7249_7260(symbol))
                        {

                            case SymbolKind.Parameter:
                            case SymbolKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 7241, 7560);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7406, 7439);

                                symbol = f_21015_7415_7438(symbol);
                                DynAbs.Tracing.TraceSender.TraceBreak(21015, 7465, 7471);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 7241, 7560);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 7241, 7560);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7527, 7541);

                                return symbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 7241, 7560);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 7196, 7575);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 7196, 7575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 7196, 7575);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 7119, 7586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 7119, 7586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 7119, 7586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ReportAttribute(CSharpAttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 7598, 9169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7691, 7725);

                var
                builder = f_21015_7705_7724()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7739, 7759);

                f_21015_7739_7758(builder, "[");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7775, 7816);

                var
                name = f_21015_7786_7815(f_21015_7786_7810(attribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7830, 7904) || true) && (f_21015_7834_7860(name, "Attribute"))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 7830, 7904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7862, 7904);

                    name = f_21015_7869_7903(name, 0, f_21015_7887_7898(name) - 9);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 7830, 7904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7918, 7939);

                f_21015_7918_7938(builder, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 7955, 8021);

                var
                arguments = f_21015_7971_8020(f_21015_7971_8001(attribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8035, 8216) || true) && (arguments.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 8035, 8216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8093, 8113);

                    f_21015_8093_8112(builder, "(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8131, 8163);

                    f_21015_8131_8162(builder, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8181, 8201);

                    f_21015_8181_8200(builder, ")");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 8035, 8216);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8232, 8252);

                f_21015_8232_8251(
                            builder, "]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8266, 8292);

                return f_21015_8273_8291(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 7598, 9169);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 7598, 9169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 7598, 9169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpAttributeData GetNullableContextAttribute(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 9292, 9395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9308, 9395);
                return f_21015_9308_9395(attributes, "System.Runtime.CompilerServices", "NullableContextAttribute"); DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 9292, 9395);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 9292, 9395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 9292, 9395);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpAttributeData GetNullableAttribute(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21015, 9512, 9608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9528, 9608);
                return f_21015_9528_9608(attributes, "System.Runtime.CompilerServices", "NullableAttribute"); DynAbs.Tracing.TraceSender.TraceExitMethod(21015, 9512, 9608);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 9512, 9608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 9512, 9608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpAttributeData GetAttribute(ImmutableArray<CSharpAttributeData> attributes, string namespaceName, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 9621, 10161);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9776, 10124);
                    foreach (var attribute in f_21015_9802_9812_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 9776, 10124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9846, 9913);

                        var
                        containingType = f_21015_9867_9912(f_21015_9867_9897(attribute))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9931, 10109) || true) && (f_21015_9935_9954(containingType) == name && (DynAbs.Tracing.TraceSender.Expression_True(21015, 9935, 10031) && f_21015_9966_10014(f_21015_9966_10000(containingType)) == namespaceName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 9931, 10109);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 10073, 10090);

                            return attribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 9931, 10109);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 9776, 10124);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 10138, 10150);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 9621, 10161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 9621, 10161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 9621, 10161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NullableAttributesVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21015, 604, 10168);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 4817, 5161);
            _displayFormat = f_21015_4834_5161(SymbolDisplayFormat.TestFormatWithConstraints, SymbolDisplayMemberOptions.IncludeParameters |
                            SymbolDisplayMemberOptions.IncludeType |
                            SymbolDisplayMemberOptions.IncludeRef |
                            SymbolDisplayMemberOptions.IncludeExplicitInterface); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21015, 604, 10168);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 604, 10168);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21015, 604, 10168);

        static System.Text.StringBuilder
        f_21015_784_803()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 784, 803);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        f_21015_832_878(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        module, System.Text.StringBuilder
        builder)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor(module, builder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 832, 878);
            return return_v;
        }


        static int
        f_21015_893_914(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 893, 914);
            return 0;
        }


        static string
        f_21015_936_954(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 936, 954);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21015_1368_1389()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1368, 1389);
            return return_v;
        }


        int
        f_21015_1486_1506(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1486, 1506);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21015_1614_1636(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.GlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 1614, 1636);
            return return_v;
        }


        int
        f_21015_1608_1637(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1608, 1637);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21015_1759_1782(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1759, 1782);
            return return_v;
        }


        int
        f_21015_1749_1783(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1749, 1783);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_1989_2009(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1989, 2009);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_1961_2010(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes)
        {
            var return_v = GetNullableContextAttribute(attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 1961, 2010);
            return return_v;
        }


        int
        f_21015_2047_2065(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2047, 2065);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_21015_2090_2109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 2090, 2109);
            return return_v;
        }


        int
        f_21015_2080_2110(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2080, 2110);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21015_2150_2167(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2150, 2167);
            return return_v;
        }


        bool
        f_21015_2286_2305(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = symbol.IsAccessor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2286, 2305);
            return return_v;
        }


        int
        f_21015_2334_2347(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.Visit(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2334, 2347);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21015_2150_2167_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2150, 2167);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_2615_2637(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2615, 2637);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_2587_2638(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes)
        {
            var return_v = GetNullableContextAttribute(attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2587, 2638);
            return return_v;
        }


        int
        f_21015_2675_2695(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2675, 2695);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_21015_2720_2741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 2720, 2741);
            return return_v;
        }


        int
        f_21015_2710_2742(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2710, 2742);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21015_2767_2784(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 2767, 2784);
            return return_v;
        }


        int
        f_21015_2757_2785(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2757, 2785);
            return 0;
        }


        int
        f_21015_2936_2956(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2936, 2956);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21015_2977_2993(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.AddMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 2977, 2993);
            return return_v;
        }


        int
        f_21015_2971_2994(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 2971, 2994);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21015_3015_3034(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.RemoveMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 3015, 3034);
            return return_v;
        }


        int
        f_21015_3009_3035(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3009, 3035);
            return 0;
        }


        int
        f_21015_3143_3165(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3143, 3165);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21015_3190_3209(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 3190, 3209);
            return return_v;
        }


        int
        f_21015_3180_3210(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3180, 3210);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_21015_3231_3249(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.GetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 3231, 3249);
            return return_v;
        }


        int
        f_21015_3225_3250(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3225, 3250);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_21015_3271_3289(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.SetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 3271, 3289);
            return return_v;
        }


        int
        f_21015_3265_3290(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3265, 3290);
            return 0;
        }


        int
        f_21015_3413_3440(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3413, 3440);
            return 0;
        }


        int
        f_21015_3640_3653<TSymbol>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, TSymbol
        symbol) where TSymbol : Symbol

        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3640, 3653);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<TSymbol>
        f_21015_3599_3606_I<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
        i) where TSymbol : Symbol

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 3599, 3606);
            return return_v;
        }


        static bool
        f_21015_4078_4097(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = symbol.IsAccessor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 4078, 4097);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_4138_4177(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.AssociatedSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 4138, 4177);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_4230_4253(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 4230, 4253);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolKind?
        f_21015_4275_4297_M(Microsoft.CodeAnalysis.SymbolKind?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 4275, 4297);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_4530_4557(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetContainingSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 4530, 4557);
            return return_v;
        }


        static string
        f_21015_4723_4749(char
        c, int
        count)
        {
            var return_v = new string(c, count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 4723, 4749);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21015_4834_5161(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        options)
        {
            var return_v = this_param.WithMemberOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 4834, 5161);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_5259_5286(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetContainingSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5259, 5286);
            return return_v;
        }


        bool
        f_21015_5393_5419(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Contains(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5393, 5419);
            return return_v;
        }


        int
        f_21015_5489_5520(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportContainingSymbols(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5489, 5520);
            return 0;
        }


        string
        f_21015_5551_5574(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetIndentString(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5551, 5574);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_5535_5575(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5535, 5575);
            return return_v;
        }


        string
        f_21015_5610_5648(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5610, 5648);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_5590_5649(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.AppendLine(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5590, 5649);
            return return_v;
        }


        bool
        f_21015_5664_5685(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5664, 5685);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_5833_5855(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5833, 5855);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_5805_5856(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes)
        {
            var return_v = GetNullableContextAttribute(attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5805, 5856);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_5950_5982(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.GetReturnTypeAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5950, 5982);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_5985_6007(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5985, 6007);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_5895_6008(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes)
        {
            var return_v = GetNullableAttribute(attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 5895, 6008);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_6456_6479(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetAccessSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6456, 6479);
            return return_v;
        }


        bool
        f_21015_6417_6480(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = this_param.ShouldDecodeNullableAttributes(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6417, 6480);
            return return_v;
        }


        int
        f_21015_6579_6610(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NullableAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportContainingSymbols(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6579, 6610);
            return 0;
        }


        string
        f_21015_6641_6664(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetIndentString(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6641, 6664);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_6625_6665(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6625, 6665);
            return return_v;
        }


        string
        f_21015_6771_6812(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        attribute)
        {
            var return_v = ReportAttribute(attribute);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6771, 6812);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_6752_6816(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6752, 6816);
            return return_v;
        }


        string
        f_21015_6930_6964(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        attribute)
        {
            var return_v = ReportAttribute(attribute);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6930, 6964);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_6911_6968(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 6911, 6968);
            return return_v;
        }


        string
        f_21015_7020_7058(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7020, 7058);
            return return_v;
        }


        System.Text.StringBuilder
        f_21015_7000_7059(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.AppendLine(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7000, 7059);
            return return_v;
        }


        bool
        f_21015_7074_7095(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7074, 7095);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolKind
        f_21015_7249_7260(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7249, 7260);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21015_7415_7438(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7415, 7438);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_7705_7724()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7705, 7724);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_7739_7758(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7739, 7758);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_21015_7786_7810(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.AttributeClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7786, 7810);
            return return_v;
        }


        static string
        f_21015_7786_7815(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7786, 7815);
            return return_v;
        }


        static bool
        f_21015_7834_7860(string
        this_param, string
        value)
        {
            var return_v = this_param.EndsWith(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7834, 7860);
            return return_v;
        }


        static int
        f_21015_7887_7898(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7887, 7898);
            return return_v;
        }


        static string
        f_21015_7869_7903(string
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Substring(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7869, 7903);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_7918_7938(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7918, 7938);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
        f_21015_7971_8001(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.ConstructorArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 7971, 8001);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        f_21015_7971_8020(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
        items)
        {
            var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.TypedConstant>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 7971, 8020);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_8093_8112(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8093, 8112);
            return return_v;
        }


        static int
        f_21015_8131_8162(System.Text.StringBuilder
        builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        values)
        {
            printValues(builder, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8131, 8162);
            return 0;
        }


        static System.Text.StringBuilder
        f_21015_8181_8200(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8181, 8200);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_8232_8251(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8232, 8251);
            return return_v;
        }


        static string
        f_21015_8273_8291(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8273, 8291);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_9308_9395(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes, string
        namespaceName, string
        name)
        {
            var return_v = GetAttribute(attributes, namespaceName, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 9308, 9395);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21015_9528_9608(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes, string
        namespaceName, string
        name)
        {
            var return_v = GetAttribute(attributes, namespaceName, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 9528, 9608);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21015_9867_9897(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.AttributeConstructor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 9867, 9897);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21015_9867_9912(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 9867, 9912);
            return return_v;
        }


        static string
        f_21015_9935_9954(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 9935, 9954);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21015_9966_10000(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 9966, 10000);
            return return_v;
        }


        static string
        f_21015_9966_10014(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.QualifiedName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21015, 9966, 10014);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21015_9802_9812_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 9802, 9812);
            return return_v;
        }


        static void
        printValues(StringBuilder builder, ImmutableArray<TypedConstant> values)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 8308, 8695);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8434, 8439);
                    for (int
    i = 0
    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8425, 8680) || true) && (i < values.Length)
    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8460, 8463)
    , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 8425, 8680))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 8425, 8680);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8505, 8608) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 8505, 8608);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8564, 8585);

                            f_21015_8564_8584(builder, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 8505, 8608);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8630, 8661);

                        f_21015_8630_8660(builder, values[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21015, 1, 256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21015, 1, 256);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 8308, 8695);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 8308, 8695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 8308, 8695);
            }
        }



        static void
        printValue(StringBuilder builder, TypedConstant value)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21015, 8711, 9158);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8810, 9143) || true) && (value.Kind == TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 8810, 9143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8893, 8914);

                    f_21015_8893_8913(builder, "{ ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8936, 8971);

                    f_21015_8936_8970(builder, value.Values);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 8993, 9014);

                    f_21015_8993_9013(builder, " }");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 8810, 9143);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21015, 8810, 9143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21015, 9096, 9124);

                    f_21015_9096_9123(builder, value.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21015, 8810, 9143);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21015, 8711, 9158);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21015, 8711, 9158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21015, 8711, 9158);
            }
        }



        static System.Text.StringBuilder
        f_21015_8564_8584(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8564, 8584);
            return return_v;
        }


        static int
        f_21015_8630_8660(System.Text.StringBuilder
        builder, Microsoft.CodeAnalysis.TypedConstant
        value)
        {
            printValue(builder, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8630, 8660);
            return 0;
        }


        static System.Text.StringBuilder
        f_21015_8893_8913(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8893, 8913);
            return return_v;
        }


        static int
        f_21015_8936_8970(System.Text.StringBuilder
        builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        values)
        {
            printValues(builder, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8936, 8970);
            return 0;
        }


        static System.Text.StringBuilder
        f_21015_8993_9013(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 8993, 9013);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21015_9096_9123(System.Text.StringBuilder
        this_param, object?
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21015, 9096, 9123);
            return return_v;
        }

    }
}
