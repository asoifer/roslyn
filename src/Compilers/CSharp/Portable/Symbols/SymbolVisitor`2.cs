// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class CSharpSymbolVisitor<TArgument, TResult>
    {
        public virtual TResult Visit(Symbol symbol, TArgument argument = default(TArgument))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 943, 1215);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 1052, 1151) || true) && ((object)symbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10168, 1052, 1151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 1112, 1136);

                    return default(TResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10168, 1052, 1151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 1167, 1204);

                return f_10168_1174_1203(symbol, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 943, 1215);

                TResult
                f_10168_1174_1203(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                visitor, TArgument?
                a)
                {
                    var return_v = this_param.Accept<TArgument?, TResult>(visitor, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 1174, 1203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 943, 1215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 943, 1215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult DefaultVisit(Symbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 1597, 1727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 1692, 1716);

                return default(TResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 1597, 1727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 1597, 1727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 1597, 1727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitAssembly(AssemblySymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 2157, 2310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 2261, 2299);

                return f_10168_2268_2298(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 2157, 2310);

                TResult
                f_10168_2268_2298(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 2268, 2298);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 2157, 2310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 2157, 2310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitModule(ModuleSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 2724, 2873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 2824, 2862);

                return f_10168_2831_2861(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 2724, 2873);

                TResult
                f_10168_2831_2861(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 2831, 2861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 2724, 2873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 2724, 2873);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitNamespace(NamespaceSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 3521, 3676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 3627, 3665);

                return f_10168_3634_3664(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 3521, 3676);

                TResult
                f_10168_3634_3664(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 3634, 3664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 3521, 3676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 3521, 3676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitNamedType(NamedTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 4078, 4233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 4184, 4222);

                return f_10168_4191_4221(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 4078, 4233);

                TResult
                f_10168_4191_4221(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 4191, 4221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 4078, 4233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 4078, 4233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitArrayType(ArrayTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 4636, 4791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 4742, 4780);

                return f_10168_4749_4779(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 4636, 4791);

                TResult
                f_10168_4749_4779(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 4749, 4779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 4636, 4791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 4636, 4791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitPointerType(PointerTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 5195, 5354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 5305, 5343);

                return f_10168_5312_5342(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 5195, 5354);

                TResult
                f_10168_5312_5342(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 5312, 5342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 5195, 5354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 5195, 5354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitFunctionPointerType(FunctionPointerTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 5764, 5939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 5890, 5928);

                return f_10168_5897_5927(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 5764, 5939);

                TResult
                f_10168_5897_5927(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 5897, 5927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 5764, 5939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 5764, 5939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitErrorType(ErrorTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 6409, 6564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 6515, 6553);

                return f_10168_6522_6552(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 6409, 6564);

                TResult
                f_10168_6522_6552(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 6522, 6552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 6409, 6564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 6409, 6564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitTypeParameter(TypeParameterSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 6970, 7133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 7084, 7122);

                return f_10168_7091_7121(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 6970, 7133);

                TResult
                f_10168_7091_7121(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 7091, 7121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 6970, 7133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 6970, 7133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitDynamicType(DynamicTypeSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 7537, 7696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 7647, 7685);

                return f_10168_7654_7684(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 7537, 7696);

                TResult
                f_10168_7654_7684(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 7654, 7684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 7537, 7696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 7537, 7696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitDiscard(DiscardSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 8096, 8247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 8198, 8236);

                return f_10168_8205_8235(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 8096, 8247);

                TResult
                f_10168_8205_8235(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.DiscardSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 8205, 8235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 8096, 8247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 8096, 8247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitMethod(MethodSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 8654, 8803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 8754, 8792);

                return f_10168_8761_8791(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 8654, 8803);

                TResult
                f_10168_8761_8791(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 8761, 8791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 8654, 8803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 8654, 8803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitField(FieldSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 9209, 9356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 9307, 9345);

                return f_10168_9314_9344(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 9209, 9356);

                TResult
                f_10168_9314_9344(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 9314, 9344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 9209, 9356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 9209, 9356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitProperty(PropertySymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 9765, 9918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 9869, 9907);

                return f_10168_9876_9906(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 9765, 9918);

                TResult
                f_10168_9876_9906(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 9876, 9906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 9765, 9918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 9765, 9918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitEvent(EventSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 10325, 10472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 10423, 10461);

                return f_10168_10430_10460(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 10325, 10472);

                TResult
                f_10168_10430_10460(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 10430, 10460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 10325, 10472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 10325, 10472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitParameter(ParameterSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 10882, 11037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 10988, 11026);

                return f_10168_10995_11025(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 10882, 11037);

                TResult
                f_10168_10995_11025(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 10995, 11025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 10882, 11037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 10882, 11037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitLocal(LocalSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 11443, 11590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 11541, 11579);

                return f_10168_11548_11578(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 11443, 11590);

                TResult
                f_10168_11548_11578(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 11548, 11578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 11443, 11590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 11443, 11590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitLabel(LabelSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 11996, 12143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 12094, 12132);

                return f_10168_12101_12131(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 11996, 12143);

                TResult
                f_10168_12101_12131(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 12101, 12131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 11996, 12143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 11996, 12143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitAlias(AliasSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 12550, 12697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 12648, 12686);

                return f_10168_12655_12685(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 12550, 12697);

                TResult
                f_10168_12655_12685(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 12655, 12685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 12550, 12697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 12550, 12697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual TResult VisitRangeVariable(RangeVariableSymbol symbol, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10168, 13111, 13274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10168, 13225, 13263);

                return f_10168_13232_13262(this, symbol, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10168, 13111, 13274);

                TResult
                f_10168_13232_13262(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.DefaultVisit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10168, 13232, 13262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10168, 13111, 13274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 13111, 13274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10168, 643, 13281);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10168, 643, 13281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 643, 13281);
        }


        static CSharpSymbolVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10168, 643, 13281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10168, 643, 13281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10168, 643, 13281);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10168, 643, 13281);
    }
}
