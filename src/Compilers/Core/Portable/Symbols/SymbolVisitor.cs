// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public abstract class SymbolVisitor
    {
        public virtual void Visit(ISymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 301, 400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 368, 389);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 644, 368, 388)?.Accept(this), 644, 375, 388);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 301, 400);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 301, 400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 301, 400);
            }
        }

        public virtual void DefaultVisit(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 412, 482);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 412, 482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 412, 482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 412, 482);
            }
        }

        public virtual void VisitAlias(IAliasSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 494, 602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 570, 591);

                f_644_570_590(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 494, 602);

                int
                f_644_570_590(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IAliasSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 570, 590);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 494, 602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 494, 602);
            }
        }

        public virtual void VisitArrayType(IArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 614, 730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 698, 719);

                f_644_698_718(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 614, 730);

                int
                f_644_698_718(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 698, 718);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 614, 730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 614, 730);
            }
        }

        public virtual void VisitAssembly(IAssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 742, 856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 824, 845);

                f_644_824_844(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 742, 856);

                int
                f_644_824_844(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IAssemblySymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 824, 844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 742, 856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 742, 856);
            }
        }

        public virtual void VisitDiscard(IDiscardSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 868, 980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 948, 969);

                f_644_948_968(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 868, 980);

                int
                f_644_948_968(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IDiscardSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 948, 968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 868, 980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 868, 980);
            }
        }

        public virtual void VisitDynamicType(IDynamicTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 992, 1112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1080, 1101);

                f_644_1080_1100(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 992, 1112);

                int
                f_644_1080_1100(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IDynamicTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1080, 1100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 992, 1112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 992, 1112);
            }
        }

        public virtual void VisitEvent(IEventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1124, 1232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1200, 1221);

                f_644_1200_1220(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1124, 1232);

                int
                f_644_1200_1220(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IEventSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1200, 1220);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1124, 1232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1124, 1232);
            }
        }

        public virtual void VisitField(IFieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1244, 1352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1320, 1341);

                f_644_1320_1340(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1244, 1352);

                int
                f_644_1320_1340(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1320, 1340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1244, 1352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1244, 1352);
            }
        }

        public virtual void VisitLabel(ILabelSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1364, 1472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1440, 1461);

                f_644_1440_1460(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1364, 1472);

                int
                f_644_1440_1460(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.ILabelSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1440, 1460);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1364, 1472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1364, 1472);
            }
        }

        public virtual void VisitLocal(ILocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1484, 1592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1560, 1581);

                f_644_1560_1580(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1484, 1592);

                int
                f_644_1560_1580(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1560, 1580);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1484, 1592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1484, 1592);
            }
        }

        public virtual void VisitMethod(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1604, 1714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1682, 1703);

                f_644_1682_1702(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1604, 1714);

                int
                f_644_1682_1702(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1682, 1702);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1604, 1714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1604, 1714);
            }
        }

        public virtual void VisitModule(IModuleSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1726, 1836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1804, 1825);

                f_644_1804_1824(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1726, 1836);

                int
                f_644_1804_1824(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IModuleSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1804, 1824);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1726, 1836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1726, 1836);
            }
        }

        public virtual void VisitNamedType(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1848, 1964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 1932, 1953);

                f_644_1932_1952(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1848, 1964);

                int
                f_644_1932_1952(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 1932, 1952);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1848, 1964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1848, 1964);
            }
        }

        public virtual void VisitNamespace(INamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 1976, 2092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2060, 2081);

                f_644_2060_2080(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 1976, 2092);

                int
                f_644_2060_2080(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2060, 2080);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 1976, 2092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 1976, 2092);
            }
        }

        public virtual void VisitParameter(IParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2104, 2220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2188, 2209);

                f_644_2188_2208(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2104, 2220);

                int
                f_644_2188_2208(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IParameterSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2188, 2208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2104, 2220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2104, 2220);
            }
        }

        public virtual void VisitPointerType(IPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2232, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2320, 2341);

                f_644_2320_2340(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2232, 2352);

                int
                f_644_2320_2340(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IPointerTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2320, 2340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2232, 2352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2232, 2352);
            }
        }

        public virtual void VisitFunctionPointerType(IFunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2364, 2500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2468, 2489);

                f_644_2468_2488(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2364, 2500);

                int
                f_644_2468_2488(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2468, 2488);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2364, 2500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2364, 2500);
            }
        }

        public virtual void VisitProperty(IPropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2512, 2626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2594, 2615);

                f_644_2594_2614(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2512, 2626);

                int
                f_644_2594_2614(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2594, 2614);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2512, 2626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2512, 2626);
            }
        }

        public virtual void VisitRangeVariable(IRangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2638, 2762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2730, 2751);

                f_644_2730_2750(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2638, 2762);

                int
                f_644_2730_2750(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.IRangeVariableSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2730, 2750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2638, 2762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2638, 2762);
            }
        }

        public virtual void VisitTypeParameter(ITypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(644, 2774, 2898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(644, 2866, 2887);

                f_644_2866_2886(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(644, 2774, 2898);

                int
                f_644_2866_2886(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol)
                {
                    this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(644, 2866, 2886);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(644, 2774, 2898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 2774, 2898);
            }
        }

        public SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(644, 249, 2905);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(644, 249, 2905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 249, 2905);
        }


        static SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(644, 249, 2905);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(644, 249, 2905);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(644, 249, 2905);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(644, 249, 2905);
    }
}
