// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class NamespaceSymbol : NamespaceOrTypeSymbol, INamespaceSymbol
    {
        private readonly Symbols.NamespaceSymbol _underlying;

        public NamespaceSymbol(Symbols.NamespaceSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10649, 559, 727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 535, 546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 642, 677);

                f_10649_642_676(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 691, 716);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10649, 559, 727);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 559, 727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 559, 727);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 788, 802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 791, 802);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 788, 802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 788, 802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 788, 802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbols.NamespaceOrTypeSymbol UnderlyingNamespaceOrTypeSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 893, 907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 896, 907);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 893, 907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 893, 907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 893, 907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbols.NamespaceSymbol UnderlyingNamespaceSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 977, 991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 980, 991);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 977, 991);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 977, 991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 977, 991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamespaceSymbol.IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1044, 1076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1047, 1076);
                    return f_10649_1047_1076(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1044, 1076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1044, 1076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1044, 1076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        NamespaceKind INamespaceSymbol.NamespaceKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1134, 1162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1137, 1162);
                    return f_10649_1137_1162(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1134, 1162);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1134, 1162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1134, 1162);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Compilation INamespaceSymbol.ContainingCompilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1226, 1262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1229, 1262);
                    return f_10649_1229_1262(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1226, 1262);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1226, 1262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1226, 1262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<INamespaceSymbol> INamespaceSymbol.ConstituentNamespaces
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1371, 1482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1407, 1467);

                    return _underlying.ConstituentNamespaces.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1371, 1482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1275, 1493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1275, 1493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IEnumerable<INamespaceOrTypeSymbol> INamespaceSymbol.GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1505, 1763);

                var listYield = new List<INamespaceOrTypeSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1595, 1752);
                    foreach (var n in f_10649_1613_1637_I(f_10649_1613_1637(_underlying)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10649, 1595, 1752);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1671, 1737);

                        listYield.Add(f_10649_1684_1736(((Symbols.NamespaceOrTypeSymbol)n)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10649, 1595, 1752);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10649, 1, 158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10649, 1, 158);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1505, 1763);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10649_1613_1637(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1613, 1637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                f_10649_1684_1736(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1684, 1736);
                    return (INamespaceOrTypeSymbol)return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10649_1613_1637_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1613, 1637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1505, 1763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1505, 1763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<INamespaceOrTypeSymbol> INamespaceSymbol.GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 1775, 2048);

                var listYield = new List<INamespaceOrTypeSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1876, 2037);
                    foreach (var n in f_10649_1894_1922_I(f_10649_1894_1922(_underlying, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10649, 1876, 2037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 1956, 2022);

                        listYield.Add(f_10649_1969_2021(((Symbols.NamespaceOrTypeSymbol)n)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10649, 1876, 2037);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10649, 1, 162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10649, 1, 162);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 1775, 2048);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10649_1894_1922(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1894, 1922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                f_10649_1969_2021(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1969, 2021);
                    return (INamespaceOrTypeSymbol)return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10649_1894_1922_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 1894, 1922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 1775, 2048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 1775, 2048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<INamespaceSymbol> INamespaceSymbol.GetNamespaceMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 2060, 2297);

                var listYield = new List<INamespaceSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 2153, 2286);
                    foreach (var n in f_10649_2171_2204_I(f_10649_2171_2204(_underlying)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10649, 2153, 2286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 2238, 2271);

                        listYield.Add(f_10649_2251_2270(n));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10649, 2153, 2286);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10649, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10649, 1, 134);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 2060, 2297);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10649_2171_2204(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetNamespaceMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 2171, 2204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10649_2251_2270(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 2251, 2270);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10649_2171_2204_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 2171, 2204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 2060, 2297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 2060, 2297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 2344, 2462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 2422, 2451);

                f_10649_2422_2450(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 2344, 2462);

                int
                f_10649_2422_2450(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamespaceSymbol
                symbol)
                {
                    this_param.VisitNamespace((Microsoft.CodeAnalysis.INamespaceSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 2422, 2450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 2344, 2462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 2344, 2462);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10649, 2474, 2620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10649, 2573, 2609);

                return f_10649_2580_2608<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10649, 2474, 2620);

                TResult?
                f_10649_2580_2608<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NamespaceSymbol
                symbol)
                {
                    var return_v = this_param.VisitNamespace((Microsoft.CodeAnalysis.INamespaceSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 2580, 2608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10649, 2474, 2620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 2474, 2620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10649, 398, 2649);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10649, 398, 2649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10649, 398, 2649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10649, 398, 2649);

        int
        f_10649_642_676(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10649, 642, 676);
            return 0;
        }


        bool
        f_10649_1047_1076(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.IsGlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10649, 1047, 1076);
            return return_v;
        }


        Microsoft.CodeAnalysis.NamespaceKind
        f_10649_1137_1162(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.NamespaceKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10649, 1137, 1162);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10649_1229_1262(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.ContainingCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10649, 1229, 1262);
            return return_v;
        }

    }
}
