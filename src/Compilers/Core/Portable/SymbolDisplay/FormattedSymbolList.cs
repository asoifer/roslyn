// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{
    internal sealed class FormattedSymbolList : IFormattable
    {
        private readonly IEnumerable<ISymbol> _symbols;

        private readonly SymbolDisplayFormat _symbolDisplayFormat;

        internal FormattedSymbolList(IEnumerable<ISymbol> symbols, SymbolDisplayFormat symbolDisplayFormat = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(568, 657, 921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 568, 576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 624, 644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 788, 818);

                f_568_788_817(symbols != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 834, 853);

                _symbols = symbols;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 867, 910);

                _symbolDisplayFormat = symbolDisplayFormat;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(568, 657, 921);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(568, 657, 921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(568, 657, 921);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(568, 933, 1562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 991, 1054);

                PooledStringBuilder
                pooled = f_568_1020_1053()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1068, 1107);

                StringBuilder
                builder = pooled.Builder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1123, 1141);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1155, 1503);
                    foreach (var symbol in f_568_1178_1186_I(_symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(568, 1155, 1503);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1220, 1407) || true) && (first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(568, 1220, 1407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1271, 1285);

                            first = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(568, 1220, 1407);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(568, 1220, 1407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1367, 1388);

                            f_568_1367_1387(builder, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(568, 1220, 1407);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1427, 1488);

                        f_568_1427_1487(
                                        builder, f_568_1442_1486(symbol, _symbolDisplayFormat));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(568, 1155, 1503);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(568, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(568, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1519, 1551);

                return f_568_1526_1550(pooled);
                DynAbs.Tracing.TraceSender.TraceExitMethod(568, 933, 1562);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_568_1020_1053()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1020, 1053);
                    return return_v;
                }


                System.Text.StringBuilder
                f_568_1367_1387(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1367, 1387);
                    return return_v;
                }


                string
                f_568_1442_1486(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1442, 1486);
                    return return_v;
                }


                System.Text.StringBuilder
                f_568_1427_1487(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1427, 1487);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                f_568_1178_1186_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1178, 1186);
                    return return_v;
                }


                string
                f_568_1526_1550(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1526, 1550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(568, 933, 1562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(568, 933, 1562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        string IFormattable.ToString(string format, IFormatProvider formatProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(568, 1574, 1703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(568, 1674, 1692);

                return f_568_1681_1691(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(568, 1574, 1703);

                string
                f_568_1681_1691(Microsoft.CodeAnalysis.FormattedSymbolList
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 1681, 1691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(568, 1574, 1703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(568, 1574, 1703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FormattedSymbolList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(568, 457, 1710);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(568, 457, 1710);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(568, 457, 1710);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(568, 457, 1710);

        static int
        f_568_788_817(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(568, 788, 817);
            return 0;
        }

    }
}
