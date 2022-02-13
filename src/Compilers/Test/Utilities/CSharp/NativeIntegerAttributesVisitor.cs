// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    internal sealed class NativeIntegerAttributesVisitor : CSharpSymbolVisitor
    {
        internal static string GetString(PEModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 726, 999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 806, 840);

                var
                builder = f_21014_820_839()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 854, 912);

                var
                visitor = f_21014_868_911(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 926, 948);

                f_21014_926_947(visitor, module);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 962, 988);

                return f_21014_969_987(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 726, 999);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 726, 999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 726, 999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly StringBuilder _builder;

        private readonly HashSet<Symbol> _reported;

        private NativeIntegerAttributesVisitor(StringBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21014, 1116, 1280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1042, 1050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1094, 1103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1202, 1221);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1235, 1269);

                _reported = f_21014_1247_1268();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21014, 1116, 1280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 1116, 1280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 1116, 1280);
            }
        }

        public override void DefaultVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 1292, 1397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1365, 1386);

                f_21014_1365_1385(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 1292, 1397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 1292, 1397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 1292, 1397);
            }
        }

        public override void VisitModule(ModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 1409, 1528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1487, 1517);

                f_21014_1487_1516(this, f_21014_1493_1515(module));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 1409, 1528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 1409, 1528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 1409, 1528);
            }
        }

        public override void VisitNamespace(NamespaceSymbol @namespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 1540, 1674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1628, 1663);

                f_21014_1628_1662(this, f_21014_1638_1661(@namespace));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 1540, 1674);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 1540, 1674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 1540, 1674);
            }
        }

        public override void VisitNamedType(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 1686, 2095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1768, 1787);

                f_21014_1768_1786(this, type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1801, 1832);

                f_21014_1801_1831(this, f_21014_1811_1830(type));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 1848, 2084);
                    foreach (var member in f_21014_1871_1888_I(f_21014_1871_1888(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 1848, 2084);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2003, 2037) || true) && (f_21014_2007_2026(member))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 2003, 2037);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2028, 2037);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 2003, 2037);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2055, 2069);

                        f_21014_2055_2068(this, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 1848, 2084);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 1, 237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 1, 237);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 1686, 2095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 1686, 2095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 1686, 2095);
            }
        }

        public override void VisitMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 2107, 2307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2185, 2206);

                f_21014_2185_2205(this, method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2220, 2253);

                f_21014_2220_2252(this, f_21014_2230_2251(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2267, 2296);

                f_21014_2267_2295(this, f_21014_2277_2294(method));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 2107, 2307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 2107, 2307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 2107, 2307);
            }
        }

        public override void VisitEvent(EventSymbol @event)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 2319, 2506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2395, 2416);

                f_21014_2395_2415(this, @event);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2430, 2454);

                f_21014_2430_2453(this, f_21014_2436_2452(@event));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2468, 2495);

                f_21014_2468_2494(this, f_21014_2474_2493(@event));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 2319, 2506);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 2319, 2506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 2319, 2506);
            }
        }

        public override void VisitProperty(PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 2518, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2602, 2625);

                f_21014_2602_2624(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2639, 2670);

                f_21014_2639_2669(this, f_21014_2649_2668(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2684, 2710);

                f_21014_2684_2709(this, f_21014_2690_2708(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2724, 2750);

                f_21014_2724_2749(this, f_21014_2730_2748(property));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 2518, 2761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 2518, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 2518, 2761);
            }
        }

        public override void VisitTypeParameter(TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 2773, 2911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 2872, 2900);

                f_21014_2872_2899(this, typeParameter);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 2773, 2911);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 2773, 2911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 2773, 2911);
            }
        }

        private void VisitList<TSymbol>(ImmutableArray<TSymbol> symbols) where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 2923, 3139);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3035, 3128);
                    foreach (var symbol in f_21014_3058_3065_I<TSymbol>(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 3035, 3128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3099, 3113);

                        f_21014_3099_3112<TSymbol>(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 3035, 3128);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 1, 94);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 1, 94);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 2923, 3139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 2923, 3139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 2923, 3139);
            }
        }

        private static Symbol GetContainingSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 3452, 3818);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3533, 3652) || true) && (f_21014_3537_3556(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 3533, 3652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3590, 3637);

                    return f_21014_3597_3636(((MethodSymbol)symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 3533, 3652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3666, 3713);

                var
                containingSymbol = f_21014_3689_3712(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3727, 3807);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(21014, 3734, 3780) || ((f_21014_3734_3756_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingSymbol, 21014, 3734, 3756)?.Kind) == SymbolKind.Namespace && DynAbs.Tracing.TraceSender.Conditional_F2(21014, 3783, 3787)) || DynAbs.Tracing.TraceSender.Conditional_F3(21014, 3790, 3806))) ? null : containingSymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 3452, 3818);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 3452, 3818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 3452, 3818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetIndentString(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 3830, 4220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3907, 3921);

                int
                level = 0
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3935, 4161) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 3935, 4161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 3980, 4017);

                        symbol = f_21014_3989_4016(symbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4035, 4120) || true) && (symbol is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 4035, 4120);
                            DynAbs.Tracing.TraceSender.TraceBreak(21014, 4095, 4101);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 4035, 4120);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4138, 4146);

                        level++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 3935, 4161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 3935, 4161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 3935, 4161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4175, 4209);

                return f_21014_4182_4208(' ', level * 4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 3830, 4220);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 3830, 4220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 3830, 4220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly SymbolDisplayFormat _displayFormat;

        private void ReportContainingSymbols(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 4744, 5267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4820, 4857);

                symbol = f_21014_4829_4856(symbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4871, 4945) || true) && (symbol is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 4871, 4945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4923, 4930);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 4871, 4945);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4959, 5045) || true) && (f_21014_4963_4989(_reported, symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 4959, 5045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5023, 5030);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 4959, 5045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5059, 5091);

                f_21014_5059_5090(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5105, 5146);

                f_21014_5105_5145(_builder, f_21014_5121_5144(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5160, 5220);

                f_21014_5160_5219(_builder, f_21014_5180_5218(symbol, _displayFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5234, 5256);

                f_21014_5234_5255(_reported, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 4744, 5267);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 4744, 5267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 4744, 5267);
            }
        }

        private void ReportSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 5279, 6229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5344, 5415);

                var
                type = (symbol as TypeSymbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(21014, 5355, 5414) ?? f_21014_5381_5409(symbol).Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5585, 5621);

                var
                method = symbol as MethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5643, 5761);

                var
                attribute = f_21014_5659_5760((DynAbs.Tracing.TraceSender.Conditional_F1(21014, 5685, 5699) || ((method != null && DynAbs.Tracing.TraceSender.Conditional_F2(21014, 5702, 5734)) || DynAbs.Tracing.TraceSender.Conditional_F3(21014, 5737, 5759))) ? f_21014_5702_5734(method) : f_21014_5737_5759(symbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5775, 5852);

                // LAFHIS
                f_21014_5775_5851((f_21014_5794_5818(type) != true) || (DynAbs.Tracing.TraceSender.Expression_False(21014, 5788, 5850) || (attribute != null)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5866, 5943) || true) && (attribute == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 5866, 5943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5921, 5928);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 5866, 5943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 5957, 5989);

                f_21014_5957_5988(this, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6003, 6044);

                f_21014_6003_6043(_builder, f_21014_6019_6042(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6058, 6108);

                f_21014_6058_6107(_builder, $"{f_21014_6077_6103(attribute)} ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6122, 6182);

                f_21014_6122_6181(_builder, f_21014_6142_6180(symbol, _displayFormat));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6196, 6218);

                f_21014_6196_6217(_reported, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 5279, 6229);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 5279, 6229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 5279, 6229);
            }
        }

        private static Symbol GetAccessSymbol(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 6241, 6708);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6318, 6697) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 6318, 6697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6363, 6682);

                        switch (f_21014_6371_6382(symbol))
                        {

                            case SymbolKind.Parameter:
                            case SymbolKind.TypeParameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 6363, 6682);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6528, 6561);

                                symbol = f_21014_6537_6560(symbol);
                                DynAbs.Tracing.TraceSender.TraceBreak(21014, 6587, 6593);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 6363, 6682);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 6363, 6682);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6649, 6663);

                                return symbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 6363, 6682);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 6318, 6697);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 6318, 6697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 6318, 6697);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 6241, 6708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 6241, 6708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 6241, 6708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ReportAttribute(CSharpAttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 6720, 8291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6813, 6847);

                var
                builder = f_21014_6827_6846()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6861, 6881);

                f_21014_6861_6880(builder, "[");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6897, 6938);

                var
                name = f_21014_6908_6937(f_21014_6908_6932(attribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6952, 7026) || true) && (f_21014_6956_6982(name, "Attribute"))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 6952, 7026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 6984, 7026);

                    name = f_21014_6991_7025(name, 0, f_21014_7009_7020(name) - 9);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 6952, 7026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7040, 7061);

                f_21014_7040_7060(builder, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7077, 7143);

                var
                arguments = f_21014_7093_7142(f_21014_7093_7123(attribute))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7157, 7338) || true) && (arguments.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 7157, 7338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7215, 7235);

                    f_21014_7215_7234(builder, "(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7253, 7285);

                    f_21014_7253_7284(builder, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7303, 7323);

                    f_21014_7303_7322(builder, ")");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 7157, 7338);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7354, 7374);

                f_21014_7354_7373(
                            builder, "]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7388, 7414);

                return f_21014_7395_7413(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 6720, 8291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 6720, 8291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 6720, 8291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpAttributeData GetNativeIntegerAttribute(ImmutableArray<CSharpAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21014, 8412, 8513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8428, 8513);
                return f_21014_8428_8513(attributes, "System.Runtime.CompilerServices", "NativeIntegerAttribute"); DynAbs.Tracing.TraceSender.TraceExitMethod(21014, 8412, 8513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 8412, 8513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 8412, 8513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpAttributeData GetAttribute(ImmutableArray<CSharpAttributeData> attributes, string namespaceName, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 8526, 9066);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8681, 9029);
                    foreach (var attribute in f_21014_8707_8717_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 8681, 9029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8751, 8818);

                        var
                        containingType = f_21014_8772_8817(f_21014_8772_8802(attribute))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8836, 9014) || true) && (f_21014_8840_8859(containingType) == name && (DynAbs.Tracing.TraceSender.Expression_True(21014, 8840, 8936) && f_21014_8871_8919(f_21014_8871_8905(containingType)) == namespaceName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 8836, 9014);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8978, 8995);

                            return attribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 8836, 9014);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 8681, 9029);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 9043, 9055);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 8526, 9066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 8526, 9066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 8526, 9066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NativeIntegerAttributesVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21014, 635, 9073);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 4276, 4731);
            _displayFormat = f_21014_4293_4731(f_21014_4293_4620(SymbolDisplayFormat.TestFormatWithConstraints, SymbolDisplayMemberOptions.IncludeParameters |
                            SymbolDisplayMemberOptions.IncludeType |
                            SymbolDisplayMemberOptions.IncludeRef |
                            SymbolDisplayMemberOptions.IncludeExplicitInterface), SymbolDisplayCompilerInternalOptions.UseNativeIntegerUnderlyingType); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21014, 635, 9073);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 635, 9073);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21014, 635, 9073);

        static System.Text.StringBuilder
        f_21014_820_839()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 820, 839);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        f_21014_868_911(System.Text.StringBuilder
        builder)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor(builder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 868, 911);
            return return_v;
        }


        static int
        f_21014_926_947(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 926, 947);
            return 0;
        }


        static string
        f_21014_969_987(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 969, 987);
            return return_v;
        }


        static System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21014_1247_1268()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1247, 1268);
            return return_v;
        }


        int
        f_21014_1365_1385(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1365, 1385);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21014_1493_1515(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.GlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 1493, 1515);
            return return_v;
        }


        int
        f_21014_1487_1516(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1487, 1516);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21014_1638_1661(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1638, 1661);
            return return_v;
        }


        int
        f_21014_1628_1662(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1628, 1662);
            return 0;
        }


        int
        f_21014_1768_1786(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1768, 1786);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_21014_1811_1830(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 1811, 1830);
            return return_v;
        }


        int
        f_21014_1801_1831(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1801, 1831);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21014_1871_1888(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1871, 1888);
            return return_v;
        }


        bool
        f_21014_2007_2026(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = symbol.IsAccessor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2007, 2026);
            return return_v;
        }


        int
        f_21014_2055_2068(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.Visit(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2055, 2068);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21014_1871_1888_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 1871, 1888);
            return return_v;
        }


        int
        f_21014_2185_2205(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2185, 2205);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_21014_2230_2251(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2230, 2251);
            return return_v;
        }


        int
        f_21014_2220_2252(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2220, 2252);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21014_2277_2294(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2277, 2294);
            return return_v;
        }


        int
        f_21014_2267_2295(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2267, 2295);
            return 0;
        }


        int
        f_21014_2395_2415(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2395, 2415);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21014_2436_2452(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.AddMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2436, 2452);
            return return_v;
        }


        int
        f_21014_2430_2453(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2430, 2453);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21014_2474_2493(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
        this_param)
        {
            var return_v = this_param.RemoveMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2474, 2493);
            return return_v;
        }


        int
        f_21014_2468_2494(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2468, 2494);
            return 0;
        }


        int
        f_21014_2602_2624(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2602, 2624);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_21014_2649_2668(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2649, 2668);
            return return_v;
        }


        int
        f_21014_2639_2669(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        symbols)
        {
            this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(symbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2639, 2669);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_21014_2690_2708(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.GetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2690, 2708);
            return return_v;
        }


        int
        f_21014_2684_2709(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2684, 2709);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_21014_2730_2748(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        this_param)
        {
            var return_v = this_param.SetMethod;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 2730, 2748);
            return return_v;
        }


        int
        f_21014_2724_2749(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        symbol)
        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2724, 2749);
            return 0;
        }


        int
        f_21014_2872_2899(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
        symbol)
        {
            this_param.ReportSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 2872, 2899);
            return 0;
        }


        int
        f_21014_3099_3112<TSymbol>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, TSymbol
        symbol) where TSymbol : Symbol

        {
            this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 3099, 3112);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<TSymbol>
        f_21014_3058_3065_I<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
        i) where TSymbol : Symbol

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 3058, 3065);
            return return_v;
        }


        static bool
        f_21014_3537_3556(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = symbol.IsAccessor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 3537, 3556);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21014_3597_3636(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.AssociatedSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 3597, 3636);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21014_3689_3712(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 3689, 3712);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolKind?
        f_21014_3734_3756_M(Microsoft.CodeAnalysis.SymbolKind?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 3734, 3756);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21014_3989_4016(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetContainingSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 3989, 4016);
            return return_v;
        }


        static string
        f_21014_4182_4208(char
        c, int
        count)
        {
            var return_v = new string(c, count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 4182, 4208);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21014_4293_4620(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        options)
        {
            var return_v = this_param.WithMemberOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 4293, 4620);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21014_4293_4731(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        options)
        {
            var return_v = this_param.WithCompilerInternalOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 4293, 4731);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_21014_4829_4856(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetContainingSymbol(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 4829, 4856);
            return return_v;
        }


        bool
        f_21014_4963_4989(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Contains(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 4963, 4989);
            return return_v;
        }


        int
        f_21014_5059_5090(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportContainingSymbols(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5059, 5090);
            return 0;
        }


        string
        f_21014_5121_5144(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetIndentString(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5121, 5144);
            return return_v;
        }


        System.Text.StringBuilder
        f_21014_5105_5145(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5105, 5145);
            return return_v;
        }


        string
        f_21014_5180_5218(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5180, 5218);
            return return_v;
        }


        System.Text.StringBuilder
        f_21014_5160_5219(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.AppendLine(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5160, 5219);
            return return_v;
        }


        bool
        f_21014_5234_5255(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5234, 5255);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_21014_5381_5409(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = symbol.GetTypeOrReturnType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5381, 5409);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21014_5702_5734(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.GetReturnTypeAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5702, 5734);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21014_5737_5759(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.GetAttributes();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5737, 5759);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21014_5659_5760(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes)
        {
            var return_v = GetNativeIntegerAttribute(attributes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5659, 5760);
            return return_v;
        }


        bool?
        f_21014_5794_5818(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        type)
        {
            var return_v = type?.ContainsNativeInteger();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5794, 5818);
            return return_v;
        }


        int
        f_21014_5775_5851(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5775, 5851);
            return 0;
        }


        int
        f_21014_5957_5988(Microsoft.CodeAnalysis.CSharp.Test.Utilities.NativeIntegerAttributesVisitor
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            this_param.ReportContainingSymbols(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 5957, 5988);
            return 0;
        }


        string
        f_21014_6019_6042(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetIndentString(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6019, 6042);
            return return_v;
        }


        System.Text.StringBuilder
        f_21014_6003_6043(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6003, 6043);
            return return_v;
        }


        string
        f_21014_6077_6103(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        attribute)
        {
            var return_v = ReportAttribute(attribute);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6077, 6103);
            return return_v;
        }


        System.Text.StringBuilder
        f_21014_6058_6107(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6058, 6107);
            return return_v;
        }


        string
        f_21014_6142_6180(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6142, 6180);
            return return_v;
        }


        System.Text.StringBuilder
        f_21014_6122_6181(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.AppendLine(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6122, 6181);
            return return_v;
        }


        bool
        f_21014_6196_6217(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6196, 6217);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolKind
        f_21014_6371_6382(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 6371, 6382);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21014_6537_6560(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 6537, 6560);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_6827_6846()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6827, 6846);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_6861_6880(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6861, 6880);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        f_21014_6908_6932(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.AttributeClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 6908, 6932);
            return return_v;
        }


        static string
        f_21014_6908_6937(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 6908, 6937);
            return return_v;
        }


        static bool
        f_21014_6956_6982(string
        this_param, string
        value)
        {
            var return_v = this_param.EndsWith(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6956, 6982);
            return return_v;
        }


        static int
        f_21014_7009_7020(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 7009, 7020);
            return return_v;
        }


        static string
        f_21014_6991_7025(string
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Substring(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 6991, 7025);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_7040_7060(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7040, 7060);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
        f_21014_7093_7123(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.ConstructorArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 7093, 7123);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        f_21014_7093_7142(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
        items)
        {
            var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.TypedConstant>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7093, 7142);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_7215_7234(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7215, 7234);
            return return_v;
        }


        static int
        f_21014_7253_7284(System.Text.StringBuilder
        builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        values)
        {
            printValues(builder, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7253, 7284);
            return 0;
        }


        static System.Text.StringBuilder
        f_21014_7303_7322(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7303, 7322);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_7354_7373(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7354, 7373);
            return return_v;
        }


        static string
        f_21014_7395_7413(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7395, 7413);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        f_21014_8428_8513(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        attributes, string
        namespaceName, string
        name)
        {
            var return_v = GetAttribute(attributes, namespaceName, name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8428, 8513);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_21014_8772_8802(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
        this_param)
        {
            var return_v = this_param.AttributeConstructor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 8772, 8802);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21014_8772_8817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 8772, 8817);
            return return_v;
        }


        static string
        f_21014_8840_8859(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 8840, 8859);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21014_8871_8905(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 8871, 8905);
            return return_v;
        }


        static string
        f_21014_8871_8919(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.QualifiedName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21014, 8871, 8919);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        f_21014_8707_8717_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8707, 8717);
            return return_v;
        }


        static void
        printValues(StringBuilder builder, ImmutableArray<TypedConstant> values)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 7430, 7817);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7556, 7561);
                    for (int
    i = 0
    ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7547, 7802) || true) && (i < values.Length)
    ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7582, 7585)
    , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 7547, 7802))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 7547, 7802);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7627, 7730) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 7627, 7730);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7686, 7707);

                            f_21014_7686_7706(builder, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 7627, 7730);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7752, 7783);

                        f_21014_7752_7782(builder, values[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21014, 1, 256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21014, 1, 256);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 7430, 7817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 7430, 7817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 7430, 7817);
            }
        }



        static void
        printValue(StringBuilder builder, TypedConstant value)

        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21014, 7833, 8280);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 7932, 8265) || true) && (value.Kind == TypedConstantKind.Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 7932, 8265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8015, 8036);

                    f_21014_8015_8035(builder, "{ ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8058, 8093);

                    f_21014_8058_8092(builder, value.Values);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8115, 8136);

                    f_21014_8115_8135(builder, " }");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 7932, 8265);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21014, 7932, 8265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21014, 8218, 8246);

                    f_21014_8218_8245(builder, value.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21014, 7932, 8265);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21014, 7833, 8280);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21014, 7833, 8280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21014, 7833, 8280);
            }
        }



        static System.Text.StringBuilder
        f_21014_7686_7706(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7686, 7706);
            return return_v;
        }


        static int
        f_21014_7752_7782(System.Text.StringBuilder
        builder, Microsoft.CodeAnalysis.TypedConstant
        value)
        {
            printValue(builder, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 7752, 7782);
            return 0;
        }


        static System.Text.StringBuilder
        f_21014_8015_8035(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8015, 8035);
            return return_v;
        }


        static int
        f_21014_8058_8092(System.Text.StringBuilder
        builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
        values)
        {
            printValues(builder, values);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8058, 8092);
            return 0;
        }


        static System.Text.StringBuilder
        f_21014_8115_8135(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8115, 8135);
            return return_v;
        }


        static System.Text.StringBuilder
        f_21014_8218_8245(System.Text.StringBuilder
        this_param, object?
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21014, 8218, 8245);
            return return_v;
        }

    }
}
