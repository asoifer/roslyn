// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class OverriddenOrHiddenMembersHelpers
    {
        internal static OverriddenOrHiddenMembersResult MakeOverriddenOrHiddenMembers(this MethodSymbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 840, 1030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 968, 1019);

                return f_10140_975_1018(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 840, 1030);

                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_975_1018(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = MakeOverriddenOrHiddenMembersWorker((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 975, 1018);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 840, 1030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 840, 1030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static OverriddenOrHiddenMembersResult MakeOverriddenOrHiddenMembers(this PropertySymbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 1042, 1234);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 1172, 1223);

                return f_10140_1179_1222(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 1042, 1234);

                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_1179_1222(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                member)
                {
                    var return_v = MakeOverriddenOrHiddenMembersWorker((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 1179, 1222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 1042, 1234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 1042, 1234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static OverriddenOrHiddenMembersResult MakeOverriddenOrHiddenMembers(this EventSymbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 1246, 1435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 1373, 1424);

                return f_10140_1380_1423(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 1246, 1435);

                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_1380_1423(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                member)
                {
                    var return_v = MakeOverriddenOrHiddenMembersWorker((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 1380, 1423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 1246, 1435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 1246, 1435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static OverriddenOrHiddenMembersResult MakeOverriddenOrHiddenMembersWorker(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 4531, 7794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 4653, 4773);

                f_10140_4653_4772(f_10140_4666_4677(member) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10140, 4666, 4736) || f_10140_4702_4713(member) == SymbolKind.Property) || (DynAbs.Tracing.TraceSender.Expression_False(10140, 4666, 4771) || f_10140_4740_4751(member) == SymbolKind.Event));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 4789, 4913) || true) && (!f_10140_4794_4819(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 4789, 4913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 4853, 4898);

                    return OverriddenOrHiddenMembersResult.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 4789, 4913);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 4929, 5893) || true) && (f_10140_4933_4952(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 4929, 5893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5103, 5150);

                    MethodSymbol
                    accessor = member as MethodSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5168, 5229);

                    Symbol
                    associatedPropertyOrEvent = f_10140_5203_5228(accessor)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5247, 5878) || true) && ((object)associatedPropertyOrEvent != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 5247, 5878);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5334, 5859) || true) && (f_10140_5338_5368(associatedPropertyOrEvent) == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 5334, 5859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5441, 5547);

                            return f_10140_5448_5546(accessor, associatedPropertyOrEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 5334, 5859);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 5334, 5859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5645, 5710);

                            f_10140_5645_5709(f_10140_5658_5688(associatedPropertyOrEvent) == SymbolKind.Event);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5736, 5836);

                            return f_10140_5743_5835(accessor, associatedPropertyOrEvent);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 5334, 5859);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 5247, 5878);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 4929, 5893);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5909, 5944);

                f_10140_5909_5943(!f_10140_5923_5942(member));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 5960, 6015);

                NamedTypeSymbol
                containingType = f_10140_5993_6014(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7047, 7121);

                bool
                memberIsFromSomeCompilation = f_10140_7082_7120(member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7137, 7299) || true) && (f_10140_7141_7167(containingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 7137, 7299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7201, 7284);

                    return f_10140_7208_7283(member, memberIsFromSomeCompilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 7137, 7299);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7315, 7350);

                ArrayBuilder<Symbol>
                hiddenBuilder
                = default(ArrayBuilder<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7364, 7405);

                ImmutableArray<Symbol>
                overriddenMembers
                = default(ImmutableArray<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7419, 7544);

                f_10140_7419_7543(member, containingType, memberIsFromSomeCompilation, out hiddenBuilder, out overriddenMembers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7560, 7689);

                ImmutableArray<Symbol>
                hiddenMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 7599, 7620) || ((hiddenBuilder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 7623, 7651)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 7654, 7688))) ? ImmutableArray<Symbol>.Empty : f_10140_7654_7688(hiddenBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 7703, 7783);

                return f_10140_7710_7782(overriddenMembers, hiddenMembers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 4531, 7794);

                Microsoft.CodeAnalysis.SymbolKind
                f_10140_4666_4677(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 4666, 4677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_4702_4713(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 4702, 4713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_4740_4751(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 4740, 4751);
                    return return_v;
                }


                int
                f_10140_4653_4772(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 4653, 4772);
                    return 0;
                }


                bool
                f_10140_4794_4819(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = CanOverrideOrHide(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 4794, 4819);
                    return return_v;
                }


                bool
                f_10140_4933_4952(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 4933, 4952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10140_5203_5228(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 5203, 5228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_5338_5368(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 5338, 5368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_5448_5546(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbol
                associatedProperty)
                {
                    var return_v = MakePropertyAccessorOverriddenOrHiddenMembers(accessor, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)associatedProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 5448, 5546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_5658_5688(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 5658, 5688);
                    return return_v;
                }


                int
                f_10140_5645_5709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 5645, 5709);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_5743_5835(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbol
                associatedEvent)
                {
                    var return_v = MakeEventAccessorOverriddenOrHiddenMembers(accessor, (Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol)associatedEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 5743, 5835);
                    return return_v;
                }


                bool
                f_10140_5923_5942(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 5923, 5942);
                    return return_v;
                }


                int
                f_10140_5909_5943(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 5909, 5943);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_5993_6014(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 5993, 6014);
                    return return_v;
                }


                bool
                f_10140_7082_7120(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Dangerous_IsFromSomeCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 7082, 7120);
                    return return_v;
                }


                bool
                f_10140_7141_7167(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 7141, 7167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_7208_7283(Microsoft.CodeAnalysis.CSharp.Symbol
                member, bool
                memberIsFromSomeCompilation)
                {
                    var return_v = MakeInterfaceOverriddenOrHiddenMembers(member, memberIsFromSomeCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 7208, 7283);
                    return return_v;
                }


                int
                f_10140_7419_7543(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, bool
                memberIsFromSomeCompilation, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers)
                {
                    FindOverriddenOrHiddenMembers(member, containingType, memberIsFromSomeCompilation, out hiddenBuilder, out overriddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 7419, 7543);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_7654_7688(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 7654, 7688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_7710_7782(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenMembers)
                {
                    var return_v = OverriddenOrHiddenMembersResult.Create(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 7710, 7782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 4531, 7794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 4531, 7794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FindOverriddenOrHiddenMembers(Symbol member, NamedTypeSymbol containingType, bool memberIsFromSomeCompilation,
                    out ArrayBuilder<Symbol> hiddenBuilder,
                    out ImmutableArray<Symbol> overriddenMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 7806, 9924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8073, 8097);

                Symbol
                bestMatch = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8111, 8132);

                hiddenBuilder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8380, 8936);

                Symbol
                knownOverriddenMember = member switch
                {
                    MethodSymbol method when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8457, 8514) && DynAbs.Tracing.TraceSender.Expression_True(10140, 8457, 8514))
=> f_10140_8480_8514(method),
                    PEPropertySymbol { GetMethod: PEMethodSymbol { ExplicitlyOverriddenClassMethod: { AssociatedSymbol: PropertySymbol overriddenProperty } } } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8533, 8694) && DynAbs.Tracing.TraceSender.Expression_True(10140, 8533, 8694))
=> overriddenProperty,
                    RetargetingPropertySymbol { GetMethod: RetargetingMethodSymbol { ExplicitlyOverriddenClassMethod: { AssociatedSymbol: PropertySymbol overriddenProperty } } } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8713, 8892) && DynAbs.Tracing.TraceSender.Expression_True(10140, 8713, 8892))
