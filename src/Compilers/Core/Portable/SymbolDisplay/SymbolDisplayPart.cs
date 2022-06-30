// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{

    public struct SymbolDisplayPart
    {

        private readonly SymbolDisplayPartKind _kind;

        private readonly string _text;

        private readonly ISymbol? _symbol;

        public SymbolDisplayPartKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(583, 908, 929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 914, 927);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(583, 908, 929);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(583, 872, 931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(583, 872, 931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISymbol? Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(583, 1215, 1238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1221, 1236);

                    return _symbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(583, 1215, 1238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(583, 1190, 1240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(583, 1190, 1240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SymbolDisplayPart(SymbolDisplayPartKind kind, ISymbol? symbol, string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(583, 1625, 2077);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1732, 1852) || true) && (!f_583_1737_1751(kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(583, 1732, 1852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1785, 1837);

                    throw f_583_1791_1836(nameof(kind));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(583, 1732, 1852);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1868, 1979) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(583, 1868, 1979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1918, 1964);

                    throw f_583_1924_1963(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(583, 1868, 1979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 1995, 2008);

                _kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 2022, 2035);

                _text = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 2049, 2066);

                _symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(583, 1625, 2077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(583, 1625, 2077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(583, 1625, 2077);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(583, 2203, 2285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(583, 2261, 2274);

                return _text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(583, 2203, 2285);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(583, 2203, 2285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(583, 2203, 2285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static SymbolDisplayPart()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(583, 587, 2292);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(583, 587, 2292);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(583, 587, 2292);
        }

        static bool
        f_583_1737_1751(Microsoft.CodeAnalysis.SymbolDisplayPartKind
        value)
        {
            var return_v = value.IsValid();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(583, 1737, 1751);
            return return_v;
        }


        static System.ArgumentOutOfRangeException
        f_583_1791_1836(string
        paramName)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(583, 1791, 1836);
            return return_v;
        }


        static System.ArgumentNullException
        f_583_1924_1963(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(583, 1924, 1963);
            return return_v;
        }

    }
}
