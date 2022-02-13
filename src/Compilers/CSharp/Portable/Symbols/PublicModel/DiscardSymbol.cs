// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class DiscardSymbol : Symbol, IDiscardSymbol
    {
        private readonly Symbols.DiscardSymbol _underlying;

        private ITypeSymbol? _lazyType;

        public DiscardSymbol(Symbols.DiscardSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10637, 509, 677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 444, 455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 487, 496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 588, 627);

                f_10637_588_626(underlying != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 641, 666);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10637, 509, 677);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 509, 677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 509, 677);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10637, 738, 752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 741, 752);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10637, 738, 752);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 738, 752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 738, 752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ITypeSymbol IDiscardSymbol.Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10637, 821, 1091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 857, 1039) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10637, 857, 1039);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 920, 1020);

                        f_10637_920_1019(ref _lazyType, _underlying.TypeWithAnnotations.GetPublicSymbol(), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10637, 857, 1039);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 1059, 1076);

                    return _lazyType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10637, 821, 1091);

                    Microsoft.CodeAnalysis.ITypeSymbol?
                    f_10637_920_1019(ref Microsoft.CodeAnalysis.ITypeSymbol?
                    location1, Microsoft.CodeAnalysis.ITypeSymbol
                    value, Microsoft.CodeAnalysis.ITypeSymbol?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10637, 920, 1019);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 765, 1102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 765, 1102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.NullableAnnotation IDiscardSymbol.NullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10637, 1180, 1235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 1183, 1235);
                    return _underlying.TypeWithAnnotations.ToPublicAnnotation(); DynAbs.Tracing.TraceSender.TraceExitMethod(10637, 1180, 1235);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 1180, 1235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 1180, 1235);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10637, 1302, 1331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 1305, 1331);
                f_10637_1305_1331(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10637, 1302, 1331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 1302, 1331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 1302, 1331);
            }

            int
            f_10637_1305_1331(Microsoft.CodeAnalysis.SymbolVisitor
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DiscardSymbol
            symbol)
            {
                this_param.VisitDiscard((Microsoft.CodeAnalysis.IDiscardSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10637, 1305, 1331);
                return 0;
            }

        }

        protected override TResult? Accept<TResult>(SymbolVisitor<TResult> visitor) where TResult : default
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10637, 1442, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10637, 1445, 1471);
                return f_10637_1445_1471<TResult>(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10637, 1442, 1471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10637, 1442, 1471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 1442, 1471);
            }
            throw new System.Exception("Slicer error: unreachable code");

            TResult?
            f_10637_1445_1471<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.DiscardSymbol
            symbol)
            {
                var return_v = this_param.VisitDiscard((Microsoft.CodeAnalysis.IDiscardSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10637, 1445, 1471);
                return return_v;
            }

        }

        static DiscardSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10637, 328, 1479);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10637, 328, 1479);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10637, 328, 1479);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10637, 328, 1479);

        int
        f_10637_588_626(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10637, 588, 626);
            return 0;
        }

    }
}
