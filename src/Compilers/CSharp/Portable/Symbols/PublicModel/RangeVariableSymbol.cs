// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel
{
    internal sealed class RangeVariableSymbol : Symbol, IRangeVariableSymbol
    {
        private readonly Symbols.RangeVariableSymbol _underlying;

        public RangeVariableSymbol(Symbols.RangeVariableSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10656, 484, 660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 460, 471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 575, 610);

                f_10656_575_609(underlying is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 624, 649);

                _underlying = underlying;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10656, 484, 660);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10656, 484, 660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10656, 484, 660);
            }
        }

        internal override CSharp.Symbol UnderlyingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10656, 721, 735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 724, 735);
                    return _underlying; DynAbs.Tracing.TraceSender.TraceExitMethod(10656, 721, 735);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10656, 721, 735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10656, 721, 735);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void Accept(SymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10656, 748, 870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 826, 859);

                f_10656_826_858(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10656, 748, 870);

                int
                f_10656_826_858(Microsoft.CodeAnalysis.SymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.RangeVariableSymbol
                symbol)
                {
                    this_param.VisitRangeVariable((Microsoft.CodeAnalysis.IRangeVariableSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10656, 826, 858);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10656, 748, 870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10656, 748, 870);
            }
        }

        protected override TResult Accept<TResult>(SymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10656, 882, 1032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10656, 981, 1021);

                return f_10656_988_1020<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10656, 882, 1032);

                TResult?
                f_10656_988_1020<TResult>(Microsoft.CodeAnalysis.SymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.RangeVariableSymbol
                symbol)
                {
                    var return_v = this_param.VisitRangeVariable((Microsoft.CodeAnalysis.IRangeVariableSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10656, 988, 1020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10656, 882, 1032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10656, 882, 1032);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RangeVariableSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10656, 326, 1039);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10656, 326, 1039);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10656, 326, 1039);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10656, 326, 1039);

        int
        f_10656_575_609(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10656, 575, 609);
            return 0;
        }

    }
}
