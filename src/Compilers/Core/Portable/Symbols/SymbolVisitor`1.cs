// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    public abstract class SymbolVisitor<TResult>
    {
        public virtual TResult? Visit(ISymbol? symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 310, 490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 381, 479);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(645, 388, 402) || ((symbol == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(645, 422, 439)) || DynAbs.Tracing.TraceSender.Conditional_F3(645, 459, 478))) ? default(TResult?)
                : f_645_459_478(symbol, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 310, 490);

                TResult?
                f_645_459_478(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                visitor)
                {
                    var return_v = this_param.Accept<TResult>(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 459, 478);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 310, 490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 310, 490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? DefaultVisit(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 502, 615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 579, 604);

                return default(TResult?);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 502, 615);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 502, 615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 502, 615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitAlias(IAliasSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 627, 746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 707, 735);

                return f_645_714_734(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 627, 746);

                TResult?
                f_645_714_734(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IAliasSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 714, 734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 627, 746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 627, 746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitArrayType(IArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 758, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 846, 874);

                return f_645_853_873(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 758, 885);

                TResult?
                f_645_853_873(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 853, 873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 758, 885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 758, 885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitAssembly(IAssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 897, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 983, 1011);

                return f_645_990_1010(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 897, 1022);

                TResult?
                f_645_990_1010(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IAssemblySymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 990, 1010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 897, 1022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 897, 1022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitDiscard(IDiscardSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1034, 1157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1118, 1146);

                return f_645_1125_1145(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1034, 1157);

                TResult?
                f_645_1125_1145(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IDiscardSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1125, 1145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1034, 1157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1034, 1157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitDynamicType(IDynamicTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1169, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1261, 1289);

                return f_645_1268_1288(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1169, 1300);

                TResult?
                f_645_1268_1288(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IDynamicTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1268, 1288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1169, 1300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1169, 1300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitEvent(IEventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1312, 1431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1392, 1420);

                return f_645_1399_1419(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1312, 1431);

                TResult?
                f_645_1399_1419(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IEventSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1399, 1419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1312, 1431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1312, 1431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitField(IFieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1443, 1562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1523, 1551);

                return f_645_1530_1550(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1443, 1562);

                TResult?
                f_645_1530_1550(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1530, 1550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1443, 1562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1443, 1562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitLabel(ILabelSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1574, 1693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1654, 1682);

                return f_645_1661_1681(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1574, 1693);

                TResult?
                f_645_1661_1681(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.ILabelSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1661, 1681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1574, 1693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1574, 1693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitLocal(ILocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1705, 1824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1785, 1813);

                return f_645_1792_1812(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1705, 1824);

                TResult?
                f_645_1792_1812(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.ILocalSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1792, 1812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1705, 1824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1705, 1824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitMethod(IMethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1836, 1957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 1918, 1946);

                return f_645_1925_1945(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1836, 1957);

                TResult?
                f_645_1925_1945(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 1925, 1945);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1836, 1957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1836, 1957);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitModule(IModuleSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 1969, 2090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2051, 2079);

                return f_645_2058_2078(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 1969, 2090);

                TResult?
                f_645_2058_2078(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IModuleSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2058, 2078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 1969, 2090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 1969, 2090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitNamedType(INamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2102, 2229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2190, 2218);

                return f_645_2197_2217(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2102, 2229);

                TResult?
                f_645_2197_2217(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2197, 2217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2102, 2229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2102, 2229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitNamespace(INamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2241, 2368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2329, 2357);

                return f_645_2336_2356(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2241, 2368);

                TResult?
                f_645_2336_2356(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2336, 2356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2241, 2368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2241, 2368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitParameter(IParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2380, 2507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2468, 2496);

                return f_645_2475_2495(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2380, 2507);

                TResult?
                f_645_2475_2495(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IParameterSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2475, 2495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2380, 2507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2380, 2507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitPointerType(IPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2519, 2650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2611, 2639);

                return f_645_2618_2638(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2519, 2650);

                TResult?
                f_645_2618_2638(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IPointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2618, 2638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2519, 2650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2519, 2650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitFunctionPointerType(IFunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2662, 2809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2770, 2798);

                return f_645_2777_2797(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2662, 2809);

                TResult?
                f_645_2777_2797(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IFunctionPointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2777, 2797);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2662, 2809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2662, 2809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitProperty(IPropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2821, 2946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 2907, 2935);

                return f_645_2914_2934(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2821, 2946);

                TResult?
                f_645_2914_2934(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 2914, 2934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2821, 2946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2821, 2946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitRangeVariable(IRangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 2958, 3093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 3054, 3082);

                return f_645_3061_3081(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 2958, 3093);

                TResult?
                f_645_3061_3081(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.IRangeVariableSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 3061, 3081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 2958, 3093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 2958, 3093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult? VisitTypeParameter(ITypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(645, 3105, 3240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(645, 3201, 3229);

                return f_645_3208_3228(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(645, 3105, 3240);

                TResult?
                f_645_3208_3228(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.ITypeParameterSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.ISymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(645, 3208, 3228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(645, 3105, 3240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 3105, 3240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(645, 249, 3247);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(645, 249, 3247);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 249, 3247);
        }


        static SymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(645, 249, 3247);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(645, 249, 3247);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(645, 249, 3247);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(645, 249, 3247);
    }
}
