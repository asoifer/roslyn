// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CSharpSymbolVisitor
    {
        public virtual void Visit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 385, 556);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 450, 545) || true) && ((object)symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10167, 450, 545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 510, 530);

                    f_10167_510_529(symbol, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10167, 450, 545);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 385, 556);

                int
                f_10167_510_529(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                visitor)
                {
                    this_param.Accept(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 510, 529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 385, 556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 385, 556);
            }
        }

        public virtual void DefaultVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 568, 637);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 568, 637);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 568, 637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 568, 637);
            }
        }

        public virtual void VisitAlias(AliasSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 649, 756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 724, 745);

                f_10167_724_744(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 649, 756);

                int
                f_10167_724_744(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 724, 744);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 649, 756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 649, 756);
            }
        }

        public virtual void VisitArrayType(ArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 768, 883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 851, 872);

                f_10167_851_871(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 768, 883);

                int
                f_10167_851_871(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 851, 871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 768, 883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 768, 883);
            }
        }

        public virtual void VisitAssembly(AssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 895, 1008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 976, 997);

                f_10167_976_996(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 895, 1008);

                int
                f_10167_976_996(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 976, 996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 895, 1008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 895, 1008);
            }
        }

        public virtual void VisitDynamicType(DynamicTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1020, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1107, 1128);

                f_10167_1107_1127(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1020, 1139);

                int
                f_10167_1107_1127(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1107, 1127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1020, 1139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1020, 1139);
            }
        }

        public virtual void VisitDiscard(DiscardSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1151, 1262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1230, 1251);

                f_10167_1230_1250(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1151, 1262);

                int
                f_10167_1230_1250(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1230, 1250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1151, 1262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1151, 1262);
            }
        }

        public virtual void VisitEvent(EventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1274, 1381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1349, 1370);

                f_10167_1349_1369(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1274, 1381);

                int
                f_10167_1349_1369(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1349, 1369);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1274, 1381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1274, 1381);
            }
        }

        public virtual void VisitField(FieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1393, 1500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1468, 1489);

                f_10167_1468_1488(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1393, 1500);

                int
                f_10167_1468_1488(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1468, 1488);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1393, 1500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1393, 1500);
            }
        }

        public virtual void VisitLabel(LabelSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1512, 1619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1587, 1608);

                f_10167_1587_1607(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1512, 1619);

                int
                f_10167_1587_1607(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1587, 1607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1512, 1619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1512, 1619);
            }
        }

        public virtual void VisitLocal(LocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1631, 1738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1706, 1727);

                f_10167_1706_1726(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1631, 1738);

                int
                f_10167_1706_1726(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1706, 1726);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1631, 1738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1631, 1738);
            }
        }

        public virtual void VisitMethod(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1750, 1859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1827, 1848);

                f_10167_1827_1847(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1750, 1859);

                int
                f_10167_1827_1847(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1827, 1847);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1750, 1859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1750, 1859);
            }
        }

        public virtual void VisitModule(ModuleSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1871, 1980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 1948, 1969);

                f_10167_1948_1968(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1871, 1980);

                int
                f_10167_1948_1968(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 1948, 1968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1871, 1980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1871, 1980);
            }
        }

        public virtual void VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 1992, 2107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2075, 2096);

                f_10167_2075_2095(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 1992, 2107);

                int
                f_10167_2075_2095(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2075, 2095);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 1992, 2107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 1992, 2107);
            }
        }

        public virtual void VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2119, 2234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2202, 2223);

                f_10167_2202_2222(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2119, 2234);

                int
                f_10167_2202_2222(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2202, 2222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2119, 2234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2119, 2234);
            }
        }

        public virtual void VisitParameter(ParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2246, 2361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2329, 2350);

                f_10167_2329_2349(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2246, 2361);

                int
                f_10167_2329_2349(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2329, 2349);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2246, 2361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2246, 2361);
            }
        }

        public virtual void VisitPointerType(PointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2373, 2492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2460, 2481);

                f_10167_2460_2480(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2373, 2492);

                int
                f_10167_2460_2480(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2460, 2480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2373, 2492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2373, 2492);
            }
        }

        public virtual void VisitFunctionPointerType(FunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2504, 2639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2607, 2628);

                f_10167_2607_2627(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2504, 2639);

                int
                f_10167_2607_2627(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2607, 2627);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2504, 2639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2504, 2639);
            }
        }

        public virtual void VisitProperty(PropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2651, 2764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2732, 2753);

                f_10167_2732_2752(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2651, 2764);

                int
                f_10167_2732_2752(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2732, 2752);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2651, 2764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2651, 2764);
            }
        }

        public virtual void VisitRangeVariable(RangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2776, 2899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 2867, 2888);

                f_10167_2867_2887(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2776, 2899);

                int
                f_10167_2867_2887(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 2867, 2887);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2776, 2899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2776, 2899);
            }
        }

        public virtual void VisitTypeParameter(TypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10167, 2911, 3034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10167, 3002, 3023);

                f_10167_3002_3022(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10167, 2911, 3034);

                int
                f_10167_3002_3022(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10167, 3002, 3022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10167, 2911, 3034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 2911, 3034);
            }
        }

        public CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10167, 325, 3041);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10167, 325, 3041);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 325, 3041);
        }


        static CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10167, 325, 3041);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10167, 325, 3041);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10167, 325, 3041);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10167, 325, 3041);
    }
}
