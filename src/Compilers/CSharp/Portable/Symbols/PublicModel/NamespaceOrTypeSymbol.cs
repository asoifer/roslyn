// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal abstract class NamespaceOrTypeSymbol : Symbol, INamespaceOrTypeSymbol
    {
        internal abstract Symbols.NamespaceOrTypeSymbol UnderlyingNamespaceOrTypeSymbol { get; }

        ImmutableArray<ISymbol> INamespaceOrTypeSymbol.GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 510, 676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 594, 665);

                return f_10648_601_645(f_10648_601_632()).GetPublicSymbols();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 510, 676);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10648_601_632()
                {
                    var return_v = UnderlyingNamespaceOrTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 601, 632);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10648_601_645(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10648, 601, 645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 510, 676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 510, 676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<ISymbol> INamespaceOrTypeSymbol.GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 688, 869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 783, 858);

                return f_10648_790_838(f_10648_790_821(), name).GetPublicSymbols();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 688, 869);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10648_790_821()
                {
                    var return_v = UnderlyingNamespaceOrTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 790, 821);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10648_790_838(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10648, 790, 838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 688, 869);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 688, 869);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<INamedTypeSymbol> INamespaceOrTypeSymbol.GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 881, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 978, 1053);

                return f_10648_985_1033(f_10648_985_1016()).GetPublicSymbols();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 881, 1064);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10648_985_1016()
                {
                    var return_v = UnderlyingNamespaceOrTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 985, 1016);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10648_985_1033(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10648, 985, 1033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 881, 1064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 881, 1064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<INamedTypeSymbol> INamespaceOrTypeSymbol.GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 1076, 1274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 1184, 1263);

                return f_10648_1191_1243(f_10648_1191_1222(), name).GetPublicSymbols();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 1076, 1274);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10648_1191_1222()
                {
                    var return_v = UnderlyingNamespaceOrTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1191, 1222);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10648_1191_1243(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10648, 1191, 1243);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 1076, 1274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 1076, 1274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<INamedTypeSymbol> INamespaceOrTypeSymbol.GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 1286, 1502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 1405, 1491);

                return f_10648_1412_1471(f_10648_1412_1443(), name, arity).GetPublicSymbols();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 1286, 1502);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10648_1412_1443()
                {
                    var return_v = UnderlyingNamespaceOrTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1412, 1443);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10648_1412_1471(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10648, 1412, 1471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 1286, 1502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 1286, 1502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool INamespaceOrTypeSymbol.IsNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 1554, 1602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 1557, 1602);
                    return f_10648_1557_1578(f_10648_1557_1573()) == SymbolKind.Namespace; DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 1554, 1602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 1554, 1602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 1554, 1602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool INamespaceOrTypeSymbol.IsType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10648, 1650, 1698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10648, 1653, 1698);
                    return f_10648_1653_1674(f_10648_1653_1669()) != SymbolKind.Namespace; DynAbs.Tracing.TraceSender.TraceExitMethod(10648, 1650, 1698);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10648, 1650, 1698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 1650, 1698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamespaceOrTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10648, 315, 1706);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10648, 315, 1706);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 315, 1706);
        }


        static NamespaceOrTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10648, 315, 1706);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10648, 315, 1706);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10648, 315, 1706);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10648, 315, 1706);

        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10648_1557_1573()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1557, 1573);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10648_1557_1578(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1557, 1578);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10648_1653_1669()
        {
            var return_v = UnderlyingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1653, 1669);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10648_1653_1674(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10648, 1653, 1674);
            return return_v;
        }

    }
}
