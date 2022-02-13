// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SymbolEqualityComparer : EqualityComparer<Symbol>
    {
        internal static readonly EqualityComparer<Symbol> ConsiderEverything;

        internal static readonly EqualityComparer<Symbol> IgnoringTupleNamesAndNullability;

        internal static EqualityComparer<Symbol> IncludeNullability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10165, 848, 869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 851, 869);
                    return ConsiderEverything; DynAbs.Tracing.TraceSender.TraceExitMethod(10165, 848, 869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10165, 848, 869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10165, 848, 869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static readonly EqualityComparer<Symbol> IgnoringDynamicTupleNamesAndNullability;

        internal static readonly EqualityComparer<Symbol> IgnoringNullable;

        internal static readonly EqualityComparer<Symbol> ObliviousNullableModifierMatchesAny;

        internal static readonly EqualityComparer<Symbol> AllIgnoreOptions;

        internal static readonly EqualityComparer<Symbol> AllIgnoreOptionsPlusNullableWithUnknownMatchesAny;

        internal static readonly EqualityComparer<Symbol> CLRSignature;

        private readonly TypeCompareKind _comparison;

        private SymbolEqualityComparer(TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10165, 2286, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 2262, 2273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 2369, 2394);

                _comparison = comparison;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10165, 2286, 2405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10165, 2286, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10165, 2286, 2405);
            }
        }

        public override int GetHashCode(Symbol obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10165, 2417, 2539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 2485, 2528);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10165, 2492, 2503) || ((obj is null && DynAbs.Tracing.TraceSender.Conditional_F2(10165, 2506, 2507)) || DynAbs.Tracing.TraceSender.Conditional_F3(10165, 2510, 2527))) ? 0 : f_10165_2510_2527(obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10165, 2417, 2539);

                int
                f_10165_2510_2527(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 2510, 2527);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10165, 2417, 2539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10165, 2417, 2539);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol x, Symbol y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10165, 2551, 2690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 2623, 2679);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10165, 2630, 2639) || ((x is null && DynAbs.Tracing.TraceSender.Conditional_F2(10165, 2642, 2651)) || DynAbs.Tracing.TraceSender.Conditional_F3(10165, 2654, 2678))) ? y is null : f_10165_2654_2678(x, y, _comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10165, 2551, 2690);

                bool
                f_10165_2654_2678(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 2654, 2678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10165, 2551, 2690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10165, 2551, 2690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolEqualityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10165, 337, 2697);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 475, 558);
            ConsiderEverything = f_10165_496_558(TypeCompareKind.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 621, 775);
            IgnoringTupleNamesAndNullability = f_10165_656_775(TypeCompareKind.IgnoreTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 1105, 1276);
            IgnoringDynamicTupleNamesAndNullability = f_10165_1147_1276(TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 1339, 1442);
            IgnoringNullable = f_10165_1358_1442(TypeCompareKind.IgnoreNullableModifiersForReferenceTypes); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 1505, 1622);
            ObliviousNullableModifierMatchesAny = f_10165_1543_1622(TypeCompareKind.ObliviousNullableModifierMatchesAny); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 1685, 1764);
            AllIgnoreOptions = f_10165_1704_1764(TypeCompareKind.AllIgnoreOptions); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 1827, 2068);
            AllIgnoreOptionsPlusNullableWithUnknownMatchesAny = f_10165_1946_2068(TypeCompareKind.AllIgnoreOptions & ~(TypeCompareKind.IgnoreNullableModifiersForReferenceTypes)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10165, 2131, 2216);
            CLRSignature = f_10165_2146_2216(TypeCompareKind.CLRSignatureCompareOptions); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10165, 337, 2697);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10165, 337, 2697);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10165, 337, 2697);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_496_558(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 496, 558);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_656_775(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 656, 775);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_1147_1276(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 1147, 1276);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_1358_1442(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 1358, 1442);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_1543_1622(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 1543, 1622);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_1704_1764(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 1704, 1764);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_1946_2068(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 1946, 2068);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer
        f_10165_2146_2216(Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SymbolEqualityComparer(comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10165, 2146, 2216);
            return return_v;
        }

    }
}
