// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class ReadWriteWalker : AbstractRegionDataFlowPass
    {
        internal static void Analyze(
                    CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion, HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes,
                    out IEnumerable<Symbol> readInside,
                    out IEnumerable<Symbol> writtenInside,
                    out IEnumerable<Symbol> readOutside,
                    out IEnumerable<Symbol> writtenOutside,
                    out IEnumerable<Symbol> captured,
                    out IEnumerable<Symbol> unsafeAddressTaken,
                    out IEnumerable<Symbol> capturedInside,
                    out IEnumerable<Symbol> capturedOutside,
                    out IEnumerable<MethodSymbol> usedLocalFunctions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10905, 695, 2737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1425, 1551);

                var
                walker = f_10905_1438_1550(compilation, member, node, firstInRegion, lastInRegion, unassignedVariableAddressOfSyntaxes)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1601, 1624);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1642, 1672);

                    f_10905_1642_1671(walker, ref badRegion);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1690, 2628) || true) && (badRegion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 1690, 2628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1745, 1899);

                        readInside = writtenInside = readOutside = writtenOutside = captured = unsafeAddressTaken = capturedInside = capturedOutside = f_10905_1872_1898();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 1921, 1975);

                        usedLocalFunctions = f_10905_1942_1974();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 1690, 2628);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 1690, 2628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2057, 2089);

                        readInside = walker._readInside;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2111, 2149);

                        writtenInside = walker._writtenInside;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2171, 2205);

                        readOutside = walker._readOutside;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2227, 2267);

                        writtenOutside = walker._writtenOutside;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2291, 2323);

                        captured = f_10905_2302_2322(walker);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2345, 2389);

                        capturedInside = f_10905_2362_2388(walker);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2411, 2457);

                        capturedOutside = f_10905_2429_2456(walker);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2481, 2533);

                        unsafeAddressTaken = f_10905_2502_2532(walker);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2557, 2609);

                        usedLocalFunctions = f_10905_2578_2608(walker);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 1690, 2628);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10905, 2657, 2726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2697, 2711);

                    f_10905_2697_2710(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10905, 2657, 2726);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10905, 695, 2737);

                Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                f_10905_1438_1550(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.BoundNode
                firstInRegion, Microsoft.CodeAnalysis.CSharp.BoundNode
                lastInRegion, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Syntax.PrefixUnaryExpressionSyntax>
                unassignedVariableAddressOfSyntaxes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ReadWriteWalker(compilation, member, node, firstInRegion, lastInRegion, unassignedVariableAddressOfSyntaxes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 1438, 1550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AbstractFlowPass<Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalState, Microsoft.CodeAnalysis.CSharp.DefiniteAssignmentPass.LocalFunctionState>.PendingBranch>
                f_10905_1642_1671(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 1642, 1671);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10905_1872_1898()
                {
                    var return_v = Enumerable.Empty<Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 1872, 1898);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10905_1942_1974()
                {
                    var return_v = Enumerable.Empty<MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 1942, 1974);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10905_2302_2322(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.GetCaptured();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2302, 2322);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10905_2362_2388(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.GetCapturedInside();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2362, 2388);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10905_2429_2456(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.GetCapturedOutside();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2429, 2456);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10905_2502_2532(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.GetUnsafeAddressTaken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2502, 2532);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10905_2578_2608(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.GetUsedLocalFunctions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2578, 2608);
                    return return_v;
                }


                int
                f_10905_2697_2710(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2697, 2710);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 695, 2737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 695, 2737);
            }
        }

        private readonly HashSet<Symbol> _readInside;

        private readonly HashSet<Symbol> _writtenInside;

        private readonly HashSet<Symbol> _readOutside;

        private readonly HashSet<Symbol> _writtenOutside;

        private ReadWriteWalker(CSharpCompilation compilation, Symbol member, BoundNode node, BoundNode firstInRegion, BoundNode lastInRegion,
                    HashSet<PrefixUnaryExpressionSyntax> unassignedVariableAddressOfSyntaxes)
        : base(f_10905_3317_3328_C(compilation), member, node, firstInRegion, lastInRegion, unassignedVariableAddressOfSyntaxes: unassignedVariableAddressOfSyntaxes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10905, 3075, 3468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2782, 2817);
                this._readInside = f_10905_2796_2817(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2861, 2899);
                this._writtenInside = f_10905_2878_2899(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 2943, 2979);
                this._readOutside = f_10905_2958_2979(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3023, 3062);
                this._writtenOutside = f_10905_3041_3062(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10905, 3075, 3468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 3075, 3468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 3075, 3468);
            }
        }

        protected override void EnterRegion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 3480, 4126);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3551, 3589);
                    for (var
        m = this.CurrentSymbol as MethodSymbol
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3542, 4080) || true) && ((object)m != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3610, 3648)
        , m = f_10905_3614_3632(m) as MethodSymbol, DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 3542, 4080))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 3542, 4080);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3682, 3824);
                            foreach (var p in f_10905_3700_3712_I(f_10905_3700_3712(m)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 3682, 3824);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3754, 3805) || true) && (f_10905_3758_3767(p) != RefKind.None)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 3754, 3805);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3785, 3805);

                                    f_10905_3785_3804(_readOutside, p);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 3754, 3805);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 3682, 3824);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10905, 1, 143);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10905, 1, 143);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3844, 3880);

                        var
                        thisParameter = f_10905_3864_3879(m)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 3898, 4065) || true) && ((object)thisParameter != null && (DynAbs.Tracing.TraceSender.Expression_True(10905, 3902, 3972) && f_10905_3935_3956(thisParameter) != RefKind.None))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 3898, 4065);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4014, 4046);

                            f_10905_4014_4045(_readOutside, thisParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 3898, 4065);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10905, 1, 539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10905, 1, 539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4096, 4115);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EnterRegion(), 10905, 4096, 4114);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 3480, 4126);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10905_3614_3632(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 3614, 3632);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10905_3700_3712(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 3700, 3712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10905_3758_3767(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 3758, 3767);
                    return return_v;
                }


                bool
                f_10905_3785_3804(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 3785, 3804);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10905_3700_3712_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 3700, 3712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_3864_3879(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 3864, 3879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10905_3935_3956(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 3935, 3956);
                    return return_v;
                }


                bool
                f_10905_4014_4045(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 4014, 4045);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 3480, 4126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 3480, 4126);
            }
        }

        protected override void NoteRead(Symbol variable, ParameterSymbol rangeVariableUnderlyingParameter = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 4432, 4790);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4563, 4600) || true) && ((object)variable == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 4563, 4600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4593, 4600);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 4563, 4600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4614, 4707) || true) && (f_10905_4618_4631(variable) != SymbolKind.Field)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 4614, 4707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4653, 4707);

                    f_10905_4653_4706(((DynAbs.Tracing.TraceSender.Conditional_F1(10905, 4654, 4662) || ((f_10905_4654_4662() && DynAbs.Tracing.TraceSender.Conditional_F2(10905, 4665, 4676)) || DynAbs.Tracing.TraceSender.Conditional_F3(10905, 4679, 4691))) ? _readInside : _readOutside), variable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 4614, 4707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4721, 4779);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.NoteRead(variable, rangeVariableUnderlyingParameter), 10905, 4721, 4778);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 4432, 4790);

                Microsoft.CodeAnalysis.SymbolKind
                f_10905_4618_4631(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 4618, 4631);
                    return return_v;
                }


                bool
                f_10905_4654_4662()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 4654, 4662);
                    return return_v;
                }


                bool
                f_10905_4653_4706(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 4653, 4706);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 4432, 4790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 4432, 4790);
            }
        }

        protected override void NoteWrite(Symbol variable, BoundExpression value, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 4802, 5085);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4911, 4948) || true) && ((object)variable == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 4911, 4948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4941, 4948);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 4911, 4948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 4962, 5022);

                f_10905_4962_5021(((DynAbs.Tracing.TraceSender.Conditional_F1(10905, 4963, 4971) || ((f_10905_4963_4971() && DynAbs.Tracing.TraceSender.Conditional_F2(10905, 4974, 4988)) || DynAbs.Tracing.TraceSender.Conditional_F3(10905, 4991, 5006))) ? _writtenInside : _writtenOutside), variable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5036, 5074);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.NoteWrite(variable, value, read), 10905, 5036, 5073);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 4802, 5085);

                bool
                f_10905_4963_4971()
                {
                    var return_v = IsInside;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 4963, 4971);
                    return return_v;
                }


                bool
                f_10905_4962_5021(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 4962, 5021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 4802, 5085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 4802, 5085);
            }
        }

        protected override void CheckAssigned(BoundExpression expr, FieldSymbol fieldSymbol, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 5097, 5469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5223, 5267);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CheckAssigned(expr, fieldSymbol, node), 10905, 5223, 5266);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5281, 5458) || true) && (f_10905_5285_5294_M(!IsInside) && (DynAbs.Tracing.TraceSender.Expression_True(10905, 5285, 5328) && node.Span.Contains(RegionSpan)) && (DynAbs.Tracing.TraceSender.Expression_True(10905, 5285, 5368) && (f_10905_5333_5342(expr) == BoundKind.FieldAccess)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 5281, 5458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5402, 5443);

                    f_10905_5402_5442(this, expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 5281, 5458);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 5097, 5469);

                bool
                f_10905_5285_5294_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 5285, 5294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10905_5333_5342(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 5333, 5342);
                    return return_v;
                }


                int
                f_10905_5402_5442(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    this_param.NoteReceiverRead((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess)expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 5402, 5442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 5097, 5469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 5097, 5469);
            }
        }

        private void NoteReceiverWritten(BoundFieldAccess expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 5481, 5620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5561, 5609);

                f_10905_5561_5608(this, expr, _writtenInside);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 5481, 5620);

                int
                f_10905_5561_5608(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expr, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                readOrWritten)
                {
                    this_param.NoteReceiverReadOrWritten(expr, readOrWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 5561, 5608);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 5481, 5620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 5481, 5620);
            }
        }

        private void NoteReceiverRead(BoundFieldAccess expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 5632, 5765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 5709, 5754);

                f_10905_5709_5753(this, expr, _readInside);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 5632, 5765);

                int
                f_10905_5709_5753(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                expr, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                readOrWritten)
                {
                    this_param.NoteReceiverReadOrWritten(expr, readOrWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 5709, 5753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 5632, 5765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 5632, 5765);
            }
        }

        private void NoteReceiverReadOrWritten(BoundFieldAccess expr, HashSet<Symbol> readOrWritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 6299, 8420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6416, 6454) || true) && (f_10905_6420_6445(f_10905_6420_6436(expr)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6416, 6454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6447, 6454);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6416, 6454);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6468, 6528) || true) && (f_10905_6472_6519(f_10905_6472_6503(f_10905_6472_6488(expr))))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6468, 6528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6521, 6528);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6468, 6528);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6542, 6574);

                var
                receiver = f_10905_6557_6573(expr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6588, 6617) || true) && (receiver == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6588, 6617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6610, 6617);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6588, 6617);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6631, 6668);

                var
                receiverSyntax = receiver.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6682, 6717) || true) && (receiverSyntax == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6682, 6717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6710, 6717);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6682, 6717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6731, 8409);

                switch (f_10905_6739_6752(receiver))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6829, 6995) || true) && (f_10905_6833_6868(this, f_10905_6848_6867(receiverSyntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6829, 6995);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 6918, 6972);

                            f_10905_6918_6971(readOrWritten, f_10905_6936_6970(((BoundLocal)receiver)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6829, 6995);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 7017, 7023);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7092, 7248) || true) && (f_10905_7096_7131(this, f_10905_7111_7130(receiverSyntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 7092, 7248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7181, 7225);

                            f_10905_7181_7224(readOrWritten, f_10905_7199_7223(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 7092, 7248);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 7270, 7276);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);

                    case BoundKind.BaseReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7345, 7501) || true) && (f_10905_7349_7384(this, f_10905_7364_7383(receiverSyntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 7345, 7501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7434, 7478);

                            f_10905_7434_7477(readOrWritten, f_10905_7452_7476(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 7345, 7501);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 7523, 7529);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7594, 7768) || true) && (f_10905_7598_7633(this, f_10905_7613_7632(receiverSyntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 7594, 7768);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7683, 7745);

                            f_10905_7683_7744(readOrWritten, f_10905_7701_7743(((BoundParameter)receiver)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 7594, 7768);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 7790, 7796);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7865, 8047) || true) && (f_10905_7869_7904(this, f_10905_7884_7903(receiverSyntax)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 7865, 8047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 7954, 8024);

                            f_10905_7954_8023(readOrWritten, f_10905_7972_8022(((BoundRangeVariable)receiver)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 7865, 8047);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 8069, 8075);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 6731, 8409);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8142, 8366) || true) && (f_10905_8146_8174(f_10905_8146_8159(receiver)) && (DynAbs.Tracing.TraceSender.Expression_True(10905, 8146, 8222) && receiverSyntax.Span.OverlapsWith(RegionSpan)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8142, 8366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8272, 8343);

                            f_10905_8272_8342(this, receiver as BoundFieldAccess, readOrWritten);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8142, 8366);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 8388, 8394);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 6731, 8409);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 6299, 8420);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10905_6420_6436(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6420, 6436);
                    return return_v;
                }


                bool
                f_10905_6420_6445(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6420, 6445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10905_6472_6488(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6472, 6488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10905_6472_6503(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6472, 6503);
                    return return_v;
                }


                bool
                f_10905_6472_6519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6472, 6519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10905_6557_6573(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6557, 6573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10905_6739_6752(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6739, 6752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10905_6848_6867(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6848, 6867);
                    return return_v;
                }


                bool
                f_10905_6833_6868(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 6833, 6868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10905_6936_6970(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 6936, 6970);
                    return return_v;
                }


                bool
                f_10905_6918_6971(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 6918, 6971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10905_7111_7130(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7111, 7130);
                    return return_v;
                }


                bool
                f_10905_7096_7131(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7096, 7131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_7199_7223(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7199, 7223);
                    return return_v;
                }


                bool
                f_10905_7181_7224(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7181, 7224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10905_7364_7383(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7364, 7383);
                    return return_v;
                }


                bool
                f_10905_7349_7384(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7349, 7384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_7452_7476(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param)
                {
                    var return_v = this_param.MethodThisParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7452, 7476);
                    return return_v;
                }


                bool
                f_10905_7434_7477(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7434, 7477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10905_7613_7632(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7613, 7632);
                    return return_v;
                }


                bool
                f_10905_7598_7633(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7598, 7633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_7701_7743(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7701, 7743);
                    return return_v;
                }


                bool
                f_10905_7683_7744(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7683, 7744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10905_7884_7903(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7884, 7903);
                    return return_v;
                }


                bool
                f_10905_7869_7904(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.RegionContains(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7869, 7904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10905_7972_8022(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 7972, 8022);
                    return return_v;
                }


                bool
                f_10905_7954_8023(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 7954, 8023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10905_8146_8159(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 8146, 8159);
                    return return_v;
                }


                bool
                f_10905_8146_8174(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 8146, 8174);
                    return return_v;
                }


                int
                f_10905_8272_8342(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                readOrWritten)
                {
                    this_param.NoteReceiverReadOrWritten((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess?)expr, readOrWritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 8272, 8342);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 6299, 8420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 6299, 8420);
            }
        }

        protected override void AssignImpl(BoundNode node, BoundExpression value, bool isRef, bool written, bool read)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 8432, 9881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8567, 9870);

                switch (f_10905_8575_8584(node))
                {

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8567, 9870);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8669, 8753) || true) && (written)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8669, 8753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8682, 8753);

                            f_10905_8682_8752(this, f_10905_8692_8738(((BoundRangeVariable)node)), value, read);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8669, 8753);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 8775, 8781);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8567, 9870);

                    case BoundKind.QueryClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8567, 9870);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8877, 8928);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AssignImpl(node, value, isRef, written, read), 10905, 8877, 8927);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 8954, 9006);

                            var
                            symbol = f_10905_8967_9005(((BoundQueryClause)node))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9032, 9187) || true) && ((object)symbol != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 9032, 9187);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9116, 9160) || true) && (written)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 9116, 9160);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9129, 9160);

                                    f_10905_9129_9159(this, symbol, value, read);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 9116, 9160);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 9032, 9187);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 9232, 9238);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8567, 9870);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8567, 9870);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9334, 9385);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AssignImpl(node, value, isRef, written, read), 10905, 9334, 9384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9411, 9454);

                            var
                            fieldAccess = node as BoundFieldAccess
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9480, 9675) || true) && (f_10905_9484_9493_M(!IsInside) && (DynAbs.Tracing.TraceSender.Expression_True(10905, 9484, 9516) && node.Syntax != null) && (DynAbs.Tracing.TraceSender.Expression_True(10905, 9484, 9557) && node.Syntax.Span.Contains(RegionSpan)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 9480, 9675);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9615, 9648);

                                f_10905_9615_9647(this, fieldAccess);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 9480, 9675);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 9720, 9726);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8567, 9870);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 8567, 9870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9776, 9827);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AssignImpl(node, value, isRef, written, read), 10905, 9776, 9826);
                        DynAbs.Tracing.TraceSender.TraceBreak(10905, 9849, 9855);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 8567, 9870);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 8432, 9881);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10905_8575_8584(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 8575, 8584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10905_8692_8738(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 8692, 8738);
                    return return_v;
                }


                int
                f_10905_8682_8752(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 8682, 8752);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol?
                f_10905_8967_9005(Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                this_param)
                {
                    var return_v = this_param.DefinedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 8967, 9005);
                    return return_v;
                }


                int
                f_10905_9129_9159(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                variable, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value, bool
                read)
                {
                    this_param.NoteWrite((Microsoft.CodeAnalysis.CSharp.Symbol)variable, value, read);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 9129, 9159);
                    return 0;
                }


                bool
                f_10905_9484_9493_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 9484, 9493);
                    return return_v;
                }


                int
                f_10905_9615_9647(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess?
                expr)
                {
                    this_param.NoteReceiverWritten(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 9615, 9647);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 8432, 9881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 8432, 9881);
            }
        }

        public override BoundNode VisitUnboundLambda(UnboundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 9893, 10041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 9982, 10030);

                return f_10905_9989_10029(this, f_10905_10001_10028(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 9893, 10041);

                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10905_10001_10028(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.BindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 10001, 10028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10905_9989_10029(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node)
                {
                    var return_v = this_param.VisitLambda(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 9989, 10029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 9893, 10041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 9893, 10041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitRangeVariable(BoundRangeVariable node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 10053, 10447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10228, 10327);

                ParameterSymbol
                rangeVariableUnderlyingParameter = f_10905_10279_10326(f_10905_10315_10325(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10341, 10410);

                f_10905_10341_10409(this, f_10905_10350_10374(node), rangeVariableUnderlyingParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10424, 10436);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 10053, 10447);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10905_10315_10325(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 10315, 10325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_10279_10326(Microsoft.CodeAnalysis.CSharp.BoundExpression
                underlying)
                {
                    var return_v = GetRangeVariableUnderlyingParameter((Microsoft.CodeAnalysis.CSharp.BoundNode)underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 10279, 10326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10905_10350_10374(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 10350, 10374);
                    return return_v;
                }


                int
                f_10905_10341_10409(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                variable, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                rangeVariableUnderlyingParameter)
                {
                    this_param.NoteRead((Microsoft.CodeAnalysis.CSharp.Symbol)variable, rangeVariableUnderlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 10341, 10409);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 10053, 10447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 10053, 10447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ParameterSymbol GetRangeVariableUnderlyingParameter(BoundNode underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10905, 10697, 11350);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10810, 11311) || true) && (underlying != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 10810, 11311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10869, 11296);

                        switch (f_10905_10877_10892(underlying))
                        {

                            case BoundKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 10869, 11296);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 10985, 11037);

                                return f_10905_10992_11036(((BoundParameter)underlying));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 10869, 11296);

                            case BoundKind.PropertyAccess:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 10869, 11296);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11115, 11174);

                                underlying = f_10905_11128_11173(((BoundPropertyAccess)underlying));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11200, 11209);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 10869, 11296);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10905, 10869, 11296);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11265, 11277);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 10869, 11296);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10905, 10810, 11311);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10905, 10810, 11311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10905, 10810, 11311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11327, 11339);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10905, 10697, 11350);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10905_10877_10892(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 10877, 10892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10905_10992_11036(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 10992, 11036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10905_11128_11173(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10905, 11128, 11173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 10697, 11350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 10697, 11350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitQueryClause(BoundQueryClause node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10905, 11362, 11538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11452, 11478);

                f_10905_11452_11477(this, node, value: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10905, 11492, 11527);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitQueryClause(node), 10905, 11499, 11526);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10905, 11362, 11538);

                int
                f_10905_11452_11477(Microsoft.CodeAnalysis.CSharp.ReadWriteWalker
                this_param, Microsoft.CodeAnalysis.CSharp.BoundQueryClause
                node, Microsoft.CodeAnalysis.CSharp.BoundExpression
                value)
                {
                    this_param.Assign((Microsoft.CodeAnalysis.CSharp.BoundNode)node, value: value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 11452, 11477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10905, 11362, 11538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 11362, 11538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ReadWriteWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10905, 619, 11545);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10905, 619, 11545);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10905, 619, 11545);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10905, 619, 11545);

        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10905_2796_2817()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2796, 2817);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10905_2878_2899()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2878, 2899);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10905_2958_2979()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 2958, 2979);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10905_3041_3062()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10905, 3041, 3062);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10905_3317_3328_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10905, 3075, 3468);
            return return_v;
        }

    }
}
