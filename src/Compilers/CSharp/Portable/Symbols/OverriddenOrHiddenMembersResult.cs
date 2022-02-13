// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class OverriddenOrHiddenMembersResult
    {
        public static readonly OverriddenOrHiddenMembersResult Empty;

        private readonly ImmutableArray<Symbol> _overriddenMembers;

        public ImmutableArray<Symbol> OverriddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10141, 1025, 1059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1031, 1057);

                    return _overriddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10141, 1025, 1059);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 975, 1061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 975, 1061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ImmutableArray<Symbol> _hiddenMembers;

        public ImmutableArray<Symbol> HiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10141, 1184, 1214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1190, 1212);

                    return _hiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10141, 1184, 1214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 1138, 1216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 1138, 1216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private OverriddenOrHiddenMembersResult(
                    ImmutableArray<Symbol> overriddenMembers,
                    ImmutableArray<Symbol> hiddenMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10141, 1228, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1399, 1438);

                _overriddenMembers = overriddenMembers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1452, 1483);

                _hiddenMembers = hiddenMembers;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10141, 1228, 1494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 1228, 1494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 1228, 1494);
            }
        }

        public static OverriddenOrHiddenMembersResult Create(
                    ImmutableArray<Symbol> overriddenMembers,
                    ImmutableArray<Symbol> hiddenMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10141, 1506, 1960);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1690, 1949) || true) && (overriddenMembers.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10141, 1694, 1744) && hiddenMembers.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 1690, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1778, 1791);

                    return Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 1690, 1949);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 1690, 1949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 1857, 1934);

                    return f_10141_1864_1933(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 1690, 1949);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10141, 1506, 1960);

                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10141_1864_1933(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 1864, 1933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 1506, 1960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 1506, 1960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol GetOverriddenMember(Symbol substitutedOverridingMember, Symbol overriddenByDefinitionMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10141, 1972, 3446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2112, 2168);

                f_10141_2112_2167(f_10141_2125_2166_M(!substitutedOverridingMember.IsDefinition));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2184, 3407) || true) && ((object)overriddenByDefinitionMember != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 2184, 3407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2266, 2361);

                    NamedTypeSymbol
                    overriddenByDefinitionContaining = f_10141_2317_2360(overriddenByDefinitionMember)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2379, 2496);

                    NamedTypeSymbol
                    overriddenByDefinitionContainingTypeDefinition = f_10141_2444_2495(overriddenByDefinitionContaining)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2535, 2617);
                        for (NamedTypeSymbol
        baseType = f_10141_2546_2617(f_10141_2546_2588(substitutedOverridingMember))
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2514, 3335) || true) && ((object)baseType != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2687, 2735)
        , baseType = f_10141_2698_2735(baseType), DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 2514, 3335))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 2514, 3335);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2777, 3316) || true) && (f_10141_2781_2912(f_10141_2799_2826(baseType), overriddenByDefinitionContainingTypeDefinition, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 2777, 3316);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 2962, 3185) || true) && (f_10141_2966_3064(baseType, overriddenByDefinitionContaining, TypeCompareKind.ConsiderEverything2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 2962, 3185);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3122, 3158);

                                    return overriddenByDefinitionMember;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 2962, 3185);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3213, 3293);

                                return f_10141_3220_3292(f_10141_3220_3267(overriddenByDefinitionMember), baseType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 2777, 3316);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10141, 1, 822);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10141, 1, 822);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3355, 3392);

                    throw f_10141_3361_3391();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 2184, 3407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3423, 3435);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10141, 1972, 3446);

                bool
                f_10141_2125_2166_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2125, 2166);
                    return return_v;
                }


                int
                f_10141_2112_2167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 2112, 2167);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2317_2360(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2317, 2360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2444_2495(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2444, 2495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2546_2588(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2546, 2588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2546_2617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2546, 2617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2698_2735(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2698, 2735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10141_2799_2826(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 2799, 2826);
                    return return_v;
                }


                bool
                f_10141_2781_2912(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 2781, 2912);
                    return return_v;
                }


                bool
                f_10141_2966_3064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 2966, 3064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10141_3220_3267(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 3220, 3267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10141_3220_3292(Microsoft.CodeAnalysis.CSharp.Symbol
                s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = s.SymbolAsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 3220, 3292);
                    return return_v;
                }


                System.Exception
                f_10141_3361_3391()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 3361, 3391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 1972, 3446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 1972, 3446);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Symbol GetOverriddenMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10141, 3765, 4143);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3827, 4104);
                    foreach (var overriddenMember in f_10141_3860_3878_I(_overriddenMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 3827, 4104);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 3912, 4089) || true) && (f_10141_3916_3943(overriddenMember) || (DynAbs.Tracing.TraceSender.Expression_False(10141, 3916, 3973) || f_10141_3947_3973(overriddenMember)) || (DynAbs.Tracing.TraceSender.Expression_False(10141, 3916, 4004) || f_10141_3977_4004(overriddenMember)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10141, 3912, 4089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 4046, 4070);

                            return overriddenMember;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 3912, 4089);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10141, 3827, 4104);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10141, 1, 278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10141, 1, 278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 4120, 4132);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10141, 3765, 4143);

                bool
                f_10141_3916_3943(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 3916, 3943);
                    return return_v;
                }


                bool
                f_10141_3947_3973(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 3947, 3973);
                    return return_v;
                }


                bool
                f_10141_3977_4004(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10141, 3977, 4004);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10141_3860_3878_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 3860, 3878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10141, 3765, 4143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 3765, 4143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OverriddenOrHiddenMembersResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10141, 617, 4150);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10141, 742, 893);
            Empty = f_10141_763_893(ImmutableArray<Symbol>.Empty, ImmutableArray<Symbol>.Empty); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10141, 617, 4150);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10141, 617, 4150);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10141, 617, 4150);

        static Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
        f_10141_763_893(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        hiddenMembers)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult(overriddenMembers, hiddenMembers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10141, 763, 893);
            return return_v;
        }

    }
}
