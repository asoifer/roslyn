// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.Cci
{
    internal sealed class SymbolEquivalentEqualityComparer : IEqualityComparer<IReference?>, IEqualityComparer<INamespace?>
    {
        public static readonly SymbolEquivalentEqualityComparer Instance;

        private SymbolEquivalentEqualityComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(516, 851, 915);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(516, 851, 915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(516, 851, 915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 851, 915);
            }
        }

        public bool Equals(IReference? x, IReference? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(516, 927, 1455);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1000, 1071) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1000, 1071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1044, 1056);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1000, 1071);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1087, 1175) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(516, 1091, 1113) || y is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1087, 1175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1147, 1160);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1087, 1175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1191, 1227);

                var
                xSymbol = f_516_1205_1226(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1241, 1277);

                var
                ySymbol = f_516_1255_1276(y)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1293, 1415) || true) && (xSymbol is object && (DynAbs.Tracing.TraceSender.Expression_True(516, 1297, 1335) && ySymbol is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1293, 1415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1369, 1400);

                    return f_516_1376_1399(xSymbol, ySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1293, 1415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1431, 1444);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(516, 927, 1455);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_516_1205_1226(Microsoft.Cci.IReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1205, 1226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_516_1255_1276(Microsoft.Cci.IReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1255, 1276);
                    return return_v;
                }


                bool
                f_516_1376_1399(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1376, 1399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(516, 927, 1455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 927, 1455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(IReference? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(516, 1467, 1777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1531, 1572);

                var
                objSymbol = f_516_1547_1571_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 516, 1547, 1571)?.GetInternalSymbol())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1588, 1691) || true) && (objSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1588, 1691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1645, 1676);

                    return f_516_1652_1675(objSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1588, 1691);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1707, 1766);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(516, 1714, 1727) || ((obj is object && DynAbs.Tracing.TraceSender.Conditional_F2(516, 1730, 1761)) || DynAbs.Tracing.TraceSender.Conditional_F3(516, 1764, 1765))) ? f_516_1730_1761(obj) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(516, 1467, 1777);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_516_1547_1571_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1547, 1571);
                    return return_v;
                }


                int
                f_516_1652_1675(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1652, 1675);
                    return return_v;
                }


                int
                f_516_1730_1761(Microsoft.Cci.IReference
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 1730, 1761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(516, 1467, 1777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 1467, 1777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(INamespace? x, INamespace? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(516, 1789, 2317);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1862, 1933) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1862, 1933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1906, 1918);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1862, 1933);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 1949, 2037) || true) && (x is null || (DynAbs.Tracing.TraceSender.Expression_False(516, 1953, 1975) || y is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 1949, 2037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2009, 2022);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 1949, 2037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2053, 2089);

                var
                xSymbol = f_516_2067_2088(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2103, 2139);

                var
                ySymbol = f_516_2117_2138(y)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2155, 2277) || true) && (xSymbol is object && (DynAbs.Tracing.TraceSender.Expression_True(516, 2159, 2197) && ySymbol is object))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 2155, 2277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2231, 2262);

                    return f_516_2238_2261(xSymbol, ySymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 2155, 2277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2293, 2306);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(516, 1789, 2317);

                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                f_516_2067_2088(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2067, 2088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                f_516_2117_2138(Microsoft.Cci.INamespace
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2117, 2138);
                    return return_v;
                }


                bool
                f_516_2238_2261(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                this_param, Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2238, 2261);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(516, 1789, 2317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 1789, 2317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(INamespace? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(516, 2329, 2639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2393, 2434);

                var
                objSymbol = f_516_2409_2433_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 516, 2409, 2433)?.GetInternalSymbol())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2450, 2553) || true) && (objSymbol is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(516, 2450, 2553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2507, 2538);

                    return f_516_2514_2537(objSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(516, 2450, 2553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 2569, 2628);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(516, 2576, 2589) || ((obj is object && DynAbs.Tracing.TraceSender.Conditional_F2(516, 2592, 2623)) || DynAbs.Tracing.TraceSender.Conditional_F3(516, 2626, 2627))) ? f_516_2592_2623(obj) : 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(516, 2329, 2639);

                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                f_516_2409_2433_I(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2409, 2433);
                    return return_v;
                }


                int
                f_516_2514_2537(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2514, 2537);
                    return return_v;
                }


                int
                f_516_2592_2623(Microsoft.Cci.INamespace
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 2592, 2623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(516, 2329, 2639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 2329, 2639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolEquivalentEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(516, 597, 2646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(516, 789, 838);
            Instance = f_516_800_838(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(516, 597, 2646);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(516, 597, 2646);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(516, 597, 2646);

        static Microsoft.Cci.SymbolEquivalentEqualityComparer
        f_516_800_838()
        {
            var return_v = new Microsoft.Cci.SymbolEquivalentEqualityComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(516, 800, 838);
            return return_v;
        }

    }
}