=> overriddenProperty,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8911, 8920) && DynAbs.Tracing.TraceSender.Expression_True(10140, 8911, 8920))
=> null
                }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8973, 9027);

                    for (NamedTypeSymbol
        currType = f_10140_8984_9027(containingType)
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 8952, 9607) || true) && ((object)currType != null && (DynAbs.Tracing.TraceSender.Expression_True(10140, 9046, 9099) && (object)bestMatch == null) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 9046, 9124) && hiddenBuilder == null))
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 9143, 9191)
        , currType = f_10140_9154_9191(currType), DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 8952, 9607))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 8952, 9607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 9225, 9237);

                        bool
                        unused
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 9255, 9592);

                        f_10140_9255_9591(member, memberIsFromSomeCompilation, containingType, knownOverriddenMember, currType, out bestMatch, out unused, out hiddenBuilder);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 9780, 9913);

                f_10140_9780_9912(f_10140_9799_9816(member), memberIsFromSomeCompilation, f_10140_9847_9858(member), bestMatch, out overriddenMembers, ref hiddenBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 7806, 9924);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_8480_8514(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = KnownOverriddenClassMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 8480, 8514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_8984_9027(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 8984, 9027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_9154_9191(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 9154, 9191);
                    return return_v;
                }


                int
                f_10140_9255_9591(Microsoft.CodeAnalysis.CSharp.Symbol
                member, bool
                memberIsFromSomeCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                memberContainingType, Microsoft.CodeAnalysis.CSharp.Symbol?
                knownOverriddenMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                currTypeBestMatch, out bool
                currTypeHasSameKindNonMatch, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder)
                {
                    FindOverriddenOrHiddenMembersInType(member, memberIsFromSomeCompilation, memberContainingType, knownOverriddenMember, currType, out currTypeBestMatch, out currTypeHasSameKindNonMatch, out hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 9255, 9591);
                    return 0;
                }


                bool
                f_10140_9799_9816(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 9799, 9816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_9847_9858(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 9847, 9858);
                    return return_v;
                }


                int
                f_10140_9780_9912(bool
                isOverride, bool
                overridingMemberIsFromSomeCompilation, Microsoft.CodeAnalysis.SymbolKind
                overridingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol?
                representativeMember, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                hiddenBuilder)
                {
                    FindRelatedMembers(isOverride, overridingMemberIsFromSomeCompilation, overridingMemberKind, representativeMember, out overriddenMembers, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 9780, 9912);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 7806, 9924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 7806, 9924);
            }
        }

        public static Symbol FindFirstHiddenMemberIfAny(Symbol member, bool memberIsFromSomeCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 9936, 10399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10057, 10092);

                ArrayBuilder<Symbol>
                hiddenBuilder
                = default(ArrayBuilder<Symbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10106, 10258);

                f_10140_10106_10257(member, f_10140_10144_10165(member), memberIsFromSomeCompilation, out hiddenBuilder, overriddenMembers: out _);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10274, 10322);

                // LAFHIS
                Symbol
                result = f_10140_10304_10321(hiddenBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10336, 10358);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(hiddenBuilder, 10140, 10336, 10357)?.Free(), 10140, 10350, 10357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10374, 10388);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 9936, 10399);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_10144_10165(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 10144, 10165);
                    return return_v;
                }


                int
                f_10140_10106_10257(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, bool
                memberIsFromSomeCompilation, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers)
                {
                    FindOverriddenOrHiddenMembers(member, containingType, memberIsFromSomeCompilation, out hiddenBuilder, out overriddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 10106, 10257);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10140_10304_10321(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                source)
                {
                    var return_v = source?.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 10304, 10321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 9936, 10399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 9936, 10399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol KnownOverriddenClassMethod(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10140, 10831, 11070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10847, 11070);
                return method switch
                {
                    PEMethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10893, 10946) && DynAbs.Tracing.TraceSender.Expression_True(10140, 10893, 10946))
    => f_10140_10913_10946(m),
                    RetargetingMethodSymbol m when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 10965, 11027) && DynAbs.Tracing.TraceSender.Expression_True(10140, 10965, 11027))
    => f_10140_10994_11027(m),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 11046, 11055) && DynAbs.Tracing.TraceSender.Expression_True(10140, 11046, 11055))
    => null
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(10140, 10831, 11070);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 10831, 11070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 10831, 11070);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10140_10913_10946(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
            this_param)
            {
                var return_v = this_param.ExplicitlyOverriddenClassMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 10913, 10946);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10140_10994_11027(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
            this_param)
            {
                var return_v = this_param.ExplicitlyOverriddenClassMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 10994, 11027);
                return return_v;
            }

        }

        private static OverriddenOrHiddenMembersResult MakePropertyAccessorOverriddenOrHiddenMembers(MethodSymbol accessor, PropertySymbol associatedProperty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 13436, 17313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13611, 13647);

                f_10140_13611_13646(f_10140_13624_13645(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13661, 13710);

                f_10140_13661_13709((object)associatedProperty != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13726, 13796);

                bool
                accessorIsGetter = f_10140_13750_13769(accessor) == MethodKind.PropertyGet
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13812, 13851);

                MethodSymbol
                overriddenAccessor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13865, 13907);

                ArrayBuilder<Symbol>
                hiddenBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 13923, 14031);

                OverriddenOrHiddenMembersResult
                hiddenOrOverriddenByProperty = f_10140_13986_14030(associatedProperty)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14047, 14906);
                    foreach (Symbol hiddenByProperty in f_10140_14083_14125_I(f_10140_14083_14125(hiddenOrOverriddenByProperty)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 14047, 14906);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14159, 14891) || true) && (f_10140_14163_14184(hiddenByProperty) == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 14159, 14891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14445, 14520);

                            PropertySymbol
                            propertyHiddenByProperty = (PropertySymbol)hiddenByProperty
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14542, 14670);

                            MethodSymbol
                            correspondingAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 14579, 14595) || ((accessorIsGetter && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 14598, 14632)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 14635, 14669))) ? f_10140_14598_14632(propertyHiddenByProperty) : f_10140_14635_14669(propertyHiddenByProperty)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14692, 14872) || true) && ((object)correspondingAccessor != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 14692, 14872);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14783, 14849);

                                f_10140_14783_14848(f_10140_14783_14821(ref hiddenBuilder), correspondingAccessor);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 14692, 14872);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 14159, 14891);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 14047, 14906);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 860);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 14922, 15659) || true) && (hiddenOrOverriddenByProperty.OverriddenMembers.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 14922, 15659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15135, 15247);

                    PropertySymbol
                    propertyOverriddenByProperty = (PropertySymbol)f_10140_15197_15243(hiddenOrOverriddenByProperty)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15265, 15481);

                    MethodSymbol
                    correspondingAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 15302, 15318) || ((accessorIsGetter && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 15342, 15399)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 15423, 15480))) ? f_10140_15342_15399(propertyOverriddenByProperty) : f_10140_15423_15480(propertyOverriddenByProperty)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15499, 15644) || true) && ((object)correspondingAccessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 15499, 15644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15582, 15625);

                        overriddenAccessor = correspondingAccessor;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 15499, 15644);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 14922, 15659);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15811, 15889);

                bool
                accessorIsFromSomeCompilation = f_10140_15848_15888(accessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15903, 15977);

                ImmutableArray<Symbol>
                overriddenAccessors = ImmutableArray<Symbol>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 15991, 16396) || true) && ((object)overriddenAccessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10140, 15995, 16106) && f_10140_16033_16106(overriddenAccessor, f_10140_16082_16105(accessor))) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 15995, 16175) && f_10140_16127_16175(accessor, overriddenAccessor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 15991, 16396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 16209, 16381);

                    f_10140_16209_16380(f_10140_16250_16269(accessor), accessorIsFromSomeCompilation, f_10140_16302_16315(accessor), overriddenAccessor, out overriddenAccessors, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 15991, 16396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 16412, 16541);

                ImmutableArray<Symbol>
                hiddenMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 16451, 16472) || ((hiddenBuilder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 16475, 16503)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 16506, 16540))) ? ImmutableArray<Symbol>.Empty : f_10140_16506_16540(hiddenBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 16555, 16637);

                return f_10140_16562_16636(overriddenAccessors, hiddenMembers);

                bool isAccessorOverride(MethodSymbol accessor, MethodSymbol overriddenAccessor)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10140, 16653, 17302);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 16765, 16980) || true) && (accessorIsFromSomeCompilation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 16765, 16980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 16840, 16939);

                            return f_10140_16847_16938(MemberSignatureComparer.CSharpAccessorOverrideComparer, accessor, overriddenAccessor);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 16765, 16980);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 17000, 17174) || true) && (f_10140_17004_17101(overriddenAccessor, f_10140_17030_17066(accessor), TypeCompareKind.AllIgnoreOptions))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 17000, 17174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 17143, 17155);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 17000, 17174);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 17194, 17287);

                        return f_10140_17201_17286(MemberSignatureComparer.RuntimeSignatureComparer, accessor, overriddenAccessor);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10140, 16653, 17302);

                        bool
                        f_10140_16847_16938(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member2)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16847, 16938);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10140_17030_17066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method)
                        {
                            var return_v = KnownOverriddenClassMethod(method);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 17030, 17066);
                            return return_v;
                        }


                        bool
                        f_10140_17004_17101(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        other, Microsoft.CodeAnalysis.TypeCompareKind
                        compareKind)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, compareKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 17004, 17101);
                            return return_v;
                        }


                        bool
                        f_10140_17201_17286(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        member2)
                        {
                            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 17201, 17286);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 16653, 17302);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 16653, 17302);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 13436, 17313);

                bool
                f_10140_13624_13645(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 13624, 13645);
                    return return_v;
                }


                int
                f_10140_13611_13646(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 13611, 13646);
                    return 0;
                }


                int
                f_10140_13661_13709(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 13661, 13709);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10140_13750_13769(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 13750, 13769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_13986_14030(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 13986, 14030);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_14083_14125(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.HiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 14083, 14125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_14163_14184(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 14163, 14184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_14598_14632(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 14598, 14632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_14635_14669(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 14635, 14669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_14783_14821(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                builder)
                {
                    var return_v = AccessOrGetInstance(ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 14783, 14821);
                    return return_v;
                }


                int
                f_10140_14783_14848(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 14783, 14848);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_14083_14125_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 14083, 14125);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_15197_15243(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.OverriddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 15197, 15243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10140_15342_15399(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 15342, 15399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10140_15423_15480(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 15423, 15480);
                    return return_v;
                }


                bool
                f_10140_15848_15888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Dangerous_IsFromSomeCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 15848, 15888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_16082_16105(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 16082, 16105);
                    return return_v;
                }


                bool
                f_10140_16033_16106(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridden, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                overridingContainingType)
                {
                    var return_v = IsOverriddenSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)overridden, overridingContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16033, 16106);
                    return return_v;
                }


                bool
                f_10140_16127_16175(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overriddenAccessor)
                {
                    var return_v = isAccessorOverride(accessor, overriddenAccessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16127, 16175);
                    return return_v;
                }


                bool
                f_10140_16250_16269(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 16250, 16269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_16302_16315(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 16302, 16315);
                    return return_v;
                }


                int
                f_10140_16209_16380(bool
                isOverride, bool
                overridingMemberIsFromSomeCompilation, Microsoft.CodeAnalysis.SymbolKind
                overridingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                representativeMember, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                hiddenBuilder)
                {
                    FindRelatedMembers(isOverride, overridingMemberIsFromSomeCompilation, overridingMemberKind, (Microsoft.CodeAnalysis.CSharp.Symbol)representativeMember, out overriddenMembers, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16209, 16380);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_16506_16540(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16506, 16540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_16562_16636(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenMembers)
                {
                    var return_v = OverriddenOrHiddenMembersResult.Create(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 16562, 16636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 13436, 17313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 13436, 17313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static OverriddenOrHiddenMembersResult MakeEventAccessorOverriddenOrHiddenMembers(MethodSymbol accessor, EventSymbol associatedEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 19087, 22344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19253, 19289);

                f_10140_19253_19288(f_10140_19266_19287(accessor));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19303, 19349);

                f_10140_19303_19348((object)associatedEvent != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19365, 19431);

                bool
                accessorIsAdder = f_10140_19388_19407(accessor) == MethodKind.EventAdd
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19447, 19486);

                MethodSymbol
                overriddenAccessor = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19500, 19542);

                ArrayBuilder<Symbol>
                hiddenBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19558, 19660);

                OverriddenOrHiddenMembersResult
                hiddenOrOverriddenByEvent = f_10140_19618_19659(associatedEvent)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19676, 20492);
                    foreach (Symbol hiddenByEvent in f_10140_19709_19748_I(f_10140_19709_19748(hiddenOrOverriddenByEvent)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 19676, 20492);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 19782, 20477) || true) && (f_10140_19786_19804(hiddenByEvent) == SymbolKind.Event)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 19782, 20477);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20056, 20116);

                            EventSymbol
                            eventHiddenByEvent = (EventSymbol)hiddenByEvent
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20138, 20256);

                            MethodSymbol
                            correspondingAccessor = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 20175, 20190) || ((accessorIsAdder && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 20193, 20221)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 20224, 20255))) ? f_10140_20193_20221(eventHiddenByEvent) : f_10140_20224_20255(eventHiddenByEvent)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20278, 20458) || true) && ((object)correspondingAccessor != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 20278, 20458);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20369, 20435);

                                f_10140_20369_20434(f_10140_20369_20407(ref hiddenBuilder), correspondingAccessor);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 20278, 20458);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 19782, 20477);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 19676, 20492);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 817);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20508, 21114) || true) && (hiddenOrOverriddenByEvent.OverriddenMembers.Any())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 20508, 21114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20718, 20815);

                    EventSymbol
                    eventOverriddenByEvent = (EventSymbol)f_10140_20768_20811(hiddenOrOverriddenByEvent)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20833, 20936);

                    MethodSymbol
                    correspondingAccessor = f_10140_20870_20935(eventOverriddenByEvent, accessorIsAdder)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 20954, 21099) || true) && ((object)correspondingAccessor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 20954, 21099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 21037, 21080);

                        overriddenAccessor = correspondingAccessor;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 20954, 21099);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 20508, 21114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 21266, 21344);

                bool
                accessorIsFromSomeCompilation = f_10140_21303_21343(accessor)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 21358, 21432);

                ImmutableArray<Symbol>
                overriddenAccessors = ImmutableArray<Symbol>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 21446, 22092) || true) && ((object)overriddenAccessor != null && (DynAbs.Tracing.TraceSender.Expression_True(10140, 21450, 21561) && f_10140_21488_21561(overriddenAccessor, f_10140_21537_21560(accessor))) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 21450, 21871) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10140, 21587, 21616) || ((accessorIsFromSomeCompilation
                && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 21644, 21735)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 21785, 21870))) ? f_10140_21644_21735(MemberSignatureComparer.CSharpAccessorOverrideComparer, accessor, overriddenAccessor) : f_10140_21785_21870(MemberSignatureComparer.RuntimeSignatureComparer, accessor, overriddenAccessor))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 21446, 22092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 21905, 22077);

                    f_10140_21905_22076(f_10140_21946_21965(accessor), accessorIsFromSomeCompilation, f_10140_21998_22011(accessor), overriddenAccessor, out overriddenAccessors, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 21446, 22092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 22108, 22237);

                ImmutableArray<Symbol>
                hiddenMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 22147, 22168) || ((hiddenBuilder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 22171, 22199)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 22202, 22236))) ? ImmutableArray<Symbol>.Empty : f_10140_22202_22236(hiddenBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 22251, 22333);

                return f_10140_22258_22332(overriddenAccessors, hiddenMembers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 19087, 22344);

                bool
                f_10140_19266_19287(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 19266, 19287);
                    return return_v;
                }


                int
                f_10140_19253_19288(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 19253, 19288);
                    return 0;
                }


                int
                f_10140_19303_19348(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 19303, 19348);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10140_19388_19407(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 19388, 19407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_19618_19659(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 19618, 19659);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_19709_19748(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.HiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 19709, 19748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_19786_19804(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 19786, 19804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10140_20193_20221(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 20193, 20221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10140_20224_20255(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 20224, 20255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_20369_20407(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                builder)
                {
                    var return_v = AccessOrGetInstance(ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 20369, 20407);
                    return return_v;
                }


                int
                f_10140_20369_20434(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 20369, 20434);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_19709_19748_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 19709, 19748);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_20768_20811(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                this_param)
                {
                    var return_v = this_param.OverriddenMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 20768, 20811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_20870_20935(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                @event, bool
                isAdder)
                {
                    var return_v = @event.GetOwnOrInheritedAccessor(isAdder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 20870, 20935);
                    return return_v;
                }


                bool
                f_10140_21303_21343(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Dangerous_IsFromSomeCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 21303, 21343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_21537_21560(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 21537, 21560);
                    return return_v;
                }


                bool
                f_10140_21488_21561(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                overridden, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                overridingContainingType)
                {
                    var return_v = IsOverriddenSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)overridden, overridingContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 21488, 21561);
                    return return_v;
                }


                bool
                f_10140_21644_21735(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member2)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 21644, 21735);
                    return return_v;
                }


                bool
                f_10140_21785_21870(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member2)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 21785, 21870);
                    return return_v;
                }


                bool
                f_10140_21946_21965(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 21946, 21965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_21998_22011(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 21998, 22011);
                    return return_v;
                }


                int
                f_10140_21905_22076(bool
                isOverride, bool
                overridingMemberIsFromSomeCompilation, Microsoft.CodeAnalysis.SymbolKind
                overridingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                representativeMember, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                hiddenBuilder)
                {
                    FindRelatedMembers(isOverride, overridingMemberIsFromSomeCompilation, overridingMemberKind, (Microsoft.CodeAnalysis.CSharp.Symbol)representativeMember, out overriddenMembers, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 21905, 22076);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_22202_22236(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 22202, 22236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_22258_22332(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenMembers)
                {
                    var return_v = OverriddenOrHiddenMembersResult.Create(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 22258, 22332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 19087, 22344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 19087, 22344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static OverriddenOrHiddenMembersResult MakeInterfaceOverriddenOrHiddenMembers(Symbol member, bool memberIsFromSomeCompilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 23975, 28752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24135, 24170);

                f_10140_24135_24169(!f_10140_24149_24168(member));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24186, 24241);

                NamedTypeSymbol
                containingType = f_10140_24219_24240(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24255, 24302);

                f_10140_24255_24301(f_10140_24268_24300(containingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24318, 24422);

                PooledHashSet<NamedTypeSymbol>
                membersOfOtherKindsHidden = f_10140_24377_24421()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24436, 24531);

                PooledHashSet<NamedTypeSymbol>
                allMembersHidden = f_10140_24486_24530()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24585, 24627);

                ArrayBuilder<Symbol>
                hiddenBuilder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24643, 27551);
                    foreach (NamedTypeSymbol currType in f_10140_24680_24728_I(f_10140_24680_24728(containingType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 24643, 27551);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24790, 24899) || true) && (f_10140_24794_24829(allMembersHidden, currType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 24790, 24899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24871, 24880);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 24790, 24899);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24919, 24944);

                        Symbol
                        currTypeBestMatch
                        = default(Symbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 24962, 24995);

                        bool
                        currTypeHasSameKindNonMatch
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25013, 25056);

                        ArrayBuilder<Symbol>
                        currTypeHiddenBuilder
                        = default(ArrayBuilder<Symbol>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25076, 25456);

                        f_10140_25076_25455(member, memberIsFromSomeCompilation, containingType, knownOverriddenMember: null, currType, out currTypeBestMatch, out currTypeHasSameKindNonMatch, out currTypeHiddenBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25476, 25531);

                        bool
                        haveBestMatch = (object)currTypeBestMatch != null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25551, 26054) || true) && (haveBestMatch)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 25551, 26054);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25782, 25949);
                                foreach (var hidden in f_10140_25805_25847_I(f_10140_25805_25847(currType)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 25782, 25949);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25897, 25926);

                                    f_10140_25897_25925(allMembersHidden, hidden);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 25782, 25949);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 168);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 168);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 25973, 26035);

                            f_10140_25973_26034(f_10140_25973_26011(ref hiddenBuilder), currTypeBestMatch);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 25551, 26054);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26074, 27536) || true) && (currTypeHiddenBuilder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 26074, 27536);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26442, 26957) || true) && (!f_10140_26447_26491(membersOfOtherKindsHidden, currType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 26442, 26957);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26541, 26835) || true) && (!haveBestMatch)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 26541, 26835);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26617, 26808);
                                        foreach (var hidden in f_10140_26640_26682_I(f_10140_26640_26682(currType)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 26617, 26808);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26748, 26777);

                                            f_10140_26748_26776(allMembersHidden, hidden);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 26617, 26808);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 192);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 192);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 26541, 26835);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26863, 26934);

                                f_10140_26863_26933(f_10140_26863_26901(ref hiddenBuilder), currTypeHiddenBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 26442, 26957);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 26981, 27010);

                            f_10140_26981_27009(
                                                currTypeHiddenBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 26074, 27536);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 26074, 27536);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27052, 27536) || true) && (currTypeHasSameKindNonMatch && (DynAbs.Tracing.TraceSender.Expression_True(10140, 27056, 27101) && !haveBestMatch))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 27052, 27536);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27341, 27517);
                                    foreach (var hidden in f_10140_27364_27406_I(f_10140_27364_27406(currType)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 27341, 27517);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27456, 27494);

                                        f_10140_27456_27493(membersOfOtherKindsHidden, hidden);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 27341, 27517);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 177);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 177);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 27052, 27536);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 26074, 27536);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 24643, 27551);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 2909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 2909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27567, 27600);

                f_10140_27567_27599(
                            membersOfOtherKindsHidden);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27614, 27638);

                f_10140_27614_27637(allMembersHidden);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27811, 27883);

                ImmutableArray<Symbol>
                overriddenMembers = ImmutableArray<Symbol>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27899, 28446) || true) && (hiddenBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 27899, 28446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 27958, 28010);

                    ArrayBuilder<Symbol>
                    hiddenAndRelatedBuilder = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28028, 28334);
                        foreach (Symbol hidden in f_10140_28054_28067_I(hiddenBuilder))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 28028, 28334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28109, 28249);

                            f_10140_28109_28248(f_10140_28128_28145(member), memberIsFromSomeCompilation, f_10140_28176_28187(member), hidden, out overriddenMembers, ref hiddenAndRelatedBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28271, 28315);

                            f_10140_28271_28314(overriddenMembers.Length == 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 28028, 28334);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 307);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 307);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28352, 28373);

                    f_10140_28352_28372(hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28391, 28431);

                    hiddenBuilder = hiddenAndRelatedBuilder;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 27899, 28446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28462, 28502);

                f_10140_28462_28501(overriddenMembers.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28518, 28647);

                ImmutableArray<Symbol>
                hiddenMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 28557, 28578) || ((hiddenBuilder == null && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 28581, 28609)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 28612, 28646))) ? ImmutableArray<Symbol>.Empty : f_10140_28612_28646(hiddenBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 28661, 28741);

                return f_10140_28668_28740(overriddenMembers, hiddenMembers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 23975, 28752);

                bool
                f_10140_24149_24168(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24149, 24168);
                    return return_v;
                }


                int
                f_10140_24135_24169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24135, 24169);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_24219_24240(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 24219, 24240);
                    return return_v;
                }


                bool
                f_10140_24268_24300(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24268, 24300);
                    return return_v;
                }


                int
                f_10140_24255_24301(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24255, 24301);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_24377_24421()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24377, 24421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_24486_24530()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24486, 24530);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_24680_24728(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 24680, 24728);
                    return return_v;
                }


                bool
                f_10140_24794_24829(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24794, 24829);
                    return return_v;
                }


                int
                f_10140_25076_25455(Microsoft.CodeAnalysis.CSharp.Symbol
                member, bool
                memberIsFromSomeCompilation, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                memberContainingType, Microsoft.CodeAnalysis.CSharp.Symbol
                knownOverriddenMember, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                currType, out Microsoft.CodeAnalysis.CSharp.Symbol
                currTypeBestMatch, out bool
                currTypeHasSameKindNonMatch, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder)
                {
                    FindOverriddenOrHiddenMembersInType(member, memberIsFromSomeCompilation, memberContainingType, knownOverriddenMember: knownOverriddenMember, currType, out currTypeBestMatch, out currTypeHasSameKindNonMatch, out hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 25076, 25455);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_25805_25847(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 25805, 25847);
                    return return_v;
                }


                bool
                f_10140_25897_25925(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 25897, 25925);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_25805_25847_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 25805, 25847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_25973_26011(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                builder)
                {
                    var return_v = AccessOrGetInstance(ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 25973, 26011);
                    return return_v;
                }


                int
                f_10140_25973_26034(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 25973, 26034);
                    return 0;
                }


                bool
                f_10140_26447_26491(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26447, 26491);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_26640_26682(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 26640, 26682);
                    return return_v;
                }


                bool
                f_10140_26748_26776(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26748, 26776);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_26640_26682_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26640, 26682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_26863_26901(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                builder)
                {
                    var return_v = AccessOrGetInstance(ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26863, 26901);
                    return return_v;
                }


                int
                f_10140_26863_26933(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26863, 26933);
                    return 0;
                }


                int
                f_10140_26981_27009(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 26981, 27009);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_27364_27406(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 27364, 27406);
                    return return_v;
                }


                bool
                f_10140_27456_27493(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 27456, 27493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_27364_27406_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 27364, 27406);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10140_24680_24728_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 24680, 24728);
                    return return_v;
                }


                int
                f_10140_27567_27599(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 27567, 27599);
                    return 0;
                }


                int
                f_10140_27614_27637(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 27614, 27637);
                    return 0;
                }


                bool
                f_10140_28128_28145(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 28128, 28145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_28176_28187(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 28176, 28187);
                    return return_v;
                }


                int
                f_10140_28109_28248(bool
                isOverride, bool
                overridingMemberIsFromSomeCompilation, Microsoft.CodeAnalysis.SymbolKind
                overridingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol
                representativeMember, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                hiddenBuilder)
                {
                    FindRelatedMembers(isOverride, overridingMemberIsFromSomeCompilation, overridingMemberKind, representativeMember, out overriddenMembers, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28109, 28248);
                    return 0;
                }


                int
                f_10140_28271_28314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28271, 28314);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_28054_28067_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28054, 28067);
                    return return_v;
                }


                int
                f_10140_28352_28372(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28352, 28372);
                    return 0;
                }


                int
                f_10140_28462_28501(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28462, 28501);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_28612_28646(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28612, 28646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                f_10140_28668_28740(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenMembers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenMembers)
                {
                    var return_v = OverriddenOrHiddenMembersResult.Create(overriddenMembers, hiddenMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 28668, 28740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 23975, 28752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 23975, 28752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FindOverriddenOrHiddenMembersInType(
                    Symbol member,
                    bool memberIsFromSomeCompilation,
                    NamedTypeSymbol memberContainingType,
                    Symbol knownOverriddenMember,
                    NamedTypeSymbol currType,
                    out Symbol currTypeBestMatch,
                    out bool currTypeHasSameKindNonMatch,
                    out ArrayBuilder<Symbol> hiddenBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 30335, 39512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30771, 30806);

                f_10140_30771_30805(!f_10140_30785_30804(member));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30822, 30847);

                currTypeBestMatch = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30861, 30897);

                currTypeHasSameKindNonMatch = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30911, 30932);

                hiddenBuilder = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30948, 30983);

                bool
                currTypeHasExactMatch = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 30997, 31039);

                int
                minCustomModifierCount = int.MaxValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31055, 31288);

                IEqualityComparer<Symbol>
                exactMatchComparer = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 31102, 31129) || ((memberIsFromSomeCompilation
                && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 31149, 31209)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 31229, 31287))) ? MemberSignatureComparer.CSharpCustomModifierOverrideComparer
                : MemberSignatureComparer.RuntimePlusRefOutSignatureComparer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31304, 31511);

                IEqualityComparer<Symbol>
                fallbackComparer = (DynAbs.Tracing.TraceSender.Conditional_F1(10140, 31349, 31376) || ((memberIsFromSomeCompilation
                && DynAbs.Tracing.TraceSender.Conditional_F2(10140, 31396, 31442)) || DynAbs.Tracing.TraceSender.Conditional_F3(10140, 31462, 31510))) ? MemberSignatureComparer.CSharpOverrideComparer
                : MemberSignatureComparer.RuntimeSignatureComparer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31527, 31563);

                SymbolKind
                memberKind = f_10140_31551_31562(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31577, 31619);

                int
                memberArity = f_10140_31595_31618(member)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31635, 35716);
                    foreach (Symbol otherMember in f_10140_31666_31698_I(f_10140_31666_31698(currType, f_10140_31686_31697(member))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 31635, 35716);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31732, 35701) || true) && (!f_10140_31737_31800(otherMember, memberContainingType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 31732, 35701);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 31732, 35701);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 31732, 35701);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 31896, 35701) || true) && (f_10140_31900_31924(otherMember) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 31900, 31984) && !f_10140_31929_31984(((MethodSymbol)otherMember))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 31896, 35701);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 31896, 35701);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 31896, 35701);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32229, 35701) || true) && (f_10140_32233_32249(otherMember) != memberKind)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32229, 35701);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32455, 32507);

                                    int
                                    otherMemberArity = f_10140_32478_32506(otherMember)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32529, 32771) || true) && (otherMemberArity == memberArity || (DynAbs.Tracing.TraceSender.Expression_False(10140, 32533, 32626) || (memberKind == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10140, 32569, 32625) && otherMemberArity == 0))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32529, 32771);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32676, 32748);

                                        f_10140_32676_32747(ref hiddenBuilder, memberKind, otherMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32529, 32771);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32229, 35701);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32229, 35701);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32813, 35701) || true) && (!currTypeHasExactMatch)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32813, 35701);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 32881, 35682);

                                        switch (memberKind)
                                        {

                                            case SymbolKind.Field:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32881, 35682);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33001, 33030);

                                                currTypeHasExactMatch = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33060, 33092);

                                                currTypeBestMatch = otherMember;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10140, 33122, 33128);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32881, 35682);

                                            case SymbolKind.NamedType:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32881, 35682);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33210, 33449) || true) && (f_10140_33214_33242(otherMember) == memberArity)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 33210, 33449);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33323, 33352);

                                                    currTypeHasExactMatch = true;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33386, 33418);

                                                    currTypeBestMatch = otherMember;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 33210, 33449);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(10140, 33479, 33485);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32881, 35682);

                                            default:
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 32881, 35682);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33551, 35621) || true) && (f_10140_33555_33630(otherMember, knownOverriddenMember, TypeCompareKind.AllIgnoreOptions))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 33551, 35621);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33696, 33725);

                                                    currTypeHasExactMatch = true;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33759, 33791);

                                                    currTypeBestMatch = otherMember;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 33551, 35621);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 33551, 35621);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 33960, 35621) || true) && (knownOverriddenMember == null)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 33960, 35621);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34059, 35590) || true) && (f_10140_34063_34109(exactMatchComparer, member, otherMember))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 34059, 35590);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34183, 34212);

                                                            currTypeHasExactMatch = true;
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34250, 34282);

                                                            currTypeBestMatch = otherMember;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 34059, 35590);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 34059, 35590);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34356, 35590) || true) && (f_10140_34360_34404(fallbackComparer, member, otherMember))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 34356, 35590);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34786, 34851);

                                                                int
                                                                methodCustomModifierCount = f_10140_34818_34850(otherMember)
                                                                ;

                                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 34889, 35374) || true) && (methodCustomModifierCount < minCustomModifierCount)
                                                                )

                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 34889, 35374);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 35025, 35168);

                                                                    f_10140_35025_35167(memberIsFromSomeCompilation || (DynAbs.Tracing.TraceSender.Expression_False(10140, 35038, 35107) || minCustomModifierCount == int.MaxValue), "Metadata members require exact custom modifier matches.");
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 35210, 35261);

                                                                    minCustomModifierCount = methodCustomModifierCount;
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 35303, 35335);

                                                                    currTypeBestMatch = otherMember;
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 34889, 35374);
                                                                }
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 34356, 35590);
                                                            }

                                                            else

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 34356, 35590);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 35520, 35555);

                                                                currTypeHasSameKindNonMatch = true;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 34356, 35590);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 34059, 35590);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 33960, 35621);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 33551, 35621);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceBreak(10140, 35653, 35659);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32881, 35682);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32813, 35701);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 32229, 35701);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 31896, 35701);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 31732, 35701);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 31635, 35716);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 4082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 4082);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 35732, 39501);

                switch (memberKind)
                {

                    case SymbolKind.Field:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 35732, 39501);
                        DynAbs.Tracing.TraceSender.TraceBreak(10140, 35872, 35878);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 35732, 39501);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 35732, 39501);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 37523, 39458) || true) && (currTypeHasExactMatch && (DynAbs.Tracing.TraceSender.Expression_True(10140, 37527, 37579) && memberIsFromSomeCompilation) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 37527, 37602) && f_10140_37583_37602(member)) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 37527, 37659) && f_10140_37606_37659(currTypeBestMatch)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 37523, 39458);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 37947, 38319);
                                foreach (ParameterSymbol param in f_10140_37981_38014_I(f_10140_37981_38014(currTypeBestMatch)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 37947, 38319);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38072, 38171);

                                    f_10140_38072_38170(!(param.TypeWithAnnotations.CustomModifiers.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10140, 38087, 38168) || param.RefCustomModifiers.Any())));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38201, 38292);

                                    f_10140_38201_38291(!f_10140_38215_38290(f_10140_38215_38225(param), flagNonDefaultArraySizesOrLowerBounds: false));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 37947, 38319);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 373);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 373);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38355, 38405);

                            Symbol
                            minCustomModifierMatch = currTypeBestMatch
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38433, 39364);
                                foreach (Symbol otherMember in f_10140_38464_38496_I(f_10140_38464_38496(currType, f_10140_38484_38495(member))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 38433, 39364);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38554, 39337) || true) && (f_10140_38558_38574(otherMember) == f_10140_38578_38600(currTypeBestMatch) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 38558, 38652) && !f_10140_38605_38652(otherMember, currTypeBestMatch)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 38554, 39337);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38718, 39306) || true) && (f_10140_38722_38807(MemberSignatureComparer.CSharpOverrideComparer, otherMember, currTypeBestMatch))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 38718, 39306);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38881, 38940);

                                            int
                                            customModifierCount = f_10140_38907_38939(otherMember)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 38978, 39271) || true) && (customModifierCount < minCustomModifierCount)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 38978, 39271);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 39108, 39153);

                                                minCustomModifierCount = customModifierCount;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 39195, 39232);

                                                minCustomModifierMatch = otherMember;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 38978, 39271);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 38718, 39306);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 38554, 39337);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 38433, 39364);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 932);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 932);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 39392, 39435);

                            currTypeBestMatch = minCustomModifierMatch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 37523, 39458);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10140, 39480, 39486);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 35732, 39501);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 30335, 39512);

                bool
                f_10140_30785_30804(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 30785, 30804);
                    return return_v;
                }


                int
                f_10140_30771_30805(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 30771, 30805);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_31551_31562(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 31551, 31562);
                    return return_v;
                }


                int
                f_10140_31595_31618(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31595, 31618);
                    return return_v;
                }


                string
                f_10140_31686_31697(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 31686, 31697);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_31666_31698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31666, 31698);
                    return return_v;
                }


                bool
                f_10140_31737_31800(Microsoft.CodeAnalysis.CSharp.Symbol
                overridden, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                overridingContainingType)
                {
                    var return_v = IsOverriddenSymbolAccessible(overridden, overridingContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31737, 31800);
                    return return_v;
                }


                bool
                f_10140_31900_31924(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31900, 31924);
                    return return_v;
                }


                bool
                f_10140_31929_31984(Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol)
                {
                    var return_v = ((MethodSymbol)methodSymbol).IsIndexedPropertyAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31929, 31984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_32233_32249(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 32233, 32249);
                    return return_v;
                }


                int
                f_10140_32478_32506(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 32478, 32506);
                    return return_v;
                }


                int
                f_10140_32676_32747(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>?
                hiddenBuilder, Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMember)
                {
                    AddHiddenMemberIfApplicable(ref hiddenBuilder, hidingMemberKind, hiddenMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 32676, 32747);
                    return 0;
                }


                int
                f_10140_33214_33242(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 33214, 33242);
                    return return_v;
                }


                bool
                f_10140_33555_33630(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 33555, 33630);
                    return return_v;
                }


                bool
                f_10140_34063_34109(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                x, Microsoft.CodeAnalysis.CSharp.Symbol
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 34063, 34109);
                    return return_v;
                }


                bool
                f_10140_34360_34404(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                x, Microsoft.CodeAnalysis.CSharp.Symbol
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 34360, 34404);
                    return return_v;
                }


                int
                f_10140_34818_34850(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = CustomModifierCount(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 34818, 34850);
                    return return_v;
                }


                int
                f_10140_35025_35167(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 35025, 35167);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_31666_31698_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 31666, 31698);
                    return return_v;
                }


                bool
                f_10140_37583_37602(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 37583, 37602);
                    return return_v;
                }


                bool
                f_10140_37606_37659(Microsoft.CodeAnalysis.CSharp.Symbol?
                member)
                {
                    var return_v = TypeOrReturnTypeHasCustomModifiers(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 37606, 37659);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10140_37981_38014(Microsoft.CodeAnalysis.CSharp.Symbol?
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 37981, 38014);
                    return return_v;
                }


                int
                f_10140_38072_38170(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38072, 38170);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10140_38215_38225(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 38215, 38225);
                    return return_v;
                }


                bool
                f_10140_38215_38290(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38215, 38290);
                    return return_v;
                }


                int
                f_10140_38201_38291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38201, 38291);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10140_37981_38014_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 37981, 38014);
                    return return_v;
                }


                string
                f_10140_38484_38495(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 38484, 38495);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_38464_38496(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38464, 38496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_38558_38574(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 38558, 38574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_38578_38600(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 38578, 38600);
                    return return_v;
                }


                bool
                f_10140_38605_38652(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38605, 38652);
                    return return_v;
                }


                bool
                f_10140_38722_38807(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38722, 38807);
                    return return_v;
                }


                int
                f_10140_38907_38939(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = CustomModifierCount(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38907, 38939);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_38464_38496_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 38464, 38496);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 30335, 39512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 30335, 39512);
            }
        }

        private static void FindRelatedMembers(
                    bool isOverride,
                    bool overridingMemberIsFromSomeCompilation,
                    SymbolKind overridingMemberKind,
                    Symbol representativeMember,
                    out ImmutableArray<Symbol> overriddenMembers,
                    ref ArrayBuilder<Symbol> hiddenBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 39896, 41827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40247, 40296);

                overriddenMembers = ImmutableArray<Symbol>.Empty;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40312, 41816) || true) && ((object)representativeMember != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 40312, 41816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40386, 40653);

                    bool
                    needToSearchForRelated = f_10140_40416_40441(representativeMember) != SymbolKind.Field && (DynAbs.Tracing.TraceSender.Expression_True(10140, 40416, 40514) && f_10140_40465_40490(representativeMember) != SymbolKind.NamedType) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 40416, 40652) && (f_10140_40566_40615_M(!f_10140_40567_40602(representativeMember).IsDefinition) || (DynAbs.Tracing.TraceSender.Expression_False(10140, 40566, 40651) || f_10140_40619_40651(representativeMember))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40673, 41801) || true) && (isOverride)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 40673, 41801);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40729, 41384) || true) && (needToSearchForRelated)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 40729, 41384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40805, 40881);

                            ArrayBuilder<Symbol>
                            overriddenBuilder = f_10140_40846_40880()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40909, 40953);

                            f_10140_40909_40952(
                                                    overriddenBuilder, representativeMember);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 40981, 41104);

                            f_10140_40981_41103(representativeMember, overridingMemberIsFromSomeCompilation, overriddenBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 41132, 41191);

                            overriddenMembers = f_10140_41152_41190(overriddenBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 40729, 41384);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 40729, 41384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 41289, 41361);

                            overriddenMembers = f_10140_41309_41360(representativeMember);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 40729, 41384);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 40673, 41801);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 40673, 41801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 41466, 41557);

                        f_10140_41466_41556(ref hiddenBuilder, overridingMemberKind, representativeMember);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 41581, 41782) || true) && (needToSearchForRelated)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 41581, 41782);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 41657, 41759);

                            f_10140_41657_41758(overridingMemberKind, representativeMember, ref hiddenBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 41581, 41782);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 40673, 41801);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 40312, 41816);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 39896, 41827);

                Microsoft.CodeAnalysis.SymbolKind
                f_10140_40416_40441(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 40416, 40441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_40465_40490(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 40465, 40490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_40567_40602(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 40567, 40602);
                    return return_v;
                }


                bool
                f_10140_40566_40615_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 40566, 40615);
                    return return_v;
                }


                bool
                f_10140_40619_40651(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 40619, 40651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_40846_40880()
                {
                    var return_v = ArrayBuilder<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 40846, 40880);
                    return return_v;
                }


                int
                f_10140_40909_40952(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 40909, 40952);
                    return 0;
                }


                int
                f_10140_40981_41103(Microsoft.CodeAnalysis.CSharp.Symbol
                representativeMember, bool
                overridingMemberIsFromSomeCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                overriddenBuilder)
                {
                    FindOtherOverriddenMethodsInContainingType(representativeMember, overridingMemberIsFromSomeCompilation, overriddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 40981, 41103);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_41152_41190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 41152, 41190);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_41309_41360(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 41309, 41360);
                    return return_v;
                }


                int
                f_10140_41466_41556(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder, Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMember)
                {
                    AddHiddenMemberIfApplicable(ref hiddenBuilder, hidingMemberKind, hiddenMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 41466, 41556);
                    return 0;
                }


                int
                f_10140_41657_41758(Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol
                representativeMember, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder)
                {
                    FindOtherHiddenMembersInContainingType(hidingMemberKind, representativeMember, ref hiddenBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 41657, 41758);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 39896, 41827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 39896, 41827);
            }
        }

        private static void AddHiddenMemberIfApplicable(ref ArrayBuilder<Symbol> hiddenBuilder, SymbolKind hidingMemberKind, Symbol hiddenMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 42132, 42584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42294, 42337);

                f_10140_42294_42336((object)hiddenMember != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42351, 42573) || true) && (f_10140_42355_42372(hiddenMember) != SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10140, 42355, 42467) || f_10140_42397_42467(((MethodSymbol)hiddenMember), hidingMemberKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 42351, 42573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42501, 42558);

                    f_10140_42501_42557(f_10140_42501_42539(ref hiddenBuilder), hiddenMember);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 42351, 42573);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 42132, 42584);

                int
                f_10140_42294_42336(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 42294, 42336);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_42355_42372(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 42355, 42372);
                    return return_v;
                }


                bool
                f_10140_42397_42467(Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMethod, Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind)
                {
                    var return_v = ((MethodSymbol)hiddenMethod).CanBeHiddenByMemberKind(hidingMemberKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 42397, 42467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_42501_42539(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder)
                {
                    var return_v = AccessOrGetInstance(ref builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 42501, 42539);
                    return return_v;
                }


                int
                f_10140_42501_42557(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 42501, 42557);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 42132, 42584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 42132, 42584);
            }
        }

        private static ArrayBuilder<T> AccessOrGetInstance<T>(ref ArrayBuilder<T> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 42596, 42853);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42703, 42811) || true) && (builder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 42703, 42811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42756, 42796);

                    builder = f_10140_42766_42795<T>();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 42703, 42811);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 42827, 42842);

                return builder;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 42596, 42853);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10140_42766_42795<T>()
                {
                    var return_v = ArrayBuilder<T>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 42766, 42795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 42596, 42853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 42596, 42853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FindOtherOverriddenMethodsInContainingType(Symbol representativeMember, bool overridingMemberIsFromSomeCompilation, ArrayBuilder<Symbol> overriddenBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 44013, 46214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44213, 44264);

                f_10140_44213_44263((object)representativeMember != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44278, 44394);

                f_10140_44278_44393(f_10140_44291_44316(representativeMember) == SymbolKind.Property || (DynAbs.Tracing.TraceSender.Expression_False(10140, 44291, 44392) || f_10140_44343_44392_M(!f_10140_44344_44379(representativeMember).IsDefinition)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44410, 44453);

                int
                representativeCustomModifierCount = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44469, 46203);
                    foreach (Symbol otherMember in f_10140_44500_44573_I(f_10140_44500_44573(f_10140_44500_44535(representativeMember), f_10140_44547_44572(representativeMember))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 44469, 46203);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44607, 46188) || true) && (f_10140_44611_44627(otherMember) == f_10140_44631_44656(representativeMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 44607, 46188);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 44698, 46169) || true) && (otherMember != representativeMember)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 44698, 46169);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45088, 46146) || true) && (overridingMemberIsFromSomeCompilation)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 45088, 46146);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45187, 45404) || true) && (representativeCustomModifierCount < 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 45187, 45404);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45294, 45373);

                                        representativeCustomModifierCount = f_10140_45330_45372(representativeMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 45187, 45404);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45436, 45767) || true) && (f_10140_45440_45528(MemberSignatureComparer.CSharpOverrideComparer, otherMember, representativeMember) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 45440, 45635) && f_10140_45565_45598(otherMember) == representativeCustomModifierCount))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 45436, 45767);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45701, 45736);

                                        f_10140_45701_45735(overriddenBuilder, otherMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 45436, 45767);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 45088, 46146);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 45088, 46146);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 45881, 46119) || true) && (f_10140_45885_45987(MemberSignatureComparer.CSharpCustomModifierOverrideComparer, otherMember, representativeMember))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 45881, 46119);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 46053, 46088);

                                        f_10140_46053_46087(overriddenBuilder, otherMember);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 45881, 46119);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 45088, 46146);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 44698, 46169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 44607, 46188);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 44469, 46203);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 1735);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 1735);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 44013, 46214);

                int
                f_10140_44213_44263(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 44213, 44263);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_44291_44316(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44291, 44316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_44344_44379(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44344, 44379);
                    return return_v;
                }


                bool
                f_10140_44343_44392_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44343, 44392);
                    return return_v;
                }


                int
                f_10140_44278_44393(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 44278, 44393);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_44500_44535(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44500, 44535);
                    return return_v;
                }


                string
                f_10140_44547_44572(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44547, 44572);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_44500_44573(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 44500, 44573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_44611_44627(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44611, 44627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_44631_44656(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 44631, 44656);
                    return return_v;
                }


                int
                f_10140_45330_45372(Microsoft.CodeAnalysis.CSharp.Symbol
                m)
                {
                    var return_v = m.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 45330, 45372);
                    return return_v;
                }


                bool
                f_10140_45440_45528(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 45440, 45528);
                    return return_v;
                }


                int
                f_10140_45565_45598(Microsoft.CodeAnalysis.CSharp.Symbol
                m)
                {
                    var return_v = m.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 45565, 45598);
                    return return_v;
                }


                int
                f_10140_45701_45735(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 45701, 45735);
                    return 0;
                }


                bool
                f_10140_45885_45987(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals(member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 45885, 45987);
                    return return_v;
                }


                int
                f_10140_46053_46087(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 46053, 46087);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_44500_44573_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 44500, 44573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 44013, 46214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 44013, 46214);
            }
        }

        private static void FindOtherHiddenMembersInContainingType(SymbolKind hidingMemberKind, Symbol representativeMember, ref ArrayBuilder<Symbol> hiddenBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 47447, 48607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 47628, 47679);

                f_10140_47628_47678((object)representativeMember != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 47693, 47753);

                f_10140_47693_47752(f_10140_47706_47731(representativeMember) != SymbolKind.Field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 47767, 47831);

                f_10140_47767_47830(f_10140_47780_47805(representativeMember) != SymbolKind.NamedType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 47845, 47961);

                f_10140_47845_47960(f_10140_47858_47883(representativeMember) == SymbolKind.Property || (DynAbs.Tracing.TraceSender.Expression_False(10140, 47858, 47959) || f_10140_47910_47959_M(!f_10140_47911_47946(representativeMember).IsDefinition)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 47977, 48075);

                IEqualityComparer<Symbol>
                comparer = MemberSignatureComparer.CSharpCustomModifierOverrideComparer
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48089, 48596);
                    foreach (Symbol otherMember in f_10140_48120_48193_I(f_10140_48120_48193(f_10140_48120_48155(representativeMember), f_10140_48167_48192(representativeMember))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48089, 48596);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48227, 48581) || true) && (f_10140_48231_48247(otherMember) == f_10140_48251_48276(representativeMember))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48227, 48581);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48318, 48562) || true) && (otherMember != representativeMember && (DynAbs.Tracing.TraceSender.Expression_True(10140, 48322, 48411) && f_10140_48361_48411(comparer, otherMember, representativeMember)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48318, 48562);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48461, 48539);

                                f_10140_48461_48538(ref hiddenBuilder, hidingMemberKind, otherMember);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48318, 48562);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48227, 48581);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48089, 48596);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 508);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 47447, 48607);

                int
                f_10140_47628_47678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 47628, 47678);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_47706_47731(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 47706, 47731);
                    return return_v;
                }


                int
                f_10140_47693_47752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 47693, 47752);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_47780_47805(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 47780, 47805);
                    return return_v;
                }


                int
                f_10140_47767_47830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 47767, 47830);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_47858_47883(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 47858, 47883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_47911_47946(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 47911, 47946);
                    return return_v;
                }


                bool
                f_10140_47910_47959_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 47910, 47959);
                    return return_v;
                }


                int
                f_10140_47845_47960(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 47845, 47960);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_48120_48155(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 48120, 48155);
                    return return_v;
                }


                string
                f_10140_48167_48192(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 48167, 48192);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_48120_48193(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 48120, 48193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_48231_48247(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 48231, 48247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_48251_48276(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 48251, 48276);
                    return return_v;
                }


                bool
                f_10140_48361_48411(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                x, Microsoft.CodeAnalysis.CSharp.Symbol
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 48361, 48411);
                    return return_v;
                }


                int
                f_10140_48461_48538(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                hiddenBuilder, Microsoft.CodeAnalysis.SymbolKind
                hidingMemberKind, Microsoft.CodeAnalysis.CSharp.Symbol
                hiddenMember)
                {
                    AddHiddenMemberIfApplicable(ref hiddenBuilder, hidingMemberKind, hiddenMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 48461, 48538);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_48120_48193_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 48120, 48193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 47447, 48607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 47447, 48607);
            }
        }

        private static bool CanOverrideOrHide(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 48619, 49348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48696, 49337);

                switch (f_10140_48704_48715(member))
                {

                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48696, 49337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 48909, 48960);

                        return !f_10140_48917_48959(member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48696, 49337);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48696, 49337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49023, 49072);

                        MethodSymbol
                        methodSymbol = (MethodSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49094, 49220);

                        return f_10140_49101_49156(f_10140_49132_49155(methodSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 49101, 49219) && f_10140_49160_49219(methodSymbol, f_10140_49190_49218(methodSymbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48696, 49337);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 48696, 49337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49268, 49322);

                        throw f_10140_49274_49321(f_10140_49309_49320(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 48696, 49337);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 48619, 49348);

                Microsoft.CodeAnalysis.SymbolKind
                f_10140_48704_48715(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 48704, 48715);
                    return return_v;
                }


                bool
                f_10140_48917_48959(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsExplicitInterfaceImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 48917, 48959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10140_49132_49155(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 49132, 49155);
                    return return_v;
                }


                bool
                f_10140_49101_49156(Microsoft.CodeAnalysis.MethodKind
                kind)
                {
                    var return_v = MethodSymbol.CanOverrideOrHide(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 49101, 49156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_49190_49218(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 49190, 49218);
                    return return_v;
                }


                bool
                f_10140_49160_49219(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 49160, 49219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_49309_49320(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 49309, 49320);
                    return return_v;
                }


                System.Exception
                f_10140_49274_49321(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 49274, 49321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 48619, 49348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 48619, 49348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TypeOrReturnTypeHasCustomModifiers(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 49360, 50676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49454, 50665);

                switch (f_10140_49462_49473(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 49454, 50665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49552, 49595);

                        MethodSymbol
                        method = (MethodSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49617, 49673);

                        var
                        methodReturnType = f_10140_49640_49672(method)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49695, 49894);

                        return methodReturnType.CustomModifiers.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10140, 49702, 49775) || method.RefCustomModifiers.Any()) || (DynAbs.Tracing.TraceSender.Expression_False(10140, 49702, 49893) || f_10140_49807_49893(methodReturnType.Type, flagNonDefaultArraySizesOrLowerBounds: false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 49454, 50665);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 49454, 50665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 49959, 50008);

                        PropertySymbol
                        property = (PropertySymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50030, 50078);

                        var
                        propertyType = f_10140_50049_50077(property)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50100, 50293);

                        return propertyType.CustomModifiers.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10140, 50107, 50178) || property.RefCustomModifiers.Any()) || (DynAbs.Tracing.TraceSender.Expression_False(10140, 50107, 50292) || f_10140_50210_50292(propertyType.Type, flagNonDefaultArraySizesOrLowerBounds: false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 49454, 50665);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 49454, 50665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50355, 50396);

                        EventSymbol
                        @event = (EventSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50418, 50502);

                        return f_10140_50425_50501(f_10140_50425_50436(@event), flagNonDefaultArraySizesOrLowerBounds: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 49454, 50665);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 49454, 50665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50596, 50650);

                        throw f_10140_50602_50649(f_10140_50637_50648(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 49454, 50665);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 49360, 50676);

                Microsoft.CodeAnalysis.SymbolKind
                f_10140_49462_49473(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 49462, 49473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10140_49640_49672(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 49640, 49672);
                    return return_v;
                }


                bool
                f_10140_49807_49893(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 49807, 49893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10140_50049_50077(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 50049, 50077);
                    return return_v;
                }


                bool
                f_10140_50210_50292(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 50210, 50292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10140_50425_50436(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 50425, 50436);
                    return return_v;
                }


                bool
                f_10140_50425_50501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds: flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 50425, 50501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_50637_50648(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 50637, 50648);
                    return return_v;
                }


                System.Exception
                f_10140_50602_50649(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 50602, 50649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 49360, 50676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 49360, 50676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int CustomModifierCount(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 50688, 51433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50766, 51422);

                switch (f_10140_50774_50785(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 50766, 51422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50864, 50907);

                        MethodSymbol
                        method = (MethodSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 50929, 50965);

                        return f_10140_50936_50964(method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 50766, 51422);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 50766, 51422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51030, 51079);

                        PropertySymbol
                        property = (PropertySymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51101, 51139);

                        return f_10140_51108_51138(property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 50766, 51422);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 50766, 51422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51201, 51242);

                        EventSymbol
                        @event = (EventSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51264, 51305);

                        return f_10140_51271_51304(f_10140_51271_51282(@event));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 50766, 51422);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 50766, 51422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51353, 51407);

                        throw f_10140_51359_51406(f_10140_51394_51405(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 50766, 51422);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 50688, 51433);

                Microsoft.CodeAnalysis.SymbolKind
                f_10140_50774_50785(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 50774, 50785);
                    return return_v;
                }


                int
                f_10140_50936_50964(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 50936, 50964);
                    return return_v;
                }


                int
                f_10140_51108_51138(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 51108, 51138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10140_51271_51282(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 51271, 51282);
                    return return_v;
                }


                int
                f_10140_51271_51304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 51271, 51304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_51394_51405(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 51394, 51405);
                    return return_v;
                }


                System.Exception
                f_10140_51359_51406(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 51359, 51406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 50688, 51433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 50688, 51433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool RequiresExplicitOverride(this MethodSymbol method, out bool warnAmbiguous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 51764, 55579);
                bool wasAmbiguous = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51884, 51906);

                warnAmbiguous = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51920, 51974) || true) && (f_10140_51924_51942_M(!method.IsOverride))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 51920, 51974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51961, 51974);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 51920, 51974);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 51990, 52052);

                MethodSymbol
                csharpOverriddenMethod = f_10140_52028_52051(method)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52066, 52132) || true) && (csharpOverriddenMethod is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 52066, 52132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52119, 52132);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 52066, 52132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52148, 52264);

                MethodSymbol
                runtimeOverriddenMethod = f_10140_52187_52263(method, out wasAmbiguous)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52278, 52380) || true) && (csharpOverriddenMethod == runtimeOverriddenMethod && (DynAbs.Tracing.TraceSender.Expression_True(10140, 52282, 52348) && !wasAmbiguous))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 52278, 52380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52367, 52380);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 52278, 52380);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52676, 52777) || true) && (f_10140_52680_52746(f_10140_52680_52705(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 52676, 52777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 52765, 52777);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 52676, 52777);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53239, 53368) || true) && (!f_10140_53244_53337(f_10140_53244_53261(method), f_10140_53269_53302(csharpOverriddenMethod), TypeCompareKind.AllIgnoreOptions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 53239, 53368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53356, 53368);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 53239, 53368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53544, 53629);

                bool
                methodimplWouldBeAmbiguous = f_10140_53578_53628(csharpOverriddenMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53643, 53705) || true) && (!methodimplWouldBeAmbiguous)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 53643, 53705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53693, 53705);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 53643, 53705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 53721, 53766);

                f_10140_53721_53765(runtimeOverriddenMethod is { });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 54169, 54339);

                bool
                originalOverriddenMethodWasAmbiguous =
                f_10140_54230_54265(csharpOverriddenMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10140, 54230, 54338) || f_10140_54269_54338(f_10140_54269_54310(csharpOverriddenMethod)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 54353, 54407);

                warnAmbiguous = !originalOverriddenMethodWasAmbiguous;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 54423, 54637);

                bool
                overriddenMethodContainedInSameTypeAsRuntimeOverriddenMethod =
                f_10140_54508_54636(f_10140_54508_54545(csharpOverriddenMethod), f_10140_54553_54591(runtimeOverriddenMethod), TypeCompareKind.CLRSignatureCompareOptions)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55118, 55214) || true) && (!overriddenMethodContainedInSameTypeAsRuntimeOverriddenMethod)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 55118, 55214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55202, 55214);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 55118, 55214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55448, 55568);

                return csharpOverriddenMethod != runtimeOverriddenMethod && (DynAbs.Tracing.TraceSender.Expression_True(10140, 55455, 55567) && f_10140_55508_55527(method) != f_10140_55531_55567(runtimeOverriddenMethod));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 51764, 55579);

                bool
                f_10140_51924_51942_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 51924, 51942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_52028_52051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 52028, 52051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_52187_52263(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                wasAmbiguous)
                {
                    var return_v = method.GetFirstRuntimeOverriddenMethodIgnoringNewSlot(out wasAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 52187, 52263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10140_52680_52705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 52680, 52705);
                    return return_v;
                }


                bool
                f_10140_52680_52746(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.RuntimeSupportsCovariantReturnsOfClasses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 52680, 52746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10140_53244_53261(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 53244, 53261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10140_53269_53302(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 53269, 53302);
                    return return_v;
                }


                bool
                f_10140_53244_53337(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 53244, 53337);
                    return return_v;
                }


                bool
                f_10140_53578_53628(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.MethodHasRuntimeCollision();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 53578, 53628);
                    return return_v;
                }


                int
                f_10140_53721_53765(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 53721, 53765);
                    return 0;
                }


                bool
                f_10140_54230_54265(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 54230, 54265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10140_54269_54310(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 54269, 54310);
                    return return_v;
                }


                bool
                f_10140_54269_54338(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.MethodHasRuntimeCollision();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 54269, 54338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_54508_54545(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 54508, 54545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_54553_54591(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 54553, 54591);
                    return return_v;
                }


                bool
                f_10140_54508_54636(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 54508, 54636);
                    return return_v;
                }


                bool
                f_10140_55508_55527(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 55508, 55527);
                    return return_v;
                }


                bool
                f_10140_55531_55567(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 55531, 55567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 51764, 55579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 51764, 55579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MethodHasRuntimeCollision(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 55591, 56031);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55688, 55991);
                    foreach (Symbol otherMethod in f_10140_55719_55764_I(f_10140_55719_55764(f_10140_55719_55740(method), f_10140_55752_55763(method))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 55688, 55991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55798, 55976) || true) && (otherMethod != method && (DynAbs.Tracing.TraceSender.Expression_True(10140, 55802, 55903) && f_10140_55827_55903(MemberSignatureComparer.RuntimeSignatureComparer, otherMethod, method)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 55798, 55976);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 55945, 55957);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 55798, 55976);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 55688, 55991);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 56007, 56020);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 55591, 56031);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_55719_55740(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 55719, 55740);
                    return return_v;
                }


                string
                f_10140_55752_55763(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 55752, 55763);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_55719_55764(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 55719, 55764);
                    return return_v;
                }


                bool
                f_10140_55827_55903(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member2)
                {
                    var return_v = this_param.Equals(member1, (Microsoft.CodeAnalysis.CSharp.Symbol)member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 55827, 55903);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_55719_55764_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 55719, 55764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 55591, 56031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 55591, 56031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodSymbol GetFirstRuntimeOverriddenMethodIgnoringNewSlot(this MethodSymbol method, out bool wasAmbiguous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 56798, 59186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57347, 57402);

                const bool
                ignoreInterfaceImplementationChanges = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57418, 57439);

                wasAmbiguous = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57453, 57581) || true) && (!f_10140_57458_57520(method, ignoreInterfaceImplementationChanges))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 57453, 57581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57554, 57566);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 57453, 57581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57597, 57652);

                NamedTypeSymbol
                containingType = f_10140_57630_57651(method)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57689, 57743);

                    for (NamedTypeSymbol
        currType = f_10140_57700_57743(containingType)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57668, 59147) || true) && (!f_10140_57746_57777(currType, null))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57779, 57827)
        , currType = f_10140_57790_57827(currType), DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 57668, 59147))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 57668, 59147);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57861, 57891);

                        MethodSymbol
                        candidate = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 57909, 59014);
                            foreach (Symbol otherMember in f_10140_57940_57972_I(f_10140_57940_57972(currType, f_10140_57960_57971(method))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 57909, 59014);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58014, 58995) || true) && (f_10140_58018_58034(otherMember) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10140, 58018, 58141) && f_10140_58084_58141(otherMember, containingType)) && (DynAbs.Tracing.TraceSender.Expression_True(10140, 58018, 58246) && f_10140_58170_58246(MemberSignatureComparer.RuntimeSignatureComparer, method, otherMember)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 58014, 58995);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58296, 58348);

                                    MethodSymbol
                                    overridden = (MethodSymbol)otherMember
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58487, 58972) || true) && (f_10140_58491_58557(overridden, ignoreInterfaceImplementationChanges))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 58487, 58972);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58615, 58890) || true) && (candidate is { })
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 58615, 58890);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58788, 58808);

                                            wasAmbiguous = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58842, 58859);

                                            return candidate;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 58615, 58890);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 58922, 58945);

                                        candidate = overridden;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 58487, 58972);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 58014, 58995);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 57909, 59014);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 1106);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 1106);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 59034, 59132) || true) && (candidate is { })
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10140, 59034, 59132);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 59096, 59113);

                            return candidate;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10140, 59034, 59132);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10140, 1, 1480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10140, 1, 1480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 59163, 59175);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 56798, 59186);

                bool
                f_10140_57458_57520(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 57458, 57520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_57630_57651(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 57630, 57651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_57700_57743(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 57700, 57743);
                    return return_v;
                }


                bool
                f_10140_57746_57777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 57746, 57777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_57790_57827(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 57790, 57827);
                    return return_v;
                }


                string
                f_10140_57960_57971(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 57960, 57971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_57940_57972(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 57940, 57972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10140_58018_58034(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 58018, 58034);
                    return return_v;
                }


                bool
                f_10140_58084_58141(Microsoft.CodeAnalysis.CSharp.Symbol
                overridden, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                overridingContainingType)
                {
                    var return_v = IsOverriddenSymbolAccessible(overridden, overridingContainingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 58084, 58141);
                    return return_v;
                }


                bool
                f_10140_58170_58246(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member1, Microsoft.CodeAnalysis.CSharp.Symbol
                member2)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)member1, member2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 58170, 58246);
                    return return_v;
                }


                bool
                f_10140_58491_58557(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 58491, 58557);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10140_57940_57972_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 57940, 57972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 56798, 59186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 56798, 59186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsOverriddenSymbolAccessible(Symbol overridden, NamedTypeSymbol overridingContainingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10140, 59571, 59918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 59705, 59755);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10140, 59769, 59907);

                return f_10140_59776_59906(f_10140_59807_59836(overridden), f_10140_59838_59881(overridingContainingType), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10140, 59571, 59918);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10140_59807_59836(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 59807, 59836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10140_59838_59881(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10140, 59838, 59881);
                    return return_v;
                }


                bool
                f_10140_59776_59906(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible(symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10140, 59776, 59906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10140, 59571, 59918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 59571, 59918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static OverriddenOrHiddenMembersHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10140, 769, 59925);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10140, 769, 59925);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10140, 769, 59925);
        }

    }
}
