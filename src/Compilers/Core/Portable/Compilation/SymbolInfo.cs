// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Linq;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{

    public struct SymbolInfo : IEquatable<SymbolInfo>
    {

        internal static readonly SymbolInfo None;

        private ImmutableArray<ISymbol> _candidateSymbols;

        public ISymbol? Symbol { get; }

        public ImmutableArray<ISymbol> CandidateSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 1667, 1757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 1703, 1742);

                    return _candidateSymbols.NullToEmpty();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(168, 1667, 1757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 1595, 1768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 1595, 1768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<ISymbol> GetAllSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 1780, 2078);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 1853, 2067) || true) && (this.Symbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(168, 1853, 2067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 1910, 1961);

                    return f_168_1917_1960(this.Symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(168, 1853, 2067);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(168, 1853, 2067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 2027, 2052);

                    return _candidateSymbols;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(168, 1853, 2067);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(168, 1780, 2078);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_168_1917_1960(Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ISymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 1917, 1960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 1780, 2078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 1780, 2078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CandidateReason CandidateReason { get; }

        internal SymbolInfo(ISymbol symbol)
        : this(f_168_2512_2518_C(symbol), ImmutableArray<ISymbol>.Empty, CandidateReason.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(168, 2456, 2594);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(168, 2456, 2594);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 2456, 2594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 2456, 2594);
            }
        }

        internal SymbolInfo(ISymbol symbol, CandidateReason reason)
        : this(f_168_2686_2692_C(symbol), ImmutableArray<ISymbol>.Empty, reason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(168, 2606, 2754);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(168, 2606, 2754);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 2606, 2754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 2606, 2754);
            }
        }

        internal SymbolInfo(ImmutableArray<ISymbol> candidateSymbols, CandidateReason candidateReason)
        : this(f_168_2881_2885_C(null), candidateSymbols, candidateReason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(168, 2766, 2943);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(168, 2766, 2943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 2766, 2943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 2766, 2943);
            }
        }

        internal SymbolInfo(ISymbol? symbol, ImmutableArray<ISymbol> candidateSymbols, CandidateReason candidateReason)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(168, 2955, 3796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3113, 3134);

                this.Symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3148, 3249);

                _candidateSymbols = (DynAbs.Tracing.TraceSender.Conditional_F1(168, 3168, 3194) || ((candidateSymbols.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(168, 3197, 3229)) || DynAbs.Tracing.TraceSender.Conditional_F3(168, 3232, 3248))) ? f_168_3197_3229() : candidateSymbols;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3276, 3343);

                const NamespaceKind
                NamespaceKindNamespaceGroup = (NamespaceKind)0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3357, 3500);

                f_168_3357_3499(symbol is null || (DynAbs.Tracing.TraceSender.Expression_False(168, 3370, 3423) || f_168_3388_3399(symbol) != SymbolKind.Namespace) || (DynAbs.Tracing.TraceSender.Expression_False(168, 3370, 3498) || f_168_3427_3467(((INamespaceSymbol)symbol)) != NamespaceKindNamespaceGroup));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3514, 3722);
                    foreach (var item in f_168_3535_3552_I(_candidateSymbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(168, 3514, 3722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3586, 3707);

                        f_168_3586_3706(f_168_3599_3608(item) != SymbolKind.Namespace || (DynAbs.Tracing.TraceSender.Expression_False(168, 3599, 3705) || f_168_3636_3674(((INamespaceSymbol)item)) != NamespaceKindNamespaceGroup));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(168, 3514, 3722);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(168, 1, 209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(168, 1, 209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3746, 3785);

                this.CandidateReason = candidateReason;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(168, 2955, 3796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 2955, 3796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 2955, 3796);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 3808, 3936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 3873, 3925);

                return obj is SymbolInfo && (DynAbs.Tracing.TraceSender.Expression_True(168, 3880, 3924) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(168, 3808, 3936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 3808, 3936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 3808, 3936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(SymbolInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 3948, 4389);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 4009, 4267) || true) && (!f_168_4014_4054(this.Symbol, other.Symbol) || (DynAbs.Tracing.TraceSender.Expression_False(168, 4013, 4139) || _candidateSymbols.IsDefault != other._candidateSymbols.IsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(168, 4013, 4205) || this.CandidateReason != other.CandidateReason))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(168, 4009, 4267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 4239, 4252);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(168, 4009, 4267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 4283, 4378);

                return _candidateSymbols.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(168, 4290, 4377) || _candidateSymbols.SequenceEqual(other._candidateSymbols));
                DynAbs.Tracing.TraceSender.TraceExitMethod(168, 3948, 4389);

                bool
                f_168_4014_4054(Microsoft.CodeAnalysis.ISymbol?
                objA, Microsoft.CodeAnalysis.ISymbol?
                objB)
                {
                    var return_v = object.Equals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 4014, 4054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 3948, 4389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 3948, 4389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 4401, 4586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 4459, 4575);

                return f_168_4466_4574(this.Symbol, f_168_4492_4573(f_168_4505_4545(_candidateSymbols, 4), this.CandidateReason));
                DynAbs.Tracing.TraceSender.TraceExitMethod(168, 4401, 4586);

                int
                f_168_4505_4545(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                values, int
                maxItemsToHash)
                {
                    var return_v = Hash.CombineValues(values, maxItemsToHash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 4505, 4545);
                    return return_v;
                }


                int
                f_168_4492_4573(int
                newKey, Microsoft.CodeAnalysis.CandidateReason
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 4492, 4573);
                    return return_v;
                }


                int
                f_168_4466_4574(Microsoft.CodeAnalysis.ISymbol?
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 4466, 4574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 4401, 4586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 4401, 4586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(168, 4644, 4780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 4680, 4765);

                    return this.Symbol == null
                    && (DynAbs.Tracing.TraceSender.Expression_True(168, 4687, 4764) && this.CandidateSymbols.Length == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(168, 4644, 4780);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(168, 4598, 4791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 4598, 4791);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static SymbolInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(168, 375, 4798);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(168, 477, 557);
            None = f_168_484_557(null, ImmutableArray<ISymbol>.Empty, CandidateReason.None); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(168, 375, 4798);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(168, 375, 4798);
        }

        static Microsoft.CodeAnalysis.SymbolInfo
        f_168_484_557(Microsoft.CodeAnalysis.ISymbol?
        symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        candidateSymbols, Microsoft.CodeAnalysis.CandidateReason
        candidateReason)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolInfo(symbol, candidateSymbols, candidateReason);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 484, 557);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ISymbol
        f_168_2512_2518_C(Microsoft.CodeAnalysis.ISymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(168, 2456, 2594);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ISymbol
        f_168_2686_2692_C(Microsoft.CodeAnalysis.ISymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(168, 2606, 2754);
            return return_v;
        }


        static Microsoft.CodeAnalysis.ISymbol?
        f_168_2881_2885_C(Microsoft.CodeAnalysis.ISymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(168, 2766, 2943);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        f_168_3197_3229()
        {
            var return_v = ImmutableArray.Create<ISymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 3197, 3229);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolKind
        f_168_3388_3399(Microsoft.CodeAnalysis.ISymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(168, 3388, 3399);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NamespaceKind
        f_168_3427_3467(Microsoft.CodeAnalysis.INamespaceSymbol
        this_param)
        {
            var return_v = this_param.NamespaceKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(168, 3427, 3467);
            return return_v;
        }


        static int
        f_168_3357_3499(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 3357, 3499);
            return 0;
        }


        static Microsoft.CodeAnalysis.SymbolKind
        f_168_3599_3608(Microsoft.CodeAnalysis.ISymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(168, 3599, 3608);
            return return_v;
        }


        static Microsoft.CodeAnalysis.NamespaceKind
        f_168_3636_3674(Microsoft.CodeAnalysis.INamespaceSymbol
        this_param)
        {
            var return_v = this_param.NamespaceKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(168, 3636, 3674);
            return return_v;
        }


        static int
        f_168_3586_3706(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 3586, 3706);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        f_168_3535_3552_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(168, 3535, 3552);
            return return_v;
        }

    }
}
