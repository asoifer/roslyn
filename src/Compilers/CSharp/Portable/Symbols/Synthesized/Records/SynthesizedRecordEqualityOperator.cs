// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordEqualityOperator : SynthesizedRecordEqualityOperatorBase
    {
        public SynthesizedRecordEqualityOperator(SourceMemberContainerTypeSymbol containingType, int memberOffset, DiagnosticBag diagnostics)
        : base(f_10723_1324_1338_C(containingType), WellKnownMemberNames.EqualityOperatorName, memberOffset, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10723, 1170, 1431);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10723, 1170, 1431);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10723, 1170, 1431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10723, 1170, 1431);
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10723, 1443, 3452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 1575, 1689);

                var
                F = f_10723_1583_1688(this, f_10723_1619_1656(f_10723_1619_1633()), compilationState, diagnostics)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 1823, 1851);

                    MethodSymbol?
                    equals = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 1869, 2485);
                        foreach (var member in f_10723_1892_1952_I(f_10723_1892_1952(f_10723_1892_1906(), WellKnownMemberNames.ObjectEquals)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10723, 1869, 2485);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 1994, 2466) || true) && (member is MethodSymbol candidate && (DynAbs.Tracing.TraceSender.Expression_True(10723, 1998, 2063) && f_10723_2034_2058(candidate) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10723, 1998, 2114) && f_10723_2067_2098(f_10723_2067_2087(candidate)[0]) == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10723, 1998, 2205) && f_10723_2143_2175(f_10723_2143_2163(candidate)) == SpecialType.System_Boolean) && (DynAbs.Tracing.TraceSender.Expression_True(10723, 1998, 2228) && f_10723_2209_2228_M(!candidate.IsStatic)) && (DynAbs.Tracing.TraceSender.Expression_True(10723, 1998, 2342) && f_10723_2257_2342(f_10723_2257_2285(f_10723_2257_2277(candidate)[0]), f_10723_2293_2307(), TypeCompareKind.AllIgnoreOptions)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10723, 1994, 2466);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2392, 2411);

                                equals = candidate;
                                DynAbs.Tracing.TraceSender.TraceBreak(10723, 2437, 2443);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10723, 1994, 2466);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10723, 1869, 2485);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10723, 1, 617);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10723, 1, 617);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2505, 2732) || true) && (equals is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10723, 2505, 2732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2655, 2684);

                        f_10723_2655_2683(                    // Unable to locate expected method, an error was reported elsewhere
                                            F, f_10723_2669_2682(F));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2706, 2713);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10723, 2505, 2732);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2752, 2788);

                    var
                    r1 = f_10723_2761_2787(F, f_10723_2773_2783()[0])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2806, 2842);

                    var
                    r2 = f_10723_2815_2841(F, f_10723_2827_2837()[1])
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2862, 2914);

                    BoundExpression
                    objectEqual = f_10723_2892_2913(F, r1, r2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 2932, 3133);

                    BoundExpression
                    recordEquals = f_10723_2963_3132(F, f_10723_2976_3046(F, r1, f_10723_2997_3045(F, f_10723_3004_3044(F, SpecialType.System_Object))), f_10723_3109_3131(F, r1, equals, r2))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 3153, 3226);

                    f_10723_3153_3225(
                                    F, f_10723_3167_3224(F, f_10723_3175_3223(F, f_10723_3184_3222(F, objectEqual, recordEquals))));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10723, 3255, 3441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 3348, 3379);

                    f_10723_3348_3378(diagnostics, f_10723_3364_3377(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10723, 3397, 3426);

                    f_10723_3397_3425(F, f_10723_3411_3424(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10723, 3255, 3441);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10723, 1443, 3452);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10723_1619_1633()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 1619, 1633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10723_1619_1656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 1619, 1656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10723_1583_1688(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordEqualityOperator
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 1583, 1688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10723_1892_1906()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 1892, 1906);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10723_1892_1952(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 1892, 1952);
                    return return_v;
                }


                int
                f_10723_2034_2058(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2034, 2058);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10723_2067_2087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2067, 2087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10723_2067_2098(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2067, 2098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10723_2143_2163(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2143, 2163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10723_2143_2175(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2143, 2175);
                    return return_v;
                }


                bool
                f_10723_2209_2228_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2209, 2228);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10723_2257_2277(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2257, 2277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10723_2257_2285(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2257, 2285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10723_2293_2307()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2293, 2307);
                    return return_v;
                }


                bool
                f_10723_2257_2342(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2257, 2342);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10723_1892_1952_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 1892, 1952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10723_2669_2682(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2669, 2682);
                    return return_v;
                }


                int
                f_10723_2655_2683(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2655, 2683);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10723_2773_2783()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2773, 2783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10723_2761_2787(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2761, 2787);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10723_2827_2837()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 2827, 2837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10723_2815_2841(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2815, 2841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10723_2892_2913(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                right)
                {
                    var return_v = this_param.ObjectEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2892, 2913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10723_3004_3044(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3004, 3044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10723_2997_3045(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2997, 3045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10723_2976_3046(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.ObjectNotEqual((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2976, 3046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10723_3109_3131(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3109, 3131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10723_2963_3132(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.LogicalAnd((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 2963, 3132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10723_3184_3222(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.LogicalOr(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3184, 3222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10723_3175_3223(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3175, 3223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10723_3167_3224(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3167, 3224);
                    return return_v;
                }


                int
                f_10723_3153_3225(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3153, 3225);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10723_3364_3377(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10723, 3364, 3377);
                    return return_v;
                }


                int
                f_10723_3348_3378(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3348, 3378);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10723_3411_3424(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3411, 3424);
                    return return_v;
                }


                int
                f_10723_3397_3425(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10723, 3397, 3425);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10723, 1443, 3452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10723, 1443, 3452);
            }
        }

        static SynthesizedRecordEqualityOperator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10723, 1058, 3459);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10723, 1058, 3459);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10723, 1058, 3459);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10723, 1058, 3459);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10723_1324_1338_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10723, 1170, 1431);
            return return_v;
        }

    }
}
