// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal sealed class FormattedSymbol : IFormattable
    {
        private readonly ISymbolInternal _symbol;

        private readonly SymbolDisplayFormat _symbolDisplayFormat;

        internal FormattedSymbol(ISymbolInternal symbol, SymbolDisplayFormat symbolDisplayFormat)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(567, 965, 1240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 877, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 932, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1079, 1139);

                f_567_1079_1138(symbol != null && (DynAbs.Tracing.TraceSender.Expression_True(567, 1092, 1137) && symbolDisplayFormat != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1155, 1172);

                _symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1186, 1229);

                _symbolDisplayFormat = symbolDisplayFormat;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(567, 965, 1240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(567, 965, 1240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 965, 1240);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(567, 1252, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1310, 1376);

                return f_567_1317_1375(f_567_1317_1337(_symbol), _symbolDisplayFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(567, 1252, 1387);

                Microsoft.CodeAnalysis.ISymbol
                f_567_1317_1337(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1317, 1337);
                    return return_v;
                }


                string
                f_567_1317_1375(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1317, 1375);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(567, 1252, 1387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 1252, 1387);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(567, 1399, 1665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1463, 1498);

                var
                other = obj as FormattedSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1512, 1654);

                return other != null && (DynAbs.Tracing.TraceSender.Expression_True(567, 1519, 1582) && f_567_1553_1582(_symbol, other._symbol)) && (DynAbs.Tracing.TraceSender.Expression_True(567, 1519, 1653) && _symbolDisplayFormat == other._symbolDisplayFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(567, 1399, 1665);

                bool
                f_567_1553_1582(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1553, 1582);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(567, 1399, 1665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 1399, 1665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(567, 1677, 1860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1735, 1849);

                return f_567_1742_1848(f_567_1773_1794(_symbol), f_567_1813_1847(_symbolDisplayFormat));
                DynAbs.Tracing.TraceSender.TraceExitMethod(567, 1677, 1860);

                int
                f_567_1773_1794(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1773, 1794);
                    return return_v;
                }


                int
                f_567_1813_1847(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1813, 1847);
                    return return_v;
                }


                int
                f_567_1742_1848(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1742, 1848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(567, 1677, 1860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 1677, 1860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(567, 1872, 2001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(567, 1972, 1990);

                return f_567_1979_1989(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(567, 1872, 2001);

                string
                f_567_1979_1989(Microsoft.CodeAnalysis.FormattedSymbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1979, 1989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(567, 1872, 2001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 1872, 2001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FormattedSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(567, 775, 2008);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(567, 775, 2008);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(567, 775, 2008);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(567, 775, 2008);

        static int
        f_567_1079_1138(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(567, 1079, 1138);
            return 0;
        }

    }
}
