// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis
{
    public sealed class SymbolEqualityComparer : IEqualityComparer<ISymbol?>
    {
        public static readonly SymbolEqualityComparer Default;

        public static readonly SymbolEqualityComparer IncludeNullability;

        internal static readonly SymbolEqualityComparer ConsiderEverything;

        internal static readonly SymbolEqualityComparer IgnoreAll;

        internal static readonly SymbolEqualityComparer CLRSignature;

        internal TypeCompareKind CompareKind { get; }

        internal SymbolEqualityComparer(TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(641, 1749, 1871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1692, 1737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1834, 1860);

                CompareKind = compareKind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(641, 1749, 1871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(641, 1749, 1871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(641, 1749, 1871);
            }
        }

        public bool Equals(ISymbol? x, ISymbol? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(641, 2242, 2440);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 2309, 2388) || true) && (x is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(641, 2309, 2388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 2356, 2373);

                    return y is null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(641, 2309, 2388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 2404, 2429);

                return f_641_2411_2428(x, y, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(641, 2242, 2440);

                bool
                f_641_2411_2428(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.ISymbol?
                other, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = this_param.Equals(other, equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 2411, 2428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(641, 2242, 2440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(641, 2242, 2440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(ISymbol? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(641, 2452, 2555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 2513, 2544);

                return f_641_2520_2538_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(obj, 641, 2520, 2538)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(641, 2520, 2543) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(641, 2452, 2555);

                int?
                f_641_2520_2538_I(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 2520, 2538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(641, 2452, 2555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(641, 2452, 2555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(641, 453, 2562);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 804, 882);
            Default = f_641_814_882(TypeCompareKind.AllNullableIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1078, 1162);
            IncludeNullability = f_641_1099_1162(TypeCompareKind.ConsiderEverything2); DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1321, 1404);
            ConsiderEverything = f_641_1342_1404(TypeCompareKind.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1463, 1535);
            IgnoreAll = f_641_1475_1535(TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(641, 1594, 1679);
            CLRSignature = f_641_1609_1679(TypeCompareKind.CLRSignatureCompareOptions); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(641, 453, 2562);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(641, 453, 2562);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(641, 453, 2562);

        static Microsoft.CodeAnalysis.SymbolEqualityComparer
        f_641_814_882(Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 814, 882);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolEqualityComparer
        f_641_1099_1162(Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 1099, 1162);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolEqualityComparer
        f_641_1342_1404(Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 1342, 1404);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolEqualityComparer
        f_641_1475_1535(Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 1475, 1535);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolEqualityComparer
        f_641_1609_1679(Microsoft.CodeAnalysis.TypeCompareKind
        compareKind)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolEqualityComparer(compareKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(641, 1609, 1679);
            return return_v;
        }

    }
}
