// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    internal sealed class UsesIsNullableVisitor : CSharpSymbolVisitor<bool>
    {
        private readonly ArrayBuilder<Symbol> _builder;

        private UsesIsNullableVisitor(ArrayBuilder<Symbol> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21011, 739, 853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 718, 726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 823, 842);

                _builder = builder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21011, 739, 853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 739, 853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 739, 853);
            }
        }

        internal static void GetUses(ArrayBuilder<Symbol> builder, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21011, 865, 1059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 963, 1012);

                var
                visitor = f_21011_977_1011(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1026, 1048);

                f_21011_1026_1047(visitor, symbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21011, 865, 1059);

                Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                f_21011_977_1011(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 977, 1011);
                    return return_v;
                }


                bool
                f_21011_1026_1047(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1026, 1047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 865, 1059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 865, 1059);
            }
        }

        private void Add(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1116, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1119, 1139);
                f_21011_1119_1139(_builder, symbol); DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1116, 1139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1116, 1139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1116, 1139);
            }
        }

        public override bool VisitNamespace(NamespaceSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1152, 1285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1236, 1274);

                return f_21011_1243_1273(this, f_21011_1253_1272(symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1152, 1285);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21011_1253_1272(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1253, 1272);
                    return return_v;
                }


                bool
                f_21011_1243_1273(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbol>(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1243, 1273);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1152, 1285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1152, 1285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool VisitNamedType(NamedTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1297, 1787);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1381, 1724) || true) && (f_21011_1385_1467(this, symbol, f_21011_1413_1448(symbol), inProgress: null) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 1385, 1574) || f_21011_1488_1574(this, symbol, f_21011_1516_1555(symbol), inProgress: null)) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 1385, 1663) || f_21011_1595_1663(this, symbol, f_21011_1623_1644(symbol), inProgress: null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 1381, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1697, 1709);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 1381, 1724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1738, 1776);

                return f_21011_1745_1775(this, f_21011_1755_1774(symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1297, 1787);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_21011_1413_1448(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 1413, 1448);
                    return return_v;
                }


                bool
                f_21011_1385_1467(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1385, 1467);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_21011_1516_1555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1516, 1555);
                    return return_v;
                }


                bool
                f_21011_1488_1574(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                types, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, types, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1488, 1574);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_21011_1623_1644(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 1623, 1644);
                    return return_v;
                }


                bool
                f_21011_1595_1663(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, typeParameters, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1595, 1663);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_21011_1755_1774(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1755, 1774);
                    return return_v;
                }


                bool
                f_21011_1745_1775(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.Symbol>(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1745, 1775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1297, 1787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1297, 1787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool VisitMethod(MethodSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 1799, 2149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 1877, 2138);

                return f_21011_1884_1952(this, symbol, f_21011_1912_1933(symbol), inProgress: null) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 1884, 2052) || f_21011_1973_2052(this, symbol, f_21011_2001_2033(symbol), inProgress: null)) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 1884, 2137) || f_21011_2073_2137(this, symbol, f_21011_2101_2118(symbol), inProgress: null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 1799, 2149);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_21011_1912_1933(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 1912, 1933);
                    return return_v;
                }


                bool
                f_21011_1884_1952(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, typeParameters, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1884, 1952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_2001_2033(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2001, 2033);
                    return return_v;
                }


                bool
                f_21011_1973_2052(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1973, 2052);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21011_2101_2118(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2101, 2118);
                    return return_v;
                }


                bool
                f_21011_2073_2137(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, parameters, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2073, 2137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 1799, 2149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 1799, 2149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool VisitProperty(PropertySymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2161, 2420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2243, 2409);

                return f_21011_2250_2323(this, symbol, f_21011_2278_2304(symbol), inProgress: null) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 2250, 2408) || f_21011_2344_2408(this, symbol, f_21011_2372_2389(symbol), inProgress: null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2161, 2420);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_2278_2304(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2278, 2304);
                    return return_v;
                }


                bool
                f_21011_2250_2323(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2250, 2323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21011_2372_2389(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2372, 2389);
                    return return_v;
                }


                bool
                f_21011_2344_2408(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, parameters, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2344, 2408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2161, 2420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2161, 2420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool VisitEvent(EventSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2432, 2600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2508, 2589);

                return f_21011_2515_2588(this, symbol, f_21011_2543_2569(symbol), inProgress: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2432, 2600);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_2543_2569(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2543, 2569);
                    return return_v;
                }


                bool
                f_21011_2515_2588(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2515, 2588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2432, 2600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2432, 2600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool VisitField(FieldSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2612, 2780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2688, 2769);

                return f_21011_2695_2768(this, symbol, f_21011_2723_2749(symbol), inProgress: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2612, 2780);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_2723_2749(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 2723, 2749);
                    return return_v;
                }


                bool
                f_21011_2695_2768(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.AddIfUsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type, inProgress: inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2695, 2768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2612, 2780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2612, 2780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool VisitList<TSymbol>(ImmutableArray<TSymbol> symbols) where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 2792, 3153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2904, 2924);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 2938, 3114);
                    foreach (var symbol in f_21011_2961_2968_I<TSymbol>(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 2938, 3114);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3002, 3099) || true) && (f_21011_3006_3024<TSymbol>(this, symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 3002, 3099);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3066, 3080);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 3002, 3099);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 2938, 3114);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21011, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21011, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3128, 3142);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 2792, 3153);

                bool
                f_21011_3006_3024<TSymbol>(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, TSymbol
                symbol) where TSymbol : Symbol

                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3006, 3024);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<TSymbol>
                f_21011_2961_2968_I<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
                i) where TSymbol : Symbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 2961, 2968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 2792, 3153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 2792, 3153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddIfUsesIsNullable(Symbol symbol, ImmutableArray<ParameterSymbol> parameters, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 3350, 3799);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3508, 3761);
                    foreach (var parameter in f_21011_3534_3544_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 3508, 3761);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3578, 3746) || true) && (f_21011_3582_3639(this, f_21011_3597_3626(parameter), inProgress))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 3578, 3746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3681, 3693);

                            f_21011_3681_3692(this, symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3715, 3727);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 3578, 3746);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 3508, 3761);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21011, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21011, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3775, 3788);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 3350, 3799);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_3597_3626(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 3597, 3626);
                    return return_v;
                }


                bool
                f_21011_3582_3639(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3582, 3639);
                    return return_v;
                }


                int
                f_21011_3681_3692(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Add(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3681, 3692);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21011_3534_3544_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3534, 3544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 3350, 3799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 3350, 3799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddIfUsesIsNullable(Symbol symbol, ImmutableArray<TypeParameterSymbol> typeParameters, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 3811, 4242);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 3977, 4204);
                    foreach (var type in f_21011_3998_4012_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 3977, 4204);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4046, 4189) || true) && (f_21011_4050_4082(this, type, inProgress))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 4046, 4189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4124, 4136);

                            f_21011_4124_4135(this, symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4158, 4170);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 4046, 4189);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 3977, 4204);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21011, 1, 228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21011, 1, 228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4218, 4231);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 3811, 4242);

                bool
                f_21011_4050_4082(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4050, 4082);
                    return return_v;
                }


                int
                f_21011_4124_4135(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Add(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4124, 4135);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_21011_3998_4012_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 3998, 4012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 3811, 4242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 3811, 4242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddIfUsesIsNullable(Symbol symbol, ImmutableArray<NamedTypeSymbol> types, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 4254, 4663);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4407, 4625);
                    foreach (var type in f_21011_4428_4433_I(types))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 4407, 4625);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4467, 4610) || true) && (f_21011_4471_4503(this, type, inProgress))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 4467, 4610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4545, 4557);

                            f_21011_4545_4556(this, symbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4579, 4591);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 4467, 4610);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 4407, 4625);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21011, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21011, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4639, 4652);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 4254, 4663);

                bool
                f_21011_4471_4503(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4471, 4503);
                    return return_v;
                }


                int
                f_21011_4545_4556(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Add(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4545, 4556);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_21011_4428_4433_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4428, 4433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 4254, 4663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 4254, 4663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddIfUsesIsNullable(Symbol symbol, TypeWithAnnotations type, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 4675, 4980);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4815, 4942) || true) && (f_21011_4819_4851(this, type, inProgress))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 4815, 4942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4885, 4897);

                    f_21011_4885_4896(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4915, 4927);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 4815, 4942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 4956, 4969);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 4675, 4980);

                bool
                f_21011_4819_4851(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4819, 4851);
                    return return_v;
                }


                int
                f_21011_4885_4896(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Add(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 4885, 4896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 4675, 4980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 4675, 4980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool AddIfUsesIsNullable(Symbol symbol, TypeSymbol type, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 4992, 5288);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5123, 5250) || true) && (f_21011_5127_5159(this, type, inProgress))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 5123, 5250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5193, 5205);

                    f_21011_5193_5204(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5223, 5235);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 5123, 5250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5264, 5277);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 4992, 5288);

                bool
                f_21011_5127_5159(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 5127, 5159);
                    return return_v;
                }


                int
                f_21011_5193_5204(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.Add(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 5193, 5204);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 4992, 5288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 4992, 5288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UsesIsNullable(TypeWithAnnotations type, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 5300, 5748);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5420, 5499) || true) && (f_21011_5424_5437_M(!type.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 5420, 5499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5471, 5484);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 5420, 5499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5513, 5540);

                var
                typeSymbol = type.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5554, 5737);

                return (type.NullableAnnotation != NullableAnnotation.Oblivious && (DynAbs.Tracing.TraceSender.Expression_True(21011, 5562, 5647) && f_21011_5621_5647(typeSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(21011, 5562, 5676) && !f_21011_5652_5676(typeSymbol))) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 5561, 5736) || f_21011_5698_5736(this, typeSymbol, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 5300, 5748);

                bool
                f_21011_5424_5437_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 5424, 5437);
                    return return_v;
                }


                bool
                f_21011_5621_5647(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 5621, 5647);
                    return return_v;
                }


                bool
                f_21011_5652_5676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 5652, 5676);
                    return return_v;
                }


                bool
                f_21011_5698_5736(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 5698, 5736);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 5300, 5748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 5300, 5748);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UsesIsNullable(TypeSymbol type, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 5760, 7999);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5871, 5949) || true) && (type is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 5871, 5949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5921, 5934);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 5871, 5949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 5963, 6398);

                switch (f_21011_5971_5984(type))
                {

                    case TypeKind.Class:
                    case TypeKind.Delegate:
                    case TypeKind.Interface:
                    case TypeKind.Struct:
                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 5963, 6398);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 6219, 6355) || true) && (f_21011_6223_6270(this, f_21011_6238_6257(type), inProgress))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6219, 6355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 6320, 6332);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6219, 6355);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(21011, 6377, 6383);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 5963, 6398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 6412, 7988);

                switch (f_21011_6420_6433(type))
                {

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 6509, 6595);

                        return f_21011_6516_6594(this, f_21011_6531_6581(((ArrayTypeSymbol)type)), inProgress);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);

                    case TypeKind.Class:
                    case TypeKind.Delegate:
                    case TypeKind.Error:
                    case TypeKind.Interface:
                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 6815, 6923);

                        return f_21011_6822_6922(this, f_21011_6837_6909(((NamedTypeSymbol)type)), inProgress);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);

                    case TypeKind.Dynamic:
                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7022, 7035);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);

                    case TypeKind.Pointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7097, 7187);

                        return f_21011_7104_7186(this, f_21011_7119_7173(((PointerTypeSymbol)type)), inProgress);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7255, 7301);

                        var
                        typeParameter = (TypeParameterSymbol)type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7354, 7524) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(21011, 7358, 7376) || ((inProgress != null && DynAbs.Tracing.TraceSender.Conditional_F2(21011, 7379, 7430)) || DynAbs.Tracing.TraceSender.Conditional_F3(21011, 7433, 7438))) ? f_21011_7379_7422(inProgress, typeParameter) == true : false)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 7354, 7524);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7488, 7501);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 7354, 7524);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7546, 7609);

                        inProgress = inProgress ?? (DynAbs.Tracing.TraceSender.Expression_Null<Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?>(21011, 7559, 7608) ?? ConsList<TypeParameterSymbol>.Empty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7631, 7678);

                        inProgress = f_21011_7644_7677(inProgress, typeParameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7700, 7869);

                        return f_21011_7707_7784(this, f_21011_7722_7771(typeParameter), inProgress) || (DynAbs.Tracing.TraceSender.Expression_False(21011, 7707, 7868) || f_21011_7813_7860(typeParameter) == true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21011, 6412, 7988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 7917, 7973);

                        throw f_21011_7923_7972(f_21011_7958_7971(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21011, 6412, 7988);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 5760, 7999);

                Microsoft.CodeAnalysis.TypeKind
                f_21011_5971_5984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 5971, 5984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_21011_6238_6257(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 6238, 6257);
                    return return_v;
                }


                bool
                f_21011_6223_6270(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 6223, 6270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21011_6420_6433(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 6420, 6433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_6531_6581(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 6531, 6581);
                    return return_v;
                }


                bool
                f_21011_6516_6594(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 6516, 6594);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_21011_6837_6909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 6837, 6909);
                    return return_v;
                }


                bool
                f_21011_6822_6922(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(types, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 6822, 6922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_21011_7119_7173(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 7119, 7173);
                    return return_v;
                }


                bool
                f_21011_7104_7186(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(type, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 7104, 7186);
                    return return_v;
                }


                bool
                f_21011_7379_7422(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 7379, 7422);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_21011_7644_7677(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 7644, 7677);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_21011_7722_7771(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 7722, 7771);
                    return return_v;
                }


                bool
                f_21011_7707_7784(Microsoft.CodeAnalysis.CSharp.Test.Utilities.UsesIsNullableVisitor
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.UsesIsNullable(types, inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 7707, 7784);
                    return return_v;
                }


                bool?
                f_21011_7813_7860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ReferenceTypeConstraintIsNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 7813, 7860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_21011_7958_7971(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21011, 7958, 7971);
                    return return_v;
                }


                System.Exception
                f_21011_7923_7972(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 7923, 7972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 5760, 7999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 5760, 7999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool UsesIsNullable(ImmutableArray<TypeWithAnnotations> types, ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21011, 8011, 8212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21011, 8148, 8201);

                return types.Any(t => UsesIsNullable(t, inProgress));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21011, 8011, 8212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21011, 8011, 8212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 8011, 8212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UsesIsNullableVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21011, 592, 8219);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21011, 592, 8219);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21011, 592, 8219);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21011, 592, 8219);

        int
        f_21011_1119_1139(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21011, 1119, 1139);
            return 0;
        }

    }
}
