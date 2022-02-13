// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CSharpSymbolVisitor<TResult>
    {
        public virtual TResult Visit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 394, 578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 462, 567);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10041, 469, 491) || (((object)symbol == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10041, 511, 527)) || DynAbs.Tracing.TraceSender.Conditional_F3(10041, 547, 566))) ? default(TResult)
                : f_10041_547_566(symbol, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 394, 578);

                TResult
                f_10041_547_566(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                visitor)
                {
                    var return_v = this_param.Accept<TResult>(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 547, 566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 394, 578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 394, 578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult DefaultVisit(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 590, 700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 665, 689);

                return default(TResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 590, 700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 590, 700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 590, 700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitAlias(AliasSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 712, 829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 790, 818);

                return f_10041_797_817(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 712, 829);

                TResult
                f_10041_797_817(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 797, 817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 712, 829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 712, 829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitArrayType(ArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 841, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 927, 955);

                return f_10041_934_954(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 841, 966);

                TResult
                f_10041_934_954(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 934, 954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 841, 966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 841, 966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitAssembly(AssemblySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 978, 1101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1062, 1090);

                return f_10041_1069_1089(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 978, 1101);

                TResult
                f_10041_1069_1089(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1069, 1089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 978, 1101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 978, 1101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitDynamicType(DynamicTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1113, 1242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1203, 1231);

                return f_10041_1210_1230(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1113, 1242);

                TResult
                f_10041_1210_1230(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1210, 1230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1113, 1242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1113, 1242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitDiscard(DiscardSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1254, 1375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1336, 1364);

                return f_10041_1343_1363(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1254, 1375);

                TResult
                f_10041_1343_1363(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1343, 1363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1254, 1375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1254, 1375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitEvent(EventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1387, 1504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1465, 1493);

                return f_10041_1472_1492(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1387, 1504);

                TResult
                f_10041_1472_1492(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1472, 1492);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1387, 1504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1387, 1504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitField(FieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1516, 1633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1594, 1622);

                return f_10041_1601_1621(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1516, 1633);

                TResult
                f_10041_1601_1621(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1601, 1621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1516, 1633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1516, 1633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitLabel(LabelSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1645, 1762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1723, 1751);

                return f_10041_1730_1750(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1645, 1762);

                TResult
                f_10041_1730_1750(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1730, 1750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1645, 1762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1645, 1762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitLocal(LocalSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1774, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1852, 1880);

                return f_10041_1859_1879(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1774, 1891);

                TResult
                f_10041_1859_1879(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1859, 1879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1774, 1891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1774, 1891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitMethod(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 1903, 2022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 1983, 2011);

                return f_10041_1990_2010(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 1903, 2022);

                TResult
                f_10041_1990_2010(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 1990, 2010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 1903, 2022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 1903, 2022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitModule(ModuleSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2034, 2153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2114, 2142);

                return f_10041_2121_2141(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2034, 2153);

                TResult
                f_10041_2121_2141(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2121, 2141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2034, 2153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2034, 2153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2165, 2290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2251, 2279);

                return f_10041_2258_2278(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2165, 2290);

                TResult
                f_10041_2258_2278(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2258, 2278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2165, 2290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2165, 2290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2302, 2427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2388, 2416);

                return f_10041_2395_2415(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2302, 2427);

                TResult
                f_10041_2395_2415(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2395, 2415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2302, 2427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2302, 2427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitParameter(ParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2439, 2564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2525, 2553);

                return f_10041_2532_2552(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2439, 2564);

                TResult
                f_10041_2532_2552(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2532, 2552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2439, 2564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2439, 2564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitPointerType(PointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2576, 2705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2666, 2694);

                return f_10041_2673_2693(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2576, 2705);

                TResult
                f_10041_2673_2693(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2673, 2693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2576, 2705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2576, 2705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitFunctionPointerType(FunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2717, 2862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2823, 2851);

                return f_10041_2830_2850(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2717, 2862);

                TResult
                f_10041_2830_2850(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2830, 2850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2717, 2862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2717, 2862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitProperty(PropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 2874, 2997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 2958, 2986);

                return f_10041_2965_2985(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 2874, 2997);

                TResult
                f_10041_2965_2985(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 2965, 2985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 2874, 2997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 2874, 2997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitRangeVariable(RangeVariableSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 3009, 3142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 3103, 3131);

                return f_10041_3110_3130(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 3009, 3142);

                TResult
                f_10041_3110_3130(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 3110, 3130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 3009, 3142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 3009, 3142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitTypeParameter(TypeParameterSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10041, 3154, 3287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10041, 3248, 3276);

                return f_10041_3255_3275(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10041, 3154, 3287);

                TResult
                f_10041_3255_3275(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10041, 3255, 3275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10041, 3154, 3287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 3154, 3287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10041, 325, 3294);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10041, 325, 3294);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 325, 3294);
        }


        static CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10041, 325, 3294);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10041, 325, 3294);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10041, 325, 3294);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10041, 325, 3294);
    }
}
