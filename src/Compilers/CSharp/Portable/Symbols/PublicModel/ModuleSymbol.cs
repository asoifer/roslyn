// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class ModuleSymbol : Symbol, IModuleSymbol
    {
        private readonly Symbols.ModuleSymbol _underlying;

        public ModuleSymbol(Symbols.ModuleSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10646, 500, 662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 476, 487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 577, 612);

                f_10646_577_611(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 626, 651);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10646, 500, 662);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 500, 662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 500, 662);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 723, 737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 726, 737);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 723, 737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 723, 737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 723, 737);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceSymbol IModuleSymbol.GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 821, 925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 857, 910);

                    return f_10646_864_909(f_10646_864_891(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 821, 925);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10646_864_891(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10646, 864, 891);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol?
                    f_10646_864_909(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 864, 909);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 750, 936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 750, 936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        INamespaceSymbol IModuleSymbol.GetModuleNamespace(INamespaceSymbol namespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 948, 1140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1056, 1129);

                return f_10646_1063_1128(f_10646_1063_1110(_underlying, namespaceSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 948, 1140);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10646_1063_1110(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetModuleNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 1063, 1110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10646_1063_1128(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 1063, 1128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 948, 1140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 948, 1140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ImmutableArray<IAssemblySymbol> IModuleSymbol.ReferencedAssemblySymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 1248, 1363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1284, 1348);

                    return _underlying.ReferencedAssemblySymbols.GetPublicSymbols();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 1248, 1363);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 1152, 1374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 1152, 1374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<AssemblyIdentity> IModuleSymbol.ReferencedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 1454, 1489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1457, 1489);
                    return f_10646_1457_1489(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 1454, 1489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 1454, 1489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 1454, 1489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ModuleMetadata IModuleSymbol.GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 1545, 1573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1548, 1573);
                return f_10646_1548_1573(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 1545, 1573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 1545, 1573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 1545, 1573);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ModuleMetadata
            f_10646_1548_1573(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            this_param)
            {
                var return_v = this_param.GetMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 1548, 1573);
                return return_v;
            }

        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 1621, 1736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1699, 1725);

                f_10646_1699_1724(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 1621, 1736);

                int
                f_10646_1699_1724(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ModuleSymbol
                symbol)
                {
                    this_param.VisitModule((Microsoft.CodeAnalysis.IModuleSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 1699, 1724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 1621, 1736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 1621, 1736);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10646, 1748, 1891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10646, 1847, 1880);

                return f_10646_1854_1879<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10646, 1748, 1891);

                TResult?
                f_10646_1854_1879<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ModuleSymbol
                symbol)
                {
                    var return_v = this_param.VisitModule((Microsoft.CodeAnalysis.IModuleSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 1854, 1879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10646, 1748, 1891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 1748, 1891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10646, 363, 1920);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10646, 363, 1920);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10646, 363, 1920);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10646, 363, 1920);

        int
        f_10646_577_611(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10646, 577, 611);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
        f_10646_1457_1489(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.ReferencedAssemblies;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10646, 1457, 1489);
            return return_v;
        }

    }
}
