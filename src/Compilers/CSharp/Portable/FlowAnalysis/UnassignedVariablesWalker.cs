// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class UnassignedVariablesWalker : DefiniteAssignmentPass
    {
        private UnassignedVariablesWalker(CSharpCompilation compilation, Symbol member, BoundNode node)
        : base(f_10909_835_846_C(compilation), member, node, f_10909_862_901())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10909, 719, 924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1861, 1892);
                this._result = f_10909_1871_1892(); DynAbs.Tracing.TraceSender.TraceExitConstructor(10909, 719, 924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10909, 719, 924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 719, 924);
            }
        }

        internal static HashSet<Symbol> Analyze(CSharpCompilation compilation, Symbol member, BoundNode node,
                                                        bool convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10909, 936, 1816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1200, 1270);

                var
                walker = f_10909_1213_1269(compilation, member, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1286, 1503) || true) && (convertInsufficientExecutionStackExceptionToCancelledByStackGuardException)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10909, 1286, 1503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1398, 1488);

                    walker._convertInsufficientExecutionStackExceptionToCancelledByStackGuardException = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10909, 1286, 1503);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1555, 1578);

                    bool
                    badRegion = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1596, 1639);

                    var
                    result = f_10909_1609_1638(walker, ref badRegion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1657, 1707);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10909, 1664, 1673) || ((badRegion && DynAbs.Tracing.TraceSender.Conditional_F2(10909, 1676, 1697)) || DynAbs.Tracing.TraceSender.Conditional_F3(10909, 1700, 1706))) ? f_10909_1676_1697() : result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10909, 1736, 1805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1776, 1790);

                    f_10909_1776_1789(walker);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10909, 1736, 1805);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10909, 936, 1816);

                Microsoft.CodeAnalysis.CSharp.UnassignedVariablesWalker
                f_10909_1213_1269(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.BoundNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnassignedVariablesWalker(compilation, member, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1213, 1269);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10909_1609_1638(Microsoft.CodeAnalysis.CSharp.UnassignedVariablesWalker
                this_param, ref bool
                badRegion)
                {
                    var return_v = this_param.Analyze(ref badRegion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1609, 1638);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10909_1676_1697()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1676, 1697);
                    return return_v;
                }


                int
                f_10909_1776_1789(Microsoft.CodeAnalysis.CSharp.UnassignedVariablesWalker
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1776, 1789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10909, 936, 1816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 936, 1816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly HashSet<Symbol> _result;

        private HashSet<Symbol> Analyze(ref bool badRegion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10909, 1905, 2055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 1981, 2015);

                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Analyze(ref badRegion, null), 10909, 1981, 2014);
                base.Analyze(ref badRegion, null);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1981, 2014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2029, 2044);

                return _result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10909, 1905, 2055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10909, 1905, 2055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 1905, 2055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ReportUnassigned(Symbol symbol, SyntaxNode node, int slot, bool skipIfUseBeforeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10909, 2067, 2569);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2262, 2558) || true) && (f_10909_2266_2277(symbol) != SymbolKind.Field)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10909, 2262, 2558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2331, 2351);

                    f_10909_2331_2350(_result, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10909, 2262, 2558);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10909, 2262, 2558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2417, 2455);

                    f_10909_2417_2454(_result, f_10909_2429_2453(this, slot));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2473, 2543);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassigned(symbol, node, slot, skipIfUseBeforeDeclaration), 10909, 2473, 2542);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10909, 2262, 2558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10909, 2067, 2569);

                Microsoft.CodeAnalysis.SymbolKind
                f_10909_2266_2277(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10909, 2266, 2277);
                    return return_v;
                }


                bool
                f_10909_2331_2350(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 2331, 2350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10909_2429_2453(Microsoft.CodeAnalysis.CSharp.UnassignedVariablesWalker
                this_param, int
                slot)
                {
                    var return_v = this_param.GetNonMemberSymbol(slot);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 2429, 2453);
                    return return_v;
                }


                bool
                f_10909_2417_2454(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 2417, 2454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10909, 2067, 2569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 2067, 2569);
            }
        }

        protected override void ReportUnassignedOutParameter(ParameterSymbol parameter, SyntaxNode node, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10909, 2581, 2830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2721, 2744);

                f_10909_2721_2743(_result, parameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10909, 2758, 2819);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReportUnassignedOutParameter(parameter, node, location), 10909, 2758, 2818);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10909, 2581, 2830);

                bool
                f_10909_2721_2743(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 2721, 2743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10909, 2581, 2830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 2581, 2830);
            }
        }

        static UnassignedVariablesWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10909, 637, 2837);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10909, 637, 2837);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10909, 637, 2837);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10909, 637, 2837);

        static Microsoft.CodeAnalysis.CSharp.EmptyStructTypeCache
        f_10909_862_901()
        {
            var return_v = EmptyStructTypeCache.CreateNeverEmpty();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 862, 901);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10909_835_846_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10909, 719, 924);
            return return_v;
        }


        System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10909_1871_1892()
        {
            var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10909, 1871, 1892);
            return return_v;
        }

    }
}
