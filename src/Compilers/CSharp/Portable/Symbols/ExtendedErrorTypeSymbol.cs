// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class ExtendedErrorTypeSymbol : ErrorTypeSymbol
    {
        private readonly string _name;

        private readonly int _arity;

        private readonly DiagnosticInfo? _errorInfo;

        private readonly NamespaceOrTypeSymbol? _containingSymbol;

        private readonly bool _unreported;

        public readonly bool VariableUsedBeforeDeclaration;

        private readonly ImmutableArray<Symbol> _candidateSymbols;

        private readonly LookupResultKind _resultKind;

        internal ExtendedErrorTypeSymbol(CSharpCompilation compilation, string name, int arity, DiagnosticInfo? errorInfo, bool unreported = false, bool variableUsedBeforeDeclaration = false)
        : this(f_10065_1353_1389_C(f_10065_1353_1389(f_10065_1353_1373(compilation))), name, arity, errorInfo, unreported, variableUsedBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 1149, 1479);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 1149, 1479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 1149, 1479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 1149, 1479);
            }
        }

        internal ExtendedErrorTypeSymbol(NamespaceOrTypeSymbol? containingSymbol, string name, int arity, DiagnosticInfo? errorInfo, bool unreported = false, bool variableUsedBeforeDeclaration = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 1491, 2409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 656, 661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 693, 699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 743, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 804, 821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 854, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 897, 926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 1089, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 1709, 1963);

                f_10065_1709_1962(((object?)containingSymbol == null) || (DynAbs.Tracing.TraceSender.Expression_False(10065, 1722, 1825) || (f_10065_1779_1800(containingSymbol) == SymbolKind.Namespace)) || (DynAbs.Tracing.TraceSender.Expression_False(10065, 1722, 1893) || (f_10065_1847_1868(containingSymbol) == SymbolKind.NamedType)) || (DynAbs.Tracing.TraceSender.Expression_False(10065, 1722, 1961) || (f_10065_1915_1936(containingSymbol) == SymbolKind.ErrorType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 1979, 2012);

                f_10065_1979_2011(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2026, 2081);

                f_10065_2026_2080(unreported == false || (DynAbs.Tracing.TraceSender.Expression_False(10065, 2039, 2079) || errorInfo != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2097, 2110);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2124, 2147);

                _errorInfo = errorInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2161, 2198);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2212, 2227);

                _arity = arity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2241, 2266);

                _unreported = unreported;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2280, 2347);

                this.VariableUsedBeforeDeclaration = variableUsedBeforeDeclaration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2361, 2398);

                _resultKind = LookupResultKind.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 1491, 2409);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 1491, 2409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 1491, 2409);
            }
        }

        private ExtendedErrorTypeSymbol(NamespaceOrTypeSymbol? containingSymbol, string name, int arity, DiagnosticInfo? errorInfo, bool unreported, bool variableUsedBeforeDeclaration, ImmutableArray<Symbol> candidateSymbols, LookupResultKind resultKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 2421, 3043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 656, 661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 693, 699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 743, 753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 804, 821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 854, 865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 897, 926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 1089, 1100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2692, 2705);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2719, 2742);

                _errorInfo = errorInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2756, 2793);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2807, 2822);

                _arity = arity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2836, 2861);

                _unreported = unreported;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2875, 2942);

                this.VariableUsedBeforeDeclaration = variableUsedBeforeDeclaration;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 2956, 2993);

                _candidateSymbols = candidateSymbols;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 3007, 3032);

                _resultKind = resultKind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 2421, 3043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 2421, 3043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 2421, 3043);
            }
        }

        internal ExtendedErrorTypeSymbol(NamespaceOrTypeSymbol guessSymbol, LookupResultKind resultKind, DiagnosticInfo errorInfo, bool unreported = false)
        : this(f_10065_3223_3262_C(f_10065_3223_3262(guessSymbol)), guessSymbol, resultKind, errorInfo, unreported)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 3055, 3333);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 3055, 3333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 3055, 3333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 3055, 3333);
            }
        }

        internal ExtendedErrorTypeSymbol(NamespaceOrTypeSymbol? containingSymbol, Symbol guessSymbol, LookupResultKind resultKind, DiagnosticInfo errorInfo, bool unreported = false)
        : this(f_10065_3539_3555_C(containingSymbol), f_10065_3557_3599(guessSymbol), resultKind, errorInfo, f_10065_3624_3645(guessSymbol), unreported)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 3345, 3680);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 3345, 3680);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 3345, 3680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 3345, 3680);
            }
        }

        internal ExtendedErrorTypeSymbol(NamespaceOrTypeSymbol? containingSymbol, ImmutableArray<Symbol> candidateSymbols, LookupResultKind resultKind, DiagnosticInfo errorInfo, int arity, bool unreported = false)
        : this(f_10065_3918_3934_C(containingSymbol), f_10065_3936_3960(candidateSymbols[0]), arity, errorInfo, unreported)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10065, 3692, 4284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4016, 4076);

                _candidateSymbols = f_10065_4036_4075(candidateSymbols);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4090, 4115);

                _resultKind = resultKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4129, 4273);

                f_10065_4129_4272(candidateSymbols.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10065, 4142, 4207) || resultKind != LookupResultKind.Viable), "Shouldn't use LookupResultKind.Viable with candidate symbols");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10065, 3692, 4284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 3692, 4284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 3692, 4284);
            }
        }

        internal ExtendedErrorTypeSymbol AsUnreported()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 4296, 4571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4368, 4560);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10065, 4375, 4390) || ((f_10065_4375_4390(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 4393, 4397)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 4417, 4559))) ? this : f_10065_4417_4559(_containingSymbol, _name, _arity, _errorInfo, true, VariableUsedBeforeDeclaration, _candidateSymbols, _resultKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 4296, 4571);

                bool
                f_10065_4375_4390(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Unreported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 4375, 4390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10065_4417_4559(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo, bool
                unreported, bool
                variableUsedBeforeDeclaration, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                candidateSymbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity, errorInfo, unreported, variableUsedBeforeDeclaration, candidateSymbols, resultKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 4417, 4559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 4296, 4571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 4296, 4571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<Symbol> UnwrapErrorCandidates(ImmutableArray<Symbol> candidateSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10065, 4583, 4945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4708, 4797);

                var
                candidate = (DynAbs.Tracing.TraceSender.Conditional_F1(10065, 4724, 4748) || ((candidateSymbols.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 4751, 4755)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 4758, 4796))) ? null : candidateSymbols[0] as ErrorTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 4811, 4934);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10065, 4818, 4885) || ((((object?)candidate != null && (DynAbs.Tracing.TraceSender.Expression_True(10065, 4819, 4884) && f_10065_4849_4884_M(!candidate.CandidateSymbols.IsEmpty))) && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 4888, 4914)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 4917, 4933))) ? f_10065_4888_4914(candidate) : candidateSymbols;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10065, 4583, 4945);

                bool
                f_10065_4849_4884_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 4849, 4884);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10065_4888_4914(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.CandidateSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 4888, 4914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 4583, 4945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 4583, 4945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 4957, 5106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5058, 5095);

                throw f_10065_5064_5094();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 4957, 5106);

                System.Exception
                f_10065_5064_5094()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 5064, 5094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 4957, 5106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 4957, 5106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo? ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5186, 5255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5222, 5240);

                    return _errorInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5186, 5255);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5118, 5266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5118, 5266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override LookupResultKind ResultKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5348, 5418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5384, 5403);

                    return _resultKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5348, 5418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5278, 5429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5278, 5429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> CandidateSymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5497, 5531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5500, 5531);
                    return _candidateSymbols.NullToEmpty(); DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5497, 5531);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5497, 5531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5497, 5531);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Unreported
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5602, 5629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5608, 5627);

                    return _unreported;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5602, 5629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5544, 5640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5544, 5640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5652, 5858);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5733, 5819) || true) && (_unreported)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 5733, 5819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5782, 5804);

                    return f_10065_5789_5803(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 5733, 5819);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5835, 5847);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5652, 5858);

                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10065_5789_5803(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 5789, 5803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5652, 5858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5652, 5858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 5920, 5985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 5956, 5970);

                    return _arity;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 5920, 5985);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 5870, 5996);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 5870, 5996);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6066, 6135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6102, 6120);

                    return _arity > 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6066, 6135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6008, 6146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6008, 6146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6223, 6299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6259, 6284);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6223, 6299);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6158, 6310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6158, 6310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6374, 6438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6410, 6423);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6374, 6438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6322, 6449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6322, 6449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6536, 6599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6572, 6584);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6536, 6599);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6461, 6610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6461, 6610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6778, 6867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6814, 6852);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6778, 6867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6703, 6878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6703, 6878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 6962, 7025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 6998, 7010);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 6962, 7025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 6890, 7036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 6890, 7036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol? GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 7048, 7191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 7168, 7180);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 7048, 7191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 7048, 7191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 7048, 7191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 7203, 7396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 7340, 7385);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 7203, 7396);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 7203, 7396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 7203, 7396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol? ExtractNonErrorType(TypeSymbol? oldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10065, 8838, 10183);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 8933, 9069) || true) && ((object?)oldSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10065, 8937, 9003) || f_10065_8967_8985(oldSymbol) != TypeKind.Error))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 8933, 9069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 9037, 9054);

                    return oldSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 8933, 9069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 9492, 9584);

                ExtendedErrorTypeSymbol?
                oldError = f_10065_9528_9556(oldSymbol) as ExtendedErrorTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 9823, 10144) || true) && ((object?)oldError != null && (DynAbs.Tracing.TraceSender.Expression_True(10065, 9827, 9893) && f_10065_9856_9893_M(!oldError._candidateSymbols.IsDefault)) && (DynAbs.Tracing.TraceSender.Expression_True(10065, 9827, 9935) && oldError._candidateSymbols.Length == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 9823, 10144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 9969, 10032);

                    TypeSymbol?
                    type = oldError._candidateSymbols[0] as TypeSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10050, 10129) || true) && ((object?)type != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 10050, 10129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10098, 10129);

                        return f_10065_10105_10128(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 10050, 10129);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 9823, 10144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10160, 10172);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10065, 8838, 10183);

                Microsoft.CodeAnalysis.TypeKind
                f_10065_8967_8985(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 8967, 8985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10065_9528_9556(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 9528, 9556);
                    return return_v;
                }


                bool
                f_10065_9856_9893_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 9856, 9893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10065_10105_10128(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNonErrorGuess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 10105, 10128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 8838, 10183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 8838, 10183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeKind ExtractNonErrorTypeKind(TypeSymbol oldSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10065, 10271, 12038);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10366, 10481) || true) && (f_10065_10370_10388(oldSymbol) != TypeKind.Error)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 10366, 10481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10440, 10466);

                    return f_10065_10447_10465(oldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 10366, 10481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 10904, 10996);

                ExtendedErrorTypeSymbol?
                oldError = f_10065_10940_10968(oldSymbol) as ExtendedErrorTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11235, 11276);

                TypeKind
                commonTypeKind = TypeKind.Error
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11290, 11989) || true) && ((object?)oldError != null && (DynAbs.Tracing.TraceSender.Expression_True(10065, 11294, 11360) && f_10065_11323_11360_M(!oldError._candidateSymbols.IsDefault)) && (DynAbs.Tracing.TraceSender.Expression_True(10065, 11294, 11401) && oldError._candidateSymbols.Length > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11290, 11989);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11435, 11974);
                        foreach (Symbol sym in f_10065_11458_11484_I(oldError._candidateSymbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11435, 11974);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11526, 11563);

                            TypeSymbol?
                            type = sym as TypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11585, 11955) || true) && ((object?)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10065, 11589, 11645) && f_10065_11614_11627(type) != TypeKind.Error))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11585, 11955);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11695, 11912) || true) && (commonTypeKind == TypeKind.Error)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11695, 11912);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11762, 11793);

                                    commonTypeKind = f_10065_11779_11792(type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11695, 11912);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11695, 11912);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11824, 11912) || true) && (commonTypeKind != f_10065_11846_11859(type))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 11824, 11912);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 11890, 11912);

                                        return TypeKind.Error;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11824, 11912);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11695, 11912);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11585, 11955);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11435, 11974);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10065, 1, 540);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10065, 1, 540);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 11290, 11989);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12005, 12027);

                return commonTypeKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10065, 10271, 12038);

                Microsoft.CodeAnalysis.TypeKind
                f_10065_10370_10388(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 10370, 10388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10065_10447_10465(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 10447, 10465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10065_10940_10968(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 10940, 10968);
                    return return_v;
                }


                bool
                f_10065_11323_11360_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 11323, 11360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10065_11614_11627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 11614, 11627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10065_11779_11792(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 11779, 11792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10065_11846_11859(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 11846, 11859);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10065_11458_11484_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 11458, 11484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 10271, 12038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 10271, 12038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol? t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 12050, 12815);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12148, 12238) || true) && (f_10065_12152_12177(this, t2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 12148, 12238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12211, 12223);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 12148, 12238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12254, 12296);

                var
                other = t2 as ExtendedErrorTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12310, 12434) || true) && ((object?)other == null || (DynAbs.Tracing.TraceSender.Expression_False(10065, 12314, 12351) || _unreported) || (DynAbs.Tracing.TraceSender.Expression_False(10065, 12314, 12372) || other._unreported))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 12310, 12434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12406, 12419);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 12310, 12434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12450, 12804);

                return
                                ((DynAbs.Tracing.TraceSender.Conditional_F1(10065, 12475, 12510) || (((object)f_10065_12483_12502(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 12513, 12573)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 12594, 12729))) ? f_10065_12513_12573(f_10065_12513_12532(this), f_10065_12540_12560(other), comparison) : (DynAbs.Tracing.TraceSender.Conditional_F1(10065, 12594, 12632) || (((object?)f_10065_12603_12624(this) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 12635, 12674)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 12677, 12729))) ? (object?)f_10065_12644_12666(other) == null : f_10065_12677_12729(f_10065_12677_12698(this), f_10065_12706_12728(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10065, 12474, 12774) && f_10065_12751_12760(this) == f_10065_12764_12774(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10065, 12474, 12803) && f_10065_12778_12788(this) == f_10065_12792_12803(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 12050, 12815);

                bool
                f_10065_12152_12177(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12152, 12177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10065_12483_12502(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12483, 12502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10065_12513_12532(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12513, 12532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10065_12540_12560(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12540, 12560);
                    return return_v;
                }


                bool
                f_10065_12513_12573(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12513, 12573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10065_12603_12624(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12603, 12624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10065_12644_12666(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12644, 12666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10065_12677_12698(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12677, 12698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10065_12706_12728(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12706, 12728);
                    return return_v;
                }


                bool
                f_10065_12677_12729(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12677, 12729);
                    return return_v;
                }


                string
                f_10065_12751_12760(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12751, 12760);
                    return return_v;
                }


                string
                f_10065_12764_12774(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12764, 12774);
                    return return_v;
                }


                int
                f_10065_12778_12788(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12778, 12788);
                    return return_v;
                }


                int
                f_10065_12792_12803(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12792, 12803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 12050, 12815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 12050, 12815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10065, 12827, 13136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 12885, 13125);

                return f_10065_12892_13124(f_10065_12905_12915(this), f_10065_12942_13123((DynAbs.Tracing.TraceSender.Conditional_F1(10065, 12955, 12993) || (((object?)f_10065_12964_12985(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 12996, 13031)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 13034, 13035))) ? f_10065_12996_13031(f_10065_12996_13017(this)) : 0, (DynAbs.Tracing.TraceSender.Conditional_F1(10065, 13075, 13092) || ((f_10065_13075_13084(this) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10065, 13095, 13118)) || DynAbs.Tracing.TraceSender.Conditional_F3(10065, 13121, 13122))) ? f_10065_13095_13118(f_10065_13095_13104(this)) : 0));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10065, 12827, 13136);

                int
                f_10065_12905_12915(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12905, 12915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10065_12964_12985(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12964, 12985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10065_12996_13017(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 12996, 13017);
                    return return_v;
                }


                int
                f_10065_12996_13031(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12996, 13031);
                    return return_v;
                }


                string
                f_10065_13075_13084(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 13075, 13084);
                    return return_v;
                }


                string
                f_10065_13095_13104(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 13095, 13104);
                    return return_v;
                }


                int
                f_10065_13095_13118(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 13095, 13118);
                    return return_v;
                }


                int
                f_10065_12942_13123(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12942, 13123);
                    return return_v;
                }


                int
                f_10065_12892_13124(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 12892, 13124);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 12827, 13136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 12827, 13136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetArity(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10065, 13148, 13581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 13215, 13570);

                switch (f_10065_13223_13234(symbol))
                {

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 13215, 13570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 13360, 13399);

                        return f_10065_13367_13398(((NamedTypeSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 13215, 13570);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 13215, 13570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 13462, 13498);

                        return f_10065_13469_13497(((MethodSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 13215, 13570);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10065, 13215, 13570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10065, 13546, 13555);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10065, 13215, 13570);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10065, 13148, 13581);

                Microsoft.CodeAnalysis.SymbolKind
                f_10065_13223_13234(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 13223, 13234);
                    return return_v;
                }


                int
                f_10065_13367_13398(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 13367, 13398);
                    return return_v;
                }


                int
                f_10065_13469_13497(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 13469, 13497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10065, 13148, 13581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 13148, 13581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExtendedErrorTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10065, 552, 13588);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10065, 552, 13588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10065, 552, 13588);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10065, 552, 13588);

        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10065_1353_1373(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 1353, 1373);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10065_1353_1389(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.GlobalNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 1353, 1389);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        f_10065_1353_1389_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10065, 1149, 1479);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10065_1779_1800(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 1779, 1800);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10065_1847_1868(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 1847, 1868);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10065_1915_1936(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 1915, 1936);
            return return_v;
        }


        int
        f_10065_1709_1962(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 1709, 1962);
            return 0;
        }


        int
        f_10065_1979_2011(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 1979, 2011);
            return 0;
        }


        int
        f_10065_2026_2080(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 2026, 2080);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        f_10065_3223_3262(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        symbol)
        {
            var return_v = symbol.ContainingNamespaceOrType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 3223, 3262);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        f_10065_3223_3262_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10065, 3055, 3333);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10065_3557_3599(Microsoft.CodeAnalysis.CSharp.Symbol
        item)
        {
            var return_v = ImmutableArray.Create<Symbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 3557, 3599);
            return return_v;
        }


        static int
        f_10065_3624_3645(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetArity(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 3624, 3645);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        f_10065_3539_3555_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10065, 3345, 3680);
            return return_v;
        }


        static string
        f_10065_3936_3960(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10065, 3936, 3960);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10065_4036_4075(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        candidateSymbols)
        {
            var return_v = UnwrapErrorCandidates(candidateSymbols);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 4036, 4075);
            return return_v;
        }


        int
        f_10065_4129_4272(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10065, 4129, 4272);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        f_10065_3918_3934_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10065, 3692, 4284);
            return return_v;
        }

    }
}
