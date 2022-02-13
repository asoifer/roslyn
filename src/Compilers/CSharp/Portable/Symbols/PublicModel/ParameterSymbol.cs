// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class ParameterSymbol : Symbol, IParameterSymbol
    {
        private readonly Symbols.ParameterSymbol _underlying;

        private ITypeSymbol _lazyType;

        public ParameterSymbol(Symbols.ParameterSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10652, 574, 742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 510, 521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 552, 561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 657, 692);

                f_10652_657_691(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 706, 731);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10652, 574, 742);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 574, 742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 574, 742);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 803, 817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 806, 817);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 803, 817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 803, 817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 803, 817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IParameterSymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 888, 1158);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 924, 1106) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10652, 924, 1106);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 987, 1087);

                        f_10652_987_1086(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10652, 924, 1106);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1126, 1143);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 888, 1158);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10652_987_1086(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10652, 987, 1086);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 830, 1169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 830, 1169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IParameterSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1249, 1304);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1252, 1304);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1249, 1304);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1249, 1304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1249, 1304);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IParameterSymbol.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1405, 1468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1411, 1466);

                    return _underlying.TypeWithAnnotations.CustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1405, 1468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1317, 1479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1317, 1479);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<CustomModifier> IParameterSymbol.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1582, 1628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1588, 1626);

                    return f_10652_1595_1625(_underlying);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1582, 1628);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10652_1595_1625(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 1595, 1625);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1491, 1639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1491, 1639);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IParameterSymbol IParameterSymbol.OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1728, 1835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1764, 1820);

                    return f_10652_1771_1819(f_10652_1771_1801(_underlying));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1728, 1835);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10652_1771_1801(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 1771, 1801);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IParameterSymbol?
                    f_10652_1771_1819(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10652, 1771, 1819);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1651, 1846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1651, 1846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        RefKind IParameterSymbol.RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1891, 1913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1894, 1913);
                    return f_10652_1894_1913(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1891, 1913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1891, 1913);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1891, 1913);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IParameterSymbol.IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 1958, 1982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 1961, 1982);
                    return f_10652_1961_1982(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 1958, 1982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 1958, 1982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 1958, 1982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IParameterSymbol.IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2026, 2049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2029, 2049);
                    return f_10652_2029_2049(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2026, 2049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2026, 2049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2026, 2049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IParameterSymbol.IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2095, 2120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2098, 2120);
                    return f_10652_2098_2120(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2095, 2120);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2095, 2120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2095, 2120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IParameterSymbol.IsThis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2162, 2183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2165, 2183);
                    return f_10652_2165_2183(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2162, 2183);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2162, 2183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2162, 2183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int IParameterSymbol.Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2225, 2247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2228, 2247);
                    return f_10652_2228_2247(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2225, 2247);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2225, 2247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2225, 2247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IParameterSymbol.HasExplicitDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2306, 2344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2309, 2344);
                    return f_10652_2309_2344(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2306, 2344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2306, 2344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2306, 2344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object IParameterSymbol.ExplicitDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2402, 2437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2405, 2437);
                    return f_10652_2405_2437(_underlying); DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2402, 2437);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2402, 2437);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2402, 2437);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2485, 2603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2563, 2592);

                f_10652_2563_2591(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2485, 2603);

                int
                f_10652_2563_2591(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ParameterSymbol
                symbol)
                {
                    this_param.VisitParameter((Microsoft.CodeAnalysis.IParameterSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10652, 2563, 2591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2485, 2603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2485, 2603);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10652, 2615, 2761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10652, 2714, 2750);

                return f_10652_2721_2749<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10652, 2615, 2761);

                TResult?
                f_10652_2721_2749<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.VisitParameter((Microsoft.CodeAnalysis.IParameterSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10652, 2721, 2749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10652, 2615, 2761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 2615, 2761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10652, 388, 2790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10652, 388, 2790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10652, 388, 2790);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10652, 388, 2790);

        int
        f_10652_657_691(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10652, 657, 691);
            return 0;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10652_1894_1913(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 1894, 1913);
            return return_v;
        }


        bool
        f_10652_1961_1982(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsDiscard;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 1961, 1982);
            return return_v;
        }


        bool
        f_10652_2029_2049(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsParams;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2029, 2049);
            return return_v;
        }


        bool
        f_10652_2098_2120(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsOptional;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2098, 2120);
            return return_v;
        }


        bool
        f_10652_2165_2183(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.IsThis;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2165, 2183);
            return return_v;
        }


        int
        f_10652_2228_2247(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2228, 2247);
            return return_v;
        }


        bool
        f_10652_2309_2344(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.HasExplicitDefaultValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2309, 2344);
            return return_v;
        }


        object
        f_10652_2405_2437(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.ExplicitDefaultValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10652, 2405, 2437);
            return return_v;
        }

    }
}
